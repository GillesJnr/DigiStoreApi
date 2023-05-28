using System;
using System.Collections.Generic;

namespace DigiStoreApi.Core.PurpleHR;

public partial class Paygroup
{
    public Guid PaygroupId { get; set; }

    public string? PaygroupName { get; set; }

    public string? PaygroupDesc { get; set; }

    public DateTime? PaygroupEntrydate { get; set; }

    public string? PaygroupEnteredby { get; set; }

    public DateTime? PaygroupLastupdatedon { get; set; }

    public string? PaygroupLastupdatedby { get; set; }

    public int? PaygroupStatus { get; set; }

    public virtual ICollection<EmployeeHrShadow> EmployeeHrShadows { get; } = new List<EmployeeHrShadow>();

    public virtual ICollection<EmployeeShadow> EmployeeShadows { get; } = new List<EmployeeShadow>();

    public virtual ICollection<Employee> Employees { get; } = new List<Employee>();

    public virtual ICollection<PurpleEmployee> PurpleEmployees { get; } = new List<PurpleEmployee>();
}
