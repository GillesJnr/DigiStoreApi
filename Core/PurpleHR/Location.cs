using System;
using System.Collections.Generic;

namespace DigiStoreApi.Core.PurpleHR;

public partial class Location
{
    public Guid LocationId { get; set; }

    public string? LocationName { get; set; }

    public string? LocationCityCode { get; set; }

    public DateTime? LocationEntrydate { get; set; }

    public string? LocationEnteredby { get; set; }

    public DateTime? LocationLastupdatedon { get; set; }

    public string? LocationLastupdatedby { get; set; }

    public int? LocationStatus { get; set; }

    public virtual ICollection<EmployeeHrShadow> EmployeeHrShadows { get; } = new List<EmployeeHrShadow>();

    public virtual ICollection<EmployeeShadow> EmployeeShadows { get; } = new List<EmployeeShadow>();

    public virtual ICollection<Employee> Employees { get; } = new List<Employee>();

    public virtual ICollection<PurpleEmployee> PurpleEmployees { get; } = new List<PurpleEmployee>();
}
