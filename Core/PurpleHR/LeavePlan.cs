using System;
using System.Collections.Generic;

namespace DigiStoreApi.Core.PurpleHR;

public partial class LeavePlan
{
    public Guid LpId { get; set; }

    public string EmpId { get; set; } = null!;

    public string LeaveYear { get; set; } = null!;

    public int? OverallTraverse { get; set; }

    public string? LpCurrentuser { get; set; }

    public DateTime? TraverseOneStartdate { get; set; }

    public DateTime? TraverseOneEnddate { get; set; }

    public int? TraverseOneDays { get; set; }

    public DateTime? TraverseTwoStartdate { get; set; }

    public DateTime? TraverseTwoEnddate { get; set; }

    public int? TraverseTwoDays { get; set; }

    public DateTime? TraverseThreeStartdate { get; set; }

    public DateTime? TraverseThreeEnddate { get; set; }

    public int? TraverseThreeDays { get; set; }

    public DateTime? TraverseFourStartdate { get; set; }

    public DateTime? TraverseFourEnddate { get; set; }

    public int? TraverseFourDays { get; set; }

    public int? Status { get; set; }

    public DateTime? Entrydate { get; set; }

    public string? Enteredby { get; set; }

    public DateTime? Reviewdate { get; set; }

    public string? Reviewedby { get; set; }

    public string? Rejectreason { get; set; }

    public DateTime? Lastupdatedon { get; set; }

    public string? Lastupdatedby { get; set; }

    public virtual LeavePlanStatus? StatusNavigation { get; set; }
}
