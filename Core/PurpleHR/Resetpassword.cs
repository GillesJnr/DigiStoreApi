using System;
using System.Collections.Generic;

namespace DigiStoreApi.Core.PurpleHR;

public partial class Resetpassword
{
    public Guid ResetId { get; set; }

    public string? EmpId { get; set; }

    public int? Status { get; set; }

    public DateTime? Entrydate { get; set; }

    public DateTime? Lastupdatedon { get; set; }
}
