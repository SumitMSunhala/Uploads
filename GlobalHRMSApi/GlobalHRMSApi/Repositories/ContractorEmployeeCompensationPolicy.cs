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
    
    public partial class ContractorEmployeeCompensationPolicy
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
    
        public virtual ContractorMaster ContractorMaster { get; set; }
    }
}
