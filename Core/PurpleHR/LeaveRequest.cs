using System;
using System.Collections.Generic;

namespace DigiStoreApi.Core.PurpleHR;

public partial class LeaveRequest
{
    public Guid RequestId { get; set; }

    public string? RequestOwner { get; set; }

    public string? RequestCurrentuser { get; set; }

    public string? RequestYear { get; set; }

    public int? NumDays { get; set; }

    public DateTime? StartDate { get; set; }

    public DateTime? EndDate { get; set; }

    public string? PayAllowance { get; set; }

    public Guid? LeaveType { get; set; }

    public string? LeaveTypeCustom { get; set; }

    public string? ContactNumber { get; set; }

    public string? HandOverTo { get; set; }

    public byte[]? HandingOverNotes { get; set; }

    public string? HandingOverNotesContentType { get; set; }

    public byte[]? SupportingDocx { get; set; }

    public string? SupportingDocxContentType { get; set; }

    public int? Status { get; set; }

    public DateTime? Entrydate { get; set; }

    public string? Enteredby { get; set; }

    public DateTime? Reviewdate { get; set; }

    public string? Reviewedby { get; set; }

    public DateTime? Approvedate { get; set; }

    public string? Approvedby { get; set; }

    public DateTime? Declinedate { get; set; }

    public string? Declinedby { get; set; }

    public string? Declinereason { get; set; }

    public DateTime? Revertdate { get; set; }

    public string? Revertedby { get; set; }

    public string? Revertreason { get; set; }

    public DateTime? Rejectdate { get; set; }

    public string? Rejectedby { get; set; }

    public string? Rejectreason { get; set; }

    public int? PayStatus { get; set; }

    public string? PaidBy { get; set; }

    public DateTime? PayDate { get; set; }

    public string? Reason { get; set; }

    public virtual LeaveRequestStatus? StatusNavigation { get; set; }
}
