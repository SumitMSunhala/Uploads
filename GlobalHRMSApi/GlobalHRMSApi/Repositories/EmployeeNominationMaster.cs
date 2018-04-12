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
    
    public partial class EmployeeNominationMaster
    {
        public int ID { get; set; }
        public int ContractorId { get; set; }
        public int EmployeeId { get; set; }
        public string Name { get; set; }
        public string AddressOfNominee { get; set; }
        public int NomineeCountryId { get; set; }
        public int NomineeStateId { get; set; }
        public int NomineeCityId { get; set; }
        public System.DateTime BirthdateOfNominee { get; set; }
        public int AgeOfNominee { get; set; }
        public int RelationId { get; set; }
        public int EPF { get; set; }
        public int EPS { get; set; }
        public int GRATUTIY { get; set; }
        public string NameOfGuardian { get; set; }
        public string AddressOfGuardian { get; set; }
        public Nullable<int> GuardianCountryId { get; set; }
        public Nullable<int> GuardianStateId { get; set; }
        public Nullable<int> GuardianCityId { get; set; }
    
        public virtual CityMaster CityMaster { get; set; }
        public virtual ContractorMaster ContractorMaster { get; set; }
        public virtual CountyMaster CountyMaster { get; set; }
        public virtual EmployeePersonalDetails EmployeePersonalDetails { get; set; }
        public virtual StateMaster StateMaster { get; set; }
    }
}