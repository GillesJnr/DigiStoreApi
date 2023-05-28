using System;
using System.Collections.Generic;

namespace DigiStoreApi.Core.PurpleHR;

public partial class Country
{
    public int CountryId { get; set; }

    public string? CountryName { get; set; }

    public string? TwocharCountrycode { get; set; }

    public string? ThreecharCountrycode { get; set; }

    public virtual ICollection<EmployeeHrShadow> EmployeeHrShadowEmpBirthcountryNavigations { get; } = new List<EmployeeHrShadow>();

    public virtual ICollection<EmployeeHrShadow> EmployeeHrShadowEmpNationalityNavigations { get; } = new List<EmployeeHrShadow>();

    public virtual ICollection<EmployeeShadow> EmployeeShadowEmpBirthcountryNavigations { get; } = new List<EmployeeShadow>();

    public virtual ICollection<EmployeeShadow> EmployeeShadowEmpNationalityNavigations { get; } = new List<EmployeeShadow>();

    public virtual ICollection<Employee> Employees { get; } = new List<Employee>();

    public virtual ICollection<PurpleEmployee> PurpleEmployees { get; } = new List<PurpleEmployee>();
}
