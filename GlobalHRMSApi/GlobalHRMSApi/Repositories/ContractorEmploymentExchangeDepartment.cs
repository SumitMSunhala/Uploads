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
    
    public partial class ContractorEmploymentExchangeDepartment
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
    
        public virtual ContractorMaster ContractorMaster { get; set; }
    }
}
