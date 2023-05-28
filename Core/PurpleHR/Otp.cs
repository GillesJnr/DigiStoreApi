using System;
using System.Collections.Generic;

namespace DigiStoreApi.Core.PurpleHR;

public partial class Otp
{
    public int Id { get; set; }

    public string? Token { get; set; }

    public string? Otp1 { get; set; }

    public int? Attempt { get; set; }

    public DateTime? FailedAt { get; set; }

    public int? Status { get; set; }

    public string? UserId { get; set; }

    public DateTime? CreatedAt { get; set; }

    public bool? IsNew { get; set; }
}
