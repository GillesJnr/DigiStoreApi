using System;
using System.Collections.Generic;

namespace DigiStoreApi.Core.PurpleHR;

public partial class EmpApproval
{
    public string EmpId { get; set; } = null!;

    public string? ApprovedBy { get; set; }

    public DateTime? ApprovedDate { get; set; }

    public string? RejectedBy { get; set; }

    public DateTime? RejectDate { get; set; }

    public string? RejectReason { get; set; }
}
