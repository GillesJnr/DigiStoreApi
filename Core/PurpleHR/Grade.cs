using System;
using System.Collections.Generic;

namespace DigiStoreApi.Core.PurpleHR;

public partial class Grade
{
    public Guid GradeCode { get; set; }

    public string? GradeName { get; set; }

    public string? GradeBand { get; set; }

    public DateTime? GradeEntrydate { get; set; }

    public string? GradeEnteredby { get; set; }

    public DateTime? GradeLastupdatedon { get; set; }

    public string? GradeLastupdatedby { get; set; }

    public int? GradeStatus { get; set; }

    public double? BasicSalary { get; set; }

    public double? ClothingAllowance { get; set; }

    public double? FuelAllowance { get; set; }

    public virtual ICollection<EmployeeHrShadow> EmployeeHrShadows { get; } = new List<EmployeeHrShadow>();

    public virtual ICollection<EmployeeShadow> EmployeeShadows { get; } = new List<EmployeeShadow>();

    public virtual ICollection<Employee> Employees { get; } = new List<Employee>();

    public virtual ICollection<PurpleEmployee> PurpleEmployees { get; } = new List<PurpleEmployee>();
}
