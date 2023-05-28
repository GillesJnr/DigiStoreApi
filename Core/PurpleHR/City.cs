using System;
using System.Collections.Generic;

namespace DigiStoreApi.Core.PurpleHR;

public partial class City
{
    public Guid CityCode { get; set; }

    public string? CityName { get; set; }

    public string? CountryCode { get; set; }

    public DateTime? CityEntrydate { get; set; }

    public string? CityEnteredby { get; set; }

    public DateTime? CityLastupdatedon { get; set; }

    public string? CityLastupdatedby { get; set; }

    public int? CityStatus { get; set; }

    public virtual ICollection<EmployeeHrShadow> EmployeeHrShadows { get; } = new List<EmployeeHrShadow>();

    public virtual ICollection<EmployeeShadow> EmployeeShadows { get; } = new List<EmployeeShadow>();

    public virtual ICollection<Employee> Employees { get; } = new List<Employee>();

    public virtual ICollection<PurpleEmployee> PurpleEmployees { get; } = new List<PurpleEmployee>();
}
