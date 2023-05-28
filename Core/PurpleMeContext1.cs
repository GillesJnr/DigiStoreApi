using System;
using System.Collections.Generic;
using DigiStoreApi.Core.PurpleHR;
using Microsoft.EntityFrameworkCore;

namespace DigiStoreApi.Core;

public partial class PurpleMeContext : DbContext
{
    private readonly IConfiguration _config;
    public PurpleMeContext(IConfiguration config)
    {
        _config = config;
    }

    public PurpleMeContext(DbContextOptions<PurpleMeContext> options)
        : base(options)
    {
    }

   

    public virtual DbSet<Department> Departments { get; set; }

    public virtual DbSet<Designation> Designations { get; set; }

    public virtual DbSet<Employee> Employees { get; set; }
    
    public virtual DbSet<GlobalSetting> GlobalSettings { get; set; }

    public virtual DbSet<Grade> Grades { get; set; }
    
    public virtual DbSet<Location> Locations { get; set; }
    
    public virtual DbSet<Ou> Ous { get; set; }

    public virtual DbSet<Paygroup> Paygroups { get; set; }

    public virtual DbSet<Position> Positions { get; set; }

    public virtual DbSet<PurpleEmployee> PurpleEmployees { get; set; }

    public virtual DbSet<Qualification> Qualifications { get; set; }

    public virtual DbSet<Region> Regions { get; set; }

    public virtual DbSet<TempGrade> TempGrades { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer(_config.GetConnectionString("PurpleDbContext"));

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
  
        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
