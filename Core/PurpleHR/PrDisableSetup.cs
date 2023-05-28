using System;
using System.Collections.Generic;

namespace DigiStoreApi.Core.PurpleHR;

public partial class PrDisableSetup
{
    public int Id { get; set; }

    public string? GradeNotch { get; set; }

    public decimal? ConsolidatedSalary { get; set; }

    public decimal? CarElement { get; set; }

    public decimal? RentElement { get; set; }

    public int? Status { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? ApproveDate { get; set; }

    public string? ApprovedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public string? ModifiedBy { get; set; }
}
