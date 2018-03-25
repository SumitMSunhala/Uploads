//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GlobalHRMSApi.Repositories
{
    using System;
    using System.Collections.Generic;
    
    public partial class EmployeeDocumentMaster
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
    
        public virtual EmployeePersonalDetails EmployeePersonalDetails { get; set; }
    }
}