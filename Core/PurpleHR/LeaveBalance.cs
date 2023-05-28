using System;
using System.Collections.Generic;

namespace DigiStoreApi.Core.PurpleHR;

public partial class LeaveBalance
{
    public Guid LbId { get; set; }

    public string? EmpId { get; set; }

    public string? LeaveYear { get; set; }

    public int? BalBefore { get; set; }

    public int? NewBal { get; set; }

    public string? Changeby { get; set; }

    public DateTime? Changedate { get; set; }

    public string? Approveby { get; set; }

    public DateTime? Approvedate { get; set; }

    public string? Rejectedby { get; set; }

    public DateTime? Rejectdate { get; set; }

    public string? Rejectreason { get; set; }

    public string? LbCurrentuser { get; set; }

    public int? Status { get; set; }
}
