using System;
using System.Collections.Generic;

namespace DigiStoreApi.Core.PurpleHR;

public partial class Department
{
    public Guid DeptId { get; set; }

    public string? DeptCode { get; set; }

    public string? DeptName { get; set; }

    public string? DeptDesc { get; set; }

    public DateTime? DeptEntrydate { get; set; }

    public string? DeptEnteredby { get; set; }

    public DateTime? DeptLastupdatedon { get; set; }

    public string? DeptLastupdatedby { get; set; }

    public int? DeptStatus { get; set; }

    public string? Category { get; set; }

    public virtual ICollection<EmployeeHrShadow> EmployeeHrShadows { get; } = new List<EmployeeHrShadow>();

    public virtual ICollection<EmployeeShadow> EmployeeShadows { get; } = new List<EmployeeShadow>();

    public virtual ICollection<Employee> Employees { get; } = new List<Employee>();

    public virtual ICollection<PurpleEmployee> PurpleEmployees { get; } = new List<PurpleEmployee>();
}
