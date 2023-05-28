using System;
using System.Collections.Generic;

namespace DigiStoreApi.Core.PurpleHR;

public partial class LocalAuth
{
    public string Id { get; set; } = null!;

    public string? Username { get; set; }

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public string? Email { get; set; }

    public string? Role { get; set; }

    public int? Status { get; set; }

    public bool? IsPasswordResetRequired { get; set; }

    public DateTime? CreatedAt { get; set; }

    public string? CreatedById { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public string? UpdatedById { get; set; }

    public string? PhoneNumber { get; set; }

    public string? Password { get; set; }
}
