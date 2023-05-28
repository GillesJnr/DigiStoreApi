using System;
using System.Collections.Generic;

namespace DigiStoreApi.Core.PurpleHR;

public partial class Designation
{
    public Guid DesignationCode { get; set; }

    public string? DesignationName { get; set; }

    public string? DesignationDesc { get; set; }

    public DateTime? DesignationEntrydate { get; set; }

    public string? DesignationEnteredby { get; set; }

    public DateTime? DesignationLastupdatedon { get; set; }

    public string? DesignationLastupdatedby { get; set; }

    public int? DesignationStatus { get; set; }

    public string? Category { get; set; }

    public virtual ICollection<EmployeeHrShadow> EmployeeHrShadows { get; } = new List<EmployeeHrShadow>();

    public virtual ICollection<EmployeeShadow> EmployeeShadows { get; } = new List<EmployeeShadow>();

    public virtual ICollection<Employee> Employees { get; } = new List<Employee>();

    public virtual ICollection<PurpleEmployee> PurpleEmployees { get; } = new List<PurpleEmployee>();
}
