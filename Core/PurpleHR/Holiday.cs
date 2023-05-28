using System;
using System.Collections.Generic;

namespace DigiStoreApi.Core.PurpleHR;

public partial class Holiday
{
    public int Sn { get; set; }

    public string? Datedd { get; set; }

    public string? Datemm { get; set; }

    public string? Datedesc { get; set; }

    public DateTime? Dateval { get; set; }

    public string? Currentuser { get; set; }

    public DateTime? Entrydate { get; set; }

    public string? Enteredby { get; set; }

    public DateTime? Approvedate { get; set; }

    public string? Approvedby { get; set; }

    public int? Status { get; set; }
}
