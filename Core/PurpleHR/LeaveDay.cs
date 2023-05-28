using System;
using System.Collections.Generic;

namespace DigiStoreApi.Core.PurpleHR;

public partial class LeaveDay
{
    public Guid GradeCode { get; set; }

    public int? TotalDays { get; set; }

    public decimal? Allowance { get; set; }

    public DateTime? Entrydate { get; set; }

    public string? Enteredby { get; set; }

    public DateTime? Lastupdatedon { get; set; }

    public string? Lastupdatedby { get; set; }
}
