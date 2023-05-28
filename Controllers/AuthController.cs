using System.Security.Claims;
using DigiStoreApi.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using static DigiStoreApi.Models.RequestsModel;
namespace DigiStoreApi.Controllers;

[ApiController]
[Route("api/auth/")]
public class AuthController : ControllerBase
{
    private readonly ILogger<AuthController> _logger;
    private readonly IConfiguration _config;
    private readonly UserFunctions _userFunctions;
    public AuthController(ILogger<AuthController> logger, IConfiguration config, UserFunctions userFunctions)
    {
        _logger = logger;
        _config = config;
        _userFunctions = userFunctions;
    }
    [Route("login")]
    [HttpPost]
    public IActionResult Index(LoginRequest request)
    {
        _logger.LogInformation("Logging Incoming Request", request);
        if (!ModelState.IsValid) return BadRequest("Invalid Credentials Entered, Please try again");
        string username, branch, role, fullName, email = string.Empty;
        if (!_userFunctions.Login(1, request.Username, request.Password, out LoginResponse loginDetails, out string message))
        {
            return Unauthorized("Invalid Login Credentials, Try Again");
        }

        username = loginDetails.Message.UserData.Username;
        string keystring = _config.GetSection("JwtConfig:Secret").Value.ToString();
        var token = _userFunctions.GenerateJwtToken(loginDetails, out DateTime expires, out DateTime issued);
        Task.Factory.StartNew(() =>
            _userFunctions.WriteLog(username, JsonConvert.SerializeObject(request), JsonConvert.SerializeObject(loginDetails), token, nameof(Index)));
        return Ok(new TokenResponse(){Status = StaticVariables.Successcode, Username = username, Token = token, TokenType = StaticVariables.Bearer, Issued = issued.ToString(), Expires = expires.ToString()});
    }
    
    [Route("logout")]
    [HttpPost]
    public IActionResult Logout()
    {
        return Ok();
    }

    [Route("check-all")]
    [HttpGet]   
    [Authorize]
    public IActionResult PostEmail()
    {
        var name = User.FindFirst(ClaimTypes.Name)?.Value;
        var email = User.FindFirst(ClaimTypes.Email)?.Value;
        var role = User.FindFirst(ClaimTypes.Role)?.Value;
        return Ok(new {name, email, role});
    }
    
    [Route("maker-checker")]
    [HttpGet]   
    [Authorize(Roles = "checker,maker")]
    public IActionResult PostUsername()
    {
        var name = User.FindFirst(ClaimTypes.Name)?.Value;
        var email = User.FindFirst(ClaimTypes.Email)?.Value;
        var role = User.FindFirst(ClaimTypes.Role)?.Value;
        return Ok(new {name, email, role});
    }
    
    [Route("postMaker")]
    [HttpGet]   
    [Authorize(Roles = "maker")]
    public IActionResult PostMaker()
    {
        var name = User.FindFirst(ClaimTypes.Name)?.Value;
        var email = User.FindFirst(ClaimTypes.Email)?.Value;
        var role = User.FindFirst(ClaimTypes.Role)?.Value;
        return Ok(new {name, email, role});
    }
    
}