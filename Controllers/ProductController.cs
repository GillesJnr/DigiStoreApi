using DigiStoreApi.Core;
using DigiStoreApi.Data;
using DigiStoreApi.Dtos;
using DigiStoreApi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using static DigiStoreApi.Models.RequestsModel;
namespace DigiStoreApi.Controllers;

[Route("products/")]
public class ProductController : ControllerBase
{
    private readonly ApiDbContext _context;
    private readonly ILogger<ProductController> _logger;
    private readonly UserFunctions _userFunctions;

    public ProductController(ApiDbContext context, ILogger<ProductController> logger, UserFunctions userFunctions)
    {
        _context = context;
        _logger = logger;
        _userFunctions = userFunctions;
    }

    // GET
    [Route("")]
    [HttpGet]
    public async Task<IActionResult> Index(string? name, string? createdBy, string? authorizedBy, int? status,
        DateTime? endDate, DateTime? startDate)
    {
        try
        {
            RequestsModel.Filter filter = new()
            {
                Name = name, CreatedBy = createdBy, Status = status ?? (int)StaticVariables.RequestStatus.Success,
                AuthorizedBy = authorizedBy
            };
            _logger.LogInformation("====== Log filter properties of Get unit request", filter);
            //function to fetch filtered data from the database
            List<Product> entities = await _userFunctions.GetEntitiesByFilterAsync<Product>(filter);
            if (startDate != null) entities = entities.Where(t => t.CreatedDate.Date >= startDate.Value.Date).ToList();
            if (endDate != null) entities = entities.Where(t => t.CreatedDate.Date <= endDate.Value.Date).ToList();
            return Ok(entities);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            return BadRequest(new {id=StaticVariables.Failedcode, message = StaticVariables.ExceptionError});
        }
    }

    [Route("add")]
    [HttpPost]
    public async Task<IActionResult> AddProduct(ProductDto product)
    {
        //check the role of the user from the token to confirm if the user is maker.
        _logger.LogInformation("Adding new product", product);
        try
        {
            Product entity = new Product();
            if (!ModelState.IsValid) return BadRequest(new {id=StaticVariables.Failedcode, message=StaticVariables.Failedmessage});
            entity = new Product()
            {
                Name = product.Name,
                CreatedDate = DateTime.UtcNow,
                CreatedBy = StaticVariables.CreatedBy,
                Status = (int)StaticVariables.RequestStatus.Pending,
                CurrentQuantity = product.CurrentQuantity,
                Brand = product.Brand,
                ActualStock = product.ActualStock,
                LevelId = product.LevelId,
                CategoryId = product.CategoryId,
                SafetyStock = product.SafetyStock,
                UnitId = product.UnitId,
                OrderQuantity = product.OrderQuantity,
                BulkId = Guid.NewGuid()
            };
            await _context.Product.AddAsync(entity);
            await _context.SaveChangesAsync();
            await _context.DisposeAsync();
            return CreatedAtAction(nameof(AddProduct), new { Id = entity.ProductId }, entity);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            return BadRequest(new {id=StaticVariables.Failedcode, message = StaticVariables.ExceptionError});
        }
    }

    [Route("add-bulk")]
    [HttpPost]
    public async Task<IActionResult> AddBulkProducts(List<ProductDto> products)
    {
        _logger.LogInformation("Adding new product", products);
        try
        {
            List<Product> entity = new List<Product>();
            if (!ModelState.IsValid) return BadRequest(new {id=StaticVariables.Failedcode, message=StaticVariables.Failedmessage});
            Guid bulkId = Guid.NewGuid();
            products.ForEach(product =>
            {
                entity.Add(new Product()
                {
                    Name = product.Name,
                    CreatedDate = DateTime.UtcNow,
                    CreatedBy = StaticVariables.CreatedBy,
                    Status = (int)StaticVariables.RequestStatus.Pending,
                    CurrentQuantity = product.CurrentQuantity,
                    Brand = product.Brand,
                    ActualStock = product.ActualStock,
                    LevelId = product.LevelId,
                    CategoryId = product.CategoryId,
                    SafetyStock = product.SafetyStock,
                    UnitId = product.UnitId,
                    OrderQuantity = product.OrderQuantity,
                    BulkId = bulkId
                });
            });
            await _context.Product.AddRangeAsync(entity);
            await _context.SaveChangesAsync();
            await _context.DisposeAsync();
            return CreatedAtAction(nameof(AddProduct), new { Id = bulkId }, entity);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            return BadRequest(new {id=StaticVariables.Failedcode, message = StaticVariables.ExceptionError});
        }
    }
    
    [Route("update")]
    [HttpPut]
    public async Task<IActionResult> UpdateProduct(int id, Product product)
    {
        _logger.LogInformation("Logging the update of the product", product);
        try
        {
            if (!ModelState.IsValid) return BadRequest(new ErrorResponse());
        
            var entity = await _context.Product.FindAsync(id);
            if (entity == null) return NotFound(new ErrorResponse() { message = StaticVariables.Notfound });
        
            product.ModifiedBy = StaticVariables.ModifiedBy;
            product.ModifiedDate = DateTime.UtcNow;
            Product update = await _userFunctions.UpdateEntity<Product>(id, product);
            return Ok(update);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            return BadRequest(new ErrorResponse(){message = StaticVariables.ExceptionError});
        }
    }
    
    [Route("authorize")]
    [HttpGet]
    public async Task<IActionResult> AuthorizeProduct([FromQuery] Guid id, int status)
    {
        _logger.LogInformation("====== Logging Authorization Details ===");
        //authorize user?
        //check if created user is not the same as the one authorizing
        try
        {
            var product = await _context.Product.FindAsync(id);
            if (product != null)
            {
                product.Status = status;
                product.AuthorizedBy = StaticVariables.AuthorizedBy;
                product.AuthorizedDate = DateTime.UtcNow;
                await _context.SaveChangesAsync();
                await _context.DisposeAsync();
                return Ok(product);
            }

            return NotFound(new ErrorResponse(){message = StaticVariables.Notfound});
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            return BadRequest(new
            {
                id = StaticVariables.Failedcode,
                message = StaticVariables.ExceptionError
            });
        }
    }

    [Route("authorize-all")]
    [HttpGet]
    public async Task<IActionResult> AuthorizeAllProducts([FromQuery] Guid bulkId, int status)
    {
        _logger.LogInformation("====== Logging Authorization Details ===");
        //authorize user?
        //check if created user is not the same as the one authorizing
        try
        {
            var products = await _context.Product.Where(t=> t.BulkId == bulkId).ToListAsync();
            if (products != null)
            {
                products.ForEach(product =>
                {
                    product.Status = status;
                    product.AuthorizedBy = StaticVariables.AuthorizedBy;
                    product.AuthorizedDate = DateTime.UtcNow;
                });
                await _context.SaveChangesAsync();
                await _context.DisposeAsync();
                return Ok(products);
            }

            return NotFound(new ErrorResponse(){message = StaticVariables.Notfound});
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            return BadRequest(new
            {
                id = StaticVariables.Failedcode,
                message = StaticVariables.ExceptionError
            });
        }
    }
    
}