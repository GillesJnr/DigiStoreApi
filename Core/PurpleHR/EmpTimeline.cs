using System;
using System.Collections.Generic;

namespace DigiStoreApi.Core.PurpleHR;

public partial class EmpTimeline
{
    public Guid Tid { get; set; }

    public string EmpId { get; set; } = null!;

    public string? EmpAction { get; set; }

    public string? EmpFrom { get; set; }

    public string? EmpTo { get; set; }

    public DateTime? Entrydate { get; set; }

    public string? Enteredby { get; set; }

    public DateTime? Lastupdatedon { get; set; }

    public string? Lastupdatedby { get; set; }

    public int? Status { get; set; }
}
