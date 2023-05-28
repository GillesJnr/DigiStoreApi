using System;
using System.Collections.Generic;

namespace DigiStoreApi.Core.PurpleHR;

public partial class EmpDataChange
{
    public Guid ChangeId { get; set; }

    public string EmpId { get; set; } = null!;

    public string? EmpSalutation { get; set; }

    public string? EmpFirstname { get; set; }

    public string? EmpOthernames { get; set; }

    public string? EmpSurname { get; set; }

    public string? EmpLegalname { get; set; }

    public string? EmpCompanyname { get; set; }

    public string? EmpGender { get; set; }

    public DateTime? EmpDob { get; set; }

    public string? EmpPhone { get; set; }

    public string? EmpPostaladdress { get; set; }

    public string? EmpResidentialaddress { get; set; }

    public string? EmpOfficephone { get; set; }

    public string? EmpOfficeaddress { get; set; }

    public string? EmpEmail { get; set; }

    public int? EmpNationality { get; set; }

    public string? EmpOfficefax { get; set; }

    public string? EmpOfficeext { get; set; }

    public string? EmpOfficemail { get; set; }

    public Guid? EmpGrade { get; set; }

    public Guid? EmpDesignation { get; set; }

    public Guid? EmpDept { get; set; }

    public Guid? EmpLocation { get; set; }

    public Guid? EmpRegion { get; set; }

    public Guid? EmpCity { get; set; }

    public Guid? EmpPosition { get; set; }

    public Guid? EmpOu { get; set; }

    public string? EmpSupervisor { get; set; }

    public string? EmpFunctionalmgr { get; set; }

    public Guid? EmpPaygroup { get; set; }

    public string? EmpSsn { get; set; }

    public string? EmpTin { get; set; }

    public string? EmpAccount { get; set; }

    public string? EmpCategory { get; set; }

    public string? EmpType { get; set; }

    public DateTime? EmpDatejoined { get; set; }

    public int? EmpIsconfirmed { get; set; }

    public DateTime? EmpConfirmdate { get; set; }

    public DateTime? EmpLeavingdate { get; set; }

    public Guid? EmpRecruiter { get; set; }

    public string? EmpPaymode { get; set; }

    public string? EmpPaylocation { get; set; }

    public byte[]? EmpCv { get; set; }

    public string? EmpReference1Name { get; set; }

    public string? EmpReference1Phone { get; set; }

    public string? EmpReference1Address { get; set; }

    public string? EmpReference2Name { get; set; }

    public string? EmpReference2Phone { get; set; }

    public string? EmpReference2Address { get; set; }

    public string? EmpReference3Name { get; set; }

    public string? EmpReference3Phone { get; set; }

    public string? EmpReference3Address { get; set; }

    public byte[]? EmpPhoto { get; set; }

    public int? ChangeStatus { get; set; }

    public string? CurrentUsr { get; set; }

    public DateTime? Requestdate { get; set; }

    public string? VerifiedBy { get; set; }

    public DateTime? VerifiedDate { get; set; }

    public string? ApprovedBy { get; set; }

    public DateTime? ApprovedDate { get; set; }
}
