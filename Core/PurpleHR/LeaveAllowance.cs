using System;
using System.Collections.Generic;

namespace DigiStoreApi.Core.PurpleHR;

public partial class LeaveAllowance
{
    public Guid LaId { get; set; }

    public string? EmpId { get; set; }

    public string? LeaveYear { get; set; }

    public decimal? OldAllowance { get; set; }

    public decimal? LeaveAllowance1 { get; set; }

    public DateTime? Entrydate { get; set; }

    public string? Enteredby { get; set; }

    public DateTime? Lastupdatedon { get; set; }

    public string? Lastupdatedby { get; set; }

    public string? Approveby { get; set; }

    public DateTime? Approvedate { get; set; }

    public string? Rejectedby { get; set; }

    public DateTime? Rejectdate { get; set; }

    public string? Rejectreason { get; set; }

    public string? LbCurrentuser { get; set; }

    public int? Status { get; set; }
}
