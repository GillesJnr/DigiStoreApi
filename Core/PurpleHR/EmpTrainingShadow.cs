using System;
using System.Collections.Generic;

namespace DigiStoreApi.Core.PurpleHR;

public partial class EmpTrainingShadow
{
    public Guid Tid { get; set; }

    public string EmpId { get; set; } = null!;

    public string? CourseName { get; set; }

    public string? DateAttended { get; set; }

    public int? HasCertificate { get; set; }

    public string? Certificate { get; set; }

    public DateTime? Entrydate { get; set; }

    public string? Enteredby { get; set; }

    public DateTime? Lastupdatedon { get; set; }

    public string? Lastupdatedby { get; set; }

    public int? Status { get; set; }

    public string? CurrentUsr { get; set; }

    public DateTime? Requestdate { get; set; }

    public string? VerifiedBy { get; set; }

    public DateTime? VerifiedDate { get; set; }

    public string? ApprovedBy { get; set; }

    public DateTime? ApprovedDate { get; set; }

    public string? RejectedBy { get; set; }

    public DateTime? RejectedDate { get; set; }

    public string? RejectReason { get; set; }
}
