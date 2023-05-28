using System;
using System.Collections.Generic;

namespace DigiStoreApi.Core.PurpleHR;

public partial class LeaveSetupStatus
{
    public int LsId { get; set; }

    public string? LsName { get; set; }

    public string? LsDesc { get; set; }

    public virtual ICollection<LeaveSetup> LeaveSetups { get; } = new List<LeaveSetup>();
}
