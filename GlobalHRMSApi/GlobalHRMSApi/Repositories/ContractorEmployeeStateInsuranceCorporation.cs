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
    
    public partial class ContractorEmployeeStateInsuranceCorporation
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
    
        public virtual ContractorMaster ContractorMaster { get; set; }
    }
}