using System;
using System.Collections.Generic;

namespace DigiStoreApi.Core.PurpleHR;

public partial class HrMakerChecker
{
    public string? EmpId { get; set; }

    public string? Currentuser { get; set; }

    public string? Maker { get; set; }

    public string? Checker { get; set; }

    public DateTime? Entrydate { get; set; }
}
