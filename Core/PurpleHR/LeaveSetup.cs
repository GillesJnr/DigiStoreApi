using System;
using System.Collections.Generic;

namespace DigiStoreApi.Core.PurpleHR;

public partial class LeaveSetup
{
    public string EmpId { get; set; } = null!;

    public string LeaveYear { get; set; } = null!;

    public int? TotalDays { get; set; }

    public string? LsCurrentuser { get; set; }

    public DateTime? Entrydate { get; set; }

    public string? Enteredby { get; set; }

    public DateTime? Approvedate { get; set; }

    public string? Approvedby { get; set; }

    public DateTime? Lastupdatedon { get; set; }

    public string? Lastupdatedby { get; set; }

    public int? Status { get; set; }

    public virtual LeaveSetupStatus? StatusNavigation { get; set; }
}
