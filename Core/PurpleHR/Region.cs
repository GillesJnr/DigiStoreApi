using System;
using System.Collections.Generic;

namespace DigiStoreApi.Core.PurpleHR;

public partial class Region
{
    public Guid RegCode { get; set; }

    public string? RegName { get; set; }

    public DateTime? RegEntrydate { get; set; }

    public string? RegEnteredby { get; set; }

    public DateTime? RegLastupdatedon { get; set; }

    public string? RegLastupdatedby { get; set; }

    public int? RegStatus { get; set; }

    public virtual ICollection<EmployeeHrShadow> EmployeeHrShadows { get; } = new List<EmployeeHrShadow>();

    public virtual ICollection<EmployeeShadow> EmployeeShadows { get; } = new List<EmployeeShadow>();

    public virtual ICollection<Employee> Employees { get; } = new List<Employee>();

    public virtual ICollection<PurpleEmployee> PurpleEmployees { get; } = new List<PurpleEmployee>();
}
