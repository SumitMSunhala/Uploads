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
		public string Username { get; set; }
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
	}

	public class EmployeeCompanyDetails
	{
		public int CompanyId { get; set; }
		public string AppointmentType { get; set; }
		public string Designation { get; set; }
		public string Category { get; set; }
		public string Grade { get; set; }
		public string Department { get; set; }
		public string Plant { get; set; }
		public int EmployeeId { get; set; }
		public bool OverTimeApplicability { get; set; }
		public int ContractorId { get; set; }
		public string EmployeeIdCode { get; set; }
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
	}
	public class EmployeeDocumentDetails
	{
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

	public class EmployeeDetails
	{
		public List<EmployeePersonalDetails> EmployeePersonalDetails { get; set; }
		public List<EmployeeDocumentDetails> EmployeeDocumentDetails { get; set; }
		public List<EmployeeCompanyDetails> EmployeeCompanyDetails { get; set; }
		public List<EmployeeContractorDetails> EmployeeContractorDetails { get; set; }
	}
}