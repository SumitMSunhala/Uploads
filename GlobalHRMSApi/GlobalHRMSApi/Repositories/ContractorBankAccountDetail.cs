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
    
    public partial class ContractorBankAccountDetail
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
    
        public virtual ContractorMaster ContractorMaster { get; set; }
    }
}