using System;
using System.Collections.Generic;

namespace DigiStoreApi.Core.PurpleHR;

public partial class Ou
{
    public Guid OuId { get; set; }

    public string? OuCode { get; set; }

    public string? OuName { get; set; }

    public string? OuCodename { get; set; }

    public Guid? OuParentOuId { get; set; }

    public int? OuIsapproved { get; set; }

    public int? OuIsactive { get; set; }

    public DateTime? OuEntrydate { get; set; }

    public string? OuEnteredby { get; set; }

    public DateTime? OuApprovedate { get; set; }

    public string? OuApprovedby { get; set; }

    public string? Category { get; set; }

    public virtual ICollection<EmployeeHrShadow> EmployeeHrShadows { get; } = new List<EmployeeHrShadow>();

    public virtual ICollection<EmployeeShadow> EmployeeShadows { get; } = new List<EmployeeShadow>();

    public virtual ICollection<Employee> Employees { get; } = new List<Employee>();

    public virtual ICollection<PurpleEmployee> PurpleEmployees { get; } = new List<PurpleEmployee>();
}
