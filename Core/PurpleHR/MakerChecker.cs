using System;
using System.Collections.Generic;

namespace DigiStoreApi.Core.PurpleHR;

public partial class MakerChecker
{
    public Guid McId { get; set; }

    public Guid? PageId { get; set; }

    public string? PageName { get; set; }

    public string? PageDesc { get; set; }

    public string? Maker { get; set; }

    public string? Checker { get; set; }

    public DateTime? Entrydate { get; set; }

    public string? Enteredby { get; set; }

    public DateTime? Lastupdatedon { get; set; }

    public string? Lastupdateby { get; set; }

    public int? Isactive { get; set; }
}
