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
    
    public partial class BankMaster
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BankMaster()
        {
            this.BankBranchMaster = new HashSet<BankBranchMaster>();
        }
    
        public int ID { get; set; }
        public string Name { get; set; }
        public bool IsActive { get; set; }
        public System.DateTime CreatedDateTime { get; set; }
        public System.DateTime UpdatedDateTime { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BankBranchMaster> BankBranchMaster { get; set; }
    }
}
