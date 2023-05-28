using System;
using System.Collections.Generic;

namespace DigiStoreApi.Core.PurpleHR;

public partial class LeavePayment
{
    public Guid RequestId { get; set; }

    public string? Maker { get; set; }

    public DateTime? Makerdate { get; set; }

    public string? MakerReason { get; set; }

    public string? Checker { get; set; }

    public DateTime? Checkerdate { get; set; }

    public string? CheckerReason { get; set; }

    public int? Status { get; set; }
}
