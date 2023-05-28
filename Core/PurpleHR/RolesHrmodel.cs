using System;
using System.Collections.Generic;

namespace DigiStoreApi.Core.PurpleHR;

public partial class RolesHrmodel
{
    public Guid RoleId { get; set; }

    public string? RoleName { get; set; }

    public string? RoleDesc { get; set; }

    public string? RoleAccess { get; set; }
}
