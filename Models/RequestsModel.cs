using System.ComponentModel.DataAnnotations;

namespace DigiStoreApi.Models;

public class RequestsModel
{
    public class LoginRequest
    {
        [Required(ErrorMessage = "Username is required")]
        public string? Username { get; set; }

        [Required(ErrorMessage = "Password is required")]
        [DataType(DataType.Password)]
        public string? Password { get; set; } 
        public string? ChannelId { get; set; }
        public string? AppId { get; set; }
    }

    public class LoginResponse
    {
        public string? Status { get; set; }
        public Message? Message { get; set; }
    }

    public class TokenResponse
    {
        public int Status { get; set; }
        public string? Token { get; set; }
        public string? Username { get; set; }
        public string? TokenType { get; set; }
        public string? Issued { get; set; }
        public string? Expires { get; set; }
    }

    public class Message
    {
        public Userdata? UserData { get; set; }
        public Usermenu[]? UserMenu { get; set; }
    }

    public class Userdata
    {
        public string? UserId { get; set; }
        public object? AppId { get; set; }
        public string? Username { get; set; }
        public string? FirstName { get; set; }
        public object? MiddleName { get; set; }
        public string? LastName { get; set; }
        public string? Role { get; set; }
        public object? RoleList { get; set; }
        public string? UserBranch { get; set; }
        public object? BranchList { get; set; }
        public string? UserEmail { get; set; }
        public object? Password { get; set; }
        public object? PwdChangeFlag { get; set; }
        public object? PwdChangeDate { get; set; }
        public object? PwdResetDate { get; set; }
        public object? PwdExpiryDate { get; set; }
        public object? LastPassword { get; set; }
        public object? AdLogin { get; set; }
        public object? AuthTypes { get; set; }
        public string? UserStatus { get; set; }
        public DateTime? LastLogin { get; set; }
        public int LoginAttempt { get; set; }
        public DateTime? MakerDate { get; set; }
        public object? MakerDateStamp { get; set; }
        public string? MakerId { get; set; }
        public string? AuthStat { get; set; }
        public string? CheckerId { get; set; }
        public DateTime? CheckerDateStamp { get; set; }
        public object? DateModified { get; set; }
        public object? UserModified { get; set; }
        public string? RecordStat { get; set; }
        public int ModNo { get; set; }
        public object? AutoAuth { get; set; }
        public object? PointingAccount { get; set; }
    }

    public class Usermenu
    {
        public string? MenuId { get; set; }
        public string? AppId { get; set; }
        public object? AppList { get; set; }
        public string? MenuName { get; set; }
        public string? Controller { get; set; }
        public string? MenuAction { get; set; }
        public string? RecordStat { get; set; }
        public DateTime MakerDate { get; set; }
        public DateTime MakerDateStamp { get; set; }
        public object? MakerId { get; set; }
        public string? AuthStat { get; set; }
        public object? CheckerId { get; set; }
        public object? CheckerDateStamp { get; set; }
        public object? DateModified { get; set; }
        public object? UserModified { get; set; }
        public int ModNo { get; set; }
        public object[]? SubMenus { get; set; }
        public string? RecordId { get; set; }
    }

    public class Filter
    {
        public string? Name { get; set; }
        public string? CreatedBy { get; set; }
        public string? AuthorizedBy { get; set; }
        // public DateTime? CreatedDate { get; set; }
        // public DateTime? EndDate { get; set; }
        public int Status { get; set; }
    }

    public class ErrorResponse
    {
        public int status { get; set; } = StaticVariables.Failedcode;
        public string message { get; set; } = StaticVariables.Failedmessage;
    }
}
