using System;
using System.Collections.Generic;

namespace DigiStoreApi.Core.PurpleHR;

public partial class LeaveType
{
    public Guid LeaveTypeId { get; set; }

    public string? LeaveTypeName { get; set; }

    public string? LeaveTypeDesc { get; set; }

    public DateTime? Entrydate { get; set; }

    public string? Enteredby { get; set; }

    public DateTime? Lastupdatedon { get; set; }

    public string? Lastupdatedby { get; set; }
}
