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
    
    public partial class ContractorGujaratLabourWelfareFundDepartment
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
    
        public virtual ContractorMaster ContractorMaster { get; set; }
    }
}
