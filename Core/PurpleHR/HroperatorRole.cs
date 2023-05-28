using System;
using System.Collections.Generic;

namespace DigiStoreApi.Core.PurpleHR;

public partial class HroperatorRole
{
    public string LoginId { get; set; } = null!;

    public string EmpId { get; set; } = null!;

    public string HrRole { get; set; } = null!;

    public DateTime? Entrydate { get; set; }

    public string? Enteredby { get; set; }

    public DateTime? Lastupdatedate { get; set; }

    public string? Lastupdatedby { get; set; }

    public int Status { get; set; }
}
