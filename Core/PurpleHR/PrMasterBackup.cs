using System;
using System.Collections.Generic;

namespace DigiStoreApi.Core.PurpleHR;

public partial class PrMasterBackup
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? EmpId { get; set; }

    public string? AccountNumber { get; set; }

    public string? GradeNotch { get; set; }

    public string? Department { get; set; }

    public int? DaysWorked { get; set; }

    public decimal? ConsolidatedSalary { get; set; }

    public decimal? CarElement { get; set; }

    public decimal? RentElement { get; set; }

    public decimal? TotalEmolument { get; set; }

    public decimal? Ssfcontribution { get; set; }

    public decimal? TaxableSalary { get; set; }

    public decimal? Tax { get; set; }

    public decimal? NetSalary { get; set; }

    public decimal? InsuranceContribution { get; set; }

    public decimal? Msoscontribution { get; set; }

    public decimal? TakeHome { get; set; }

    public string? Comment { get; set; }

    public string? PaymentPeriod { get; set; }

    public int? PaymentStatus { get; set; }

    public DateTime? PaymentDate { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? ApproveDate { get; set; }

    public string? ApprovedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public string? ModifiedBy { get; set; }

    public decimal? Fuel { get; set; }

    public decimal? Clothing { get; set; }

    public decimal? ActingAllowance { get; set; }

    public decimal? ClothingPayable { get; set; }

    public bool? IsJoiner { get; set; }

    public bool? IsExisting { get; set; }
}
