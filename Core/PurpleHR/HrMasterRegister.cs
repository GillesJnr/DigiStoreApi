using System;
using System.Collections.Generic;

namespace DigiStoreApi.Core.PurpleHR;

public partial class HrMasterRegister
{
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

    public int? EmpBirthcountry { get; set; }

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

    public string? EmpHealthinsurancenumber { get; set; }

    public string? EmpBenefitoption { get; set; }

    public string? EmpCategory { get; set; }

    public string? EmpType { get; set; }

    public DateTime? EmpDatejoined { get; set; }

    public string? EmpIsconfirmed { get; set; }

    public DateTime? EmpConfirmdate { get; set; }

    public DateTime? EmpLeavingdate { get; set; }

    public string? EmpRecruiter { get; set; }

    public string? EmpPaymode { get; set; }

    public string? EmpPaylocation { get; set; }

    public string? FdQualification { get; set; }

    public string? FdInstitution { get; set; }

    public DateTime? FdDateobtained { get; set; }

    public byte[]? FdCertificate { get; set; }

    public string? SdQualification { get; set; }

    public string? SdInstitution { get; set; }

    public DateTime? SdDateobtained { get; set; }

    public byte[]? SdCertificate { get; set; }

    public string? P1Qualification { get; set; }

    public string? P1Institution { get; set; }

    public DateTime? P1Dateobtained { get; set; }

    public byte[]? P1Certificate { get; set; }

    public string? P2Qualification { get; set; }

    public string? P2Institution { get; set; }

    public DateTime? P2Dateobtained { get; set; }

    public byte[]? P2Certificate { get; set; }

    public string? P3Qualification { get; set; }

    public string? P3Institution { get; set; }

    public DateTime? P3Dateobtained { get; set; }

    public byte[]? P3Certificate { get; set; }

    public string? P4Qualification { get; set; }

    public string? P4Institution { get; set; }

    public DateTime? P4Dateobtained { get; set; }

    public byte[]? P4Certificate { get; set; }

    public string? P5Qualification { get; set; }

    public string? P5Institution { get; set; }

    public DateTime? P5Dateobtained { get; set; }

    public byte[]? P5Certificate { get; set; }

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

    public int? EmpStatus { get; set; }

    public string? EmpEnteredby { get; set; }

    public DateTime? EmpEntrydate { get; set; }

    public string? EmpLastupdatedby { get; set; }

    public DateTime? EmpLastupdatedon { get; set; }
}
