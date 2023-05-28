using System;
using System.Collections.Generic;

namespace DigiStoreApi.Core.PurpleHR;

public partial class EmpTraining
{
    public Guid Tid { get; set; }

    public string EmpId { get; set; } = null!;

    public string? CourseName { get; set; }

    public string? DateAttended { get; set; }

    public int? HasCertificate { get; set; }

    public string? Certificate { get; set; }

    public DateTime? Entrydate { get; set; }

    public string? Enteredby { get; set; }

    public DateTime? Lastupdatedon { get; set; }

    public string? Lastupdatedby { get; set; }

    public int? Status { get; set; }
}
