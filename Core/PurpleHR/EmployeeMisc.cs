using System;
using System.Collections.Generic;

namespace DigiStoreApi.Core.PurpleHR;

public partial class EmployeeMisc
{
    public string EmpId { get; set; } = null!;

    public string? GeneralRemarks { get; set; }

    public string? Disability { get; set; }

    public string? NokName { get; set; }

    public string? NokContact { get; set; }

    public string? NokAddress { get; set; }

    public string? DepName1 { get; set; }

    public string? DepContact1 { get; set; }

    public string? DepAddress1 { get; set; }

    public string? DepName2 { get; set; }

    public string? DepContact2 { get; set; }

    public string? DepAddress2 { get; set; }

    public string? DepName3 { get; set; }

    public string? DepContact3 { get; set; }

    public string? DepAddress3 { get; set; }

    public string? DepName4 { get; set; }

    public string? DepContact4 { get; set; }

    public string? DepAddress4 { get; set; }

    public string? Training { get; set; }

    public DateTime? Entrydate { get; set; }

    public string? Enteredby { get; set; }

    public DateTime? Lastupdatedon { get; set; }

    public string? Lastupdatedby { get; set; }

    public int? Status { get; set; }
}
