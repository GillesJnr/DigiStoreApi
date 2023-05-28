using System;
using System.Collections.Generic;

namespace DigiStoreApi.Core.PurpleHR;

public partial class Position
{
    public Guid PosId { get; set; }

    public string? PosNo { get; set; }

    public string? PosTitle { get; set; }

    public string? PosDesc { get; set; }

    public DateTime? PosEntrydate { get; set; }

    public string? PosEnteredby { get; set; }

    public DateTime? PosLastupdatedon { get; set; }

    public string? PosLastupdatedby { get; set; }

    public int? PosStatus { get; set; }
}
