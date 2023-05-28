using System;
using System.Collections.Generic;

namespace DigiStoreApi.Core.PurpleHR;

public partial class UserRole
{
    public Guid RoleId { get; set; }

    public string RoleName { get; set; } = null!;

    public string? RoleDesc { get; set; }

    public string? RoleAccess { get; set; }

    public string? IsActive { get; set; }

    public DateTime? EntryDate { get; set; }

    public string? Enteredby { get; set; }

    public DateTime? LastupdateDate { get; set; }

    public string? Lastudatedby { get; set; }
}
