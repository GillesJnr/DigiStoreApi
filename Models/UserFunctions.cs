using System.IdentityModel.Tokens.Jwt;
using System.Linq.Expressions;
using System.Net.Http.Headers;
using System.Net.Security;
using System.Reflection;
using System.Reflection.Metadata;
using System.Security.Claims;
using System.Text;
using DigiStoreApi.Core;
using DigiStoreApi.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Newtonsoft.Json;
using static DigiStoreApi.Models.RequestsModel;
namespace DigiStoreApi.Models;

public class UserFunctions
{
    private readonly ILogger<UserFunctions> _logger;
    private readonly IConfiguration _config;
    private readonly  IWebHostEnvironment _environment;
    private readonly ApiDbContext _context;
 
    public UserFunctions(ILogger<UserFunctions> logger, IConfiguration config, IWebHostEnvironment environment, ApiDbContext context)
    {
        _logger = logger;
        _environment = environment;
        _config = config;
        _context = context;
    }

    public async Task<List<T>> GetEntitiesByFilterAsync<T>(object filter) where T : class
    {
        var query = _context.Set<T>().AsQueryable();
        var parameter = Expression.Parameter(typeof(T), "e");

        foreach (var property in filter.GetType().GetProperties())
        {
            var value = property.GetValue(filter);
            if (value != null)
            {
                var propertyExpression = Expression.Property(parameter, property.Name);
                var constantExpression = Expression.Constant(value, property.PropertyType);
                var equalExpression = Expression.Equal(propertyExpression, constantExpression);
                var lambda = Expression.Lambda<Func<T, bool>>(equalExpression, parameter);
                query = query.Where(lambda);
            }
        }

        var entities = await query.ToListAsync();
        await _context.DisposeAsync();
        return entities;
    }

    public async Task<T> UpdateEntity<T>(int id, T entity) where T : class
    {
        var dbEntity = await _context.Set<T>().FindAsync(id);
        if (dbEntity != null)
        {
            foreach (var property in entity.GetType().GetProperties())
            {
                var value = property.GetValue(entity);
                if (value != null)
                {
                    property.SetValue(dbEntity, value);
                }
            }

            _context.Entry(dbEntity).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            await _context.DisposeAsync();
        }

        return dbEntity;
    }
    
    public void WriteLog(string type, string logId, string request, string response, string function)
    {
        StringBuilder logFilePath = new StringBuilder();
        logFilePath.Append($"{_environment.ContentRootPath}/Logs/{type}/");
        logFilePath.Append($"Log-{DateTime.Today.ToString("MM-dd-yyyy")}.txt");
        try
        {
            using (FileStream fileStream = new FileStream(logFilePath.ToString(), FileMode.Append, FileAccess.Write))
            {
                FileInfo logFileInfo = new FileInfo(logFilePath.ToString());
                DirectoryInfo logDirInfo = new DirectoryInfo(logFileInfo.DirectoryName.ToString());
                if (!logDirInfo.Exists) logDirInfo.Create();

                StreamWriter log = new StreamWriter(fileStream);
                if (!logFileInfo.Exists)
                {
                    _ = logFileInfo.Create();
                }
                log.WriteLine(logId);
                log.WriteLine(DateTime.Now);
                log.WriteLine(request);
                log.WriteLine(response);
                log.WriteLine(function);
                log.WriteLine("_________________________________________________________________________________________________________");
                log.Close();
                fileStream.Close();
            }
        }
        catch (Exception e)
        {
            string message = e.Message + " || " + e.StackTrace;
            _logger.LogError(e.Message);
        }
    }

    public bool Login(int logId, string username, string password, out LoginResponse loginDetails, out string message)
    {
        bool worked = false;
        loginDetails = null;
        message = string.Empty;
        string request, response = string.Empty;
        string url = _config.GetSection("CoreBanking:BaseUrl").Value.ToString();
        string token = _config.GetSection("CoreBanking:AuthorizationKey").Value.ToString();
        string appId = _config.GetSection("CoreBanking:AppId").Value.ToString();
        string channelId = _config.GetSection("CoreBanking:ChannelId").Value.ToString();

        try
        {
            HttpClientHandler clientHandler = new HttpClientHandler();
            clientHandler.ServerCertificateCustomValidationCallback = (sender, cert, chain, sslPolicyErrors) =>
            {
                return true;
            };

            using (var client = new HttpClient(clientHandler))
            {
                client.Timeout = TimeSpan.FromMinutes(5);
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", token);
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));


                LoginRequest json = new LoginRequest { Username = username, Password = password , AppId = appId, ChannelId = channelId};

                request = JsonConvert.SerializeObject(json);
                HttpContent content = new StringContent(request, Encoding.UTF8, "application/json");

                var res = client.PostAsync(new Uri(url + "User/Login"), content).Result;
                string statusCod = res.StatusCode.ToString();
                response = res.Content.ReadAsStringAsync().Result;
                loginDetails = JsonConvert.DeserializeObject<LoginResponse>(res.Content.ReadAsStringAsync().Result);

                if (loginDetails == null)
                {
                    message = StaticVariables.Loginattemptfailed;
                    loginDetails = null;
                }
                else if (!(statusCod == "OK" && loginDetails.Status == "SUCCESS" && !string.IsNullOrEmpty(loginDetails.Message.UserData.UserId)))
                {
                    message = StaticVariables.Loginattemptfailed;
                }
                else
                {
                    message = StaticVariables.Succcessstatusmessage;
                    worked = true;
                }

            }
            
        }
        catch (Exception ex)
        {
            string error = ex.Message + " || " + ex.StackTrace;
            _logger.LogError(error);
            Task.Factory.StartNew(() => WriteLog(username, logId.ToString(), string.Empty, error, "Login"));
        }
        Task.Factory.StartNew(() => WriteLog(username, logId.ToString(), string.Empty, JsonConvert.SerializeObject(response), "Login"));
        return worked;
    }


    #region Utilities

    public string GenerateJwtToken(LoginResponse user, out DateTime expires, out DateTime issued)
    {
        string middleName = user.Message.UserData.MiddleName == null ? "" : user.Message.UserData.MiddleName.ToString();
        string fullName = $"{user.Message.UserData.FirstName} {middleName} {user.Message.UserData.LastName}";
        var jwtTokenHandler = new JwtSecurityTokenHandler();
        var key = Encoding.UTF8.GetBytes(_config.GetSection("JwtConfig:Secret").ToString() ?? throw new InvalidOperationException());
        var tokenDescriptor = new SecurityTokenDescriptor()
        {
            Subject = new ClaimsIdentity(new []
            {
                new Claim("Id", user.Message.UserData.UserId ?? throw new InvalidOperationException()),
                new Claim("Role", user.Message.UserData.Role ?? throw new InvalidOperationException()),
                new Claim("Name", fullName),
                new Claim("Username", user.Message.UserData.Username ?? throw new InvalidOperationException()),
                new Claim("Branch", user.Message.UserData.UserBranch ?? throw new InvalidOperationException()),
                new Claim("Email", user.Message.UserData.UserEmail ?? throw new InvalidOperationException()),
                new Claim("AuthStat", user.Message.UserData.AuthStat ?? throw new InvalidOperationException()),
            }),
            Expires = DateTime.Now.AddHours(1),
            SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256)
        };
        var token = jwtTokenHandler.CreateToken(tokenDescriptor);
        var jwtToken = jwtTokenHandler.WriteToken(token);
        issued = DateTime.Now;
        expires = DateTime.Now.AddHours(1);
        return jwtToken;
    }

    public ClaimsPrincipal DecodeJwtToken(string encodedToken)
    {
        var handler = new JwtSecurityTokenHandler();
        var key = Encoding.UTF8.GetBytes(_config.GetSection("JwtConfig:Secret").ToString() ?? throw new InvalidOperationException());
        var tokenValidationParameters = new TokenValidationParameters
        {
            ValidateIssuerSigningKey = true,
            IssuerSigningKey = new SymmetricSecurityKey(key),
            ValidateIssuer = false,
            ValidateAudience = false,
            ClockSkew = TimeSpan.Zero
        };

        var claimsPrincipal = handler.ValidateToken(encodedToken, tokenValidationParameters, out var securityToken);
        return claimsPrincipal;
    }
    
    #endregion
}