using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace DigiStoreApi.Core.PurpleHR;

public partial class PurpleMeContext : DbContext
{
    private readonly IConfiguration _config;
    public PurpleMeContext(IConfiguration config)
    {
       _config = config;
    }

    public virtual DbSet<City> Cities { get; set; }

    public virtual DbSet<Country> Countries { get; set; }

    public virtual DbSet<Department> Departments { get; set; }

    public virtual DbSet<Designation> Designations { get; set; }

    public virtual DbSet<DisableStaffRequest> DisableStaffRequests { get; set; }

    public virtual DbSet<EmpApproval> EmpApprovals { get; set; }

    public virtual DbSet<EmpDataChange> EmpDataChanges { get; set; }

    public virtual DbSet<EmpShadow> EmpShadows { get; set; }

    public virtual DbSet<EmpTimeline> EmpTimelines { get; set; }

    public virtual DbSet<EmpTraining> EmpTrainings { get; set; }

    public virtual DbSet<EmpTrainingShadow> EmpTrainingShadows { get; set; }

    public virtual DbSet<Employee> Employees { get; set; }

    public virtual DbSet<EmployeeHrShadow> EmployeeHrShadows { get; set; }

    public virtual DbSet<EmployeeHrUpdate> EmployeeHrUpdates { get; set; }

    public virtual DbSet<EmployeeMisc> EmployeeMiscs { get; set; }

    public virtual DbSet<EmployeeMiscShadow> EmployeeMiscShadows { get; set; }

    public virtual DbSet<EmployeeShadow> EmployeeShadows { get; set; }

    public virtual DbSet<EmployeeUpdate> EmployeeUpdates { get; set; }

    public virtual DbSet<GlobalSetting> GlobalSettings { get; set; }

    public virtual DbSet<Grade> Grades { get; set; }

    public virtual DbSet<Holiday> Holidays { get; set; }

    public virtual DbSet<HrMakerChecker> HrMakerCheckers { get; set; }

    public virtual DbSet<HrMasterRegister> HrMasterRegisters { get; set; }

    public virtual DbSet<Hrmaster> Hrmasters { get; set; }

    public virtual DbSet<HroperatorRole> HroperatorRoles { get; set; }

    public virtual DbSet<LeaveAllowance> LeaveAllowances { get; set; }

    public virtual DbSet<LeaveBalance> LeaveBalances { get; set; }

    public virtual DbSet<LeaveDay> LeaveDays { get; set; }

    public virtual DbSet<LeavePayment> LeavePayments { get; set; }

    public virtual DbSet<LeavePlan> LeavePlans { get; set; }

    public virtual DbSet<LeavePlanStatus> LeavePlanStatuses { get; set; }

    public virtual DbSet<LeaveRequest> LeaveRequests { get; set; }

    public virtual DbSet<LeaveRequestStatus> LeaveRequestStatuses { get; set; }

    public virtual DbSet<LeaveSetup> LeaveSetups { get; set; }

    public virtual DbSet<LeaveSetupStatus> LeaveSetupStatuses { get; set; }

    public virtual DbSet<LeaveType> LeaveTypes { get; set; }

    public virtual DbSet<LocalAuth> LocalAuths { get; set; }

    public virtual DbSet<Location> Locations { get; set; }

    public virtual DbSet<MakerChecker> MakerCheckers { get; set; }

    public virtual DbSet<MigrationHistory> MigrationHistories { get; set; }

    public virtual DbSet<Otp> Otps { get; set; }

    public virtual DbSet<Ou> Ous { get; set; }

    public virtual DbSet<Paygroup> Paygroups { get; set; }

    public virtual DbSet<Position> Positions { get; set; }

    public virtual DbSet<PrDisableSetup> PrDisableSetups { get; set; }

    public virtual DbSet<PrMaster> PrMasters { get; set; }

    public virtual DbSet<PrMasterBackup> PrMasterBackups { get; set; }

    public virtual DbSet<PrSetup> PrSetups { get; set; }

    public virtual DbSet<PrSetupShadow> PrSetupShadows { get; set; }

    public virtual DbSet<PurpleEmployee> PurpleEmployees { get; set; }

    public virtual DbSet<Qualification> Qualifications { get; set; }

    public virtual DbSet<Region> Regions { get; set; }

    public virtual DbSet<Resetpassword> Resetpasswords { get; set; }

    public virtual DbSet<RolesHrmodel> RolesHrmodels { get; set; }

    public virtual DbSet<TempDept> TempDepts { get; set; }

    public virtual DbSet<TempDesignation> TempDesignations { get; set; }

    public virtual DbSet<TempGrade> TempGrades { get; set; }

    public virtual DbSet<UserMessage> UserMessages { get; set; }

    public virtual DbSet<UserRole> UserRoles { get; set; }

    public virtual DbSet<UsersInRole> UsersInRoles { get; set; }

    // protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    //     => optionsBuilder.UseSqlServer("Name=ConnectionStrings:PurpleDbContext");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<City>(entity =>
        {
            entity.HasKey(e => e.CityCode);

            entity.ToTable("CITY");

            entity.Property(e => e.CityCode)
                .ValueGeneratedNever()
                .HasColumnName("CITY_CODE");
            entity.Property(e => e.CityEnteredby)
                .HasMaxLength(50)
                .HasColumnName("CITY_ENTEREDBY");
            entity.Property(e => e.CityEntrydate)
                .HasColumnType("datetime")
                .HasColumnName("CITY_ENTRYDATE");
            entity.Property(e => e.CityLastupdatedby)
                .HasMaxLength(50)
                .HasColumnName("CITY_LASTUPDATEDBY");
            entity.Property(e => e.CityLastupdatedon)
                .HasColumnType("datetime")
                .HasColumnName("CITY_LASTUPDATEDON");
            entity.Property(e => e.CityName)
                .HasMaxLength(256)
                .HasColumnName("CITY_NAME");
            entity.Property(e => e.CityStatus).HasColumnName("CITY_STATUS");
            entity.Property(e => e.CountryCode)
                .HasMaxLength(16)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("COUNTRY_CODE");
        });

        modelBuilder.Entity<Country>(entity =>
        {
            entity.ToTable("COUNTRIES");

            entity.Property(e => e.CountryId)
                .ValueGeneratedNever()
                .HasColumnName("COUNTRY_ID");
            entity.Property(e => e.CountryName)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("COUNTRY_NAME");
            entity.Property(e => e.ThreecharCountrycode)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("THREECHAR_COUNTRYCODE");
            entity.Property(e => e.TwocharCountrycode)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("TWOCHAR_COUNTRYCODE");
        });

        modelBuilder.Entity<Department>(entity =>
        {
            entity.HasKey(e => e.DeptId);

            entity.ToTable("DEPARTMENT");

            entity.Property(e => e.DeptId)
                .ValueGeneratedNever()
                .HasColumnName("DEPT_ID");
            entity.Property(e => e.Category)
                .HasMaxLength(50)
                .HasColumnName("CATEGORY");
            entity.Property(e => e.DeptCode)
                .HasMaxLength(50)
                .HasColumnName("DEPT_CODE");
            entity.Property(e => e.DeptDesc)
                .HasMaxLength(100)
                .HasColumnName("DEPT_DESC");
            entity.Property(e => e.DeptEnteredby)
                .HasMaxLength(50)
                .HasColumnName("DEPT_ENTEREDBY");
            entity.Property(e => e.DeptEntrydate)
                .HasColumnType("datetime")
                .HasColumnName("DEPT_ENTRYDATE");
            entity.Property(e => e.DeptLastupdatedby)
                .HasMaxLength(50)
                .HasColumnName("DEPT_LASTUPDATEDBY");
            entity.Property(e => e.DeptLastupdatedon)
                .HasColumnType("datetime")
                .HasColumnName("DEPT_LASTUPDATEDON");
            entity.Property(e => e.DeptName)
                .HasMaxLength(50)
                .HasColumnName("DEPT_NAME");
            entity.Property(e => e.DeptStatus).HasColumnName("DEPT_STATUS");
        });

        modelBuilder.Entity<Designation>(entity =>
        {
            entity.HasKey(e => e.DesignationCode);

            entity.ToTable("DESIGNATION");

            entity.Property(e => e.DesignationCode)
                .ValueGeneratedNever()
                .HasColumnName("DESIGNATION_CODE");
            entity.Property(e => e.Category)
                .HasMaxLength(50)
                .HasColumnName("CATEGORY");
            entity.Property(e => e.DesignationDesc).HasColumnName("DESIGNATION_DESC");
            entity.Property(e => e.DesignationEnteredby)
                .HasMaxLength(50)
                .HasColumnName("DESIGNATION_ENTEREDBY");
            entity.Property(e => e.DesignationEntrydate)
                .HasColumnType("datetime")
                .HasColumnName("DESIGNATION_ENTRYDATE");
            entity.Property(e => e.DesignationLastupdatedby)
                .HasMaxLength(50)
                .HasColumnName("DESIGNATION_LASTUPDATEDBY");
            entity.Property(e => e.DesignationLastupdatedon)
                .HasColumnType("datetime")
                .HasColumnName("DESIGNATION_LASTUPDATEDON");
            entity.Property(e => e.DesignationName)
                .HasMaxLength(256)
                .HasColumnName("DESIGNATION_NAME");
            entity.Property(e => e.DesignationStatus).HasColumnName("DESIGNATION_STATUS");
        });

        modelBuilder.Entity<DisableStaffRequest>(entity =>
        {
            entity.HasKey(e => e.RequestId);

            entity.ToTable("DISABLE_STAFF_REQUEST");

            entity.Property(e => e.RequestId)
                .ValueGeneratedNever()
                .HasColumnName("REQUEST_ID");
            entity.Property(e => e.ApproveDate)
                .HasColumnType("datetime")
                .HasColumnName("APPROVE_DATE");
            entity.Property(e => e.ApprovedBy)
                .HasMaxLength(50)
                .HasColumnName("APPROVED_BY");
            entity.Property(e => e.Currentuser)
                .HasMaxLength(50)
                .HasColumnName("CURRENTUSER");
            entity.Property(e => e.DisableReason).HasColumnName("DISABLE_REASON");
            entity.Property(e => e.EmpId)
                .HasMaxLength(50)
                .HasColumnName("EMP_ID");
            entity.Property(e => e.RejectDate)
                .HasColumnType("datetime")
                .HasColumnName("REJECT_DATE");
            entity.Property(e => e.RejectedBy)
                .HasMaxLength(50)
                .HasColumnName("REJECTED_BY");
            entity.Property(e => e.RequestBy)
                .HasMaxLength(50)
                .HasColumnName("REQUEST_BY");
            entity.Property(e => e.RequestDate)
                .HasColumnType("datetime")
                .HasColumnName("REQUEST_DATE");
            entity.Property(e => e.RequestStatus).HasColumnName("REQUEST_STATUS");
        });

        modelBuilder.Entity<EmpApproval>(entity =>
        {
            entity.HasKey(e => e.EmpId);

            entity.ToTable("EMP_APPROVAL");

            entity.Property(e => e.EmpId)
                .HasMaxLength(50)
                .HasColumnName("EMP_ID");
            entity.Property(e => e.ApprovedBy)
                .HasMaxLength(50)
                .HasColumnName("APPROVED_BY");
            entity.Property(e => e.ApprovedDate)
                .HasColumnType("datetime")
                .HasColumnName("APPROVED_DATE");
            entity.Property(e => e.RejectDate)
                .HasColumnType("datetime")
                .HasColumnName("REJECT_DATE");
            entity.Property(e => e.RejectReason).HasColumnName("REJECT_REASON");
            entity.Property(e => e.RejectedBy)
                .HasMaxLength(50)
                .HasColumnName("REJECTED_BY");
        });

        modelBuilder.Entity<EmpDataChange>(entity =>
        {
            entity.HasKey(e => e.ChangeId);

            entity.ToTable("EMP_DATA_CHANGE");

            entity.Property(e => e.ChangeId)
                .ValueGeneratedNever()
                .HasColumnName("CHANGE_ID");
            entity.Property(e => e.ApprovedBy)
                .HasMaxLength(50)
                .HasColumnName("APPROVED_BY");
            entity.Property(e => e.ApprovedDate)
                .HasColumnType("datetime")
                .HasColumnName("APPROVED_DATE");
            entity.Property(e => e.ChangeStatus).HasColumnName("CHANGE_STATUS");
            entity.Property(e => e.CurrentUsr)
                .HasMaxLength(50)
                .HasColumnName("CURRENT_USR");
            entity.Property(e => e.EmpAccount)
                .HasMaxLength(50)
                .HasColumnName("EMP_ACCOUNT");
            entity.Property(e => e.EmpCategory)
                .HasMaxLength(50)
                .HasColumnName("EMP_CATEGORY");
            entity.Property(e => e.EmpCity).HasColumnName("EMP_CITY");
            entity.Property(e => e.EmpCompanyname)
                .HasMaxLength(200)
                .IsFixedLength()
                .HasColumnName("EMP_COMPANYNAME");
            entity.Property(e => e.EmpConfirmdate)
                .HasColumnType("date")
                .HasColumnName("EMP_CONFIRMDATE");
            entity.Property(e => e.EmpCv).HasColumnName("EMP_CV");
            entity.Property(e => e.EmpDatejoined)
                .HasColumnType("date")
                .HasColumnName("EMP_DATEJOINED");
            entity.Property(e => e.EmpDept).HasColumnName("EMP_DEPT");
            entity.Property(e => e.EmpDesignation).HasColumnName("EMP_DESIGNATION");
            entity.Property(e => e.EmpDob)
                .HasColumnType("date")
                .HasColumnName("EMP_DOB");
            entity.Property(e => e.EmpEmail)
                .HasMaxLength(50)
                .HasColumnName("EMP_EMAIL");
            entity.Property(e => e.EmpFirstname)
                .HasMaxLength(50)
                .HasColumnName("EMP_FIRSTNAME");
            entity.Property(e => e.EmpFunctionalmgr)
                .HasMaxLength(10)
                .HasColumnName("EMP_FUNCTIONALMGR");
            entity.Property(e => e.EmpGender)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("EMP_GENDER");
            entity.Property(e => e.EmpGrade).HasColumnName("EMP_GRADE");
            entity.Property(e => e.EmpId)
                .HasMaxLength(50)
                .HasColumnName("EMP_ID");
            entity.Property(e => e.EmpIsconfirmed).HasColumnName("EMP_ISCONFIRMED");
            entity.Property(e => e.EmpLeavingdate)
                .HasColumnType("date")
                .HasColumnName("EMP_LEAVINGDATE");
            entity.Property(e => e.EmpLegalname)
                .HasMaxLength(200)
                .IsFixedLength()
                .HasColumnName("EMP_LEGALNAME");
            entity.Property(e => e.EmpLocation).HasColumnName("EMP_LOCATION");
            entity.Property(e => e.EmpNationality).HasColumnName("EMP_NATIONALITY");
            entity.Property(e => e.EmpOfficeaddress)
                .HasMaxLength(50)
                .HasColumnName("EMP_OFFICEADDRESS");
            entity.Property(e => e.EmpOfficeext)
                .HasMaxLength(50)
                .HasColumnName("EMP_OFFICEEXT");
            entity.Property(e => e.EmpOfficefax)
                .HasMaxLength(50)
                .HasColumnName("EMP_OFFICEFAX");
            entity.Property(e => e.EmpOfficemail)
                .HasMaxLength(50)
                .HasColumnName("EMP_OFFICEMAIL");
            entity.Property(e => e.EmpOfficephone)
                .HasMaxLength(15)
                .HasColumnName("EMP_OFFICEPHONE");
            entity.Property(e => e.EmpOthernames)
                .HasMaxLength(100)
                .HasColumnName("EMP_OTHERNAMES");
            entity.Property(e => e.EmpOu).HasColumnName("EMP_OU");
            entity.Property(e => e.EmpPaygroup).HasColumnName("EMP_PAYGROUP");
            entity.Property(e => e.EmpPaylocation)
                .HasMaxLength(50)
                .HasColumnName("EMP_PAYLOCATION");
            entity.Property(e => e.EmpPaymode)
                .HasMaxLength(50)
                .HasColumnName("EMP_PAYMODE");
            entity.Property(e => e.EmpPhone)
                .HasMaxLength(50)
                .HasColumnName("EMP_PHONE");
            entity.Property(e => e.EmpPhoto).HasColumnName("EMP_PHOTO");
            entity.Property(e => e.EmpPosition).HasColumnName("EMP_POSITION");
            entity.Property(e => e.EmpPostaladdress)
                .HasMaxLength(256)
                .HasColumnName("EMP_POSTALADDRESS");
            entity.Property(e => e.EmpRecruiter).HasColumnName("EMP_RECRUITER");
            entity.Property(e => e.EmpReference1Address)
                .HasMaxLength(50)
                .HasColumnName("EMP_REFERENCE1_ADDRESS");
            entity.Property(e => e.EmpReference1Name).HasColumnName("EMP_REFERENCE1_NAME");
            entity.Property(e => e.EmpReference1Phone)
                .HasMaxLength(50)
                .HasColumnName("EMP_REFERENCE1_PHONE");
            entity.Property(e => e.EmpReference2Address).HasColumnName("EMP_REFERENCE2_ADDRESS");
            entity.Property(e => e.EmpReference2Name)
                .HasMaxLength(50)
                .HasColumnName("EMP_REFERENCE2_NAME");
            entity.Property(e => e.EmpReference2Phone)
                .HasMaxLength(50)
                .HasColumnName("EMP_REFERENCE2_PHONE");
            entity.Property(e => e.EmpReference3Address).HasColumnName("EMP_REFERENCE3_ADDRESS");
            entity.Property(e => e.EmpReference3Name)
                .HasMaxLength(50)
                .HasColumnName("EMP_REFERENCE3_NAME");
            entity.Property(e => e.EmpReference3Phone)
                .HasMaxLength(50)
                .HasColumnName("EMP_REFERENCE3_PHONE");
            entity.Property(e => e.EmpRegion).HasColumnName("EMP_REGION");
            entity.Property(e => e.EmpResidentialaddress)
                .HasMaxLength(50)
                .HasColumnName("EMP_RESIDENTIALADDRESS");
            entity.Property(e => e.EmpSalutation)
                .HasMaxLength(5)
                .HasColumnName("EMP_SALUTATION");
            entity.Property(e => e.EmpSsn)
                .HasMaxLength(50)
                .HasColumnName("EMP_SSN");
            entity.Property(e => e.EmpSupervisor)
                .HasMaxLength(10)
                .HasColumnName("EMP_SUPERVISOR");
            entity.Property(e => e.EmpSurname)
                .HasMaxLength(50)
                .HasColumnName("EMP_SURNAME");
            entity.Property(e => e.EmpTin)
                .HasMaxLength(50)
                .HasColumnName("EMP_TIN");
            entity.Property(e => e.EmpType)
                .HasMaxLength(50)
                .HasColumnName("EMP_TYPE");
            entity.Property(e => e.Requestdate)
                .HasColumnType("datetime")
                .HasColumnName("REQUESTDATE");
            entity.Property(e => e.VerifiedBy)
                .HasMaxLength(50)
                .HasColumnName("VERIFIED_BY");
            entity.Property(e => e.VerifiedDate)
                .HasColumnType("datetime")
                .HasColumnName("VERIFIED_DATE");
        });

        modelBuilder.Entity<EmpShadow>(entity =>
        {
            entity.HasKey(e => e.EmpId);

            entity.ToTable("EMP_SHADOW");

            entity.Property(e => e.EmpId)
                .HasMaxLength(50)
                .HasColumnName("EMP_ID");
            entity.Property(e => e.ApprovedBy)
                .HasMaxLength(50)
                .HasColumnName("APPROVED_BY");
            entity.Property(e => e.ApprovedDate)
                .HasColumnType("datetime")
                .HasColumnName("APPROVED_DATE");
            entity.Property(e => e.CreateStatus).HasColumnName("CREATE_STATUS");
            entity.Property(e => e.CurrentUsr)
                .HasMaxLength(50)
                .HasColumnName("CURRENT_USR");
            entity.Property(e => e.EmpAccount)
                .HasMaxLength(50)
                .HasColumnName("EMP_ACCOUNT");
            entity.Property(e => e.EmpBenefitoption)
                .HasMaxLength(100)
                .HasColumnName("EMP_BENEFITOPTION");
            entity.Property(e => e.EmpBirthcountry).HasColumnName("EMP_BIRTHCOUNTRY");
            entity.Property(e => e.EmpCategory)
                .HasMaxLength(20)
                .HasColumnName("EMP_CATEGORY");
            entity.Property(e => e.EmpCity).HasColumnName("EMP_CITY");
            entity.Property(e => e.EmpCompanyname)
                .HasMaxLength(200)
                .HasColumnName("EMP_COMPANYNAME");
            entity.Property(e => e.EmpConfirmdate)
                .HasColumnType("date")
                .HasColumnName("EMP_CONFIRMDATE");
            entity.Property(e => e.EmpCv).HasColumnName("EMP_CV");
            entity.Property(e => e.EmpDatejoined)
                .HasColumnType("date")
                .HasColumnName("EMP_DATEJOINED");
            entity.Property(e => e.EmpDept).HasColumnName("EMP_DEPT");
            entity.Property(e => e.EmpDesignation).HasColumnName("EMP_DESIGNATION");
            entity.Property(e => e.EmpDivisionalhead)
                .HasMaxLength(50)
                .HasColumnName("EMP_DIVISIONALHEAD");
            entity.Property(e => e.EmpDob)
                .HasColumnType("date")
                .HasColumnName("EMP_DOB");
            entity.Property(e => e.EmpEmail)
                .HasMaxLength(50)
                .HasColumnName("EMP_EMAIL");
            entity.Property(e => e.EmpEnteredby)
                .HasMaxLength(50)
                .HasColumnName("EMP_ENTEREDBY");
            entity.Property(e => e.EmpEntrydate)
                .HasColumnType("datetime")
                .HasColumnName("EMP_ENTRYDATE");
            entity.Property(e => e.EmpFirstname)
                .HasMaxLength(50)
                .HasColumnName("EMP_FIRSTNAME");
            entity.Property(e => e.EmpFunctionalmgr)
                .HasMaxLength(50)
                .HasColumnName("EMP_FUNCTIONALMGR");
            entity.Property(e => e.EmpGender)
                .HasMaxLength(10)
                .HasColumnName("EMP_GENDER");
            entity.Property(e => e.EmpGrade).HasColumnName("EMP_GRADE");
            entity.Property(e => e.EmpHealthinsurancenumber)
                .HasMaxLength(50)
                .HasColumnName("EMP_HEALTHINSURANCENUMBER");
            entity.Property(e => e.EmpIsconfirmed)
                .HasMaxLength(50)
                .HasColumnName("EMP_ISCONFIRMED");
            entity.Property(e => e.EmpLastupdatedby)
                .HasMaxLength(50)
                .HasColumnName("EMP_LASTUPDATEDBY");
            entity.Property(e => e.EmpLastupdatedon)
                .HasColumnType("datetime")
                .HasColumnName("EMP_LASTUPDATEDON");
            entity.Property(e => e.EmpLeavingdate)
                .HasColumnType("date")
                .HasColumnName("EMP_LEAVINGDATE");
            entity.Property(e => e.EmpLegalname)
                .HasMaxLength(200)
                .HasColumnName("EMP_LEGALNAME");
            entity.Property(e => e.EmpLocation).HasColumnName("EMP_LOCATION");
            entity.Property(e => e.EmpNationality).HasColumnName("EMP_NATIONALITY");
            entity.Property(e => e.EmpOfficeaddress)
                .HasMaxLength(100)
                .HasColumnName("EMP_OFFICEADDRESS");
            entity.Property(e => e.EmpOfficeext)
                .HasMaxLength(50)
                .HasColumnName("EMP_OFFICEEXT");
            entity.Property(e => e.EmpOfficefax)
                .HasMaxLength(50)
                .HasColumnName("EMP_OFFICEFAX");
            entity.Property(e => e.EmpOfficemail)
                .HasMaxLength(50)
                .HasColumnName("EMP_OFFICEMAIL");
            entity.Property(e => e.EmpOfficephone)
                .HasMaxLength(50)
                .HasColumnName("EMP_OFFICEPHONE");
            entity.Property(e => e.EmpOthernames)
                .HasMaxLength(100)
                .HasColumnName("EMP_OTHERNAMES");
            entity.Property(e => e.EmpOu).HasColumnName("EMP_OU");
            entity.Property(e => e.EmpPaygroup).HasColumnName("EMP_PAYGROUP");
            entity.Property(e => e.EmpPaylocation)
                .HasMaxLength(50)
                .HasColumnName("EMP_PAYLOCATION");
            entity.Property(e => e.EmpPaymode)
                .HasMaxLength(50)
                .HasColumnName("EMP_PAYMODE");
            entity.Property(e => e.EmpPhone)
                .HasMaxLength(50)
                .HasColumnName("EMP_PHONE");
            entity.Property(e => e.EmpPhoto).HasColumnName("EMP_PHOTO");
            entity.Property(e => e.EmpPosition).HasColumnName("EMP_POSITION");
            entity.Property(e => e.EmpPostaladdress)
                .HasMaxLength(256)
                .HasColumnName("EMP_POSTALADDRESS");
            entity.Property(e => e.EmpRecruiter)
                .HasMaxLength(100)
                .HasColumnName("EMP_RECRUITER");
            entity.Property(e => e.EmpReference1Address).HasColumnName("EMP_REFERENCE1_ADDRESS");
            entity.Property(e => e.EmpReference1Name)
                .HasMaxLength(200)
                .HasColumnName("EMP_REFERENCE1_NAME");
            entity.Property(e => e.EmpReference1Phone)
                .HasMaxLength(50)
                .HasColumnName("EMP_REFERENCE1_PHONE");
            entity.Property(e => e.EmpReference2Address).HasColumnName("EMP_REFERENCE2_ADDRESS");
            entity.Property(e => e.EmpReference2Name)
                .HasMaxLength(200)
                .HasColumnName("EMP_REFERENCE2_NAME");
            entity.Property(e => e.EmpReference2Phone)
                .HasMaxLength(50)
                .HasColumnName("EMP_REFERENCE2_PHONE");
            entity.Property(e => e.EmpReference3Address).HasColumnName("EMP_REFERENCE3_ADDRESS");
            entity.Property(e => e.EmpReference3Name)
                .HasMaxLength(200)
                .HasColumnName("EMP_REFERENCE3_NAME");
            entity.Property(e => e.EmpReference3Phone)
                .HasMaxLength(50)
                .HasColumnName("EMP_REFERENCE3_PHONE");
            entity.Property(e => e.EmpRegion).HasColumnName("EMP_REGION");
            entity.Property(e => e.EmpResidentialaddress)
                .HasMaxLength(100)
                .HasColumnName("EMP_RESIDENTIALADDRESS");
            entity.Property(e => e.EmpSalutation)
                .HasMaxLength(10)
                .HasColumnName("EMP_SALUTATION");
            entity.Property(e => e.EmpSsn)
                .HasMaxLength(50)
                .HasColumnName("EMP_SSN");
            entity.Property(e => e.EmpStatus).HasColumnName("EMP_STATUS");
            entity.Property(e => e.EmpSupervisor)
                .HasMaxLength(50)
                .HasColumnName("EMP_SUPERVISOR");
            entity.Property(e => e.EmpSurname)
                .HasMaxLength(50)
                .HasColumnName("EMP_SURNAME");
            entity.Property(e => e.EmpTin)
                .HasMaxLength(50)
                .HasColumnName("EMP_TIN");
            entity.Property(e => e.EmpType)
                .HasMaxLength(20)
                .HasColumnName("EMP_TYPE");
            entity.Property(e => e.FdCertificate).HasColumnName("FD_CERTIFICATE");
            entity.Property(e => e.FdDateobtained)
                .HasColumnType("date")
                .HasColumnName("FD_DATEOBTAINED");
            entity.Property(e => e.FdInstitution)
                .HasMaxLength(200)
                .HasColumnName("FD_INSTITUTION");
            entity.Property(e => e.FdQualification)
                .HasMaxLength(200)
                .HasColumnName("FD_QUALIFICATION");
            entity.Property(e => e.P1Certificate).HasColumnName("P1_CERTIFICATE");
            entity.Property(e => e.P1Dateobtained)
                .HasColumnType("date")
                .HasColumnName("P1_DATEOBTAINED");
            entity.Property(e => e.P1Institution)
                .HasMaxLength(200)
                .HasColumnName("P1_INSTITUTION");
            entity.Property(e => e.P1Qualification)
                .HasMaxLength(200)
                .HasColumnName("P1_QUALIFICATION");
            entity.Property(e => e.P2Certificate).HasColumnName("P2_CERTIFICATE");
            entity.Property(e => e.P2Dateobtained)
                .HasColumnType("date")
                .HasColumnName("P2_DATEOBTAINED");
            entity.Property(e => e.P2Institution)
                .HasMaxLength(200)
                .HasColumnName("P2_INSTITUTION");
            entity.Property(e => e.P2Qualification)
                .HasMaxLength(200)
                .HasColumnName("P2_QUALIFICATION");
            entity.Property(e => e.P3Certificate).HasColumnName("P3_CERTIFICATE");
            entity.Property(e => e.P3Dateobtained)
                .HasColumnType("date")
                .HasColumnName("P3_DATEOBTAINED");
            entity.Property(e => e.P3Institution)
                .HasMaxLength(200)
                .HasColumnName("P3_INSTITUTION");
            entity.Property(e => e.P3Qualification)
                .HasMaxLength(200)
                .HasColumnName("P3_QUALIFICATION");
            entity.Property(e => e.P4Certificate).HasColumnName("P4_CERTIFICATE");
            entity.Property(e => e.P4Dateobtained)
                .HasColumnType("date")
                .HasColumnName("P4_DATEOBTAINED");
            entity.Property(e => e.P4Institution)
                .HasMaxLength(200)
                .HasColumnName("P4_INSTITUTION");
            entity.Property(e => e.P4Qualification)
                .HasMaxLength(200)
                .HasColumnName("P4_QUALIFICATION");
            entity.Property(e => e.P5Certificate).HasColumnName("P5_CERTIFICATE");
            entity.Property(e => e.P5Dateobtained)
                .HasColumnType("date")
                .HasColumnName("P5_DATEOBTAINED");
            entity.Property(e => e.P5Institution)
                .HasMaxLength(200)
                .HasColumnName("P5_INSTITUTION");
            entity.Property(e => e.P5Qualification)
                .HasMaxLength(200)
                .HasColumnName("P5_QUALIFICATION");
            entity.Property(e => e.RejectDate)
                .HasColumnType("datetime")
                .HasColumnName("REJECT_DATE");
            entity.Property(e => e.RejectReason).HasColumnName("REJECT_REASON");
            entity.Property(e => e.RejectedBy)
                .HasMaxLength(50)
                .HasColumnName("REJECTED_BY");
            entity.Property(e => e.Requestdate)
                .HasColumnType("datetime")
                .HasColumnName("REQUESTDATE");
            entity.Property(e => e.SdCertificate).HasColumnName("SD_CERTIFICATE");
            entity.Property(e => e.SdDateobtained)
                .HasColumnType("date")
                .HasColumnName("SD_DATEOBTAINED");
            entity.Property(e => e.SdInstitution)
                .HasMaxLength(200)
                .HasColumnName("SD_INSTITUTION");
            entity.Property(e => e.SdQualification)
                .HasMaxLength(200)
                .HasColumnName("SD_QUALIFICATION");
        });

        modelBuilder.Entity<EmpTimeline>(entity =>
        {
            entity.HasKey(e => e.Tid);

            entity.ToTable("EMP_TIMELINE");

            entity.Property(e => e.Tid)
                .ValueGeneratedNever()
                .HasColumnName("TID");
            entity.Property(e => e.EmpAction).HasColumnName("EMP_ACTION");
            entity.Property(e => e.EmpFrom).HasColumnName("EMP_FROM");
            entity.Property(e => e.EmpId)
                .HasMaxLength(50)
                .HasColumnName("EMP_ID");
            entity.Property(e => e.EmpTo).HasColumnName("EMP_TO");
            entity.Property(e => e.Enteredby)
                .HasMaxLength(50)
                .HasColumnName("ENTEREDBY");
            entity.Property(e => e.Entrydate)
                .HasColumnType("datetime")
                .HasColumnName("ENTRYDATE");
            entity.Property(e => e.Lastupdatedby)
                .HasMaxLength(50)
                .HasColumnName("LASTUPDATEDBY");
            entity.Property(e => e.Lastupdatedon)
                .HasColumnType("datetime")
                .HasColumnName("LASTUPDATEDON");
            entity.Property(e => e.Status).HasColumnName("STATUS");
        });

        modelBuilder.Entity<EmpTraining>(entity =>
        {
            entity.HasKey(e => e.Tid);

            entity.ToTable("EMP_TRAINING");

            entity.Property(e => e.Tid)
                .ValueGeneratedNever()
                .HasColumnName("TID");
            entity.Property(e => e.Certificate).HasColumnName("CERTIFICATE");
            entity.Property(e => e.CourseName).HasColumnName("COURSE_NAME");
            entity.Property(e => e.DateAttended)
                .HasMaxLength(100)
                .HasColumnName("DATE_ATTENDED");
            entity.Property(e => e.EmpId)
                .HasMaxLength(50)
                .HasColumnName("EMP_ID");
            entity.Property(e => e.Enteredby)
                .HasMaxLength(50)
                .HasColumnName("ENTEREDBY");
            entity.Property(e => e.Entrydate)
                .HasColumnType("datetime")
                .HasColumnName("ENTRYDATE");
            entity.Property(e => e.HasCertificate).HasColumnName("HAS_CERTIFICATE");
            entity.Property(e => e.Lastupdatedby)
                .HasMaxLength(50)
                .HasColumnName("LASTUPDATEDBY");
            entity.Property(e => e.Lastupdatedon)
                .HasColumnType("datetime")
                .HasColumnName("LASTUPDATEDON");
            entity.Property(e => e.Status).HasColumnName("STATUS");
        });

        modelBuilder.Entity<EmpTrainingShadow>(entity =>
        {
            entity.HasKey(e => e.Tid);

            entity.ToTable("EMP_TRAINING_SHADOW");

            entity.Property(e => e.Tid)
                .ValueGeneratedNever()
                .HasColumnName("TID");
            entity.Property(e => e.ApprovedBy)
                .HasMaxLength(50)
                .HasColumnName("APPROVED_BY");
            entity.Property(e => e.ApprovedDate)
                .HasColumnType("datetime")
                .HasColumnName("APPROVED_DATE");
            entity.Property(e => e.Certificate).HasColumnName("CERTIFICATE");
            entity.Property(e => e.CourseName).HasColumnName("COURSE_NAME");
            entity.Property(e => e.CurrentUsr)
                .HasMaxLength(50)
                .HasColumnName("CURRENT_USR");
            entity.Property(e => e.DateAttended)
                .HasMaxLength(100)
                .HasColumnName("DATE_ATTENDED");
            entity.Property(e => e.EmpId)
                .HasMaxLength(50)
                .HasColumnName("EMP_ID");
            entity.Property(e => e.Enteredby)
                .HasMaxLength(50)
                .HasColumnName("ENTEREDBY");
            entity.Property(e => e.Entrydate)
                .HasColumnType("datetime")
                .HasColumnName("ENTRYDATE");
            entity.Property(e => e.HasCertificate).HasColumnName("HAS_CERTIFICATE");
            entity.Property(e => e.Lastupdatedby)
                .HasMaxLength(50)
                .HasColumnName("LASTUPDATEDBY");
            entity.Property(e => e.Lastupdatedon)
                .HasColumnType("datetime")
                .HasColumnName("LASTUPDATEDON");
            entity.Property(e => e.RejectReason).HasColumnName("REJECT_REASON");
            entity.Property(e => e.RejectedBy)
                .HasMaxLength(50)
                .HasColumnName("REJECTED_BY");
            entity.Property(e => e.RejectedDate)
                .HasColumnType("datetime")
                .HasColumnName("REJECTED_DATE");
            entity.Property(e => e.Requestdate)
                .HasColumnType("datetime")
                .HasColumnName("REQUESTDATE");
            entity.Property(e => e.Status).HasColumnName("STATUS");
            entity.Property(e => e.VerifiedBy)
                .HasMaxLength(50)
                .HasColumnName("VERIFIED_BY");
            entity.Property(e => e.VerifiedDate)
                .HasColumnType("datetime")
                .HasColumnName("VERIFIED_DATE");
        });

        modelBuilder.Entity<Employee>(entity =>
        {
            entity.HasKey(e => e.EmpId);

            entity.ToTable("EMPLOYEE");

            entity.Property(e => e.EmpId)
                .HasMaxLength(50)
                .HasColumnName("EMP_ID");
            entity.Property(e => e.ActingStartDate).HasColumnType("datetime");
            entity.Property(e => e.EmpAccount)
                .HasMaxLength(50)
                .HasColumnName("EMP_ACCOUNT");
            entity.Property(e => e.EmpBenefitoption)
                .HasMaxLength(100)
                .HasColumnName("EMP_BENEFITOPTION");
            entity.Property(e => e.EmpBirthcountry).HasColumnName("EMP_BIRTHCOUNTRY");
            entity.Property(e => e.EmpCategory)
                .HasMaxLength(20)
                .HasColumnName("EMP_CATEGORY");
            entity.Property(e => e.EmpCity).HasColumnName("EMP_CITY");
            entity.Property(e => e.EmpCompanyname)
                .HasMaxLength(200)
                .HasColumnName("EMP_COMPANYNAME");
            entity.Property(e => e.EmpConfirmdate)
                .HasColumnType("date")
                .HasColumnName("EMP_CONFIRMDATE");
            entity.Property(e => e.EmpCv).HasColumnName("EMP_CV");
            entity.Property(e => e.EmpCvContenttype)
                .HasMaxLength(256)
                .HasColumnName("EMP_CV_CONTENTTYPE");
            entity.Property(e => e.EmpCvName)
                .HasMaxLength(256)
                .HasColumnName("EMP_CV_NAME");
            entity.Property(e => e.EmpDatejoined)
                .HasColumnType("date")
                .HasColumnName("EMP_DATEJOINED");
            entity.Property(e => e.EmpDept).HasColumnName("EMP_DEPT");
            entity.Property(e => e.EmpDesignation).HasColumnName("EMP_DESIGNATION");
            entity.Property(e => e.EmpDivisionalhead)
                .HasMaxLength(50)
                .HasColumnName("EMP_DIVISIONALHEAD");
            entity.Property(e => e.EmpDob)
                .HasColumnType("date")
                .HasColumnName("EMP_DOB");
            entity.Property(e => e.EmpEmail)
                .HasMaxLength(50)
                .HasColumnName("EMP_EMAIL");
            entity.Property(e => e.EmpEnddate)
                .HasColumnType("date")
                .HasColumnName("EMP_ENDDATE");
            entity.Property(e => e.EmpEndletterdate)
                .HasColumnType("date")
                .HasColumnName("EMP_ENDLETTERDATE");
            entity.Property(e => e.EmpEnteredby)
                .HasMaxLength(50)
                .HasColumnName("EMP_ENTEREDBY");
            entity.Property(e => e.EmpEntrydate)
                .HasColumnType("datetime")
                .HasColumnName("EMP_ENTRYDATE");
            entity.Property(e => e.EmpFirstname)
                .HasMaxLength(50)
                .HasColumnName("EMP_FIRSTNAME");
            entity.Property(e => e.EmpFunctionalmgr)
                .HasMaxLength(50)
                .HasColumnName("EMP_FUNCTIONALMGR");
            entity.Property(e => e.EmpGender)
                .HasMaxLength(10)
                .HasColumnName("EMP_GENDER");
            entity.Property(e => e.EmpGrade).HasColumnName("EMP_GRADE");
            entity.Property(e => e.EmpHealthinsurancenumber)
                .HasMaxLength(50)
                .HasColumnName("EMP_HEALTHINSURANCENUMBER");
            entity.Property(e => e.EmpIsconfirmed)
                .HasMaxLength(50)
                .HasColumnName("EMP_ISCONFIRMED");
            entity.Property(e => e.EmpLastupdatedby)
                .HasMaxLength(50)
                .HasColumnName("EMP_LASTUPDATEDBY");
            entity.Property(e => e.EmpLastupdatedon)
                .HasColumnType("datetime")
                .HasColumnName("EMP_LASTUPDATEDON");
            entity.Property(e => e.EmpLeavingdate)
                .HasColumnType("date")
                .HasColumnName("EMP_LEAVINGDATE");
            entity.Property(e => e.EmpLegalname)
                .HasMaxLength(200)
                .HasColumnName("EMP_LEGALNAME");
            entity.Property(e => e.EmpLocation).HasColumnName("EMP_LOCATION");
            entity.Property(e => e.EmpNationality).HasColumnName("EMP_NATIONALITY");
            entity.Property(e => e.EmpOfficeaddress)
                .HasMaxLength(100)
                .HasColumnName("EMP_OFFICEADDRESS");
            entity.Property(e => e.EmpOfficeext)
                .HasMaxLength(50)
                .HasColumnName("EMP_OFFICEEXT");
            entity.Property(e => e.EmpOfficefax)
                .HasMaxLength(50)
                .HasColumnName("EMP_OFFICEFAX");
            entity.Property(e => e.EmpOfficemail)
                .HasMaxLength(50)
                .HasColumnName("EMP_OFFICEMAIL");
            entity.Property(e => e.EmpOfficephone)
                .HasMaxLength(50)
                .HasColumnName("EMP_OFFICEPHONE");
            entity.Property(e => e.EmpOthernames)
                .HasMaxLength(100)
                .HasColumnName("EMP_OTHERNAMES");
            entity.Property(e => e.EmpOu).HasColumnName("EMP_OU");
            entity.Property(e => e.EmpPaygroup).HasColumnName("EMP_PAYGROUP");
            entity.Property(e => e.EmpPaylocation)
                .HasMaxLength(50)
                .HasColumnName("EMP_PAYLOCATION");
            entity.Property(e => e.EmpPaymode)
                .HasMaxLength(50)
                .HasColumnName("EMP_PAYMODE");
            entity.Property(e => e.EmpPhone)
                .HasMaxLength(50)
                .HasColumnName("EMP_PHONE");
            entity.Property(e => e.EmpPhoto).HasColumnName("EMP_PHOTO");
            entity.Property(e => e.EmpPhotoContenttype)
                .HasMaxLength(256)
                .HasColumnName("EMP_PHOTO_CONTENTTYPE");
            entity.Property(e => e.EmpPhotoName)
                .HasMaxLength(256)
                .HasColumnName("EMP_PHOTO_NAME");
            entity.Property(e => e.EmpPosition).HasColumnName("EMP_POSITION");
            entity.Property(e => e.EmpPostaladdress)
                .HasMaxLength(100)
                .HasColumnName("EMP_POSTALADDRESS");
            entity.Property(e => e.EmpRecruiter)
                .HasMaxLength(100)
                .HasColumnName("EMP_RECRUITER");
            entity.Property(e => e.EmpReference1Address).HasColumnName("EMP_REFERENCE1_ADDRESS");
            entity.Property(e => e.EmpReference1Name)
                .HasMaxLength(200)
                .HasColumnName("EMP_REFERENCE1_NAME");
            entity.Property(e => e.EmpReference1Phone)
                .HasMaxLength(50)
                .HasColumnName("EMP_REFERENCE1_PHONE");
            entity.Property(e => e.EmpReference2Address).HasColumnName("EMP_REFERENCE2_ADDRESS");
            entity.Property(e => e.EmpReference2Name)
                .HasMaxLength(200)
                .HasColumnName("EMP_REFERENCE2_NAME");
            entity.Property(e => e.EmpReference2Phone)
                .HasMaxLength(50)
                .HasColumnName("EMP_REFERENCE2_PHONE");
            entity.Property(e => e.EmpReference3Address).HasColumnName("EMP_REFERENCE3_ADDRESS");
            entity.Property(e => e.EmpReference3Name)
                .HasMaxLength(200)
                .HasColumnName("EMP_REFERENCE3_NAME");
            entity.Property(e => e.EmpReference3Phone)
                .HasMaxLength(50)
                .HasColumnName("EMP_REFERENCE3_PHONE");
            entity.Property(e => e.EmpRegion).HasColumnName("EMP_REGION");
            entity.Property(e => e.EmpResidentialaddress)
                .HasMaxLength(100)
                .HasColumnName("EMP_RESIDENTIALADDRESS");
            entity.Property(e => e.EmpSalutation)
                .HasMaxLength(10)
                .HasColumnName("EMP_SALUTATION");
            entity.Property(e => e.EmpSsn)
                .HasMaxLength(50)
                .HasColumnName("EMP_SSN");
            entity.Property(e => e.EmpStatus).HasColumnName("EMP_STATUS");
            entity.Property(e => e.EmpSupervisor)
                .HasMaxLength(50)
                .HasColumnName("EMP_SUPERVISOR");
            entity.Property(e => e.EmpSurname)
                .HasMaxLength(50)
                .HasColumnName("EMP_SURNAME");
            entity.Property(e => e.EmpTin)
                .HasMaxLength(50)
                .HasColumnName("EMP_TIN");
            entity.Property(e => e.EmpType)
                .HasMaxLength(20)
                .HasColumnName("EMP_TYPE");
            entity.Property(e => e.FdCertificate).HasColumnName("FD_CERTIFICATE");
            entity.Property(e => e.FdCertificateContenttype)
                .HasMaxLength(256)
                .HasColumnName("FD_CERTIFICATE_CONTENTTYPE");
            entity.Property(e => e.FdCertificateName)
                .HasMaxLength(256)
                .HasColumnName("FD_CERTIFICATE_NAME");
            entity.Property(e => e.FdDateobtained)
                .HasColumnType("date")
                .HasColumnName("FD_DATEOBTAINED");
            entity.Property(e => e.FdInstitution)
                .HasMaxLength(200)
                .HasColumnName("FD_INSTITUTION");
            entity.Property(e => e.FdQualification)
                .HasMaxLength(200)
                .HasColumnName("FD_QUALIFICATION");
            entity.Property(e => e.P1Certificate).HasColumnName("P1_CERTIFICATE");
            entity.Property(e => e.P1CertificateContenttype)
                .HasMaxLength(256)
                .HasColumnName("P1_CERTIFICATE_CONTENTTYPE");
            entity.Property(e => e.P1CertificateName)
                .HasMaxLength(256)
                .HasColumnName("P1_CERTIFICATE_NAME");
            entity.Property(e => e.P1Dateobtained)
                .HasColumnType("date")
                .HasColumnName("P1_DATEOBTAINED");
            entity.Property(e => e.P1Institution)
                .HasMaxLength(200)
                .HasColumnName("P1_INSTITUTION");
            entity.Property(e => e.P1Qualification)
                .HasMaxLength(200)
                .HasColumnName("P1_QUALIFICATION");
            entity.Property(e => e.P2Certificate).HasColumnName("P2_CERTIFICATE");
            entity.Property(e => e.P2CertificateContenttype)
                .HasMaxLength(256)
                .HasColumnName("P2_CERTIFICATE_CONTENTTYPE");
            entity.Property(e => e.P2CertificateName)
                .HasMaxLength(256)
                .HasColumnName("P2_CERTIFICATE_NAME");
            entity.Property(e => e.P2Dateobtained)
                .HasColumnType("date")
                .HasColumnName("P2_DATEOBTAINED");
            entity.Property(e => e.P2Institution)
                .HasMaxLength(200)
                .HasColumnName("P2_INSTITUTION");
            entity.Property(e => e.P2Qualification)
                .HasMaxLength(200)
                .HasColumnName("P2_QUALIFICATION");
            entity.Property(e => e.P3Certificate).HasColumnName("P3_CERTIFICATE");
            entity.Property(e => e.P3CertificateContenttype)
                .HasMaxLength(256)
                .HasColumnName("P3_CERTIFICATE_CONTENTTYPE");
            entity.Property(e => e.P3CertificateName)
                .HasMaxLength(256)
                .HasColumnName("P3_CERTIFICATE_NAME");
            entity.Property(e => e.P3Dateobtained)
                .HasColumnType("date")
                .HasColumnName("P3_DATEOBTAINED");
            entity.Property(e => e.P3Institution)
                .HasMaxLength(200)
                .HasColumnName("P3_INSTITUTION");
            entity.Property(e => e.P3Qualification)
                .HasMaxLength(200)
                .HasColumnName("P3_QUALIFICATION");
            entity.Property(e => e.P4Certificate).HasColumnName("P4_CERTIFICATE");
            entity.Property(e => e.P4CertificateContenttype)
                .HasMaxLength(256)
                .HasColumnName("P4_CERTIFICATE_CONTENTTYPE");
            entity.Property(e => e.P4CertificateName)
                .HasMaxLength(256)
                .HasColumnName("P4_CERTIFICATE_NAME");
            entity.Property(e => e.P4Dateobtained)
                .HasColumnType("date")
                .HasColumnName("P4_DATEOBTAINED");
            entity.Property(e => e.P4Institution)
                .HasMaxLength(200)
                .HasColumnName("P4_INSTITUTION");
            entity.Property(e => e.P4Qualification)
                .HasMaxLength(200)
                .HasColumnName("P4_QUALIFICATION");
            entity.Property(e => e.P5Certificate).HasColumnName("P5_CERTIFICATE");
            entity.Property(e => e.P5CertificateContenttype)
                .HasMaxLength(256)
                .HasColumnName("P5_CERTIFICATE_CONTENTTYPE");
            entity.Property(e => e.P5CertificateName)
                .HasMaxLength(256)
                .HasColumnName("P5_CERTIFICATE_NAME");
            entity.Property(e => e.P5Dateobtained)
                .HasColumnType("date")
                .HasColumnName("P5_DATEOBTAINED");
            entity.Property(e => e.P5Institution)
                .HasMaxLength(200)
                .HasColumnName("P5_INSTITUTION");
            entity.Property(e => e.P5Qualification)
                .HasMaxLength(200)
                .HasColumnName("P5_QUALIFICATION");
            entity.Property(e => e.SdCertificate).HasColumnName("SD_CERTIFICATE");
            entity.Property(e => e.SdCertificateContenttype)
                .HasMaxLength(256)
                .HasColumnName("SD_CERTIFICATE_CONTENTTYPE");
            entity.Property(e => e.SdCertificateName)
                .HasMaxLength(256)
                .HasColumnName("SD_CERTIFICATE_NAME");
            entity.Property(e => e.SdDateobtained)
                .HasColumnType("date")
                .HasColumnName("SD_DATEOBTAINED");
            entity.Property(e => e.SdInstitution)
                .HasMaxLength(200)
                .HasColumnName("SD_INSTITUTION");
            entity.Property(e => e.SdQualification)
                .HasMaxLength(200)
                .HasColumnName("SD_QUALIFICATION");

            entity.HasOne(d => d.EmpCityNavigation).WithMany(p => p.Employees)
                .HasForeignKey(d => d.EmpCity)
                .HasConstraintName("FK_EMPLOYEE_CITY");

            entity.HasOne(d => d.EmpDeptNavigation).WithMany(p => p.Employees)
                .HasForeignKey(d => d.EmpDept)
                .HasConstraintName("FK_EMPLOYEE_DEPARTMENT");

            entity.HasOne(d => d.EmpGradeNavigation).WithMany(p => p.Employees)
                .HasForeignKey(d => d.EmpGrade)
                .HasConstraintName("FK_EMPLOYEE_GRADE");

            entity.HasOne(d => d.EmpLocationNavigation).WithMany(p => p.Employees)
                .HasForeignKey(d => d.EmpLocation)
                .HasConstraintName("FK_EMPLOYEE_LOCATION");

            entity.HasOne(d => d.EmpNationalityNavigation).WithMany(p => p.Employees)
                .HasForeignKey(d => d.EmpNationality)
                .HasConstraintName("FK_EMPLOYEE_COUNTRIES");

            entity.HasOne(d => d.EmpOuNavigation).WithMany(p => p.Employees)
                .HasForeignKey(d => d.EmpOu)
                .HasConstraintName("FK_EMPLOYEE_OU");

            entity.HasOne(d => d.EmpPaygroupNavigation).WithMany(p => p.Employees)
                .HasForeignKey(d => d.EmpPaygroup)
                .HasConstraintName("FK_EMPLOYEE_PAYGROUP");

            entity.HasOne(d => d.EmpPositionNavigation).WithMany(p => p.Employees)
                .HasForeignKey(d => d.EmpPosition)
                .HasConstraintName("FK_EMPLOYEE_DESIGNATION");

            entity.HasOne(d => d.EmpRegionNavigation).WithMany(p => p.Employees)
                .HasForeignKey(d => d.EmpRegion)
                .HasConstraintName("FK_EMPLOYEE_REGION");
        });

        modelBuilder.Entity<EmployeeHrShadow>(entity =>
        {
            entity.HasKey(e => e.EmpId);

            entity.ToTable("EMPLOYEE_HR_SHADOW");

            entity.Property(e => e.EmpId)
                .HasMaxLength(50)
                .HasColumnName("EMP_ID");
            entity.Property(e => e.ActingStartDate).HasColumnType("datetime");
            entity.Property(e => e.ApprovedBy)
                .HasMaxLength(50)
                .HasColumnName("APPROVED_BY");
            entity.Property(e => e.ApprovedDate)
                .HasColumnType("datetime")
                .HasColumnName("APPROVED_DATE");
            entity.Property(e => e.CurrentUsr)
                .HasMaxLength(50)
                .HasColumnName("CURRENT_USR");
            entity.Property(e => e.EmpAccount)
                .HasMaxLength(50)
                .HasColumnName("EMP_ACCOUNT");
            entity.Property(e => e.EmpBenefitoption)
                .HasMaxLength(100)
                .HasColumnName("EMP_BENEFITOPTION");
            entity.Property(e => e.EmpBirthcountry).HasColumnName("EMP_BIRTHCOUNTRY");
            entity.Property(e => e.EmpCategory)
                .HasMaxLength(20)
                .HasColumnName("EMP_CATEGORY");
            entity.Property(e => e.EmpCity).HasColumnName("EMP_CITY");
            entity.Property(e => e.EmpCompanyname)
                .HasMaxLength(200)
                .HasColumnName("EMP_COMPANYNAME");
            entity.Property(e => e.EmpConfirmdate)
                .HasColumnType("date")
                .HasColumnName("EMP_CONFIRMDATE");
            entity.Property(e => e.EmpCv).HasColumnName("EMP_CV");
            entity.Property(e => e.EmpCvContenttype)
                .HasMaxLength(256)
                .HasColumnName("EMP_CV_CONTENTTYPE");
            entity.Property(e => e.EmpCvName)
                .HasMaxLength(256)
                .HasColumnName("EMP_CV_NAME");
            entity.Property(e => e.EmpDatejoined)
                .HasColumnType("date")
                .HasColumnName("EMP_DATEJOINED");
            entity.Property(e => e.EmpDept).HasColumnName("EMP_DEPT");
            entity.Property(e => e.EmpDesignation).HasColumnName("EMP_DESIGNATION");
            entity.Property(e => e.EmpDivisionalhead)
                .HasMaxLength(50)
                .HasColumnName("EMP_DIVISIONALHEAD");
            entity.Property(e => e.EmpDob)
                .HasColumnType("date")
                .HasColumnName("EMP_DOB");
            entity.Property(e => e.EmpEmail)
                .HasMaxLength(50)
                .HasColumnName("EMP_EMAIL");
            entity.Property(e => e.EmpEnddate)
                .HasColumnType("date")
                .HasColumnName("EMP_ENDDATE");
            entity.Property(e => e.EmpEndletterdate)
                .HasColumnType("date")
                .HasColumnName("EMP_ENDLETTERDATE");
            entity.Property(e => e.EmpFirstname)
                .HasMaxLength(50)
                .HasColumnName("EMP_FIRSTNAME");
            entity.Property(e => e.EmpFunctionalmgr)
                .HasMaxLength(50)
                .HasColumnName("EMP_FUNCTIONALMGR");
            entity.Property(e => e.EmpGender)
                .HasMaxLength(10)
                .HasColumnName("EMP_GENDER");
            entity.Property(e => e.EmpGrade).HasColumnName("EMP_GRADE");
            entity.Property(e => e.EmpHealthinsurancenumber)
                .HasMaxLength(50)
                .HasColumnName("EMP_HEALTHINSURANCENUMBER");
            entity.Property(e => e.EmpIsconfirmed)
                .HasMaxLength(50)
                .HasColumnName("EMP_ISCONFIRMED");
            entity.Property(e => e.EmpLeavingdate)
                .HasColumnType("date")
                .HasColumnName("EMP_LEAVINGDATE");
            entity.Property(e => e.EmpLegalname)
                .HasMaxLength(200)
                .HasColumnName("EMP_LEGALNAME");
            entity.Property(e => e.EmpLocation).HasColumnName("EMP_LOCATION");
            entity.Property(e => e.EmpNationality).HasColumnName("EMP_NATIONALITY");
            entity.Property(e => e.EmpOfficeaddress)
                .HasMaxLength(100)
                .HasColumnName("EMP_OFFICEADDRESS");
            entity.Property(e => e.EmpOfficeext)
                .HasMaxLength(50)
                .HasColumnName("EMP_OFFICEEXT");
            entity.Property(e => e.EmpOfficefax)
                .HasMaxLength(50)
                .HasColumnName("EMP_OFFICEFAX");
            entity.Property(e => e.EmpOfficemail)
                .HasMaxLength(50)
                .HasColumnName("EMP_OFFICEMAIL");
            entity.Property(e => e.EmpOfficephone)
                .HasMaxLength(50)
                .HasColumnName("EMP_OFFICEPHONE");
            entity.Property(e => e.EmpOthernames)
                .HasMaxLength(100)
                .HasColumnName("EMP_OTHERNAMES");
            entity.Property(e => e.EmpOu).HasColumnName("EMP_OU");
            entity.Property(e => e.EmpPaygroup).HasColumnName("EMP_PAYGROUP");
            entity.Property(e => e.EmpPaylocation)
                .HasMaxLength(50)
                .HasColumnName("EMP_PAYLOCATION");
            entity.Property(e => e.EmpPaymode)
                .HasMaxLength(50)
                .HasColumnName("EMP_PAYMODE");
            entity.Property(e => e.EmpPhone)
                .HasMaxLength(50)
                .HasColumnName("EMP_PHONE");
            entity.Property(e => e.EmpPhoto).HasColumnName("EMP_PHOTO");
            entity.Property(e => e.EmpPosition).HasColumnName("EMP_POSITION");
            entity.Property(e => e.EmpPostaladdress)
                .HasMaxLength(100)
                .HasColumnName("EMP_POSTALADDRESS");
            entity.Property(e => e.EmpRecruiter)
                .HasMaxLength(100)
                .HasColumnName("EMP_RECRUITER");
            entity.Property(e => e.EmpReference1Address).HasColumnName("EMP_REFERENCE1_ADDRESS");
            entity.Property(e => e.EmpReference1Name)
                .HasMaxLength(200)
                .HasColumnName("EMP_REFERENCE1_NAME");
            entity.Property(e => e.EmpReference1Phone)
                .HasMaxLength(50)
                .HasColumnName("EMP_REFERENCE1_PHONE");
            entity.Property(e => e.EmpReference2Address).HasColumnName("EMP_REFERENCE2_ADDRESS");
            entity.Property(e => e.EmpReference2Name)
                .HasMaxLength(200)
                .HasColumnName("EMP_REFERENCE2_NAME");
            entity.Property(e => e.EmpReference2Phone)
                .HasMaxLength(50)
                .HasColumnName("EMP_REFERENCE2_PHONE");
            entity.Property(e => e.EmpReference3Address).HasColumnName("EMP_REFERENCE3_ADDRESS");
            entity.Property(e => e.EmpReference3Name)
                .HasMaxLength(200)
                .HasColumnName("EMP_REFERENCE3_NAME");
            entity.Property(e => e.EmpReference3Phone)
                .HasMaxLength(50)
                .HasColumnName("EMP_REFERENCE3_PHONE");
            entity.Property(e => e.EmpRegion).HasColumnName("EMP_REGION");
            entity.Property(e => e.EmpResidentialaddress)
                .HasMaxLength(100)
                .HasColumnName("EMP_RESIDENTIALADDRESS");
            entity.Property(e => e.EmpSalutation)
                .HasMaxLength(10)
                .HasColumnName("EMP_SALUTATION");
            entity.Property(e => e.EmpSsn)
                .HasMaxLength(50)
                .HasColumnName("EMP_SSN");
            entity.Property(e => e.EmpStatus).HasColumnName("EMP_STATUS");
            entity.Property(e => e.EmpSupervisor)
                .HasMaxLength(50)
                .HasColumnName("EMP_SUPERVISOR");
            entity.Property(e => e.EmpSurname)
                .HasMaxLength(50)
                .HasColumnName("EMP_SURNAME");
            entity.Property(e => e.EmpTin)
                .HasMaxLength(50)
                .HasColumnName("EMP_TIN");
            entity.Property(e => e.EmpType)
                .HasMaxLength(20)
                .HasColumnName("EMP_TYPE");
            entity.Property(e => e.FdCertificate).HasColumnName("FD_CERTIFICATE");
            entity.Property(e => e.FdCertificateContenttype)
                .HasMaxLength(256)
                .HasColumnName("FD_CERTIFICATE_CONTENTTYPE");
            entity.Property(e => e.FdCertificateName)
                .HasMaxLength(256)
                .HasColumnName("FD_CERTIFICATE_NAME");
            entity.Property(e => e.FdDateobtained)
                .HasColumnType("date")
                .HasColumnName("FD_DATEOBTAINED");
            entity.Property(e => e.FdInstitution)
                .HasMaxLength(200)
                .HasColumnName("FD_INSTITUTION");
            entity.Property(e => e.FdQualification)
                .HasMaxLength(200)
                .HasColumnName("FD_QUALIFICATION");
            entity.Property(e => e.P1Certificate).HasColumnName("P1_CERTIFICATE");
            entity.Property(e => e.P1CertificateContenttype)
                .HasMaxLength(256)
                .HasColumnName("P1_CERTIFICATE_CONTENTTYPE");
            entity.Property(e => e.P1CertificateName)
                .HasMaxLength(256)
                .HasColumnName("P1_CERTIFICATE_NAME");
            entity.Property(e => e.P1Dateobtained)
                .HasColumnType("date")
                .HasColumnName("P1_DATEOBTAINED");
            entity.Property(e => e.P1Institution)
                .HasMaxLength(200)
                .HasColumnName("P1_INSTITUTION");
            entity.Property(e => e.P1Qualification)
                .HasMaxLength(200)
                .HasColumnName("P1_QUALIFICATION");
            entity.Property(e => e.P2Certificate).HasColumnName("P2_CERTIFICATE");
            entity.Property(e => e.P2CertificateContenttype)
                .HasMaxLength(256)
                .HasColumnName("P2_CERTIFICATE_CONTENTTYPE");
            entity.Property(e => e.P2CertificateName)
                .HasMaxLength(256)
                .HasColumnName("P2_CERTIFICATE_NAME");
            entity.Property(e => e.P2Dateobtained)
                .HasColumnType("date")
                .HasColumnName("P2_DATEOBTAINED");
            entity.Property(e => e.P2Institution)
                .HasMaxLength(200)
                .HasColumnName("P2_INSTITUTION");
            entity.Property(e => e.P2Qualification)
                .HasMaxLength(200)
                .HasColumnName("P2_QUALIFICATION");
            entity.Property(e => e.P3Certificate).HasColumnName("P3_CERTIFICATE");
            entity.Property(e => e.P3CertificateContenttype)
                .HasMaxLength(256)
                .HasColumnName("P3_CERTIFICATE_CONTENTTYPE");
            entity.Property(e => e.P3CertificateName)
                .HasMaxLength(256)
                .HasColumnName("P3_CERTIFICATE_NAME");
            entity.Property(e => e.P3Dateobtained)
                .HasColumnType("date")
                .HasColumnName("P3_DATEOBTAINED");
            entity.Property(e => e.P3Institution)
                .HasMaxLength(200)
                .HasColumnName("P3_INSTITUTION");
            entity.Property(e => e.P3Qualification)
                .HasMaxLength(200)
                .HasColumnName("P3_QUALIFICATION");
            entity.Property(e => e.P4Certificate).HasColumnName("P4_CERTIFICATE");
            entity.Property(e => e.P4CertificateContenttype)
                .HasMaxLength(256)
                .HasColumnName("P4_CERTIFICATE_CONTENTTYPE");
            entity.Property(e => e.P4CertificateName)
                .HasMaxLength(256)
                .HasColumnName("P4_CERTIFICATE_NAME");
            entity.Property(e => e.P4Dateobtained)
                .HasColumnType("date")
                .HasColumnName("P4_DATEOBTAINED");
            entity.Property(e => e.P4Institution)
                .HasMaxLength(200)
                .HasColumnName("P4_INSTITUTION");
            entity.Property(e => e.P4Qualification)
                .HasMaxLength(200)
                .HasColumnName("P4_QUALIFICATION");
            entity.Property(e => e.P5Certificate).HasColumnName("P5_CERTIFICATE");
            entity.Property(e => e.P5CertificateContenttype)
                .HasMaxLength(256)
                .HasColumnName("P5_CERTIFICATE_CONTENTTYPE");
            entity.Property(e => e.P5CertificateName)
                .HasMaxLength(256)
                .HasColumnName("P5_CERTIFICATE_NAME");
            entity.Property(e => e.P5Dateobtained)
                .HasColumnType("date")
                .HasColumnName("P5_DATEOBTAINED");
            entity.Property(e => e.P5Institution)
                .HasMaxLength(200)
                .HasColumnName("P5_INSTITUTION");
            entity.Property(e => e.P5Qualification)
                .HasMaxLength(200)
                .HasColumnName("P5_QUALIFICATION");
            entity.Property(e => e.RejectReason)
                .HasMaxLength(255)
                .HasColumnName("REJECT_REASON");
            entity.Property(e => e.RejectedBy)
                .HasMaxLength(50)
                .HasColumnName("REJECTED_BY");
            entity.Property(e => e.RejectedDate)
                .HasColumnType("datetime")
                .HasColumnName("REJECTED_DATE");
            entity.Property(e => e.Requestdate)
                .HasColumnType("datetime")
                .HasColumnName("REQUESTDATE");
            entity.Property(e => e.SdCertificate).HasColumnName("SD_CERTIFICATE");
            entity.Property(e => e.SdCertificateContenttype)
                .HasMaxLength(256)
                .HasColumnName("SD_CERTIFICATE_CONTENTTYPE");
            entity.Property(e => e.SdCertificateName)
                .HasMaxLength(256)
                .HasColumnName("SD_CERTIFICATE_NAME");
            entity.Property(e => e.SdDateobtained)
                .HasColumnType("date")
                .HasColumnName("SD_DATEOBTAINED");
            entity.Property(e => e.SdInstitution)
                .HasMaxLength(200)
                .HasColumnName("SD_INSTITUTION");
            entity.Property(e => e.SdQualification)
                .HasMaxLength(200)
                .HasColumnName("SD_QUALIFICATION");
            entity.Property(e => e.VerifiedBy)
                .HasMaxLength(50)
                .HasColumnName("VERIFIED_BY");
            entity.Property(e => e.VerifiedDate)
                .HasColumnType("datetime")
                .HasColumnName("VERIFIED_DATE");

            entity.HasOne(d => d.EmpBirthcountryNavigation).WithMany(p => p.EmployeeHrShadowEmpBirthcountryNavigations)
                .HasForeignKey(d => d.EmpBirthcountry)
                .HasConstraintName("FK_EMPLOYEE_SHADOW_COUNTRIES_HR");

            entity.HasOne(d => d.EmpCityNavigation).WithMany(p => p.EmployeeHrShadows)
                .HasForeignKey(d => d.EmpCity)
                .HasConstraintName("FK_EMPLOYEE_SHADOW_CITY_HR");

            entity.HasOne(d => d.EmpDeptNavigation).WithMany(p => p.EmployeeHrShadows)
                .HasForeignKey(d => d.EmpDept)
                .HasConstraintName("FK_EMPLOYEE_SHADOW_DEPARTMENT_HR");

            entity.HasOne(d => d.EmpDesignationNavigation).WithMany(p => p.EmployeeHrShadows)
                .HasForeignKey(d => d.EmpDesignation)
                .HasConstraintName("FK_EMPLOYEE_SHADOW_DESIGNATION_HR");

            entity.HasOne(d => d.EmpGradeNavigation).WithMany(p => p.EmployeeHrShadows)
                .HasForeignKey(d => d.EmpGrade)
                .HasConstraintName("FK_EMPLOYEE_SHADOW_GRADE_HR");

            entity.HasOne(d => d.EmpLocationNavigation).WithMany(p => p.EmployeeHrShadows)
                .HasForeignKey(d => d.EmpLocation)
                .HasConstraintName("FK_EMPLOYEE_SHADOW_LOCATION_HR");

            entity.HasOne(d => d.EmpNationalityNavigation).WithMany(p => p.EmployeeHrShadowEmpNationalityNavigations)
                .HasForeignKey(d => d.EmpNationality)
                .HasConstraintName("FK_EMPLOYEE_SHADOW_COUNTRIES1_HR");

            entity.HasOne(d => d.EmpOuNavigation).WithMany(p => p.EmployeeHrShadows)
                .HasForeignKey(d => d.EmpOu)
                .HasConstraintName("FK_EMPLOYEE_SHADOW_OU_HR");

            entity.HasOne(d => d.EmpPaygroupNavigation).WithMany(p => p.EmployeeHrShadows)
                .HasForeignKey(d => d.EmpPaygroup)
                .HasConstraintName("FK_EMPLOYEE_SHADOW_PAYGROUP_HR");

            entity.HasOne(d => d.EmpRegionNavigation).WithMany(p => p.EmployeeHrShadows)
                .HasForeignKey(d => d.EmpRegion)
                .HasConstraintName("FK_EMPLOYEE_SHADOW_REGION_HR");
        });

        modelBuilder.Entity<EmployeeHrUpdate>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("EMPLOYEE_HR_UPDATE");

            entity.Property(e => e.ApprovedBy)
                .HasMaxLength(50)
                .HasColumnName("APPROVED_BY");
            entity.Property(e => e.ApprovedDate)
                .HasColumnType("datetime")
                .HasColumnName("APPROVED_DATE");
            entity.Property(e => e.CurrentUsr)
                .HasMaxLength(50)
                .HasColumnName("CURRENT_USR");
            entity.Property(e => e.EmpAccount)
                .HasMaxLength(50)
                .HasColumnName("EMP_ACCOUNT");
            entity.Property(e => e.EmpBenefitoption)
                .HasMaxLength(100)
                .HasColumnName("EMP_BENEFITOPTION");
            entity.Property(e => e.EmpBirthcountry).HasColumnName("EMP_BIRTHCOUNTRY");
            entity.Property(e => e.EmpCategory)
                .HasMaxLength(20)
                .HasColumnName("EMP_CATEGORY");
            entity.Property(e => e.EmpCity).HasColumnName("EMP_CITY");
            entity.Property(e => e.EmpCompanyname)
                .HasMaxLength(200)
                .HasColumnName("EMP_COMPANYNAME");
            entity.Property(e => e.EmpConfirmdate)
                .HasColumnType("date")
                .HasColumnName("EMP_CONFIRMDATE");
            entity.Property(e => e.EmpCv).HasColumnName("EMP_CV");
            entity.Property(e => e.EmpDatejoined)
                .HasColumnType("date")
                .HasColumnName("EMP_DATEJOINED");
            entity.Property(e => e.EmpDept).HasColumnName("EMP_DEPT");
            entity.Property(e => e.EmpDesignation).HasColumnName("EMP_DESIGNATION");
            entity.Property(e => e.EmpDivisionalhead)
                .HasMaxLength(50)
                .HasColumnName("EMP_DIVISIONALHEAD");
            entity.Property(e => e.EmpDob)
                .HasColumnType("date")
                .HasColumnName("EMP_DOB");
            entity.Property(e => e.EmpEmail)
                .HasMaxLength(50)
                .HasColumnName("EMP_EMAIL");
            entity.Property(e => e.EmpFirstname)
                .HasMaxLength(50)
                .HasColumnName("EMP_FIRSTNAME");
            entity.Property(e => e.EmpFunctionalmgr)
                .HasMaxLength(50)
                .HasColumnName("EMP_FUNCTIONALMGR");
            entity.Property(e => e.EmpGender)
                .HasMaxLength(10)
                .HasColumnName("EMP_GENDER");
            entity.Property(e => e.EmpGrade).HasColumnName("EMP_GRADE");
            entity.Property(e => e.EmpHealthinsurancenumber)
                .HasMaxLength(50)
                .HasColumnName("EMP_HEALTHINSURANCENUMBER");
            entity.Property(e => e.EmpId)
                .HasMaxLength(50)
                .HasColumnName("EMP_ID");
            entity.Property(e => e.EmpIsconfirmed)
                .HasMaxLength(50)
                .HasColumnName("EMP_ISCONFIRMED");
            entity.Property(e => e.EmpLeavingdate)
                .HasColumnType("date")
                .HasColumnName("EMP_LEAVINGDATE");
            entity.Property(e => e.EmpLegalname)
                .HasMaxLength(200)
                .HasColumnName("EMP_LEGALNAME");
            entity.Property(e => e.EmpLocation).HasColumnName("EMP_LOCATION");
            entity.Property(e => e.EmpNationality).HasColumnName("EMP_NATIONALITY");
            entity.Property(e => e.EmpOfficeaddress)
                .HasMaxLength(100)
                .HasColumnName("EMP_OFFICEADDRESS");
            entity.Property(e => e.EmpOfficeext)
                .HasMaxLength(50)
                .HasColumnName("EMP_OFFICEEXT");
            entity.Property(e => e.EmpOfficefax)
                .HasMaxLength(50)
                .HasColumnName("EMP_OFFICEFAX");
            entity.Property(e => e.EmpOfficemail)
                .HasMaxLength(50)
                .HasColumnName("EMP_OFFICEMAIL");
            entity.Property(e => e.EmpOfficephone)
                .HasMaxLength(50)
                .HasColumnName("EMP_OFFICEPHONE");
            entity.Property(e => e.EmpOthernames)
                .HasMaxLength(100)
                .HasColumnName("EMP_OTHERNAMES");
            entity.Property(e => e.EmpOu).HasColumnName("EMP_OU");
            entity.Property(e => e.EmpPaygroup).HasColumnName("EMP_PAYGROUP");
            entity.Property(e => e.EmpPaylocation)
                .HasMaxLength(50)
                .HasColumnName("EMP_PAYLOCATION");
            entity.Property(e => e.EmpPaymode)
                .HasMaxLength(50)
                .HasColumnName("EMP_PAYMODE");
            entity.Property(e => e.EmpPhone)
                .HasMaxLength(50)
                .HasColumnName("EMP_PHONE");
            entity.Property(e => e.EmpPhoto).HasColumnName("EMP_PHOTO");
            entity.Property(e => e.EmpPosition).HasColumnName("EMP_POSITION");
            entity.Property(e => e.EmpPostaladdress)
                .HasMaxLength(100)
                .HasColumnName("EMP_POSTALADDRESS");
            entity.Property(e => e.EmpRecruiter)
                .HasMaxLength(100)
                .HasColumnName("EMP_RECRUITER");
            entity.Property(e => e.EmpReference1Address).HasColumnName("EMP_REFERENCE1_ADDRESS");
            entity.Property(e => e.EmpReference1Name)
                .HasMaxLength(200)
                .HasColumnName("EMP_REFERENCE1_NAME");
            entity.Property(e => e.EmpReference1Phone)
                .HasMaxLength(50)
                .HasColumnName("EMP_REFERENCE1_PHONE");
            entity.Property(e => e.EmpReference2Address).HasColumnName("EMP_REFERENCE2_ADDRESS");
            entity.Property(e => e.EmpReference2Name)
                .HasMaxLength(200)
                .HasColumnName("EMP_REFERENCE2_NAME");
            entity.Property(e => e.EmpReference2Phone)
                .HasMaxLength(50)
                .HasColumnName("EMP_REFERENCE2_PHONE");
            entity.Property(e => e.EmpReference3Address).HasColumnName("EMP_REFERENCE3_ADDRESS");
            entity.Property(e => e.EmpReference3Name)
                .HasMaxLength(200)
                .HasColumnName("EMP_REFERENCE3_NAME");
            entity.Property(e => e.EmpReference3Phone)
                .HasMaxLength(50)
                .HasColumnName("EMP_REFERENCE3_PHONE");
            entity.Property(e => e.EmpRegion).HasColumnName("EMP_REGION");
            entity.Property(e => e.EmpResidentialaddress)
                .HasMaxLength(100)
                .HasColumnName("EMP_RESIDENTIALADDRESS");
            entity.Property(e => e.EmpSalutation)
                .HasMaxLength(10)
                .HasColumnName("EMP_SALUTATION");
            entity.Property(e => e.EmpSsn)
                .HasMaxLength(50)
                .HasColumnName("EMP_SSN");
            entity.Property(e => e.EmpStatus).HasColumnName("EMP_STATUS");
            entity.Property(e => e.EmpSupervisor)
                .HasMaxLength(50)
                .HasColumnName("EMP_SUPERVISOR");
            entity.Property(e => e.EmpSurname)
                .HasMaxLength(50)
                .HasColumnName("EMP_SURNAME");
            entity.Property(e => e.EmpTin)
                .HasMaxLength(50)
                .HasColumnName("EMP_TIN");
            entity.Property(e => e.EmpType)
                .HasMaxLength(20)
                .HasColumnName("EMP_TYPE");
            entity.Property(e => e.FdCertificate).HasColumnName("FD_CERTIFICATE");
            entity.Property(e => e.FdDateobtained)
                .HasColumnType("date")
                .HasColumnName("FD_DATEOBTAINED");
            entity.Property(e => e.FdInstitution)
                .HasMaxLength(200)
                .HasColumnName("FD_INSTITUTION");
            entity.Property(e => e.FdQualification)
                .HasMaxLength(200)
                .HasColumnName("FD_QUALIFICATION");
            entity.Property(e => e.P1Certificate).HasColumnName("P1_CERTIFICATE");
            entity.Property(e => e.P1Dateobtained)
                .HasColumnType("date")
                .HasColumnName("P1_DATEOBTAINED");
            entity.Property(e => e.P1Institution)
                .HasMaxLength(200)
                .HasColumnName("P1_INSTITUTION");
            entity.Property(e => e.P1Qualification)
                .HasMaxLength(200)
                .HasColumnName("P1_QUALIFICATION");
            entity.Property(e => e.P2Certificate).HasColumnName("P2_CERTIFICATE");
            entity.Property(e => e.P2Dateobtained)
                .HasColumnType("date")
                .HasColumnName("P2_DATEOBTAINED");
            entity.Property(e => e.P2Institution)
                .HasMaxLength(200)
                .HasColumnName("P2_INSTITUTION");
            entity.Property(e => e.P2Qualification)
                .HasMaxLength(200)
                .HasColumnName("P2_QUALIFICATION");
            entity.Property(e => e.P3Certificate).HasColumnName("P3_CERTIFICATE");
            entity.Property(e => e.P3Dateobtained)
                .HasColumnType("date")
                .HasColumnName("P3_DATEOBTAINED");
            entity.Property(e => e.P3Institution)
                .HasMaxLength(200)
                .HasColumnName("P3_INSTITUTION");
            entity.Property(e => e.P3Qualification)
                .HasMaxLength(200)
                .HasColumnName("P3_QUALIFICATION");
            entity.Property(e => e.P4Certificate).HasColumnName("P4_CERTIFICATE");
            entity.Property(e => e.P4Dateobtained)
                .HasColumnType("date")
                .HasColumnName("P4_DATEOBTAINED");
            entity.Property(e => e.P4Institution)
                .HasMaxLength(200)
                .HasColumnName("P4_INSTITUTION");
            entity.Property(e => e.P4Qualification)
                .HasMaxLength(200)
                .HasColumnName("P4_QUALIFICATION");
            entity.Property(e => e.P5Certificate).HasColumnName("P5_CERTIFICATE");
            entity.Property(e => e.P5Dateobtained)
                .HasColumnType("date")
                .HasColumnName("P5_DATEOBTAINED");
            entity.Property(e => e.P5Institution)
                .HasMaxLength(200)
                .HasColumnName("P5_INSTITUTION");
            entity.Property(e => e.P5Qualification)
                .HasMaxLength(200)
                .HasColumnName("P5_QUALIFICATION");
            entity.Property(e => e.RejectReason)
                .HasMaxLength(255)
                .HasColumnName("REJECT_REASON");
            entity.Property(e => e.RejectedBy)
                .HasMaxLength(50)
                .HasColumnName("REJECTED_BY");
            entity.Property(e => e.RejectedDate)
                .HasColumnType("datetime")
                .HasColumnName("REJECTED_DATE");
            entity.Property(e => e.Requestdate)
                .HasColumnType("datetime")
                .HasColumnName("REQUESTDATE");
            entity.Property(e => e.SdCertificate).HasColumnName("SD_CERTIFICATE");
            entity.Property(e => e.SdDateobtained)
                .HasColumnType("date")
                .HasColumnName("SD_DATEOBTAINED");
            entity.Property(e => e.SdInstitution)
                .HasMaxLength(200)
                .HasColumnName("SD_INSTITUTION");
            entity.Property(e => e.SdQualification)
                .HasMaxLength(200)
                .HasColumnName("SD_QUALIFICATION");
            entity.Property(e => e.VerifiedBy)
                .HasMaxLength(50)
                .HasColumnName("VERIFIED_BY");
            entity.Property(e => e.VerifiedDate)
                .HasColumnType("datetime")
                .HasColumnName("VERIFIED_DATE");
        });

        modelBuilder.Entity<EmployeeMisc>(entity =>
        {
            entity.HasKey(e => e.EmpId);

            entity.ToTable("EMPLOYEE_MISC");

            entity.Property(e => e.EmpId)
                .HasMaxLength(50)
                .HasColumnName("EMP_ID");
            entity.Property(e => e.DepAddress1)
                .HasMaxLength(100)
                .HasColumnName("DEP_ADDRESS_1");
            entity.Property(e => e.DepAddress2)
                .HasMaxLength(100)
                .HasColumnName("DEP_ADDRESS_2");
            entity.Property(e => e.DepAddress3)
                .HasMaxLength(100)
                .HasColumnName("DEP_ADDRESS_3");
            entity.Property(e => e.DepAddress4)
                .HasMaxLength(100)
                .HasColumnName("DEP_ADDRESS_4");
            entity.Property(e => e.DepContact1)
                .HasMaxLength(50)
                .HasColumnName("DEP_CONTACT_1");
            entity.Property(e => e.DepContact2)
                .HasMaxLength(50)
                .HasColumnName("DEP_CONTACT_2");
            entity.Property(e => e.DepContact3)
                .HasMaxLength(50)
                .HasColumnName("DEP_CONTACT_3");
            entity.Property(e => e.DepContact4)
                .HasMaxLength(50)
                .HasColumnName("DEP_CONTACT_4");
            entity.Property(e => e.DepName1)
                .HasMaxLength(100)
                .HasColumnName("DEP_NAME_1");
            entity.Property(e => e.DepName2)
                .HasMaxLength(100)
                .HasColumnName("DEP_NAME_2");
            entity.Property(e => e.DepName3)
                .HasMaxLength(100)
                .HasColumnName("DEP_NAME_3");
            entity.Property(e => e.DepName4)
                .HasMaxLength(100)
                .HasColumnName("DEP_NAME_4");
            entity.Property(e => e.Disability).HasColumnName("DISABILITY");
            entity.Property(e => e.Enteredby)
                .HasMaxLength(50)
                .HasColumnName("ENTEREDBY");
            entity.Property(e => e.Entrydate)
                .HasColumnType("datetime")
                .HasColumnName("ENTRYDATE");
            entity.Property(e => e.GeneralRemarks).HasColumnName("GENERAL_REMARKS");
            entity.Property(e => e.Lastupdatedby)
                .HasMaxLength(50)
                .HasColumnName("LASTUPDATEDBY");
            entity.Property(e => e.Lastupdatedon)
                .HasColumnType("datetime")
                .HasColumnName("LASTUPDATEDON");
            entity.Property(e => e.NokAddress)
                .HasMaxLength(100)
                .HasColumnName("NOK_ADDRESS");
            entity.Property(e => e.NokContact)
                .HasMaxLength(50)
                .HasColumnName("NOK_CONTACT");
            entity.Property(e => e.NokName)
                .HasMaxLength(100)
                .HasColumnName("NOK_NAME");
            entity.Property(e => e.Status).HasColumnName("STATUS");
            entity.Property(e => e.Training).HasColumnName("TRAINING");
        });

        modelBuilder.Entity<EmployeeMiscShadow>(entity =>
        {
            entity.HasKey(e => e.EmpId);

            entity.ToTable("EMPLOYEE_MISC_SHADOW");

            entity.Property(e => e.EmpId)
                .HasMaxLength(50)
                .HasColumnName("EMP_ID");
            entity.Property(e => e.ApprovedBy)
                .HasMaxLength(50)
                .HasColumnName("APPROVED_BY");
            entity.Property(e => e.ApprovedDate)
                .HasColumnType("datetime")
                .HasColumnName("APPROVED_DATE");
            entity.Property(e => e.CurrentUsr)
                .HasMaxLength(50)
                .HasColumnName("CURRENT_USR");
            entity.Property(e => e.DepAddress1)
                .HasMaxLength(100)
                .HasColumnName("DEP_ADDRESS_1");
            entity.Property(e => e.DepAddress2)
                .HasMaxLength(100)
                .HasColumnName("DEP_ADDRESS_2");
            entity.Property(e => e.DepAddress3)
                .HasMaxLength(100)
                .HasColumnName("DEP_ADDRESS_3");
            entity.Property(e => e.DepAddress4)
                .HasMaxLength(100)
                .HasColumnName("DEP_ADDRESS_4");
            entity.Property(e => e.DepContact1)
                .HasMaxLength(50)
                .HasColumnName("DEP_CONTACT_1");
            entity.Property(e => e.DepContact2)
                .HasMaxLength(50)
                .HasColumnName("DEP_CONTACT_2");
            entity.Property(e => e.DepContact3)
                .HasMaxLength(50)
                .HasColumnName("DEP_CONTACT_3");
            entity.Property(e => e.DepContact4)
                .HasMaxLength(50)
                .HasColumnName("DEP_CONTACT_4");
            entity.Property(e => e.DepName1)
                .HasMaxLength(100)
                .HasColumnName("DEP_NAME_1");
            entity.Property(e => e.DepName2)
                .HasMaxLength(100)
                .HasColumnName("DEP_NAME_2");
            entity.Property(e => e.DepName3)
                .HasMaxLength(100)
                .HasColumnName("DEP_NAME_3");
            entity.Property(e => e.DepName4)
                .HasMaxLength(100)
                .HasColumnName("DEP_NAME_4");
            entity.Property(e => e.Disability).HasColumnName("DISABILITY");
            entity.Property(e => e.Enteredby)
                .HasMaxLength(50)
                .HasColumnName("ENTEREDBY");
            entity.Property(e => e.Entrydate)
                .HasColumnType("datetime")
                .HasColumnName("ENTRYDATE");
            entity.Property(e => e.GeneralRemarks).HasColumnName("GENERAL_REMARKS");
            entity.Property(e => e.Lastupdatedby)
                .HasMaxLength(50)
                .HasColumnName("LASTUPDATEDBY");
            entity.Property(e => e.Lastupdatedon)
                .HasColumnType("datetime")
                .HasColumnName("LASTUPDATEDON");
            entity.Property(e => e.NokAddress)
                .HasMaxLength(100)
                .HasColumnName("NOK_ADDRESS");
            entity.Property(e => e.NokContact)
                .HasMaxLength(50)
                .HasColumnName("NOK_CONTACT");
            entity.Property(e => e.NokName)
                .HasMaxLength(100)
                .HasColumnName("NOK_NAME");
            entity.Property(e => e.RejectReason)
                .HasMaxLength(255)
                .HasColumnName("REJECT_REASON");
            entity.Property(e => e.RejectedBy)
                .HasMaxLength(50)
                .HasColumnName("REJECTED_BY");
            entity.Property(e => e.RejectedDate)
                .HasColumnType("datetime")
                .HasColumnName("REJECTED_DATE");
            entity.Property(e => e.Requestdate)
                .HasColumnType("datetime")
                .HasColumnName("REQUESTDATE");
            entity.Property(e => e.Status).HasColumnName("STATUS");
            entity.Property(e => e.Training).HasColumnName("TRAINING");
            entity.Property(e => e.VerifiedBy)
                .HasMaxLength(50)
                .HasColumnName("VERIFIED_BY");
            entity.Property(e => e.VerifiedDate)
                .HasColumnType("datetime")
                .HasColumnName("VERIFIED_DATE");
        });

        modelBuilder.Entity<EmployeeShadow>(entity =>
        {
            entity.HasKey(e => e.EmpId);

            entity.ToTable("EMPLOYEE_SHADOW");

            entity.Property(e => e.EmpId)
                .HasMaxLength(50)
                .HasColumnName("EMP_ID");
            entity.Property(e => e.ApprovedBy)
                .HasMaxLength(50)
                .HasColumnName("APPROVED_BY");
            entity.Property(e => e.ApprovedDate)
                .HasColumnType("datetime")
                .HasColumnName("APPROVED_DATE");
            entity.Property(e => e.CurrentUsr)
                .HasMaxLength(50)
                .HasColumnName("CURRENT_USR");
            entity.Property(e => e.EmpAccount)
                .HasMaxLength(50)
                .HasColumnName("EMP_ACCOUNT");
            entity.Property(e => e.EmpBenefitoption)
                .HasMaxLength(100)
                .HasColumnName("EMP_BENEFITOPTION");
            entity.Property(e => e.EmpBirthcountry).HasColumnName("EMP_BIRTHCOUNTRY");
            entity.Property(e => e.EmpCategory)
                .HasMaxLength(20)
                .HasColumnName("EMP_CATEGORY");
            entity.Property(e => e.EmpCity).HasColumnName("EMP_CITY");
            entity.Property(e => e.EmpCompanyname)
                .HasMaxLength(200)
                .HasColumnName("EMP_COMPANYNAME");
            entity.Property(e => e.EmpConfirmdate)
                .HasColumnType("date")
                .HasColumnName("EMP_CONFIRMDATE");
            entity.Property(e => e.EmpCv).HasColumnName("EMP_CV");
            entity.Property(e => e.EmpCvContenttype)
                .HasMaxLength(256)
                .HasColumnName("EMP_CV_CONTENTTYPE");
            entity.Property(e => e.EmpCvName)
                .HasMaxLength(256)
                .HasColumnName("EMP_CV_NAME");
            entity.Property(e => e.EmpDatejoined)
                .HasColumnType("date")
                .HasColumnName("EMP_DATEJOINED");
            entity.Property(e => e.EmpDept).HasColumnName("EMP_DEPT");
            entity.Property(e => e.EmpDesignation).HasColumnName("EMP_DESIGNATION");
            entity.Property(e => e.EmpDivisionalhead)
                .HasMaxLength(50)
                .HasColumnName("EMP_DIVISIONALHEAD");
            entity.Property(e => e.EmpDob)
                .HasColumnType("date")
                .HasColumnName("EMP_DOB");
            entity.Property(e => e.EmpEmail)
                .HasMaxLength(50)
                .HasColumnName("EMP_EMAIL");
            entity.Property(e => e.EmpEnddate)
                .HasColumnType("datetime")
                .HasColumnName("EMP_ENDDATE");
            entity.Property(e => e.EmpEndletterdate)
                .HasColumnType("datetime")
                .HasColumnName("EMP_ENDLETTERDATE");
            entity.Property(e => e.EmpFirstname)
                .HasMaxLength(50)
                .HasColumnName("EMP_FIRSTNAME");
            entity.Property(e => e.EmpFunctionalmgr)
                .HasMaxLength(50)
                .HasColumnName("EMP_FUNCTIONALMGR");
            entity.Property(e => e.EmpGender)
                .HasMaxLength(50)
                .HasColumnName("EMP_GENDER");
            entity.Property(e => e.EmpGrade).HasColumnName("EMP_GRADE");
            entity.Property(e => e.EmpHealthinsurancenumber)
                .HasMaxLength(50)
                .HasColumnName("EMP_HEALTHINSURANCENUMBER");
            entity.Property(e => e.EmpIsconfirmed)
                .HasMaxLength(50)
                .HasColumnName("EMP_ISCONFIRMED");
            entity.Property(e => e.EmpLeavingdate)
                .HasColumnType("date")
                .HasColumnName("EMP_LEAVINGDATE");
            entity.Property(e => e.EmpLegalname)
                .HasMaxLength(200)
                .HasColumnName("EMP_LEGALNAME");
            entity.Property(e => e.EmpLocation).HasColumnName("EMP_LOCATION");
            entity.Property(e => e.EmpNationality).HasColumnName("EMP_NATIONALITY");
            entity.Property(e => e.EmpOfficeaddress)
                .HasMaxLength(100)
                .HasColumnName("EMP_OFFICEADDRESS");
            entity.Property(e => e.EmpOfficeext)
                .HasMaxLength(50)
                .HasColumnName("EMP_OFFICEEXT");
            entity.Property(e => e.EmpOfficefax)
                .HasMaxLength(50)
                .HasColumnName("EMP_OFFICEFAX");
            entity.Property(e => e.EmpOfficemail)
                .HasMaxLength(50)
                .HasColumnName("EMP_OFFICEMAIL");
            entity.Property(e => e.EmpOfficephone)
                .HasMaxLength(50)
                .HasColumnName("EMP_OFFICEPHONE");
            entity.Property(e => e.EmpOthernames)
                .HasMaxLength(100)
                .HasColumnName("EMP_OTHERNAMES");
            entity.Property(e => e.EmpOu).HasColumnName("EMP_OU");
            entity.Property(e => e.EmpPaygroup).HasColumnName("EMP_PAYGROUP");
            entity.Property(e => e.EmpPaylocation)
                .HasMaxLength(50)
                .HasColumnName("EMP_PAYLOCATION");
            entity.Property(e => e.EmpPaymode)
                .HasMaxLength(50)
                .HasColumnName("EMP_PAYMODE");
            entity.Property(e => e.EmpPhone)
                .HasMaxLength(50)
                .HasColumnName("EMP_PHONE");
            entity.Property(e => e.EmpPhoto).HasColumnName("EMP_PHOTO");
            entity.Property(e => e.EmpPosition).HasColumnName("EMP_POSITION");
            entity.Property(e => e.EmpPostaladdress)
                .HasMaxLength(100)
                .HasColumnName("EMP_POSTALADDRESS");
            entity.Property(e => e.EmpRecruiter)
                .HasMaxLength(100)
                .HasColumnName("EMP_RECRUITER");
            entity.Property(e => e.EmpReference1Address).HasColumnName("EMP_REFERENCE1_ADDRESS");
            entity.Property(e => e.EmpReference1Name)
                .HasMaxLength(200)
                .HasColumnName("EMP_REFERENCE1_NAME");
            entity.Property(e => e.EmpReference1Phone)
                .HasMaxLength(50)
                .HasColumnName("EMP_REFERENCE1_PHONE");
            entity.Property(e => e.EmpReference2Address).HasColumnName("EMP_REFERENCE2_ADDRESS");
            entity.Property(e => e.EmpReference2Name)
                .HasMaxLength(200)
                .HasColumnName("EMP_REFERENCE2_NAME");
            entity.Property(e => e.EmpReference2Phone)
                .HasMaxLength(50)
                .HasColumnName("EMP_REFERENCE2_PHONE");
            entity.Property(e => e.EmpReference3Address).HasColumnName("EMP_REFERENCE3_ADDRESS");
            entity.Property(e => e.EmpReference3Name)
                .HasMaxLength(200)
                .HasColumnName("EMP_REFERENCE3_NAME");
            entity.Property(e => e.EmpReference3Phone)
                .HasMaxLength(50)
                .HasColumnName("EMP_REFERENCE3_PHONE");
            entity.Property(e => e.EmpRegion).HasColumnName("EMP_REGION");
            entity.Property(e => e.EmpResidentialaddress)
                .HasMaxLength(100)
                .HasColumnName("EMP_RESIDENTIALADDRESS");
            entity.Property(e => e.EmpSalutation)
                .HasMaxLength(50)
                .HasColumnName("EMP_SALUTATION");
            entity.Property(e => e.EmpSsn)
                .HasMaxLength(50)
                .HasColumnName("EMP_SSN");
            entity.Property(e => e.EmpStatus).HasColumnName("EMP_STATUS");
            entity.Property(e => e.EmpSupervisor)
                .HasMaxLength(50)
                .HasColumnName("EMP_SUPERVISOR");
            entity.Property(e => e.EmpSurname)
                .HasMaxLength(50)
                .HasColumnName("EMP_SURNAME");
            entity.Property(e => e.EmpTin)
                .HasMaxLength(50)
                .HasColumnName("EMP_TIN");
            entity.Property(e => e.EmpType)
                .HasMaxLength(20)
                .HasColumnName("EMP_TYPE");
            entity.Property(e => e.FdCertificate).HasColumnName("FD_CERTIFICATE");
            entity.Property(e => e.FdCertificateContenttype)
                .HasMaxLength(256)
                .HasColumnName("FD_CERTIFICATE_CONTENTTYPE");
            entity.Property(e => e.FdCertificateName)
                .HasMaxLength(256)
                .HasColumnName("FD_CERTIFICATE_NAME");
            entity.Property(e => e.FdDateobtained)
                .HasColumnType("date")
                .HasColumnName("FD_DATEOBTAINED");
            entity.Property(e => e.FdInstitution)
                .HasMaxLength(200)
                .HasColumnName("FD_INSTITUTION");
            entity.Property(e => e.FdQualification)
                .HasMaxLength(200)
                .HasColumnName("FD_QUALIFICATION");
            entity.Property(e => e.P1Certificate).HasColumnName("P1_CERTIFICATE");
            entity.Property(e => e.P1CertificateContenttype)
                .HasMaxLength(256)
                .HasColumnName("P1_CERTIFICATE_CONTENTTYPE");
            entity.Property(e => e.P1CertificateName)
                .HasMaxLength(256)
                .HasColumnName("P1_CERTIFICATE_NAME");
            entity.Property(e => e.P1Dateobtained)
                .HasColumnType("date")
                .HasColumnName("P1_DATEOBTAINED");
            entity.Property(e => e.P1Institution)
                .HasMaxLength(200)
                .HasColumnName("P1_INSTITUTION");
            entity.Property(e => e.P1Qualification)
                .HasMaxLength(200)
                .HasColumnName("P1_QUALIFICATION");
            entity.Property(e => e.P2Certificate).HasColumnName("P2_CERTIFICATE");
            entity.Property(e => e.P2CertificateContenttype)
                .HasMaxLength(256)
                .HasColumnName("P2_CERTIFICATE_CONTENTTYPE");
            entity.Property(e => e.P2CertificateName)
                .HasMaxLength(256)
                .HasColumnName("P2_CERTIFICATE_NAME");
            entity.Property(e => e.P2Dateobtained)
                .HasColumnType("date")
                .HasColumnName("P2_DATEOBTAINED");
            entity.Property(e => e.P2Institution)
                .HasMaxLength(200)
                .HasColumnName("P2_INSTITUTION");
            entity.Property(e => e.P2Qualification)
                .HasMaxLength(200)
                .HasColumnName("P2_QUALIFICATION");
            entity.Property(e => e.P3Certificate).HasColumnName("P3_CERTIFICATE");
            entity.Property(e => e.P3CertificateContenttype)
                .HasMaxLength(256)
                .HasColumnName("P3_CERTIFICATE_CONTENTTYPE");
            entity.Property(e => e.P3CertificateName)
                .HasMaxLength(256)
                .HasColumnName("P3_CERTIFICATE_NAME");
            entity.Property(e => e.P3Dateobtained)
                .HasColumnType("date")
                .HasColumnName("P3_DATEOBTAINED");
            entity.Property(e => e.P3Institution)
                .HasMaxLength(200)
                .HasColumnName("P3_INSTITUTION");
            entity.Property(e => e.P3Qualification)
                .HasMaxLength(200)
                .HasColumnName("P3_QUALIFICATION");
            entity.Property(e => e.P4Certificate).HasColumnName("P4_CERTIFICATE");
            entity.Property(e => e.P4CertificateContenttype)
                .HasMaxLength(256)
                .HasColumnName("P4_CERTIFICATE_CONTENTTYPE");
            entity.Property(e => e.P4CertificateName)
                .HasMaxLength(256)
                .HasColumnName("P4_CERTIFICATE_NAME");
            entity.Property(e => e.P4Dateobtained)
                .HasColumnType("date")
                .HasColumnName("P4_DATEOBTAINED");
            entity.Property(e => e.P4Institution)
                .HasMaxLength(200)
                .HasColumnName("P4_INSTITUTION");
            entity.Property(e => e.P4Qualification)
                .HasMaxLength(200)
                .HasColumnName("P4_QUALIFICATION");
            entity.Property(e => e.P5Certificate).HasColumnName("P5_CERTIFICATE");
            entity.Property(e => e.P5CertificateContenttype)
                .HasMaxLength(256)
                .HasColumnName("P5_CERTIFICATE_CONTENTTYPE");
            entity.Property(e => e.P5CertificateName)
                .HasMaxLength(256)
                .HasColumnName("P5_CERTIFICATE_NAME");
            entity.Property(e => e.P5Dateobtained)
                .HasColumnType("date")
                .HasColumnName("P5_DATEOBTAINED");
            entity.Property(e => e.P5Institution)
                .HasMaxLength(200)
                .HasColumnName("P5_INSTITUTION");
            entity.Property(e => e.P5Qualification)
                .HasMaxLength(200)
                .HasColumnName("P5_QUALIFICATION");
            entity.Property(e => e.RejectReason)
                .HasMaxLength(255)
                .HasColumnName("REJECT_REASON");
            entity.Property(e => e.RejectedBy)
                .HasMaxLength(50)
                .HasColumnName("REJECTED_BY");
            entity.Property(e => e.RejectedDate)
                .HasColumnType("datetime")
                .HasColumnName("REJECTED_DATE");
            entity.Property(e => e.Requestdate)
                .HasColumnType("datetime")
                .HasColumnName("REQUESTDATE");
            entity.Property(e => e.SdCertificate).HasColumnName("SD_CERTIFICATE");
            entity.Property(e => e.SdCertificateContenttype)
                .HasMaxLength(256)
                .HasColumnName("SD_CERTIFICATE_CONTENTTYPE");
            entity.Property(e => e.SdCertificateName)
                .HasMaxLength(256)
                .HasColumnName("SD_CERTIFICATE_NAME");
            entity.Property(e => e.SdDateobtained)
                .HasColumnType("date")
                .HasColumnName("SD_DATEOBTAINED");
            entity.Property(e => e.SdInstitution)
                .HasMaxLength(200)
                .HasColumnName("SD_INSTITUTION");
            entity.Property(e => e.SdQualification)
                .HasMaxLength(200)
                .HasColumnName("SD_QUALIFICATION");
            entity.Property(e => e.VerifiedBy)
                .HasMaxLength(50)
                .HasColumnName("VERIFIED_BY");
            entity.Property(e => e.VerifiedDate)
                .HasColumnType("datetime")
                .HasColumnName("VERIFIED_DATE");

            entity.HasOne(d => d.EmpBirthcountryNavigation).WithMany(p => p.EmployeeShadowEmpBirthcountryNavigations)
                .HasForeignKey(d => d.EmpBirthcountry)
                .HasConstraintName("FK_EMPLOYEE_SHADOW_COUNTRIES");

            entity.HasOne(d => d.EmpCityNavigation).WithMany(p => p.EmployeeShadows)
                .HasForeignKey(d => d.EmpCity)
                .HasConstraintName("FK_EMPLOYEE_SHADOW_CITY");

            entity.HasOne(d => d.EmpDeptNavigation).WithMany(p => p.EmployeeShadows)
                .HasForeignKey(d => d.EmpDept)
                .HasConstraintName("FK_EMPLOYEE_SHADOW_DEPARTMENT");

            entity.HasOne(d => d.EmpDesignationNavigation).WithMany(p => p.EmployeeShadows)
                .HasForeignKey(d => d.EmpDesignation)
                .HasConstraintName("FK_EMPLOYEE_SHADOW_DESIGNATION");

            entity.HasOne(d => d.EmpGradeNavigation).WithMany(p => p.EmployeeShadows)
                .HasForeignKey(d => d.EmpGrade)
                .HasConstraintName("FK_EMPLOYEE_SHADOW_GRADE");

            entity.HasOne(d => d.EmpLocationNavigation).WithMany(p => p.EmployeeShadows)
                .HasForeignKey(d => d.EmpLocation)
                .HasConstraintName("FK_EMPLOYEE_SHADOW_LOCATION");

            entity.HasOne(d => d.EmpNationalityNavigation).WithMany(p => p.EmployeeShadowEmpNationalityNavigations)
                .HasForeignKey(d => d.EmpNationality)
                .HasConstraintName("FK_EMPLOYEE_SHADOW_COUNTRIES1");

            entity.HasOne(d => d.EmpOuNavigation).WithMany(p => p.EmployeeShadows)
                .HasForeignKey(d => d.EmpOu)
                .HasConstraintName("FK_EMPLOYEE_SHADOW_OU");

            entity.HasOne(d => d.EmpPaygroupNavigation).WithMany(p => p.EmployeeShadows)
                .HasForeignKey(d => d.EmpPaygroup)
                .HasConstraintName("FK_EMPLOYEE_SHADOW_PAYGROUP");

            entity.HasOne(d => d.EmpRegionNavigation).WithMany(p => p.EmployeeShadows)
                .HasForeignKey(d => d.EmpRegion)
                .HasConstraintName("FK_EMPLOYEE_SHADOW_REGION");
        });

        modelBuilder.Entity<EmployeeUpdate>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("EMPLOYEE_UPDATE");

            entity.Property(e => e.ApprovedBy)
                .HasMaxLength(50)
                .HasColumnName("APPROVED_BY");
            entity.Property(e => e.ApprovedDate)
                .HasColumnType("datetime")
                .HasColumnName("APPROVED_DATE");
            entity.Property(e => e.CurrentUsr)
                .HasMaxLength(50)
                .HasColumnName("CURRENT_USR");
            entity.Property(e => e.EmpAccount)
                .HasMaxLength(50)
                .HasColumnName("EMP_ACCOUNT");
            entity.Property(e => e.EmpBenefitoption)
                .HasMaxLength(100)
                .HasColumnName("EMP_BENEFITOPTION");
            entity.Property(e => e.EmpBirthcountry).HasColumnName("EMP_BIRTHCOUNTRY");
            entity.Property(e => e.EmpCategory)
                .HasMaxLength(20)
                .HasColumnName("EMP_CATEGORY");
            entity.Property(e => e.EmpCity).HasColumnName("EMP_CITY");
            entity.Property(e => e.EmpCompanyname)
                .HasMaxLength(200)
                .HasColumnName("EMP_COMPANYNAME");
            entity.Property(e => e.EmpConfirmdate)
                .HasColumnType("date")
                .HasColumnName("EMP_CONFIRMDATE");
            entity.Property(e => e.EmpCv).HasColumnName("EMP_CV");
            entity.Property(e => e.EmpDatejoined)
                .HasColumnType("date")
                .HasColumnName("EMP_DATEJOINED");
            entity.Property(e => e.EmpDept).HasColumnName("EMP_DEPT");
            entity.Property(e => e.EmpDesignation).HasColumnName("EMP_DESIGNATION");
            entity.Property(e => e.EmpDivisionalhead)
                .HasMaxLength(50)
                .HasColumnName("EMP_DIVISIONALHEAD");
            entity.Property(e => e.EmpDob)
                .HasColumnType("date")
                .HasColumnName("EMP_DOB");
            entity.Property(e => e.EmpEmail)
                .HasMaxLength(50)
                .HasColumnName("EMP_EMAIL");
            entity.Property(e => e.EmpFirstname)
                .HasMaxLength(50)
                .HasColumnName("EMP_FIRSTNAME");
            entity.Property(e => e.EmpFunctionalmgr)
                .HasMaxLength(50)
                .HasColumnName("EMP_FUNCTIONALMGR");
            entity.Property(e => e.EmpGender)
                .HasMaxLength(10)
                .HasColumnName("EMP_GENDER");
            entity.Property(e => e.EmpGrade).HasColumnName("EMP_GRADE");
            entity.Property(e => e.EmpHealthinsurancenumber)
                .HasMaxLength(50)
                .HasColumnName("EMP_HEALTHINSURANCENUMBER");
            entity.Property(e => e.EmpId)
                .HasMaxLength(50)
                .HasColumnName("EMP_ID");
            entity.Property(e => e.EmpIsconfirmed)
                .HasMaxLength(50)
                .HasColumnName("EMP_ISCONFIRMED");
            entity.Property(e => e.EmpLeavingdate)
                .HasColumnType("date")
                .HasColumnName("EMP_LEAVINGDATE");
            entity.Property(e => e.EmpLegalname)
                .HasMaxLength(200)
                .HasColumnName("EMP_LEGALNAME");
            entity.Property(e => e.EmpLocation).HasColumnName("EMP_LOCATION");
            entity.Property(e => e.EmpNationality).HasColumnName("EMP_NATIONALITY");
            entity.Property(e => e.EmpOfficeaddress)
                .HasMaxLength(100)
                .HasColumnName("EMP_OFFICEADDRESS");
            entity.Property(e => e.EmpOfficeext)
                .HasMaxLength(50)
                .HasColumnName("EMP_OFFICEEXT");
            entity.Property(e => e.EmpOfficefax)
                .HasMaxLength(50)
                .HasColumnName("EMP_OFFICEFAX");
            entity.Property(e => e.EmpOfficemail)
                .HasMaxLength(50)
                .HasColumnName("EMP_OFFICEMAIL");
            entity.Property(e => e.EmpOfficephone)
                .HasMaxLength(50)
                .HasColumnName("EMP_OFFICEPHONE");
            entity.Property(e => e.EmpOthernames)
                .HasMaxLength(100)
                .HasColumnName("EMP_OTHERNAMES");
            entity.Property(e => e.EmpOu).HasColumnName("EMP_OU");
            entity.Property(e => e.EmpPaygroup).HasColumnName("EMP_PAYGROUP");
            entity.Property(e => e.EmpPaylocation)
                .HasMaxLength(50)
                .HasColumnName("EMP_PAYLOCATION");
            entity.Property(e => e.EmpPaymode)
                .HasMaxLength(50)
                .HasColumnName("EMP_PAYMODE");
            entity.Property(e => e.EmpPhone)
                .HasMaxLength(250)
                .HasColumnName("EMP_PHONE");
            entity.Property(e => e.EmpPhoto).HasColumnName("EMP_PHOTO");
            entity.Property(e => e.EmpPosition).HasColumnName("EMP_POSITION");
            entity.Property(e => e.EmpPostaladdress)
                .HasMaxLength(100)
                .HasColumnName("EMP_POSTALADDRESS");
            entity.Property(e => e.EmpRecruiter)
                .HasMaxLength(100)
                .HasColumnName("EMP_RECRUITER");
            entity.Property(e => e.EmpReference1Address).HasColumnName("EMP_REFERENCE1_ADDRESS");
            entity.Property(e => e.EmpReference1Name)
                .HasMaxLength(200)
                .HasColumnName("EMP_REFERENCE1_NAME");
            entity.Property(e => e.EmpReference1Phone)
                .HasMaxLength(50)
                .HasColumnName("EMP_REFERENCE1_PHONE");
            entity.Property(e => e.EmpReference2Address).HasColumnName("EMP_REFERENCE2_ADDRESS");
            entity.Property(e => e.EmpReference2Name)
                .HasMaxLength(200)
                .HasColumnName("EMP_REFERENCE2_NAME");
            entity.Property(e => e.EmpReference2Phone)
                .HasMaxLength(50)
                .HasColumnName("EMP_REFERENCE2_PHONE");
            entity.Property(e => e.EmpReference3Address).HasColumnName("EMP_REFERENCE3_ADDRESS");
            entity.Property(e => e.EmpReference3Name)
                .HasMaxLength(200)
                .HasColumnName("EMP_REFERENCE3_NAME");
            entity.Property(e => e.EmpReference3Phone)
                .HasMaxLength(50)
                .HasColumnName("EMP_REFERENCE3_PHONE");
            entity.Property(e => e.EmpRegion).HasColumnName("EMP_REGION");
            entity.Property(e => e.EmpResidentialaddress)
                .HasMaxLength(100)
                .HasColumnName("EMP_RESIDENTIALADDRESS");
            entity.Property(e => e.EmpSalutation)
                .HasMaxLength(10)
                .HasColumnName("EMP_SALUTATION");
            entity.Property(e => e.EmpSsn)
                .HasMaxLength(50)
                .HasColumnName("EMP_SSN");
            entity.Property(e => e.EmpStatus).HasColumnName("EMP_STATUS");
            entity.Property(e => e.EmpSupervisor)
                .HasMaxLength(50)
                .HasColumnName("EMP_SUPERVISOR");
            entity.Property(e => e.EmpSurname)
                .HasMaxLength(50)
                .HasColumnName("EMP_SURNAME");
            entity.Property(e => e.EmpTin)
                .HasMaxLength(50)
                .HasColumnName("EMP_TIN");
            entity.Property(e => e.EmpType)
                .HasMaxLength(20)
                .HasColumnName("EMP_TYPE");
            entity.Property(e => e.FdCertificate).HasColumnName("FD_CERTIFICATE");
            entity.Property(e => e.FdDateobtained)
                .HasColumnType("date")
                .HasColumnName("FD_DATEOBTAINED");
            entity.Property(e => e.FdInstitution)
                .HasMaxLength(200)
                .HasColumnName("FD_INSTITUTION");
            entity.Property(e => e.FdQualification)
                .HasMaxLength(200)
                .HasColumnName("FD_QUALIFICATION");
            entity.Property(e => e.P1Certificate).HasColumnName("P1_CERTIFICATE");
            entity.Property(e => e.P1Dateobtained)
                .HasColumnType("date")
                .HasColumnName("P1_DATEOBTAINED");
            entity.Property(e => e.P1Institution)
                .HasMaxLength(200)
                .HasColumnName("P1_INSTITUTION");
            entity.Property(e => e.P1Qualification)
                .HasMaxLength(200)
                .HasColumnName("P1_QUALIFICATION");
            entity.Property(e => e.P2Certificate).HasColumnName("P2_CERTIFICATE");
            entity.Property(e => e.P2Dateobtained)
                .HasColumnType("date")
                .HasColumnName("P2_DATEOBTAINED");
            entity.Property(e => e.P2Institution)
                .HasMaxLength(200)
                .HasColumnName("P2_INSTITUTION");
            entity.Property(e => e.P2Qualification)
                .HasMaxLength(200)
                .HasColumnName("P2_QUALIFICATION");
            entity.Property(e => e.P3Certificate).HasColumnName("P3_CERTIFICATE");
            entity.Property(e => e.P3Dateobtained)
                .HasColumnType("date")
                .HasColumnName("P3_DATEOBTAINED");
            entity.Property(e => e.P3Institution)
                .HasMaxLength(200)
                .HasColumnName("P3_INSTITUTION");
            entity.Property(e => e.P3Qualification)
                .HasMaxLength(200)
                .HasColumnName("P3_QUALIFICATION");
            entity.Property(e => e.P4Certificate).HasColumnName("P4_CERTIFICATE");
            entity.Property(e => e.P4Dateobtained)
                .HasColumnType("date")
                .HasColumnName("P4_DATEOBTAINED");
            entity.Property(e => e.P4Institution)
                .HasMaxLength(200)
                .HasColumnName("P4_INSTITUTION");
            entity.Property(e => e.P4Qualification)
                .HasMaxLength(200)
                .HasColumnName("P4_QUALIFICATION");
            entity.Property(e => e.P5Certificate).HasColumnName("P5_CERTIFICATE");
            entity.Property(e => e.P5Dateobtained)
                .HasColumnType("date")
                .HasColumnName("P5_DATEOBTAINED");
            entity.Property(e => e.P5Institution)
                .HasMaxLength(200)
                .HasColumnName("P5_INSTITUTION");
            entity.Property(e => e.P5Qualification)
                .HasMaxLength(200)
                .HasColumnName("P5_QUALIFICATION");
            entity.Property(e => e.RejectReason)
                .HasMaxLength(255)
                .HasColumnName("REJECT_REASON");
            entity.Property(e => e.RejectedBy)
                .HasMaxLength(50)
                .HasColumnName("REJECTED_BY");
            entity.Property(e => e.RejectedDate)
                .HasColumnType("datetime")
                .HasColumnName("REJECTED_DATE");
            entity.Property(e => e.Requestdate)
                .HasColumnType("datetime")
                .HasColumnName("REQUESTDATE");
            entity.Property(e => e.SdCertificate).HasColumnName("SD_CERTIFICATE");
            entity.Property(e => e.SdDateobtained)
                .HasColumnType("date")
                .HasColumnName("SD_DATEOBTAINED");
            entity.Property(e => e.SdInstitution)
                .HasMaxLength(200)
                .HasColumnName("SD_INSTITUTION");
            entity.Property(e => e.SdQualification)
                .HasMaxLength(200)
                .HasColumnName("SD_QUALIFICATION");
            entity.Property(e => e.VerifiedBy)
                .HasMaxLength(50)
                .HasColumnName("VERIFIED_BY");
            entity.Property(e => e.VerifiedDate)
                .HasColumnType("datetime")
                .HasColumnName("VERIFIED_DATE");
        });

        modelBuilder.Entity<GlobalSetting>(entity =>
        {
            entity.ToTable("GlobalSetting");

            entity.Property(e => e.CreatedBy).HasMaxLength(256);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.ModifiedBy).HasMaxLength(256);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.SessionTimeOut).HasMaxLength(50);
        });

        modelBuilder.Entity<Grade>(entity =>
        {
            entity.HasKey(e => e.GradeCode);

            entity.ToTable("GRADE");

            entity.Property(e => e.GradeCode)
                .ValueGeneratedNever()
                .HasColumnName("GRADE_CODE");
            entity.Property(e => e.BasicSalary).HasColumnName("BASIC_SALARY");
            entity.Property(e => e.ClothingAllowance).HasColumnName("CLOTHING_ALLOWANCE");
            entity.Property(e => e.FuelAllowance).HasColumnName("FUEL_ALLOWANCE");
            entity.Property(e => e.GradeBand)
                .HasMaxLength(50)
                .HasColumnName("GRADE_BAND");
            entity.Property(e => e.GradeEnteredby)
                .HasMaxLength(50)
                .HasColumnName("GRADE_ENTEREDBY");
            entity.Property(e => e.GradeEntrydate)
                .HasColumnType("datetime")
                .HasColumnName("GRADE_ENTRYDATE");
            entity.Property(e => e.GradeLastupdatedby)
                .HasMaxLength(50)
                .HasColumnName("GRADE_LASTUPDATEDBY");
            entity.Property(e => e.GradeLastupdatedon)
                .HasColumnType("datetime")
                .HasColumnName("GRADE_LASTUPDATEDON");
            entity.Property(e => e.GradeName)
                .HasMaxLength(50)
                .HasColumnName("GRADE_NAME");
            entity.Property(e => e.GradeStatus).HasColumnName("GRADE_STATUS");
        });

        modelBuilder.Entity<Holiday>(entity =>
        {
            entity.HasKey(e => e.Sn);

            entity.ToTable("HOLIDAYS");

            entity.Property(e => e.Sn).HasColumnName("SN");
            entity.Property(e => e.Approvedate)
                .HasColumnType("datetime")
                .HasColumnName("APPROVEDATE");
            entity.Property(e => e.Approvedby)
                .HasMaxLength(50)
                .HasColumnName("APPROVEDBY");
            entity.Property(e => e.Currentuser)
                .HasMaxLength(50)
                .HasColumnName("CURRENTUSER");
            entity.Property(e => e.Datedd)
                .HasMaxLength(50)
                .HasColumnName("DATEDD");
            entity.Property(e => e.Datedesc)
                .HasMaxLength(100)
                .HasColumnName("DATEDESC");
            entity.Property(e => e.Datemm)
                .HasMaxLength(50)
                .HasColumnName("DATEMM");
            entity.Property(e => e.Dateval)
                .HasColumnType("date")
                .HasColumnName("DATEVAL");
            entity.Property(e => e.Enteredby)
                .HasMaxLength(50)
                .HasColumnName("ENTEREDBY");
            entity.Property(e => e.Entrydate)
                .HasColumnType("datetime")
                .HasColumnName("ENTRYDATE");
            entity.Property(e => e.Status).HasColumnName("STATUS");
        });

        modelBuilder.Entity<HrMakerChecker>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("HR_MAKER_CHECKER");

            entity.Property(e => e.Checker)
                .HasMaxLength(50)
                .HasColumnName("CHECKER");
            entity.Property(e => e.Currentuser)
                .HasMaxLength(50)
                .HasColumnName("CURRENTUSER");
            entity.Property(e => e.EmpId)
                .HasMaxLength(50)
                .HasColumnName("EMP_ID");
            entity.Property(e => e.Entrydate)
                .HasColumnType("datetime")
                .HasColumnName("ENTRYDATE");
            entity.Property(e => e.Maker)
                .HasMaxLength(50)
                .HasColumnName("MAKER");
        });

        modelBuilder.Entity<HrMasterRegister>(entity =>
        {
            entity.HasKey(e => e.EmpId);

            entity.ToTable("HR_MASTER_REGISTER");

            entity.Property(e => e.EmpId)
                .HasMaxLength(50)
                .HasColumnName("EMP_ID");
            entity.Property(e => e.EmpAccount)
                .HasMaxLength(50)
                .HasColumnName("EMP_ACCOUNT");
            entity.Property(e => e.EmpBenefitoption)
                .HasMaxLength(100)
                .HasColumnName("EMP_BENEFITOPTION");
            entity.Property(e => e.EmpBirthcountry).HasColumnName("EMP_BIRTHCOUNTRY");
            entity.Property(e => e.EmpCategory)
                .HasMaxLength(20)
                .HasColumnName("EMP_CATEGORY");
            entity.Property(e => e.EmpCity).HasColumnName("EMP_CITY");
            entity.Property(e => e.EmpCompanyname)
                .HasMaxLength(200)
                .IsFixedLength()
                .HasColumnName("EMP_COMPANYNAME");
            entity.Property(e => e.EmpConfirmdate)
                .HasColumnType("date")
                .HasColumnName("EMP_CONFIRMDATE");
            entity.Property(e => e.EmpCv).HasColumnName("EMP_CV");
            entity.Property(e => e.EmpDatejoined)
                .HasColumnType("date")
                .HasColumnName("EMP_DATEJOINED");
            entity.Property(e => e.EmpDept).HasColumnName("EMP_DEPT");
            entity.Property(e => e.EmpDesignation).HasColumnName("EMP_DESIGNATION");
            entity.Property(e => e.EmpDob)
                .HasColumnType("date")
                .HasColumnName("EMP_DOB");
            entity.Property(e => e.EmpEmail)
                .HasMaxLength(50)
                .HasColumnName("EMP_EMAIL");
            entity.Property(e => e.EmpEnteredby)
                .HasMaxLength(50)
                .HasColumnName("EMP_ENTEREDBY");
            entity.Property(e => e.EmpEntrydate)
                .HasColumnType("datetime")
                .HasColumnName("EMP_ENTRYDATE");
            entity.Property(e => e.EmpFirstname)
                .HasMaxLength(50)
                .HasColumnName("EMP_FIRSTNAME");
            entity.Property(e => e.EmpFunctionalmgr)
                .HasMaxLength(50)
                .HasColumnName("EMP_FUNCTIONALMGR");
            entity.Property(e => e.EmpGender)
                .HasMaxLength(10)
                .HasColumnName("EMP_GENDER");
            entity.Property(e => e.EmpGrade).HasColumnName("EMP_GRADE");
            entity.Property(e => e.EmpHealthinsurancenumber)
                .HasMaxLength(50)
                .HasColumnName("EMP_HEALTHINSURANCENUMBER");
            entity.Property(e => e.EmpIsconfirmed)
                .HasMaxLength(50)
                .HasColumnName("EMP_ISCONFIRMED");
            entity.Property(e => e.EmpLastupdatedby)
                .HasMaxLength(50)
                .HasColumnName("EMP_LASTUPDATEDBY");
            entity.Property(e => e.EmpLastupdatedon)
                .HasColumnType("datetime")
                .HasColumnName("EMP_LASTUPDATEDON");
            entity.Property(e => e.EmpLeavingdate)
                .HasColumnType("date")
                .HasColumnName("EMP_LEAVINGDATE");
            entity.Property(e => e.EmpLegalname)
                .HasMaxLength(200)
                .IsFixedLength()
                .HasColumnName("EMP_LEGALNAME");
            entity.Property(e => e.EmpLocation).HasColumnName("EMP_LOCATION");
            entity.Property(e => e.EmpNationality).HasColumnName("EMP_NATIONALITY");
            entity.Property(e => e.EmpOfficeaddress)
                .HasMaxLength(100)
                .HasColumnName("EMP_OFFICEADDRESS");
            entity.Property(e => e.EmpOfficeext)
                .HasMaxLength(50)
                .HasColumnName("EMP_OFFICEEXT");
            entity.Property(e => e.EmpOfficefax)
                .HasMaxLength(50)
                .HasColumnName("EMP_OFFICEFAX");
            entity.Property(e => e.EmpOfficemail)
                .HasMaxLength(50)
                .HasColumnName("EMP_OFFICEMAIL");
            entity.Property(e => e.EmpOfficephone)
                .HasMaxLength(50)
                .HasColumnName("EMP_OFFICEPHONE");
            entity.Property(e => e.EmpOthernames)
                .HasMaxLength(100)
                .HasColumnName("EMP_OTHERNAMES");
            entity.Property(e => e.EmpOu).HasColumnName("EMP_OU");
            entity.Property(e => e.EmpPaygroup).HasColumnName("EMP_PAYGROUP");
            entity.Property(e => e.EmpPaylocation)
                .HasMaxLength(50)
                .HasColumnName("EMP_PAYLOCATION");
            entity.Property(e => e.EmpPaymode)
                .HasMaxLength(50)
                .HasColumnName("EMP_PAYMODE");
            entity.Property(e => e.EmpPhone)
                .HasMaxLength(50)
                .HasColumnName("EMP_PHONE");
            entity.Property(e => e.EmpPhoto).HasColumnName("EMP_PHOTO");
            entity.Property(e => e.EmpPosition).HasColumnName("EMP_POSITION");
            entity.Property(e => e.EmpPostaladdress)
                .HasMaxLength(100)
                .HasColumnName("EMP_POSTALADDRESS");
            entity.Property(e => e.EmpRecruiter)
                .HasMaxLength(100)
                .HasColumnName("EMP_RECRUITER");
            entity.Property(e => e.EmpReference1Address).HasColumnName("EMP_REFERENCE1_ADDRESS");
            entity.Property(e => e.EmpReference1Name)
                .HasMaxLength(200)
                .HasColumnName("EMP_REFERENCE1_NAME");
            entity.Property(e => e.EmpReference1Phone)
                .HasMaxLength(50)
                .HasColumnName("EMP_REFERENCE1_PHONE");
            entity.Property(e => e.EmpReference2Address).HasColumnName("EMP_REFERENCE2_ADDRESS");
            entity.Property(e => e.EmpReference2Name)
                .HasMaxLength(200)
                .HasColumnName("EMP_REFERENCE2_NAME");
            entity.Property(e => e.EmpReference2Phone)
                .HasMaxLength(50)
                .HasColumnName("EMP_REFERENCE2_PHONE");
            entity.Property(e => e.EmpReference3Address).HasColumnName("EMP_REFERENCE3_ADDRESS");
            entity.Property(e => e.EmpReference3Name)
                .HasMaxLength(200)
                .HasColumnName("EMP_REFERENCE3_NAME");
            entity.Property(e => e.EmpReference3Phone)
                .HasMaxLength(50)
                .HasColumnName("EMP_REFERENCE3_PHONE");
            entity.Property(e => e.EmpRegion).HasColumnName("EMP_REGION");
            entity.Property(e => e.EmpResidentialaddress)
                .HasMaxLength(100)
                .HasColumnName("EMP_RESIDENTIALADDRESS");
            entity.Property(e => e.EmpSalutation)
                .HasMaxLength(10)
                .HasColumnName("EMP_SALUTATION");
            entity.Property(e => e.EmpSsn)
                .HasMaxLength(50)
                .HasColumnName("EMP_SSN");
            entity.Property(e => e.EmpStatus).HasColumnName("EMP_STATUS");
            entity.Property(e => e.EmpSupervisor)
                .HasMaxLength(50)
                .HasColumnName("EMP_SUPERVISOR");
            entity.Property(e => e.EmpSurname)
                .HasMaxLength(50)
                .HasColumnName("EMP_SURNAME");
            entity.Property(e => e.EmpTin)
                .HasMaxLength(50)
                .HasColumnName("EMP_TIN");
            entity.Property(e => e.EmpType)
                .HasMaxLength(20)
                .HasColumnName("EMP_TYPE");
            entity.Property(e => e.FdCertificate).HasColumnName("FD_CERTIFICATE");
            entity.Property(e => e.FdDateobtained)
                .HasColumnType("date")
                .HasColumnName("FD_DATEOBTAINED");
            entity.Property(e => e.FdInstitution)
                .HasMaxLength(200)
                .HasColumnName("FD_INSTITUTION");
            entity.Property(e => e.FdQualification)
                .HasMaxLength(200)
                .HasColumnName("FD_QUALIFICATION");
            entity.Property(e => e.P1Certificate).HasColumnName("P1_CERTIFICATE");
            entity.Property(e => e.P1Dateobtained)
                .HasColumnType("date")
                .HasColumnName("P1_DATEOBTAINED");
            entity.Property(e => e.P1Institution)
                .HasMaxLength(200)
                .HasColumnName("P1_INSTITUTION");
            entity.Property(e => e.P1Qualification)
                .HasMaxLength(200)
                .HasColumnName("P1_QUALIFICATION");
            entity.Property(e => e.P2Certificate).HasColumnName("P2_CERTIFICATE");
            entity.Property(e => e.P2Dateobtained)
                .HasColumnType("date")
                .HasColumnName("P2_DATEOBTAINED");
            entity.Property(e => e.P2Institution)
                .HasMaxLength(200)
                .HasColumnName("P2_INSTITUTION");
            entity.Property(e => e.P2Qualification)
                .HasMaxLength(200)
                .HasColumnName("P2_QUALIFICATION");
            entity.Property(e => e.P3Certificate).HasColumnName("P3_CERTIFICATE");
            entity.Property(e => e.P3Dateobtained)
                .HasColumnType("date")
                .HasColumnName("P3_DATEOBTAINED");
            entity.Property(e => e.P3Institution)
                .HasMaxLength(200)
                .HasColumnName("P3_INSTITUTION");
            entity.Property(e => e.P3Qualification)
                .HasMaxLength(200)
                .HasColumnName("P3_QUALIFICATION");
            entity.Property(e => e.P4Certificate).HasColumnName("P4_CERTIFICATE");
            entity.Property(e => e.P4Dateobtained)
                .HasColumnType("date")
                .HasColumnName("P4_DATEOBTAINED");
            entity.Property(e => e.P4Institution)
                .HasMaxLength(200)
                .HasColumnName("P4_INSTITUTION");
            entity.Property(e => e.P4Qualification)
                .HasMaxLength(200)
                .HasColumnName("P4_QUALIFICATION");
            entity.Property(e => e.P5Certificate).HasColumnName("P5_CERTIFICATE");
            entity.Property(e => e.P5Dateobtained)
                .HasColumnType("date")
                .HasColumnName("P5_DATEOBTAINED");
            entity.Property(e => e.P5Institution)
                .HasMaxLength(200)
                .HasColumnName("P5_INSTITUTION");
            entity.Property(e => e.P5Qualification)
                .HasMaxLength(200)
                .HasColumnName("P5_QUALIFICATION");
            entity.Property(e => e.SdCertificate).HasColumnName("SD_CERTIFICATE");
            entity.Property(e => e.SdDateobtained)
                .HasColumnType("date")
                .HasColumnName("SD_DATEOBTAINED");
            entity.Property(e => e.SdInstitution)
                .HasMaxLength(200)
                .HasColumnName("SD_INSTITUTION");
            entity.Property(e => e.SdQualification)
                .HasMaxLength(200)
                .HasColumnName("SD_QUALIFICATION");
        });

        modelBuilder.Entity<Hrmaster>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("hrmaster");

            entity.Property(e => e.Accountno)
                .HasMaxLength(200)
                .HasColumnName("ACCOUNTNO");
            entity.Property(e => e.Benefitoption)
                .HasMaxLength(200)
                .HasColumnName("BENEFITOPTION");
            entity.Property(e => e.Birthcountry)
                .HasMaxLength(50)
                .HasColumnName("BIRTHCOUNTRY");
            entity.Property(e => e.Category)
                .HasMaxLength(200)
                .HasColumnName("CATEGORY");
            entity.Property(e => e.Confirmation)
                .HasMaxLength(50)
                .HasColumnName("CONFIRMATION");
            entity.Property(e => e.Dept)
                .HasMaxLength(200)
                .HasColumnName("DEPT");
            entity.Property(e => e.Dob)
                .HasColumnType("date")
                .HasColumnName("DOB");
            entity.Property(e => e.Doj)
                .HasColumnType("date")
                .HasColumnName("DOJ");
            entity.Property(e => e.Email)
                .HasMaxLength(200)
                .HasColumnName("EMAIL");
            entity.Property(e => e.Firstname)
                .HasMaxLength(200)
                .HasColumnName("FIRSTNAME");
            entity.Property(e => e.Fullname)
                .HasMaxLength(200)
                .HasColumnName("FULLNAME");
            entity.Property(e => e.Gender)
                .HasMaxLength(50)
                .HasColumnName("GENDER");
            entity.Property(e => e.Grade)
                .HasMaxLength(50)
                .HasColumnName("GRADE");
            entity.Property(e => e.Hin)
                .HasMaxLength(50)
                .HasColumnName("HIN");
            entity.Property(e => e.Location)
                .HasMaxLength(200)
                .HasColumnName("LOCATION");
            entity.Property(e => e.Nationality)
                .HasMaxLength(50)
                .HasColumnName("NATIONALITY");
            entity.Property(e => e.Phoneno)
                .HasMaxLength(50)
                .HasColumnName("PHONENO");
            entity.Property(e => e.Role)
                .HasMaxLength(200)
                .HasColumnName("ROLE");
            entity.Property(e => e.Ssn)
                .HasMaxLength(50)
                .HasColumnName("SSN");
            entity.Property(e => e.Staffid)
                .HasMaxLength(50)
                .IsFixedLength()
                .HasColumnName("STAFFID");
            entity.Property(e => e.Stafftype)
                .HasMaxLength(50)
                .HasColumnName("STAFFTYPE");
            entity.Property(e => e.Tin)
                .HasMaxLength(50)
                .HasColumnName("TIN");
        });

        modelBuilder.Entity<HroperatorRole>(entity =>
        {
            entity.HasKey(e => new { e.LoginId, e.EmpId }).HasName("PK_HROPREATOR_ROLES");

            entity.ToTable("HROPERATOR_ROLES");

            entity.Property(e => e.LoginId)
                .HasMaxLength(50)
                .HasColumnName("LOGIN_ID");
            entity.Property(e => e.EmpId)
                .HasMaxLength(50)
                .HasColumnName("EMP_ID");
            entity.Property(e => e.Enteredby)
                .HasMaxLength(50)
                .HasColumnName("ENTEREDBY");
            entity.Property(e => e.Entrydate)
                .HasColumnType("datetime")
                .HasColumnName("ENTRYDATE");
            entity.Property(e => e.HrRole)
                .HasMaxLength(50)
                .HasColumnName("HR_ROLE");
            entity.Property(e => e.Lastupdatedate)
                .HasColumnType("datetime")
                .HasColumnName("LASTUPDATEDATE");
            entity.Property(e => e.Lastupdatedby)
                .HasMaxLength(50)
                .HasColumnName("LASTUPDATEDBY");
            entity.Property(e => e.Status).HasColumnName("STATUS");
        });

        modelBuilder.Entity<LeaveAllowance>(entity =>
        {
            entity.HasKey(e => e.LaId);

            entity.ToTable("LEAVE_ALLOWANCE");

            entity.Property(e => e.LaId)
                .ValueGeneratedNever()
                .HasColumnName("LA_ID");
            entity.Property(e => e.Approveby)
                .HasMaxLength(50)
                .HasColumnName("APPROVEBY");
            entity.Property(e => e.Approvedate)
                .HasColumnType("datetime")
                .HasColumnName("APPROVEDATE");
            entity.Property(e => e.EmpId)
                .HasMaxLength(50)
                .HasColumnName("EMP_ID");
            entity.Property(e => e.Enteredby)
                .HasMaxLength(50)
                .HasColumnName("ENTEREDBY");
            entity.Property(e => e.Entrydate)
                .HasColumnType("datetime")
                .HasColumnName("ENTRYDATE");
            entity.Property(e => e.Lastupdatedby)
                .HasMaxLength(50)
                .HasColumnName("LASTUPDATEDBY");
            entity.Property(e => e.Lastupdatedon)
                .HasColumnType("datetime")
                .HasColumnName("LASTUPDATEDON");
            entity.Property(e => e.LbCurrentuser)
                .HasMaxLength(50)
                .HasColumnName("LB_CURRENTUSER");
            entity.Property(e => e.LeaveAllowance1)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("LEAVE_ALLOWANCE");
            entity.Property(e => e.LeaveYear)
                .HasMaxLength(4)
                .HasColumnName("LEAVE_YEAR");
            entity.Property(e => e.OldAllowance)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("OLD_ALLOWANCE");
            entity.Property(e => e.Rejectdate)
                .HasColumnType("datetime")
                .HasColumnName("REJECTDATE");
            entity.Property(e => e.Rejectedby)
                .HasMaxLength(50)
                .HasColumnName("REJECTEDBY");
            entity.Property(e => e.Rejectreason).HasColumnName("REJECTREASON");
            entity.Property(e => e.Status).HasColumnName("STATUS");
        });

        modelBuilder.Entity<LeaveBalance>(entity =>
        {
            entity.HasKey(e => e.LbId);

            entity.ToTable("LEAVE_BALANCE");

            entity.Property(e => e.LbId)
                .ValueGeneratedNever()
                .HasColumnName("LB_ID");
            entity.Property(e => e.Approveby)
                .HasMaxLength(50)
                .HasColumnName("APPROVEBY");
            entity.Property(e => e.Approvedate)
                .HasColumnType("datetime")
                .HasColumnName("APPROVEDATE");
            entity.Property(e => e.BalBefore).HasColumnName("BAL_BEFORE");
            entity.Property(e => e.Changeby)
                .HasMaxLength(50)
                .HasColumnName("CHANGEBY");
            entity.Property(e => e.Changedate)
                .HasColumnType("datetime")
                .HasColumnName("CHANGEDATE");
            entity.Property(e => e.EmpId)
                .HasMaxLength(50)
                .HasColumnName("EMP_ID");
            entity.Property(e => e.LbCurrentuser)
                .HasMaxLength(50)
                .HasColumnName("LB_CURRENTUSER");
            entity.Property(e => e.LeaveYear)
                .HasMaxLength(4)
                .HasColumnName("LEAVE_YEAR");
            entity.Property(e => e.NewBal).HasColumnName("NEW_BAL");
            entity.Property(e => e.Rejectdate)
                .HasColumnType("datetime")
                .HasColumnName("REJECTDATE");
            entity.Property(e => e.Rejectedby)
                .HasMaxLength(50)
                .HasColumnName("REJECTEDBY");
            entity.Property(e => e.Rejectreason).HasColumnName("REJECTREASON");
            entity.Property(e => e.Status).HasColumnName("STATUS");
        });

        modelBuilder.Entity<LeaveDay>(entity =>
        {
            entity.HasKey(e => e.GradeCode);

            entity.ToTable("LEAVE_DAYS");

            entity.Property(e => e.GradeCode)
                .ValueGeneratedNever()
                .HasColumnName("GRADE_CODE");
            entity.Property(e => e.Allowance)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("ALLOWANCE");
            entity.Property(e => e.Enteredby)
                .HasMaxLength(50)
                .HasColumnName("ENTEREDBY");
            entity.Property(e => e.Entrydate)
                .HasColumnType("datetime")
                .HasColumnName("ENTRYDATE");
            entity.Property(e => e.Lastupdatedby)
                .HasMaxLength(50)
                .HasColumnName("LASTUPDATEDBY");
            entity.Property(e => e.Lastupdatedon)
                .HasColumnType("datetime")
                .HasColumnName("LASTUPDATEDON");
            entity.Property(e => e.TotalDays).HasColumnName("TOTAL_DAYS");
        });

        modelBuilder.Entity<LeavePayment>(entity =>
        {
            entity.HasKey(e => e.RequestId);

            entity.ToTable("LEAVE_PAYMENT");

            entity.Property(e => e.RequestId)
                .ValueGeneratedNever()
                .HasColumnName("REQUEST_ID");
            entity.Property(e => e.Checker)
                .HasMaxLength(50)
                .HasColumnName("CHECKER");
            entity.Property(e => e.CheckerReason).HasColumnName("CHECKER_REASON");
            entity.Property(e => e.Checkerdate)
                .HasColumnType("datetime")
                .HasColumnName("CHECKERDATE");
            entity.Property(e => e.Maker)
                .HasMaxLength(50)
                .HasColumnName("MAKER");
            entity.Property(e => e.MakerReason).HasColumnName("MAKER_REASON");
            entity.Property(e => e.Makerdate)
                .HasColumnType("datetime")
                .HasColumnName("MAKERDATE");
            entity.Property(e => e.Status).HasColumnName("STATUS");
        });

        modelBuilder.Entity<LeavePlan>(entity =>
        {
            entity.HasKey(e => e.LpId);

            entity.ToTable("LEAVE_PLAN");

            entity.Property(e => e.LpId)
                .ValueGeneratedNever()
                .HasColumnName("LP_ID");
            entity.Property(e => e.EmpId)
                .HasMaxLength(50)
                .HasColumnName("EMP_ID");
            entity.Property(e => e.Enteredby)
                .HasMaxLength(50)
                .HasColumnName("ENTEREDBY");
            entity.Property(e => e.Entrydate)
                .HasColumnType("datetime")
                .HasColumnName("ENTRYDATE");
            entity.Property(e => e.Lastupdatedby)
                .HasMaxLength(50)
                .HasColumnName("LASTUPDATEDBY");
            entity.Property(e => e.Lastupdatedon)
                .HasColumnType("datetime")
                .HasColumnName("LASTUPDATEDON");
            entity.Property(e => e.LeaveYear)
                .HasMaxLength(4)
                .HasColumnName("LEAVE_YEAR");
            entity.Property(e => e.LpCurrentuser)
                .HasMaxLength(50)
                .HasColumnName("LP_CURRENTUSER");
            entity.Property(e => e.OverallTraverse).HasColumnName("OVERALL_TRAVERSE");
            entity.Property(e => e.Rejectreason).HasColumnName("REJECTREASON");
            entity.Property(e => e.Reviewdate)
                .HasColumnType("datetime")
                .HasColumnName("REVIEWDATE");
            entity.Property(e => e.Reviewedby)
                .HasMaxLength(50)
                .HasColumnName("REVIEWEDBY");
            entity.Property(e => e.Status).HasColumnName("STATUS");
            entity.Property(e => e.TraverseFourDays).HasColumnName("TRAVERSE_FOUR_DAYS");
            entity.Property(e => e.TraverseFourEnddate)
                .HasColumnType("date")
                .HasColumnName("TRAVERSE_FOUR_ENDDATE");
            entity.Property(e => e.TraverseFourStartdate)
                .HasColumnType("date")
                .HasColumnName("TRAVERSE_FOUR_STARTDATE");
            entity.Property(e => e.TraverseOneDays).HasColumnName("TRAVERSE_ONE_DAYS");
            entity.Property(e => e.TraverseOneEnddate)
                .HasColumnType("date")
                .HasColumnName("TRAVERSE_ONE_ENDDATE");
            entity.Property(e => e.TraverseOneStartdate)
                .HasColumnType("date")
                .HasColumnName("TRAVERSE_ONE_STARTDATE");
            entity.Property(e => e.TraverseThreeDays).HasColumnName("TRAVERSE_THREE_DAYS");
            entity.Property(e => e.TraverseThreeEnddate)
                .HasColumnType("date")
                .HasColumnName("TRAVERSE_THREE_ENDDATE");
            entity.Property(e => e.TraverseThreeStartdate)
                .HasColumnType("date")
                .HasColumnName("TRAVERSE_THREE_STARTDATE");
            entity.Property(e => e.TraverseTwoDays).HasColumnName("TRAVERSE_TWO_DAYS");
            entity.Property(e => e.TraverseTwoEnddate)
                .HasColumnType("date")
                .HasColumnName("TRAVERSE_TWO_ENDDATE");
            entity.Property(e => e.TraverseTwoStartdate)
                .HasColumnType("date")
                .HasColumnName("TRAVERSE_TWO_STARTDATE");

            entity.HasOne(d => d.StatusNavigation).WithMany(p => p.LeavePlans)
                .HasForeignKey(d => d.Status)
                .HasConstraintName("FK_LEAVE_PLAN_LEAVE_PLAN_STATUS");
        });

        modelBuilder.Entity<LeavePlanStatus>(entity =>
        {
            entity.HasKey(e => e.LpId);

            entity.ToTable("LEAVE_PLAN_STATUS");

            entity.Property(e => e.LpId)
                .ValueGeneratedNever()
                .HasColumnName("LP_ID");
            entity.Property(e => e.LpDesc)
                .HasMaxLength(100)
                .HasColumnName("LP_DESC");
            entity.Property(e => e.LpName)
                .HasMaxLength(50)
                .HasColumnName("LP_NAME");
        });

        modelBuilder.Entity<LeaveRequest>(entity =>
        {
            entity.HasKey(e => e.RequestId);

            entity.ToTable("LEAVE_REQUEST");

            entity.Property(e => e.RequestId)
                .ValueGeneratedNever()
                .HasColumnName("REQUEST_ID");
            entity.Property(e => e.Approvedate)
                .HasColumnType("datetime")
                .HasColumnName("APPROVEDATE");
            entity.Property(e => e.Approvedby)
                .HasMaxLength(50)
                .HasColumnName("APPROVEDBY");
            entity.Property(e => e.ContactNumber)
                .HasMaxLength(50)
                .HasColumnName("CONTACT_NUMBER");
            entity.Property(e => e.Declinedate)
                .HasColumnType("datetime")
                .HasColumnName("DECLINEDATE");
            entity.Property(e => e.Declinedby)
                .HasMaxLength(50)
                .HasColumnName("DECLINEDBY");
            entity.Property(e => e.Declinereason).HasColumnName("DECLINEREASON");
            entity.Property(e => e.EndDate)
                .HasColumnType("date")
                .HasColumnName("END_DATE");
            entity.Property(e => e.Enteredby)
                .HasMaxLength(50)
                .HasColumnName("ENTEREDBY");
            entity.Property(e => e.Entrydate)
                .HasColumnType("datetime")
                .HasColumnName("ENTRYDATE");
            entity.Property(e => e.HandOverTo)
                .HasMaxLength(50)
                .HasColumnName("HAND_OVER_TO");
            entity.Property(e => e.HandingOverNotes).HasColumnName("HANDING_OVER_NOTES");
            entity.Property(e => e.HandingOverNotesContentType)
                .HasMaxLength(256)
                .HasColumnName("HANDING_OVER_NOTES_CONTENT_TYPE");
            entity.Property(e => e.LeaveType).HasColumnName("LEAVE_TYPE");
            entity.Property(e => e.LeaveTypeCustom).HasColumnName("LEAVE_TYPE_CUSTOM");
            entity.Property(e => e.NumDays).HasColumnName("NUM_DAYS");
            entity.Property(e => e.PaidBy)
                .HasMaxLength(50)
                .HasColumnName("PAID_BY");
            entity.Property(e => e.PayAllowance)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("PAY_ALLOWANCE");
            entity.Property(e => e.PayDate)
                .HasColumnType("datetime")
                .HasColumnName("PAY_DATE");
            entity.Property(e => e.PayStatus).HasColumnName("PAY_STATUS");
            entity.Property(e => e.Rejectdate)
                .HasColumnType("datetime")
                .HasColumnName("REJECTDATE");
            entity.Property(e => e.Rejectedby)
                .HasMaxLength(50)
                .HasColumnName("REJECTEDBY");
            entity.Property(e => e.Rejectreason).HasColumnName("REJECTREASON");
            entity.Property(e => e.RequestCurrentuser)
                .HasMaxLength(50)
                .HasColumnName("REQUEST_CURRENTUSER");
            entity.Property(e => e.RequestOwner)
                .HasMaxLength(50)
                .HasColumnName("REQUEST_OWNER");
            entity.Property(e => e.RequestYear)
                .HasMaxLength(4)
                .HasColumnName("REQUEST_YEAR");
            entity.Property(e => e.Revertdate)
                .HasColumnType("datetime")
                .HasColumnName("REVERTDATE");
            entity.Property(e => e.Revertedby)
                .HasMaxLength(50)
                .HasColumnName("REVERTEDBY");
            entity.Property(e => e.Revertreason).HasColumnName("REVERTREASON");
            entity.Property(e => e.Reviewdate)
                .HasColumnType("datetime")
                .HasColumnName("REVIEWDATE");
            entity.Property(e => e.Reviewedby)
                .HasMaxLength(50)
                .HasColumnName("REVIEWEDBY");
            entity.Property(e => e.StartDate)
                .HasColumnType("date")
                .HasColumnName("START_DATE");
            entity.Property(e => e.Status).HasColumnName("STATUS");
            entity.Property(e => e.SupportingDocx).HasColumnName("SUPPORTING_DOCX");
            entity.Property(e => e.SupportingDocxContentType)
                .HasMaxLength(256)
                .HasColumnName("SUPPORTING_DOCX_CONTENT_TYPE");

            entity.HasOne(d => d.StatusNavigation).WithMany(p => p.LeaveRequests)
                .HasForeignKey(d => d.Status)
                .HasConstraintName("FK_LEAVE_REQUEST_LEAVE_REQUEST_STATUS");
        });

        modelBuilder.Entity<LeaveRequestStatus>(entity =>
        {
            entity.HasKey(e => e.LsId).HasName("PK_LEAVE_STATUS");

            entity.ToTable("LEAVE_REQUEST_STATUS");

            entity.Property(e => e.LsId)
                .ValueGeneratedNever()
                .HasColumnName("LS_ID");
            entity.Property(e => e.LsDesc)
                .HasMaxLength(100)
                .HasColumnName("LS_DESC");
            entity.Property(e => e.LsName)
                .HasMaxLength(50)
                .HasColumnName("LS_NAME");
        });

        modelBuilder.Entity<LeaveSetup>(entity =>
        {
            entity.HasKey(e => new { e.EmpId, e.LeaveYear });

            entity.ToTable("LEAVE_SETUP");

            entity.Property(e => e.EmpId)
                .HasMaxLength(50)
                .HasColumnName("EMP_ID");
            entity.Property(e => e.LeaveYear)
                .HasMaxLength(4)
                .HasColumnName("LEAVE_YEAR");
            entity.Property(e => e.Approvedate)
                .HasColumnType("datetime")
                .HasColumnName("APPROVEDATE");
            entity.Property(e => e.Approvedby)
                .HasMaxLength(50)
                .HasColumnName("APPROVEDBY");
            entity.Property(e => e.Enteredby)
                .HasMaxLength(50)
                .HasColumnName("ENTEREDBY");
            entity.Property(e => e.Entrydate)
                .HasColumnType("datetime")
                .HasColumnName("ENTRYDATE");
            entity.Property(e => e.Lastupdatedby)
                .HasMaxLength(50)
                .HasColumnName("LASTUPDATEDBY");
            entity.Property(e => e.Lastupdatedon)
                .HasColumnType("datetime")
                .HasColumnName("LASTUPDATEDON");
            entity.Property(e => e.LsCurrentuser)
                .HasMaxLength(50)
                .HasColumnName("LS_CURRENTUSER");
            entity.Property(e => e.Status).HasColumnName("STATUS");
            entity.Property(e => e.TotalDays).HasColumnName("TOTAL_DAYS");

            entity.HasOne(d => d.StatusNavigation).WithMany(p => p.LeaveSetups)
                .HasForeignKey(d => d.Status)
                .HasConstraintName("FK_LEAVE_SETUP_LEAVE_SETUP_STATUS");
        });

        modelBuilder.Entity<LeaveSetupStatus>(entity =>
        {
            entity.HasKey(e => e.LsId);

            entity.ToTable("LEAVE_SETUP_STATUS");

            entity.Property(e => e.LsId)
                .ValueGeneratedNever()
                .HasColumnName("LS_ID");
            entity.Property(e => e.LsDesc)
                .HasMaxLength(100)
                .HasColumnName("LS_DESC");
            entity.Property(e => e.LsName)
                .HasMaxLength(50)
                .HasColumnName("LS_NAME");
        });

        modelBuilder.Entity<LeaveType>(entity =>
        {
            entity.HasKey(e => e.LeaveTypeId).HasName("PK_LEAVE_TYPES");

            entity.ToTable("LEAVE_TYPE");

            entity.Property(e => e.LeaveTypeId)
                .ValueGeneratedNever()
                .HasColumnName("LEAVE_TYPE_ID");
            entity.Property(e => e.Enteredby)
                .HasMaxLength(50)
                .HasColumnName("ENTEREDBY");
            entity.Property(e => e.Entrydate)
                .HasColumnType("datetime")
                .HasColumnName("ENTRYDATE");
            entity.Property(e => e.Lastupdatedby)
                .HasMaxLength(50)
                .HasColumnName("LASTUPDATEDBY");
            entity.Property(e => e.Lastupdatedon)
                .HasColumnType("datetime")
                .HasColumnName("LASTUPDATEDON");
            entity.Property(e => e.LeaveTypeDesc).HasColumnName("LEAVE_TYPE_DESC");
            entity.Property(e => e.LeaveTypeName)
                .HasMaxLength(100)
                .HasColumnName("LEAVE_TYPE_NAME");
        });

        modelBuilder.Entity<LocalAuth>(entity =>
        {
            entity.ToTable("LocalAuth");

            entity.Property(e => e.Id).HasMaxLength(128);
            entity.Property(e => e.CreatedAt).HasColumnType("datetime");
            entity.Property(e => e.CreatedById).HasMaxLength(128);
            entity.Property(e => e.Email).HasMaxLength(255);
            entity.Property(e => e.FirstName).HasMaxLength(255);
            entity.Property(e => e.LastName).HasMaxLength(255);
            entity.Property(e => e.Password).HasMaxLength(300);
            entity.Property(e => e.PhoneNumber).HasMaxLength(20);
            entity.Property(e => e.Role).HasMaxLength(50);
            entity.Property(e => e.UpdatedAt).HasColumnType("datetime");
            entity.Property(e => e.UpdatedById).HasMaxLength(128);
            entity.Property(e => e.Username).HasMaxLength(128);
        });

        modelBuilder.Entity<Location>(entity =>
        {
            entity.ToTable("LOCATION");

            entity.Property(e => e.LocationId)
                .ValueGeneratedNever()
                .HasColumnName("LOCATION_ID");
            entity.Property(e => e.LocationCityCode)
                .HasMaxLength(16)
                .IsFixedLength()
                .HasColumnName("LOCATION_CITY_CODE");
            entity.Property(e => e.LocationEnteredby)
                .HasMaxLength(50)
                .HasColumnName("LOCATION_ENTEREDBY");
            entity.Property(e => e.LocationEntrydate)
                .HasColumnType("datetime")
                .HasColumnName("LOCATION_ENTRYDATE");
            entity.Property(e => e.LocationLastupdatedby)
                .HasMaxLength(50)
                .HasColumnName("LOCATION_LASTUPDATEDBY");
            entity.Property(e => e.LocationLastupdatedon)
                .HasColumnType("datetime")
                .HasColumnName("LOCATION_LASTUPDATEDON");
            entity.Property(e => e.LocationName)
                .HasMaxLength(256)
                .HasColumnName("LOCATION_NAME");
            entity.Property(e => e.LocationStatus).HasColumnName("LOCATION_STATUS");
        });

        modelBuilder.Entity<MakerChecker>(entity =>
        {
            entity.HasKey(e => e.McId);

            entity.ToTable("MAKER_CHECKER");

            entity.Property(e => e.McId)
                .ValueGeneratedNever()
                .HasColumnName("MC_ID");
            entity.Property(e => e.Checker)
                .HasMaxLength(10)
                .HasColumnName("CHECKER");
            entity.Property(e => e.Enteredby)
                .HasMaxLength(50)
                .HasColumnName("ENTEREDBY");
            entity.Property(e => e.Entrydate)
                .HasColumnType("datetime")
                .HasColumnName("ENTRYDATE");
            entity.Property(e => e.Isactive).HasColumnName("ISACTIVE");
            entity.Property(e => e.Lastupdateby)
                .HasMaxLength(50)
                .HasColumnName("LASTUPDATEBY");
            entity.Property(e => e.Lastupdatedon)
                .HasColumnType("datetime")
                .HasColumnName("LASTUPDATEDON");
            entity.Property(e => e.Maker)
                .HasMaxLength(10)
                .HasColumnName("MAKER");
            entity.Property(e => e.PageDesc)
                .HasMaxLength(255)
                .HasColumnName("PAGE_DESC");
            entity.Property(e => e.PageId).HasColumnName("PAGE_ID");
            entity.Property(e => e.PageName)
                .HasMaxLength(100)
                .HasColumnName("PAGE_NAME");
        });

        modelBuilder.Entity<MigrationHistory>(entity =>
        {
            entity.HasKey(e => new { e.MigrationId, e.ContextKey }).HasName("PK_dbo.__MigrationHistory");

            entity.ToTable("__MigrationHistory");

            entity.Property(e => e.MigrationId).HasMaxLength(150);
            entity.Property(e => e.ContextKey).HasMaxLength(300);
            entity.Property(e => e.ProductVersion).HasMaxLength(32);
        });

        modelBuilder.Entity<Otp>(entity =>
        {
            entity.ToTable("OTP");

            entity.Property(e => e.CreatedAt).HasColumnType("datetime");
            entity.Property(e => e.FailedAt).HasColumnType("datetime");
            entity.Property(e => e.Otp1)
                .HasMaxLength(255)
                .IsFixedLength()
                .HasColumnName("OTP");
            entity.Property(e => e.Token)
                .HasMaxLength(255)
                .IsFixedLength();
            entity.Property(e => e.UserId)
                .HasMaxLength(100)
                .IsFixedLength();
        });

        modelBuilder.Entity<Ou>(entity =>
        {
            entity.ToTable("OU");

            entity.Property(e => e.OuId)
                .ValueGeneratedNever()
                .HasColumnName("OU_ID");
            entity.Property(e => e.Category)
                .HasMaxLength(50)
                .HasColumnName("CATEGORY");
            entity.Property(e => e.OuApprovedate)
                .HasColumnType("datetime")
                .HasColumnName("OU_APPROVEDATE");
            entity.Property(e => e.OuApprovedby)
                .HasMaxLength(50)
                .HasColumnName("OU_APPROVEDBY");
            entity.Property(e => e.OuCode)
                .HasMaxLength(50)
                .HasColumnName("OU_CODE");
            entity.Property(e => e.OuCodename)
                .HasMaxLength(100)
                .HasColumnName("OU_CODENAME");
            entity.Property(e => e.OuEnteredby)
                .HasMaxLength(50)
                .HasColumnName("OU_ENTEREDBY");
            entity.Property(e => e.OuEntrydate)
                .HasColumnType("datetime")
                .HasColumnName("OU_ENTRYDATE");
            entity.Property(e => e.OuIsactive).HasColumnName("OU_ISACTIVE");
            entity.Property(e => e.OuIsapproved).HasColumnName("OU_ISAPPROVED");
            entity.Property(e => e.OuName)
                .HasMaxLength(100)
                .HasColumnName("OU_NAME");
            entity.Property(e => e.OuParentOuId).HasColumnName("OU_PARENT_OU_ID");
        });

        modelBuilder.Entity<Paygroup>(entity =>
        {
            entity.ToTable("PAYGROUP");

            entity.Property(e => e.PaygroupId)
                .ValueGeneratedNever()
                .HasColumnName("PAYGROUP_ID");
            entity.Property(e => e.PaygroupDesc)
                .HasMaxLength(256)
                .HasColumnName("PAYGROUP_DESC");
            entity.Property(e => e.PaygroupEnteredby)
                .HasMaxLength(50)
                .HasColumnName("PAYGROUP_ENTEREDBY");
            entity.Property(e => e.PaygroupEntrydate)
                .HasColumnType("datetime")
                .HasColumnName("PAYGROUP_ENTRYDATE");
            entity.Property(e => e.PaygroupLastupdatedby)
                .HasMaxLength(50)
                .HasColumnName("PAYGROUP_LASTUPDATEDBY");
            entity.Property(e => e.PaygroupLastupdatedon)
                .HasColumnType("datetime")
                .HasColumnName("PAYGROUP_LASTUPDATEDON");
            entity.Property(e => e.PaygroupName)
                .HasMaxLength(256)
                .HasColumnName("PAYGROUP_NAME");
            entity.Property(e => e.PaygroupStatus).HasColumnName("PAYGROUP_STATUS");
        });

        modelBuilder.Entity<Position>(entity =>
        {
            entity.HasKey(e => e.PosId);

            entity.ToTable("POSITION");

            entity.Property(e => e.PosId)
                .ValueGeneratedNever()
                .HasColumnName("POS_ID");
            entity.Property(e => e.PosDesc)
                .HasMaxLength(256)
                .HasColumnName("POS_DESC");
            entity.Property(e => e.PosEnteredby)
                .HasMaxLength(50)
                .HasColumnName("POS_ENTEREDBY");
            entity.Property(e => e.PosEntrydate)
                .HasColumnType("datetime")
                .HasColumnName("POS_ENTRYDATE");
            entity.Property(e => e.PosLastupdatedby)
                .HasMaxLength(50)
                .HasColumnName("POS_LASTUPDATEDBY");
            entity.Property(e => e.PosLastupdatedon)
                .HasColumnType("datetime")
                .HasColumnName("POS_LASTUPDATEDON");
            entity.Property(e => e.PosNo)
                .HasMaxLength(10)
                .HasColumnName("POS_NO");
            entity.Property(e => e.PosStatus).HasColumnName("POS_STATUS");
            entity.Property(e => e.PosTitle)
                .HasMaxLength(256)
                .HasColumnName("POS_TITLE");
        });

        modelBuilder.Entity<PrDisableSetup>(entity =>
        {
            entity.ToTable("PR_DISABLE_SETUP");

            entity.Property(e => e.ApproveDate).HasColumnType("datetime");
            entity.Property(e => e.ApprovedBy).HasMaxLength(256);
            entity.Property(e => e.CarElement).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.ConsolidatedSalary).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.CreatedBy).HasMaxLength(256);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.GradeNotch).HasMaxLength(50);
            entity.Property(e => e.ModifiedBy).HasMaxLength(256);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.RentElement).HasColumnType("decimal(18, 2)");
        });

        modelBuilder.Entity<PrMaster>(entity =>
        {
            entity.ToTable("PR_Master");

            entity.Property(e => e.AccountNumber).HasMaxLength(20);
            entity.Property(e => e.ActingAllowance).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.ApproveDate).HasColumnType("datetime");
            entity.Property(e => e.ApprovedBy).HasMaxLength(256);
            entity.Property(e => e.CarElement).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.CfoappStatus)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("CFOAppStatus");
            entity.Property(e => e.Cfoapprover)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CFOApprover");
            entity.Property(e => e.CfotimeStamp)
                .HasColumnType("datetime")
                .HasColumnName("CFOTimeStamp");
            entity.Property(e => e.Clothing).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.ClothingPayable).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.Comment).HasMaxLength(256);
            entity.Property(e => e.ConsolidatedSalary).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.CreatedBy).HasMaxLength(256);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.CurrentTraverse)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("Current_Traverse");
            entity.Property(e => e.CurrentlyWith)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Currently_With");
            entity.Property(e => e.Department).HasMaxLength(256);
            entity.Property(e => e.EdappStatus)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("EDAppStatus");
            entity.Property(e => e.Edapprover)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("EDApprover");
            entity.Property(e => e.EdtimeStamp)
                .HasColumnType("datetime")
                .HasColumnName("EDTimeStamp");
            entity.Property(e => e.EmpId)
                .HasMaxLength(256)
                .HasColumnName("EMP_ID");
            entity.Property(e => e.FinconAppStatus)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.FinconApprover)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.FinconTimeStamp).HasColumnType("datetime");
            entity.Property(e => e.Fuel).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.GradeNotch).HasMaxLength(50);
            entity.Property(e => e.Hrapp2Status)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("HRApp2_Status");
            entity.Property(e => e.Hrapp2TimeStamp)
                .HasColumnType("datetime")
                .HasColumnName("HRApp2_TimeStamp");
            entity.Property(e => e.Hrapprover2)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("HRApprover2");
            entity.Property(e => e.InsuranceContribution).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.ModifiedBy).HasMaxLength(256);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.Msoscontribution)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("MSOSContribution");
            entity.Property(e => e.Name).HasMaxLength(256);
            entity.Property(e => e.NetSalary).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.PaymentDate).HasColumnType("datetime");
            entity.Property(e => e.PaymentPeriod).HasMaxLength(256);
            entity.Property(e => e.RejectReason)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.RentElement).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Ssfcontribution)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("SSFContribution");
            entity.Property(e => e.Status)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.TakeHome).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Tax).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TaxableSalary).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TotalEmolument).HasColumnType("decimal(18, 2)");
        });

        modelBuilder.Entity<PrMasterBackup>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("pr_master_backup");

            entity.Property(e => e.AccountNumber).HasMaxLength(20);
            entity.Property(e => e.ActingAllowance).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.ApproveDate).HasColumnType("datetime");
            entity.Property(e => e.ApprovedBy).HasMaxLength(256);
            entity.Property(e => e.CarElement).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Clothing).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.ClothingPayable).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.Comment).HasMaxLength(256);
            entity.Property(e => e.ConsolidatedSalary).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.CreatedBy).HasMaxLength(256);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.Department).HasMaxLength(256);
            entity.Property(e => e.EmpId)
                .HasMaxLength(256)
                .HasColumnName("EMP_ID");
            entity.Property(e => e.Fuel).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.GradeNotch).HasMaxLength(50);
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.InsuranceContribution).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.ModifiedBy).HasMaxLength(256);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.Msoscontribution)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("MSOSContribution");
            entity.Property(e => e.Name).HasMaxLength(256);
            entity.Property(e => e.NetSalary).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.PaymentDate).HasColumnType("datetime");
            entity.Property(e => e.PaymentPeriod).HasMaxLength(256);
            entity.Property(e => e.RentElement).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Ssfcontribution)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("SSFContribution");
            entity.Property(e => e.TakeHome).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Tax).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TaxableSalary).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TotalEmolument).HasColumnType("decimal(18, 2)");
        });

        modelBuilder.Entity<PrSetup>(entity =>
        {
            entity.ToTable("PR_Setup");

            entity.Property(e => e.ApproveDate).HasColumnType("datetime");
            entity.Property(e => e.ApprovedBy).HasMaxLength(256);
            entity.Property(e => e.CarElement).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Clothing).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.ConsolidatedSalary).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.CreatedBy).HasMaxLength(256);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.Fuel).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.GradeNotch).HasMaxLength(50);
            entity.Property(e => e.ModifiedBy).HasMaxLength(256);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.RentElement).HasColumnType("decimal(18, 2)");
        });

        modelBuilder.Entity<PrSetupShadow>(entity =>
        {
            entity.ToTable("PR_Setup_Shadow");

            entity.Property(e => e.ApproveDate).HasColumnType("datetime");
            entity.Property(e => e.ApprovedBy).HasMaxLength(256);
            entity.Property(e => e.CarElement).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Clothing).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.ConsolidatedSalary).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.CreatedBy).HasMaxLength(256);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.Fuel).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.GradeNotch).HasMaxLength(50);
            entity.Property(e => e.ModifiedBy).HasMaxLength(256);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.RentElement).HasColumnType("decimal(18, 2)");
        });

        modelBuilder.Entity<PurpleEmployee>(entity =>
        {
            entity.HasKey(e => e.EmpId);

            entity.ToTable("PURPLE_EMPLOYEE");

            entity.Property(e => e.EmpId)
                .HasMaxLength(50)
                .HasColumnName("EMP_ID");
            entity.Property(e => e.EmpAccount)
                .HasMaxLength(50)
                .HasColumnName("EMP_ACCOUNT");
            entity.Property(e => e.EmpBenefitoption)
                .HasMaxLength(100)
                .HasColumnName("EMP_BENEFITOPTION");
            entity.Property(e => e.EmpBirthcountry).HasColumnName("EMP_BIRTHCOUNTRY");
            entity.Property(e => e.EmpCategory)
                .HasMaxLength(20)
                .HasColumnName("EMP_CATEGORY");
            entity.Property(e => e.EmpCity).HasColumnName("EMP_CITY");
            entity.Property(e => e.EmpCompanyname)
                .HasMaxLength(200)
                .IsFixedLength()
                .HasColumnName("EMP_COMPANYNAME");
            entity.Property(e => e.EmpConfirmdate)
                .HasColumnType("date")
                .HasColumnName("EMP_CONFIRMDATE");
            entity.Property(e => e.EmpCv).HasColumnName("EMP_CV");
            entity.Property(e => e.EmpDatejoined)
                .HasColumnType("date")
                .HasColumnName("EMP_DATEJOINED");
            entity.Property(e => e.EmpDept).HasColumnName("EMP_DEPT");
            entity.Property(e => e.EmpDesignation).HasColumnName("EMP_DESIGNATION");
            entity.Property(e => e.EmpDob)
                .HasColumnType("date")
                .HasColumnName("EMP_DOB");
            entity.Property(e => e.EmpEmail)
                .HasMaxLength(50)
                .HasColumnName("EMP_EMAIL");
            entity.Property(e => e.EmpEnteredby)
                .HasMaxLength(50)
                .HasColumnName("EMP_ENTEREDBY");
            entity.Property(e => e.EmpEntrydate)
                .HasColumnType("datetime")
                .HasColumnName("EMP_ENTRYDATE");
            entity.Property(e => e.EmpFirstname)
                .HasMaxLength(50)
                .HasColumnName("EMP_FIRSTNAME");
            entity.Property(e => e.EmpFunctionalmgr)
                .HasMaxLength(10)
                .HasColumnName("EMP_FUNCTIONALMGR");
            entity.Property(e => e.EmpGender)
                .HasMaxLength(10)
                .HasColumnName("EMP_GENDER");
            entity.Property(e => e.EmpGrade).HasColumnName("EMP_GRADE");
            entity.Property(e => e.EmpHealthinsurancenumber)
                .HasMaxLength(50)
                .HasColumnName("EMP_HEALTHINSURANCENUMBER");
            entity.Property(e => e.EmpIsconfirmed)
                .HasMaxLength(50)
                .HasColumnName("EMP_ISCONFIRMED");
            entity.Property(e => e.EmpLastupdatedby)
                .HasMaxLength(50)
                .HasColumnName("EMP_LASTUPDATEDBY");
            entity.Property(e => e.EmpLastupdatedon)
                .HasColumnType("datetime")
                .HasColumnName("EMP_LASTUPDATEDON");
            entity.Property(e => e.EmpLeavingdate)
                .HasColumnType("date")
                .HasColumnName("EMP_LEAVINGDATE");
            entity.Property(e => e.EmpLegalname)
                .HasMaxLength(200)
                .IsFixedLength()
                .HasColumnName("EMP_LEGALNAME");
            entity.Property(e => e.EmpLocation).HasColumnName("EMP_LOCATION");
            entity.Property(e => e.EmpNationality).HasColumnName("EMP_NATIONALITY");
            entity.Property(e => e.EmpOfficeaddress)
                .HasMaxLength(100)
                .HasColumnName("EMP_OFFICEADDRESS");
            entity.Property(e => e.EmpOfficeext)
                .HasMaxLength(50)
                .HasColumnName("EMP_OFFICEEXT");
            entity.Property(e => e.EmpOfficefax)
                .HasMaxLength(50)
                .HasColumnName("EMP_OFFICEFAX");
            entity.Property(e => e.EmpOfficemail)
                .HasMaxLength(50)
                .HasColumnName("EMP_OFFICEMAIL");
            entity.Property(e => e.EmpOfficephone)
                .HasMaxLength(15)
                .HasColumnName("EMP_OFFICEPHONE");
            entity.Property(e => e.EmpOthernames)
                .HasMaxLength(100)
                .HasColumnName("EMP_OTHERNAMES");
            entity.Property(e => e.EmpOu).HasColumnName("EMP_OU");
            entity.Property(e => e.EmpPaygroup).HasColumnName("EMP_PAYGROUP");
            entity.Property(e => e.EmpPaylocation)
                .HasMaxLength(50)
                .HasColumnName("EMP_PAYLOCATION");
            entity.Property(e => e.EmpPaymode)
                .HasMaxLength(50)
                .HasColumnName("EMP_PAYMODE");
            entity.Property(e => e.EmpPhone)
                .HasMaxLength(10)
                .HasColumnName("EMP_PHONE");
            entity.Property(e => e.EmpPhoto).HasColumnName("EMP_PHOTO");
            entity.Property(e => e.EmpPosition).HasColumnName("EMP_POSITION");
            entity.Property(e => e.EmpPostaladdress)
                .HasMaxLength(100)
                .HasColumnName("EMP_POSTALADDRESS");
            entity.Property(e => e.EmpRecruiter)
                .HasMaxLength(100)
                .HasColumnName("EMP_RECRUITER");
            entity.Property(e => e.EmpReference1Address).HasColumnName("EMP_REFERENCE1_ADDRESS");
            entity.Property(e => e.EmpReference1Name)
                .HasMaxLength(200)
                .HasColumnName("EMP_REFERENCE1_NAME");
            entity.Property(e => e.EmpReference1Phone)
                .HasMaxLength(50)
                .HasColumnName("EMP_REFERENCE1_PHONE");
            entity.Property(e => e.EmpReference2Address).HasColumnName("EMP_REFERENCE2_ADDRESS");
            entity.Property(e => e.EmpReference2Name)
                .HasMaxLength(200)
                .HasColumnName("EMP_REFERENCE2_NAME");
            entity.Property(e => e.EmpReference2Phone)
                .HasMaxLength(50)
                .HasColumnName("EMP_REFERENCE2_PHONE");
            entity.Property(e => e.EmpReference3Address).HasColumnName("EMP_REFERENCE3_ADDRESS");
            entity.Property(e => e.EmpReference3Name)
                .HasMaxLength(200)
                .HasColumnName("EMP_REFERENCE3_NAME");
            entity.Property(e => e.EmpReference3Phone)
                .HasMaxLength(50)
                .HasColumnName("EMP_REFERENCE3_PHONE");
            entity.Property(e => e.EmpRegion).HasColumnName("EMP_REGION");
            entity.Property(e => e.EmpResidentialaddress)
                .HasMaxLength(100)
                .HasColumnName("EMP_RESIDENTIALADDRESS");
            entity.Property(e => e.EmpSalutation)
                .HasMaxLength(10)
                .HasColumnName("EMP_SALUTATION");
            entity.Property(e => e.EmpSsn)
                .HasMaxLength(50)
                .HasColumnName("EMP_SSN");
            entity.Property(e => e.EmpStatus).HasColumnName("EMP_STATUS");
            entity.Property(e => e.EmpSupervisor)
                .HasMaxLength(10)
                .HasColumnName("EMP_SUPERVISOR");
            entity.Property(e => e.EmpSurname)
                .HasMaxLength(50)
                .HasColumnName("EMP_SURNAME");
            entity.Property(e => e.EmpTin)
                .HasMaxLength(50)
                .HasColumnName("EMP_TIN");
            entity.Property(e => e.EmpType)
                .HasMaxLength(20)
                .HasColumnName("EMP_TYPE");
            entity.Property(e => e.FdCertificate).HasColumnName("FD_CERTIFICATE");
            entity.Property(e => e.FdDateobtained)
                .HasColumnType("date")
                .HasColumnName("FD_DATEOBTAINED");
            entity.Property(e => e.FdInstitution)
                .HasMaxLength(200)
                .HasColumnName("FD_INSTITUTION");
            entity.Property(e => e.FdQualification)
                .HasMaxLength(200)
                .HasColumnName("FD_QUALIFICATION");
            entity.Property(e => e.P1Certificate).HasColumnName("P1_CERTIFICATE");
            entity.Property(e => e.P1Dateobtained)
                .HasColumnType("date")
                .HasColumnName("P1_DATEOBTAINED");
            entity.Property(e => e.P1Institution)
                .HasMaxLength(200)
                .HasColumnName("P1_INSTITUTION");
            entity.Property(e => e.P1Qualification)
                .HasMaxLength(200)
                .HasColumnName("P1_QUALIFICATION");
            entity.Property(e => e.P2Certificate).HasColumnName("P2_CERTIFICATE");
            entity.Property(e => e.P2Dateobtained)
                .HasColumnType("date")
                .HasColumnName("P2_DATEOBTAINED");
            entity.Property(e => e.P2Institution)
                .HasMaxLength(200)
                .HasColumnName("P2_INSTITUTION");
            entity.Property(e => e.P2Qualification)
                .HasMaxLength(200)
                .HasColumnName("P2_QUALIFICATION");
            entity.Property(e => e.P3Certificate).HasColumnName("P3_CERTIFICATE");
            entity.Property(e => e.P3Dateobtained)
                .HasColumnType("date")
                .HasColumnName("P3_DATEOBTAINED");
            entity.Property(e => e.P3Institution)
                .HasMaxLength(200)
                .HasColumnName("P3_INSTITUTION");
            entity.Property(e => e.P3Qualification)
                .HasMaxLength(200)
                .HasColumnName("P3_QUALIFICATION");
            entity.Property(e => e.P4Certificate).HasColumnName("P4_CERTIFICATE");
            entity.Property(e => e.P4Dateobtained)
                .HasColumnType("date")
                .HasColumnName("P4_DATEOBTAINED");
            entity.Property(e => e.P4Institution)
                .HasMaxLength(200)
                .HasColumnName("P4_INSTITUTION");
            entity.Property(e => e.P4Qualification)
                .HasMaxLength(200)
                .HasColumnName("P4_QUALIFICATION");
            entity.Property(e => e.P5Certificate).HasColumnName("P5_CERTIFICATE");
            entity.Property(e => e.P5Dateobtained)
                .HasColumnType("date")
                .HasColumnName("P5_DATEOBTAINED");
            entity.Property(e => e.P5Institution)
                .HasMaxLength(200)
                .HasColumnName("P5_INSTITUTION");
            entity.Property(e => e.P5Qualification)
                .HasMaxLength(200)
                .HasColumnName("P5_QUALIFICATION");
            entity.Property(e => e.SdCertificate).HasColumnName("SD_CERTIFICATE");
            entity.Property(e => e.SdDateobtained)
                .HasColumnType("date")
                .HasColumnName("SD_DATEOBTAINED");
            entity.Property(e => e.SdInstitution)
                .HasMaxLength(200)
                .HasColumnName("SD_INSTITUTION");
            entity.Property(e => e.SdQualification)
                .HasMaxLength(200)
                .HasColumnName("SD_QUALIFICATION");

            entity.HasOne(d => d.EmpCityNavigation).WithMany(p => p.PurpleEmployees)
                .HasForeignKey(d => d.EmpCity)
                .HasConstraintName("FK_EMPLOYEE_CITY1");

            entity.HasOne(d => d.EmpDeptNavigation).WithMany(p => p.PurpleEmployees)
                .HasForeignKey(d => d.EmpDept)
                .HasConstraintName("FK_EMPLOYEE_DEPARTMENT1");

            entity.HasOne(d => d.EmpGradeNavigation).WithMany(p => p.PurpleEmployees)
                .HasForeignKey(d => d.EmpGrade)
                .HasConstraintName("FK_EMPLOYEE_GRADE1");

            entity.HasOne(d => d.EmpLocationNavigation).WithMany(p => p.PurpleEmployees)
                .HasForeignKey(d => d.EmpLocation)
                .HasConstraintName("FK_EMPLOYEE_LOCATION1");

            entity.HasOne(d => d.EmpNationalityNavigation).WithMany(p => p.PurpleEmployees)
                .HasForeignKey(d => d.EmpNationality)
                .HasConstraintName("FK_EMPLOYEE_COUNTRIES1");

            entity.HasOne(d => d.EmpOuNavigation).WithMany(p => p.PurpleEmployees)
                .HasForeignKey(d => d.EmpOu)
                .HasConstraintName("FK_EMPLOYEE_OU1");

            entity.HasOne(d => d.EmpPaygroupNavigation).WithMany(p => p.PurpleEmployees)
                .HasForeignKey(d => d.EmpPaygroup)
                .HasConstraintName("FK_EMPLOYEE_PAYGROUP1");

            entity.HasOne(d => d.EmpPositionNavigation).WithMany(p => p.PurpleEmployees)
                .HasForeignKey(d => d.EmpPosition)
                .HasConstraintName("FK_EMPLOYEE_DESIGNATION1");

            entity.HasOne(d => d.EmpRegionNavigation).WithMany(p => p.PurpleEmployees)
                .HasForeignKey(d => d.EmpRegion)
                .HasConstraintName("FK_EMPLOYEE_REGION1");
        });

        modelBuilder.Entity<Qualification>(entity =>
        {
            entity.HasKey(e => e.QId);

            entity.ToTable("QUALIFICATION");

            entity.Property(e => e.QId)
                .ValueGeneratedNever()
                .HasColumnName("Q_ID");
            entity.Property(e => e.Approvalby)
                .HasMaxLength(50)
                .HasColumnName("APPROVALBY");
            entity.Property(e => e.Approveddate)
                .HasColumnType("datetime")
                .HasColumnName("APPROVEDDATE");
            entity.Property(e => e.Certificate).HasColumnName("CERTIFICATE");
            entity.Property(e => e.Dateattained)
                .HasColumnType("date")
                .HasColumnName("DATEATTAINED");
            entity.Property(e => e.EmpNo)
                .HasMaxLength(50)
                .HasColumnName("EMP_NO");
            entity.Property(e => e.Entrydate)
                .HasColumnType("datetime")
                .HasColumnName("ENTRYDATE");
            entity.Property(e => e.Institution)
                .HasMaxLength(200)
                .HasColumnName("INSTITUTION");
            entity.Property(e => e.Lastupdatedon)
                .HasColumnType("datetime")
                .HasColumnName("LASTUPDATEDON");
            entity.Property(e => e.QStatus).HasColumnName("Q_STATUS");
            entity.Property(e => e.Qualification1)
                .HasMaxLength(200)
                .HasColumnName("QUALIFICATION");
            entity.Property(e => e.Rejectdate)
                .HasColumnType("datetime")
                .HasColumnName("REJECTDATE");
            entity.Property(e => e.Rejectedby)
                .HasMaxLength(50)
                .HasColumnName("REJECTEDBY");
            entity.Property(e => e.Reviewedby)
                .HasMaxLength(50)
                .HasColumnName("REVIEWEDBY");
            entity.Property(e => e.Revieweddate)
                .HasColumnType("datetime")
                .HasColumnName("REVIEWEDDATE");

            entity.HasOne(d => d.EmpNoNavigation).WithMany(p => p.Qualifications)
                .HasForeignKey(d => d.EmpNo)
                .HasConstraintName("FK_QUALIFICATION_EMPLOYEE");
        });

        modelBuilder.Entity<Region>(entity =>
        {
            entity.HasKey(e => e.RegCode);

            entity.ToTable("REGION");

            entity.Property(e => e.RegCode)
                .ValueGeneratedNever()
                .HasColumnName("REG_CODE");
            entity.Property(e => e.RegEnteredby)
                .HasMaxLength(50)
                .HasColumnName("REG_ENTEREDBY");
            entity.Property(e => e.RegEntrydate)
                .HasColumnType("datetime")
                .HasColumnName("REG_ENTRYDATE");
            entity.Property(e => e.RegLastupdatedby)
                .HasMaxLength(50)
                .HasColumnName("REG_LASTUPDATEDBY");
            entity.Property(e => e.RegLastupdatedon)
                .HasColumnType("datetime")
                .HasColumnName("REG_LASTUPDATEDON");
            entity.Property(e => e.RegName)
                .HasMaxLength(256)
                .HasColumnName("REG_NAME");
            entity.Property(e => e.RegStatus).HasColumnName("REG_STATUS");
        });

        modelBuilder.Entity<Resetpassword>(entity =>
        {
            entity.HasKey(e => e.ResetId);

            entity.ToTable("RESETPASSWORD");

            entity.Property(e => e.ResetId)
                .ValueGeneratedNever()
                .HasColumnName("RESET_ID");
            entity.Property(e => e.EmpId)
                .HasMaxLength(50)
                .IsFixedLength()
                .HasColumnName("EMP_ID");
            entity.Property(e => e.Entrydate)
                .HasColumnType("datetime")
                .HasColumnName("ENTRYDATE");
            entity.Property(e => e.Lastupdatedon)
                .HasColumnType("datetime")
                .HasColumnName("LASTUPDATEDON");
            entity.Property(e => e.Status).HasColumnName("STATUS");
        });

        modelBuilder.Entity<RolesHrmodel>(entity =>
        {
            entity.HasKey(e => e.RoleId).HasName("PK_dbo.RolesHRModels");

            entity.ToTable("RolesHRModels");

            entity.Property(e => e.RoleId)
                .ValueGeneratedNever()
                .HasColumnName("ROLE_ID");
            entity.Property(e => e.RoleAccess).HasColumnName("ROLE_ACCESS");
            entity.Property(e => e.RoleDesc).HasColumnName("ROLE_DESC");
            entity.Property(e => e.RoleName).HasColumnName("ROLE_NAME");
        });
        
        modelBuilder.Entity<TempDept>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tempDEPT");
        });

        modelBuilder.Entity<TempDesignation>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tempDESIGNATION");
        });

        modelBuilder.Entity<TempGrade>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tempGRADE");

            entity.Property(e => e.Gradename)
                .HasMaxLength(50)
                .HasColumnName("GRADENAME");
        });

        modelBuilder.Entity<UserMessage>(entity =>
        {
            entity.HasKey(e => e.MessageId);

            entity.ToTable("USER_MESSAGES");

            entity.Property(e => e.MessageId)
                .ValueGeneratedNever()
                .HasColumnName("MessageID");
            entity.Property(e => e.EntryDate).HasColumnType("datetime");
            entity.Property(e => e.MessageFrom).HasMaxLength(50);
            entity.Property(e => e.MessageOwner)
                .HasMaxLength(50)
                .IsFixedLength();
            entity.Property(e => e.MessageStatus)
                .HasMaxLength(1)
                .IsFixedLength();
            entity.Property(e => e.MessageTitle).HasMaxLength(256);
            entity.Property(e => e.SeenDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<UserRole>(entity =>
        {
            entity.HasKey(e => e.RoleId);

            entity.ToTable("USER_ROLES");

            entity.Property(e => e.RoleId)
                .ValueGeneratedNever()
                .HasColumnName("RoleID");
            entity.Property(e => e.Enteredby)
                .HasMaxLength(50)
                .IsFixedLength()
                .HasColumnName("ENTEREDBY");
            entity.Property(e => e.EntryDate)
                .HasColumnType("datetime")
                .HasColumnName("ENTRY_DATE");
            entity.Property(e => e.IsActive)
                .HasMaxLength(1)
                .IsFixedLength()
                .HasColumnName("IS_ACTIVE");
            entity.Property(e => e.Lastudatedby)
                .HasMaxLength(50)
                .IsFixedLength()
                .HasColumnName("LASTUDATEDBY");
            entity.Property(e => e.LastupdateDate)
                .HasColumnType("datetime")
                .HasColumnName("LASTUPDATE_DATE");
            entity.Property(e => e.RoleAccess).HasColumnName("ROLE_ACCESS");
            entity.Property(e => e.RoleDesc)
                .HasMaxLength(100)
                .HasColumnName("ROLE_DESC");
            entity.Property(e => e.RoleName)
                .HasMaxLength(256)
                .HasColumnName("ROLE_NAME");
        });

        modelBuilder.Entity<UsersInRole>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("USERS_IN_ROLES");

            entity.Property(e => e.LoginId)
                .HasMaxLength(50)
                .HasColumnName("LOGIN_ID");
            entity.Property(e => e.RoleId).HasColumnName("RoleID");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
