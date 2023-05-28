using DigiStoreApi.Core;
using DigiStoreApi.Data;
using DigiStoreApi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using static DigiStoreApi.Models.RequestsModel;

namespace DigiStoreApi.Controllers;
[ApiController]
[Route("api/config/")]
public class ConfigurationController : ControllerBase
{
    private readonly ApiDbContext _context;
    private readonly ILogger<ConfigurationController> _logger;
    private readonly UserFunctions _userFunctions;

    public ConfigurationController(ILogger<ConfigurationController> logger,UserFunctions userFunctions, ApiDbContext context)
    {
        _logger = logger;
        _userFunctions = userFunctions;
        _context = context;
    }

    #region Units

    // [Authorize]
    [Route("unit/add")]
    [HttpPost]
    public  async Task<IActionResult> AddUnit(string? name)
    {
        try
        {
            if (name != null)
            {
                _logger.LogInformation("Adding new unit", name);
                Unit unit = new Unit();
                unit = new Unit(){ Name = name, CreatedDate = DateTime.UtcNow, CreatedBy = StaticVariables.CreatedBy, Status = (int)StaticVariables.RequestStatus.Pending};
                await _context.Unit.AddAsync(unit);
                await _context.SaveChangesAsync();
                await _context.DisposeAsync();
                return CreatedAtAction(nameof(AddUnit), name, unit);
            }
            return BadRequest(new ErrorResponse());
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            return BadRequest(new ErrorResponse(){message = StaticVariables.ExceptionError});
        }
    }

    [Route("unit/")]
    [HttpGet]
    public async Task<ActionResult<IEnumerable<Unit>>> Unit(string? name, string? createdBy, string? authorizedBy, int? status,
        DateTime? endDate, DateTime? startDate)
    {
        RequestsModel.Filter filter = new()
        {
            Name = name, CreatedBy = createdBy, Status = status ?? (int)StaticVariables.RequestStatus.Success , AuthorizedBy = authorizedBy
        };
        _logger.LogInformation("====== Log filter properties of Get unit request", filter);
        //function to fetch filtered data from the database
        var entities = await _userFunctions.GetEntitiesByFilterAsync<Unit>(filter);
        if(startDate != null) entities = entities.Where(t => t.CreatedDate.Date >= startDate.Value.Date).ToList();
        if(endDate != null) entities = entities.Where(t => t.CreatedDate.Date <= endDate.Value.Date).ToList();
        return Ok(entities);
    }

    [Route("unit/authorize")]
    [HttpGet]
    public async Task<IActionResult> AuthorizeUnit([FromQuery] int id, int status)
    {
        _logger.LogInformation("====== Logging Authorization Details ===");
        //authorize user?
        //check if created user is not the same as the one authorizing
        try
        {
            var unit = await _context.Unit.FindAsync(id);
            if (unit != null)
            {
                unit.Status = status;
                unit.AuthorizedBy = StaticVariables.AuthorizedBy;
                unit.AuthorizedDate = DateTime.UtcNow;
                await _context.SaveChangesAsync();
                await _context.DisposeAsync();
                return Ok(unit);
            }
            return NotFound(new ErrorResponse(){message = StaticVariables.Notfound});
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            return BadRequest(new ErrorResponse());
        }
    }

    [Route("unit/update/")]
    [HttpPut]
    public async Task<IActionResult> UpdateUnit(int id, Unit unit)
    {
        _logger.LogInformation("=========Logging Update Unit==");
        if (!ModelState.IsValid) return BadRequest(new ErrorResponse(){status = StaticVariables.Failedcode, message = StaticVariables.Failedmessage});
        try
        {
            var entity = _context.Unit.FindAsync(id);
            if (entity == null) return NotFound(new ErrorResponse(){message = StaticVariables.Notfound});
            //Try to get the old record into a history table. This should be done before though before the update
            unit.ModifiedBy = StaticVariables.ModifiedBy;
            unit.ModifiedDate = DateTime.UtcNow;
            Unit update = await _userFunctions.UpdateEntity<Unit>(id, unit);
            return Ok(update);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            return BadRequest(new ErrorResponse());
        }
    }

#endregion

#region Categories

[Route("category/")]
[HttpGet]
public async Task<IActionResult> Category(string? name, string? createdBy, string? authorizedBy, int? status,
    DateTime? endDate, DateTime? startDate)
{
    try
    {
        Filter filter = new()
        {
            Name = name, CreatedBy = createdBy, Status = status ?? (int)StaticVariables.RequestStatus.Success , AuthorizedBy = authorizedBy
        };
        _logger.LogInformation("============ Logging Category filter by User", filter);
        //function to filter all categories
        var entities = await _userFunctions.GetEntitiesByFilterAsync<Category>(filter);
        if(startDate != null) entities = entities.Where(t => t.CreatedDate.Date >= startDate.Value.Date).ToList();
        if(endDate != null) entities = entities.Where(t => t.CreatedDate.Date <= endDate.Value.Date).ToList();
        return Ok(entities);
    }
    catch (Exception e)
    {
        Console.WriteLine(e);
        return BadRequest(new ErrorResponse() { message = StaticVariables.ExceptionError });
    }
}

[Route("category/add")]
[HttpPost]
public async Task<IActionResult> AddCategory(string name)
{
    _logger.LogInformation("========== Logging incoming request ====", name);
    try
    {
        if (!ModelState.IsValid) return BadRequest(new {id= StaticVariables.Failedcode, text= StaticVariables.Failedmessage});
        Category category = new() { Name = name, CreatedBy = StaticVariables.CreatedBy, Status = StaticVariables.Pendingcode, CreatedDate = DateTime.UtcNow};
        _context.Category?.AddAsync(category);
        await _context.SaveChangesAsync();
        return CreatedAtAction(nameof(AddCategory), new {id=category.Id} , category);
    }
    catch (Exception e)
    {
        Console.WriteLine(e);
        return BadRequest(new ErrorResponse(){message = StaticVariables.ExceptionError});
    }
}

[Route("category/update")]
[HttpPut]
public async Task<IActionResult> UpdateCategory(int id, Category category)
{
    _logger.LogInformation("======= logging update request===", category);
    try
    {
        if (!ModelState.IsValid) return BadRequest(new ErrorResponse());
        category.ModifiedBy = StaticVariables.AuthorizedBy;
        category.ModifiedDate = DateTime.UtcNow;
        Category update = await  _userFunctions.UpdateEntity<Category>(id, category);
        return Ok(update);
    }
    catch (Exception e)
    {
        Console.WriteLine(e);
        return BadRequest(new ErrorResponse(){message = StaticVariables.ExceptionError});
    }
}

[Route("category/authorize")]
[HttpGet]
public async Task<IActionResult> AuthorizeCategory([FromQuery] int id, int status)
{
    _logger.LogInformation("====== Logging Authorization Details ===");
    //authorize user?
    //check if created user is not the same as the one authorizing
    try
    {
        var category = await _context.Category.FindAsync(id);
        if (category != null)
        {
            category.Status = status;
            category.AuthorizedBy = StaticVariables.AuthorizedBy;
            category.AuthorizedDate = DateTime.UtcNow;
            await _context.SaveChangesAsync();
            await _context.DisposeAsync();
            return Ok(category);
        }

        return NotFound();
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

#endregion

#region Reorder Level

[Route("reorder-level/")]
[HttpGet]
public async Task<IActionResult> Level(string? name, string? createdBy, string? authorizedBy, int? status,
    DateTime? endDate, DateTime? startDate)
{
    try
    {
        RequestsModel.Filter filter = new()
        {
            Name = name, CreatedBy = createdBy, Status = status ?? (int)StaticVariables.RequestStatus.Success , AuthorizedBy = authorizedBy
        };
        _logger.LogInformation("============ Logging Category filter by User", filter);
        //function to filter all categories
        var entities = await _userFunctions.GetEntitiesByFilterAsync<ReorderLevel>(filter);
        if(startDate != null) entities = entities.Where(t => t.CreatedDate.Date >= startDate.Value.Date).ToList();
        if(endDate != null) entities = entities.Where(t => t.CreatedDate.Date <= endDate.Value.Date).ToList();
        return Ok(entities);
    }
    catch (Exception e)
    {
        Console.WriteLine(e);
        return BadRequest(new ErrorResponse(){message = StaticVariables.ExceptionError});
    }
}

[Route("reorder-level/add")]
[HttpPost]
public async Task<IActionResult> AddLevel(string name)
{
    _logger.LogInformation("========== Logging incoming request ====", name);
    try
    {
        if (!ModelState.IsValid) return BadRequest(new ErrorResponse());
        ReorderLevel level = new() { Level = name, CreatedBy = StaticVariables.CreatedBy, CreatedDate = DateTime.UtcNow, Status = (int)StaticVariables.RequestStatus.Success};
        _context.ReorderLevel?.AddAsync(level);
        await _context.SaveChangesAsync();
        return CreatedAtAction(nameof(AddCategory), new {id=level.Id} , level);
    }
    catch (Exception e)
    {
        Console.WriteLine(e);
        return BadRequest(new ErrorResponse(){message = StaticVariables.ExceptionError});
    }
}

[Route("reorder-level/update")]
[HttpPut]
public async Task<IActionResult> UpdateLevel(int id, ReorderLevel level)
{
    _logger.LogInformation("=========Logging Update Unit==");
    try
    {
        if (!ModelState.IsValid) return BadRequest(new ErrorResponse());
        
        var entity = await _context.ReorderLevel.FindAsync(id);
        if (entity == null) return NotFound(new ErrorResponse() { message = StaticVariables.Notfound });
        
        level.ModifiedBy = StaticVariables.ModifiedBy;
        level.ModifiedDate = DateTime.UtcNow;
        ReorderLevel update = await _userFunctions.UpdateEntity<ReorderLevel>(id, level);
        return Ok(update);
    }
    catch (Exception e)
    {
        Console.WriteLine(e);
        return BadRequest(new ErrorResponse(){message = StaticVariables.ExceptionError});
    }
    //Try to get the old record into a history table. This should be done before though before the update
}

#endregion

#region DropDowns

[HttpGet]
[Route("get-categories/")]
public async Task<IActionResult> GetCategories(string? searchTerm)
{
    try
    {
        var categoryList = await _context.Category.ToListAsync();
        if (searchTerm != null)
        {
            categoryList = await _context.Category.Where(t => t.Name.Contains(searchTerm)).ToListAsync();
        }

        var categories = categoryList.Select(x => new
        {
            id = x.Id,
            message = x.Name.ToString().Trim()
        });
        return Ok(categories);
    }
    catch (Exception e)
    {
        Console.WriteLine(e);
        return BadRequest(new
        {
            id = StaticVariables.Failedcode,
            message = StaticVariables.NoData
        });
    }
}

[HttpGet]
[Route("get-branches/")]
public async Task<IActionResult> GetBranches(string? searchTerm)
{
    try
    {
        var branchList = await _context.Branch.ToListAsync();
        if (searchTerm != null)
        {
            branchList = await _context.Branch.Where(t => t.BranchName.Contains(searchTerm)).ToListAsync();
        }

        var branches = branchList.Select(x => new
        {
            id = x.BranchCode.ToString().Trim(),
            message = x.BranchName.ToString().Trim()
        });
        return Ok(branches);
    }
    catch (Exception e)
    {
        Console.WriteLine(e);
        return BadRequest(new
        {
            id = StaticVariables.Failedcode,
            message = StaticVariables.NoData
        });
    }
}

[HttpGet]
[Route("get-units/")]
public async Task<IActionResult> GetUnits(string? searchTerm)
{
    try
    {
        var unitList = await _context.Unit.ToListAsync();
        if (searchTerm != null)
        {
            unitList = await _context.Unit.Where(t => t.Name.Contains(searchTerm)).ToListAsync();
        }

        var units = unitList.Select(x => new
        {
            id = x.Id,
            message = x.Name.ToString().Trim()
        });
        return Ok(units);
    }
    catch (Exception e)
    {
        Console.WriteLine(e);
        return BadRequest(new
        {
            id = StaticVariables.Failedcode,
            message = StaticVariables.NoData
        });
    }
}

[HttpGet]
[Route("get-levels/")]
public async Task<IActionResult> GetLevels(string? searchTerm)
{
    try
    {
        var levelList = await _context.ReorderLevel.ToListAsync();
        if (searchTerm != null)
        {
            levelList = await _context.ReorderLevel.Where(t => t.Level.Contains(searchTerm)).ToListAsync();
        }

        var levels = levelList.Select(x => new
        {
            id = x.Id,
            message = x.Level.ToString().Trim()
        });
        return Ok(levels);
    }
    catch (Exception e)
    {
        Console.WriteLine(e);
        return BadRequest(new
        {
            id = StaticVariables.Failedcode,
            message = StaticVariables.NoData
        });
    }
}

[HttpGet]
[Route("get-products/")]
public async Task<IActionResult> GetProducts(string? searchTerm)
{
    try
    {
        var levelList = await _context.ReorderLevel.ToListAsync();
        if (searchTerm != null)
        {
            levelList = await _context.ReorderLevel.Where(t => t.Level.Contains(searchTerm)).ToListAsync();
        }

        var levels = levelList.Select(x => new
        {
            id = x.Id,
            message = x.Level.ToString().Trim()
        });
        return Ok(levels);
    }
    catch (Exception e)
    {
        Console.WriteLine(e);
        return BadRequest(new
        {
            id = StaticVariables.Failedcode,
            message = StaticVariables.NoData
        });
    }
}

#endregion
}