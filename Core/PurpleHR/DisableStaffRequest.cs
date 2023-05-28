using System;
using System.Collections.Generic;

namespace DigiStoreApi.Core.PurpleHR;

public partial class DisableStaffRequest
{
    public Guid RequestId { get; set; }

    public string? EmpId { get; set; }

    public string? DisableReason { get; set; }

    public string? Currentuser { get; set; }

    public int? RequestStatus { get; set; }

    public string? RequestBy { get; set; }

    public DateTime? RequestDate { get; set; }

    public string? ApprovedBy { get; set; }

    public DateTime? ApproveDate { get; set; }

    public string? RejectedBy { get; set; }

    public DateTime? RejectDate { get; set; }
}
