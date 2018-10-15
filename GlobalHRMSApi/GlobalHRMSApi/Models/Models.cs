using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;

namespace GlobalHRMSApi.Models
{
  public class Models
  {

  }

  public class LoginRequest
  {
    public string UserName { get; set; }
    public string Password { get; set; }
  }

  public class RegisterRequest
  {
    public string UserName { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public string Mobile { get; set; }
    public string Password { get; set; }
  }

  public class LoginResponse
  {
    public LoginResponse()
    {

      this.Token = "";
      this.responseMsg = new HttpResponseMessage() { StatusCode = System.Net.HttpStatusCode.Unauthorized };
    }

    public string Token { get; set; }
    public HttpResponseMessage responseMsg { get; set; }

  }
  public class RegisterResponse
  {
    public RegisterResponse()
    {

      this.Token = "";
      this.responseMsg = new HttpResponseMessage() { StatusCode = System.Net.HttpStatusCode.Unauthorized };
    }

    public string Token { get; set; }
    public HttpResponseMessage responseMsg { get; set; }

  }

  public class Country
  {
    public int ID { get; set; }
    public string Name { get; set; }
    public bool IsActive { get; set; }
  }

  public class State
  {
    public int ID { get; set; }
    public string Name { get; set; }
    public int CountryId { get; set; }
    public bool IsActive { get; set; }
  }

  public class City
  {
    public int ID { get; set; }
    public string Name { get; set; }
    public int StateId { get; set; }
    public bool IsActive { get; set; }
  }

  public class Gender
  {
    public int ID { get; set; }
    public string Name { get; set; }
    public bool IsActive { get; set; }
  }

  public class MaritalStatus
  {
    public int ID { get; set; }
    public string Name { get; set; }
    public bool IsActive { get; set; }
  }

  public class ModeOfPayment
  {
    public int ID { get; set; }
    public string Name { get; set; }
    public bool IsActive { get; set; }
  }

  public class Religion
  {
    public int ID { get; set; }
    public string Name { get; set; }
    public bool IsActive { get; set; }
  }

  public class BloodGroup
  {
    public int ID { get; set; }
    public string Name { get; set; }
    public bool IsActive { get; set; }
  }


  public class AppointmentType
  {
    public int ID { get; set; }
    public string Name { get; set; }
    public bool IsActive { get; set; }
  }

  public class Bank
  {
    public int ID { get; set; }
    public string Name { get; set; }
    public bool IsActive { get; set; }
  }

  public class BankBranch
  {
    public int ID { get; set; }
    public string Name { get; set; }
    public int BankId { get; set; }
    public bool IsActive { get; set; }
  }

  public class Category
  {
    public int ID { get; set; }
    public string Name { get; set; }
    public bool IsActive { get; set; }
  }

  public class Education
  {
    public int ID { get; set; }
    public string Name { get; set; }
    public bool IsActive { get; set; }
  }

  public class Designation
  {
    public int ID { get; set; }
    public string Name { get; set; }
    public bool IsActive { get; set; }
  }

  public class Grade
  {
    public int ID { get; set; }
    public string Name { get; set; }
    public bool IsActive { get; set; }
  }

  public class Relation
  {
    public int ID { get; set; }
    public string Name { get; set; }
    public bool IsActive { get; set; }
  }

  public class Unit
  {
    public int ID { get; set; }
    public string Name { get; set; }
    public bool IsActive { get; set; }
  }

  public class Department
  {
    public int ID { get; set; }
    public string Name { get; set; }
    public bool IsActive { get; set; }
  }

  public class Company
  {
    public int ID { get; set; }
    public string Name { get; set; }
    public bool IsActive { get; set; }
    public string Address { get; set; }
    public int CountryId { get; set; }
    public int StateId { get; set; }
    public int CityId { get; set; }
    public string ZipCode { get; set; }
    public string Phone { get; set; }
    public string EmailId { get; set; }
    public string WebSite { get; set; }
    public string Logo { get; set; }
  }

  public class Contractor
  {
    public int ID { get; set; }
    public string Name { get; set; }
    public bool IsActive { get; set; }
  }


  public class EmployeePersonalDetails
  {
    public int ID { get; set; }
    public DateTime DateOfBirth { get; set; }
    public int MaritalStatusId { get; set; }
    public DateTime DateOfMarriage { get; set; }
    public int Age { get; set; }
    public int ReligionId { get; set; }
    public int GenderId { get; set; }
    public int BloodGroupId { get; set; }
    public string Height { get; set; }
    public string Weight { get; set; }
    public string Education { get; set; }
    public string MobileNo { get; set; }
    public string EmergencyContactNo { get; set; }
    public string EmailId { get; set; }
    public string PermenantAddressLine1 { get; set; }
    public string PermenantAddressLine2 { get; set; }
    public string TemporaryAddressLine1 { get; set; }
    public string TemporaryAddressLine2 { get; set; }
    public int PermenantAddressCountryId { get; set; }
    public int PermenantAddressStateId { get; set; }
    public int PermenantAddressCityId { get; set; }
    public int TemporaryAddressCountryId { get; set; }
    public int TemporaryAddressStateId { get; set; }
    public int TemporaryAddressCityId { get; set; }
  }

  public class EmployeePersonalDetailsList
  {
    public int ID { get; set; }
    public DateTime DateOfBirth { get; set; }
    public int MaritalStatusId { get; set; }
    public DateTime DateOfMarriage { get; set; }
    public int Age { get; set; }
    public int ReligionId { get; set; }
    public int GenderId { get; set; }
    public int BloodGroupId { get; set; }
    public string Height { get; set; }
    public string Weight { get; set; }
    public string Education { get; set; }
    public string MobileNo { get; set; }
    public string EmergencyContactNo { get; set; }
    public string EmailId { get; set; }
    public string PermenantAddressLine1 { get; set; }
    public string PermenantAddressLine2 { get; set; }
    public string TemporaryAddressLine1 { get; set; }
    public string TemporaryAddressLine2 { get; set; }
    public int PermenantAddressCountryId { get; set; }
    public int PermenantAddressStateId { get; set; }
    public int PermenantAddressCityId { get; set; }
    public int TemporaryAddressCountryId { get; set; }
    public int TemporaryAddressStateId { get; set; }
    public int TemporaryAddressCityId { get; set; }
    public List<EmployeeCompanyDetails> EmployeeCompanyDetailsList { get; set; }
    public List<EmployeeContractorDetails> EmployeeContractorDetails { get; set; }
    public List<EmployeeDocumentDetails> EmployeeDocumentDetails { get; set; }
    public List<EmployeeNominationDetails> EmployeeNominationDetails { get; set; }
  }

  public class EmployeeCompanyDetails
  {
    public int CompanyId { get; set; }
    public int AppointmentTypeID { get; set; }
    public int DesignationId { get; set; }
    public int CategoryId { get; set; }
    public int EmployeeId { get; set; }
    public bool OverTimeApplicability { get; set; }
    public int ContractorId { get; set; }
    public string EmployeeIdCode { get; set; }
    public int ID { get; set; }
    public int GradeId { get; set; }
    public int DepartmentId { get; set; }
    public int UnitId { get; set; }
  }
  public class EmployeeContractorDetails
  {
    public int ContractorId { get; set; }
    public DateTime DateOfJoining { get; set; }
    public DateTime DateOfResignation { get; set; }
    public DateTime DateOfLeaving { get; set; }
    public DateTime DateOfTermination { get; set; }
    public DateTime DateOfRetirement { get; set; }
    public DateTime DateOfConfirmation { get; set; }
    public string ReasonForLeaving { get; set; }
    public string ReasonForTermination { get; set; }
    public int EmployeeId { get; set; }
    public int ModeOfPaymentId { get; set; }
    public string SavingBankAccountNumber { get; set; }
    public string NameOfBank { get; set; }
    public string BankAddress { get; set; }
    public string BranchOfBank { get; set; }
    public string IFSCNumber { get; set; }
    public string MICRNumber { get; set; }
    public bool ProfessionalTaxApplicability { get; set; }
    public bool GujaratLabourWelfareFundApplicability { get; set; }
    public bool ProvidentfundApplicability { get; set; }
    public string UniversalAccountNumber { get; set; }
    public string PFAccountNumber { get; set; }
    public bool EmployeeStateInsuranceCorporationApplicability { get; set; }
    public string ESICIPNumber { get; set; }
    public int ID { get; set; }
  }
  public class EmployeeDocumentDetails
  {
    public int ID { get; set; }
    public string AadharCardNumber { get; set; }
    public string AadharEnrolmentNumber { get; set; }
    public string PANCardNumber { get; set; }
    public string ElectionCardNumber { get; set; }
    public string RationCardNumber { get; set; }
    public string NationalPopulationRegister { get; set; }
    public string DrivingLicenceNumber { get; set; }
    public string DrivingLicenceNumberValidUpTo { get; set; }
    public string PassportNumber { get; set; }
    public string PassportNumberValidUpTo { get; set; }
    public int EmployeeId { get; set; }
    public string EmployeeNameAsPerAadharCard { get; set; }
    public string FatherNameAsPerAadharCard { get; set; }
    public string EmployeeNameAsPerPanCard { get; set; }
    public string EmployeeNameAsPerElectionCard { get; set; }
    public string EmployeeNameAsPerRationCard { get; set; }
    public string EmployeeNameAsPerNationalPopulationRegister { get; set; }
    public string EmployeeNameAsPerDrivingLicence { get; set; }
    public string EmployeeNameAsPerPassport { get; set; }
  }
  public class EmployeeNominationDetails
  {
    public int ID { get; set; }
    public int ContractorId { get; set; }
    public int EmployeeId { get; set; }
    public string Name { get; set; }
    public string AddressOfNominee { get; set; }
    public int NomineeCountryId { get; set; }
    public int NomineeStateId { get; set; }
    public int NomineeCityId { get; set; }
    public DateTime BirthdateOfNominee { get; set; }
    public int AgeOfNominee { get; set; }
    public int RelationId { get; set; }
    public int EPF { get; set; }
    public int EPS { get; set; }
    public int GRATUTIY { get; set; }
    public string NameOfGuardian { get; set; }
    public string AddressOfGuardian { get; set; }
    public int? GuardianCountryId { get; set; }
    public int? GuardianStateId { get; set; }
    public int? GuardianCityId { get; set; }
  }

  public class EmployeeDetails
  {
    public List<EmployeePersonalDetails> EmployeePersonalDetails { get; set; }
    public List<EmployeeDocumentDetails> EmployeeDocumentDetails { get; set; }
    public List<EmployeeCompanyDetails> EmployeeCompanyDetails { get; set; }
    public List<EmployeeContractorDetails> EmployeeContractorDetails { get; set; }
    public List<EmployeeNominationDetails> EmployeeNominationDetails { get; set; }
  }
  public class ExceptionLogDetails
  {
    public int ID { get; set; }
    public DateTime ExceptionDateTime { get; set; }
    public string Message { get; set; }
    public string StackTrace { get; set; }
    public string Source { get; set; }
    public string InnerExceptionMessage { get; set; }
    public string InnerExceptionStackTrace { get; set; }
    public string InnerExceptionSource { get; set; }
  }

  public class ContractorDetails
  {
    public UDT_ContractorMaster ContractorMaster { get; set; }
    public UDT_ContractorBankAccountDetail ContractorBankAccountDetail { get; set; }
    public UDT_ContractorCommercialTaxDepartment ContractorCommercialTaxDepartment { get; set; }
    public UDT_ContractorEmployeeCompensationPolicy ContractorEmployeeCompensationPolicy { get; set; }
    public UDT_ContractorEmployeeProvidentFundOrganisation ContractorEmployeeProvidentFundOrganisation { get; set; }
    public UDT_ContractorEmployeeStateInsuranceCorporation ContractorEmployeeStateInsuranceCorporation { get; set; }
    public UDT_ContractorEmploymentExchangeDepartment ContractorEmploymentExchangeDepartment { get; set; }
    public UDT_ContractorGoodAndServicesTaxDepartment ContractorGoodAndServicesTaxDepartment { get; set; }
    public UDT_ContractorLabourAndEmploymentDepartment ContractorLabourAndEmploymentDepartment { get; set; }
    public UDT_ContractorShopAndEstablishmentDepartment ContractorShopAndEstablishmentDepartment { get; set; }
    public UDT_ContractorGujaratLabourWelfareFundDepartment ContractorGujaratLabourWelfareFundDepartment { get; set; }
  }

  public class UDT_ContractorMaster
  {
    public int ID { get; set; }
    public string Name { get; set; }
    public bool IsActive { get; set; }
    public System.DateTime CreatedDateTime { get; set; }
    public System.DateTime UpdatedDateTime { get; set; }
    public byte[] FirmSoftCopy { get; set; }
    public string FirmCode { get; set; }
    public Nullable<int> TypeOfFirm { get; set; }
    public string Partner1Name { get; set; }
    public string Partner2Name { get; set; }
    public byte[] Partner1PanCardSoftCopy { get; set; }
    public byte[] Partner2PanCardSoftCopy { get; set; }
    public string Partner1PanCardNo { get; set; }
    public string Partner2PanCardNo { get; set; }
    public byte[] Partner1AadhaarCardSoftCopy { get; set; }
    public byte[] Partner2AadhaarSoftCopy { get; set; }
    public string Partner1AadhaarNo { get; set; }
    public string Partner2AadhaarNo { get; set; }
    public byte[] FirmPanCardSoftCopy { get; set; }
    public string FirmPanCardNo { get; set; }
    public string AddressOfRegisteredOffice1 { get; set; }
    public string AddressOfRegisteredOffice2 { get; set; }
    public string AddressOfRegisteredOffice3 { get; set; }
    public string AddressOfRegisteredOffice4 { get; set; }
    public string ContactNo1 { get; set; }
    public string ContactNo2 { get; set; }
    public string EmailId { get; set; }
    public string Password { get; set; }
    public byte[] Partner1Photo { get; set; }
    public byte[] Partner2Photo { get; set; }
    public string WebsiteOfL_EDepartment { get; set; }
    public string WebsiteOfL_EDepartmentID { get; set; }
    public string WebsiteOfL_EDepartmentPassword { get; set; }
  }
  public class UDT_ContractorBankAccountDetail
  {
    public int ID { get; set; }
    public Nullable<int> BankID { get; set; }
    public Nullable<int> TypeOfBankAcccountID { get; set; }
    public Nullable<int> IFSCNo { get; set; }
    public Nullable<int> MicroNo { get; set; }
    public Nullable<int> WebSiteID { get; set; }
    public Nullable<int> WebSitePassword { get; set; }
    public int ContractorId { get; set; }
    public System.DateTime CreatedDateTime { get; set; }
    public System.DateTime UpdatedDateTime { get; set; }
  }
  public class UDT_ContractorCommercialTaxDepartment
  {
    public int ID { get; set; }
    public string ProfessionalTaxRegistrationNo_DateOfIssue { get; set; }
    public byte[] ProfessionalTaxRegistrationNo_DateOfIssueSoftCopy { get; set; }
    public string WebsiteOfCTDDepartment { get; set; }
    public string WebsiteOfCTDDepartmentID { get; set; }
    public string WebsiteOfCTDDepartmentPassword { get; set; }
    public int ContractorId { get; set; }
    public System.DateTime CreatedDateTime { get; set; }
    public System.DateTime UpdatedDateTime { get; set; }
  }
  public class UDT_ContractorEmployeeCompensationPolicy
  {
    public int ID { get; set; }
    public string EmployeeCompensationPolicyNo { get; set; }
    public byte[] EmployeeCompensationPolicyNoSoftCopy { get; set; }
    public Nullable<System.DateTime> DateOfIssue { get; set; }
    public Nullable<System.DateTime> DurationOfPolicyFromDate { get; set; }
    public Nullable<System.DateTime> DurationOfPolicyToDate { get; set; }
    public Nullable<System.DateTime> DurationOfPolicyRenewDate { get; set; }
    public Nullable<int> NoOfEmployeeCoveredUnderPolicy { get; set; }
    public int ContractorId { get; set; }
    public System.DateTime CreatedDateTime { get; set; }
    public System.DateTime UpdatedDateTime { get; set; }
  }
  public class UDT_ContractorEmployeeProvidentFundOrganisation
  {
    public int ID { get; set; }
    public string EPFORegistrationNo_DateOfIssue { get; set; }
    public byte[] EPFORegistrationNo_DateOfIssueSoftCopy { get; set; }
    public string WebsiteOfL_EDepartment { get; set; }
    public string WebsiteOfL_EDepartmentID { get; set; }
    public string WebsiteOfL_EDepartmentPassword { get; set; }
    public int ContractorId { get; set; }
    public System.DateTime CreatedDateTime { get; set; }
    public System.DateTime UpdatedDateTime { get; set; }
  }
  public class UDT_ContractorEmployeeStateInsuranceCorporation
  {
    public int ID { get; set; }
    public string ESICRegistrationNo_DateOfIssue { get; set; }
    public byte[] ESICRegistrationNo_DateOfIssueSoftCopy { get; set; }
    public string WebsiteOfL_EDepartment { get; set; }
    public string WebsiteOfL_EDepartmentID { get; set; }
    public string WebsiteOfL_EDepartmentPassword { get; set; }
    public int ContractorId { get; set; }
    public System.DateTime CreatedDateTime { get; set; }
    public System.DateTime UpdatedDateTime { get; set; }
  }
  public class UDT_ContractorEmploymentExchangeDepartment
  {
    public int ID { get; set; }
    public string EmploymentExchangeRegistrationNo_Date { get; set; }
    public byte[] EmploymentExchangeRegistrationNo_DateSoftCopy { get; set; }
    public string WebsiteOfEEDeparment { get; set; }
    public string WebsiteOfEEDeparmentID { get; set; }
    public string WebsiteOfEEDeparmentPassword { get; set; }
    public int ContractorId { get; set; }
    public System.DateTime CreatedDateTime { get; set; }
    public System.DateTime UpdatedDateTime { get; set; }
  }
  public class UDT_ContractorGoodAndServicesTaxDepartment
  {
    public int ID { get; set; }
    public string GSTRegistrationNo_DateOfIssue { get; set; }
    public byte[] GSTRegistrationNo_DateOfIssueSoftCopy { get; set; }
    public string WebsiteOfL_EDepartment { get; set; }
    public string WebsiteOfL_EDepartmentID { get; set; }
    public string WebsiteOfL_EDepartmentPassword { get; set; }
    public int ContractorId { get; set; }
    public System.DateTime CreatedDateTime { get; set; }
    public System.DateTime UpdatedDateTime { get; set; }
  }
  public class UDT_ContractorLabourAndEmploymentDepartment
  {
    public int ID { get; set; }
    public string Name_AddressUnderWhichContractIsCarriedOn { get; set; }
    public string Name_AddressOfPrincipleEmployer { get; set; }
    public byte[] ContractLabourLicenseNo_DateOfIssue { get; set; }
    public Nullable<System.DateTime> DurationOfLicenseFromDate { get; set; }
    public Nullable<System.DateTime> DurationOfLicenseToDate { get; set; }
    public Nullable<System.DateTime> DurationOfLicenseRenewDate { get; set; }
    public string Nature_LocationOfWork { get; set; }
    public string MaximumLabourAllowedAnyWorkingDay { get; set; }
    public int ContractorId { get; set; }
    public System.DateTime CreatedDateTime { get; set; }
    public System.DateTime UpdatedDateTime { get; set; }
  }
  public class UDT_ContractorShopAndEstablishmentDepartment
  {
    public int ID { get; set; }
    public string Shop_EstablishmentRegistrationNo_DateOfIssue { get; set; }
    public byte[] Shop_EstablishmentRegistrationNo_DateOfIssueSoftCopy { get; set; }
    public Nullable<System.DateTime> DurationOfShop_EstablishmentLicenceFromDate { get; set; }
    public Nullable<System.DateTime> DurationOfShop_EstablishmentLicenceToDate { get; set; }
    public Nullable<System.DateTime> DurationOfShop_EstablishmentLicenceLastRenewDate { get; set; }
    public string RegisteredTradeUnderShop_EstablishmentLicence { get; set; }
    public byte[] UdhyogAadhaarRegistrationNo_DateOfIssue { get; set; }
    public byte[] UdhyogAadhaarRegistrationNo_DateOfIssueSoftCopy { get; set; }
    public string UAN { get; set; }
    public string RegisteredTradeUnderUdhyogAadhaarLicence { get; set; }
    public string WebsiteOfUdhyogAadhaarDepartment { get; set; }
    public string WebsiteOfUdhyogAadhaarDepartmentID { get; set; }
    public string WebsiteOfUdhyogAadhaarDepartmentPassword { get; set; }
    public int ContactorId { get; set; }
    public System.DateTime CreatedDateTime { get; set; }
    public System.DateTime UpdatedDateTime { get; set; }
  }
  public class UDT_ContractorGujaratLabourWelfareFundDepartment
  {
    public int ID { get; set; }
    public string GujaratLabourWelfareFundRegistrationNo_DateOfIssue { get; set; }
    public byte[] GujaratLabourWelfareFundRegistrationNo_DateOfIssueSoftCopy { get; set; }
    public string WebsiteOfGLWFDepartment { get; set; }
    public string WebsiteOfGLWFDepartmentID { get; set; }
    public string WebsiteOfGLWFDepartmentPassword { get; set; }
    public int ContractorId { get; set; }
    public System.DateTime CreatedDateTime { get; set; }
    public System.DateTime UpdatedDateTime { get; set; }
  }
}