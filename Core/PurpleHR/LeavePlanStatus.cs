using System;
using System.Collections.Generic;

namespace DigiStoreApi.Core.PurpleHR;

public partial class LeavePlanStatus
{
    public int LpId { get; set; }

    public string? LpName { get; set; }

    public string? LpDesc { get; set; }

    public virtual ICollection<LeavePlan> LeavePlans { get; } = new List<LeavePlan>();
}
