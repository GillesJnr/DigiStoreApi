using System;
using System.Collections.Generic;

namespace DigiStoreApi.Core.PurpleHR;

public partial class Qualification
{
    public Guid QId { get; set; }

    public string? EmpNo { get; set; }

    public string? Qualification1 { get; set; }

    public string? Institution { get; set; }

    public DateTime? Dateattained { get; set; }

    public byte[]? Certificate { get; set; }

    public string? Reviewedby { get; set; }

    public DateTime? Revieweddate { get; set; }

    public string? Approvalby { get; set; }

    public DateTime? Approveddate { get; set; }

    public string? Rejectedby { get; set; }

    public DateTime? Rejectdate { get; set; }

    public int? QStatus { get; set; }

    public DateTime? Entrydate { get; set; }

    public DateTime? Lastupdatedon { get; set; }

    public virtual Employee? EmpNoNavigation { get; set; }
}
