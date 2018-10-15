using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Linq;
using System.Web;
using GlobalHRMSApi.Repositories;
using GlobalHRMSApi.Models;
using System.Data.Entity.Core.Objects;

namespace GlobalHRMSApi.BLL
{
	public class ContractorLogic
	{
		HRMSManagementEntities hrmsEntities = new HRMSManagementEntities();
		LookupLogic lookupLogic = new LookupLogic();

		public int SaveContractor(Contractor contractor)
		{
			bool isNewContractor = contractor.ID <= 0,
				isDuplicateContractorExists = hrmsEntities.ContractorMaster.Any(x => x.Name.ToLower().Equals(contractor.Name.ToLower()) && (contractor.ID == 0 || x.ID != contractor.ID));
			if (isDuplicateContractorExists) return -1;
			ContractorMaster contractorMaster = isNewContractor ? new ContractorMaster() : hrmsEntities.ContractorMaster.Find(contractor.ID) ;
			if (contractorMaster != null)
			{
				contractorMaster.Name = contractor.Name;
				contractorMaster.IsActive = contractor.IsActive;
				contractorMaster.CreatedDateTime = DateTime.Now;
				contractorMaster.UpdatedDateTime = DateTime.Now;
				if (isNewContractor) hrmsEntities.ContractorMaster.Add(contractorMaster);
			}
			return hrmsEntities.SaveChanges();
		}

		public int DeleteContractor(int id)
		{
			ContractorMaster contractorMaster = hrmsEntities.ContractorMaster.Find(id);
			if (contractorMaster != null) hrmsEntities.ContractorMaster.Remove(contractorMaster);
			return hrmsEntities.SaveChanges();
		}

		public int UpdateContractorActiveStatus(Contractor contractor)
		{
			ContractorMaster contractorMaster = hrmsEntities.ContractorMaster.Find(contractor.ID);
			if (contractorMaster != null)
			{
				contractorMaster.IsActive = contractor.IsActive;
				contractorMaster.UpdatedDateTime = DateTime.Now;
			}
			return hrmsEntities.SaveChanges();
		}

    public int ManageContractorDetails(ContractorDetails contractorDetails)
    {
      DataTable contractorMaster = Common.Common.ToDataTable(new List<UDT_ContractorMaster> { contractorDetails.ContractorMaster }),
          contractorBankAccountDetail = Common.Common.ToDataTable(new List<UDT_ContractorBankAccountDetail> { contractorDetails.ContractorBankAccountDetail }),
          contractorCommercialTaxDepartment = Common.Common.ToDataTable(new List<UDT_ContractorCommercialTaxDepartment> { contractorDetails.ContractorCommercialTaxDepartment }),
          contractorEmployeeCompensationPolicy = Common.Common.ToDataTable(new List<UDT_ContractorEmployeeCompensationPolicy> { contractorDetails.ContractorEmployeeCompensationPolicy }),
          contractorEmployeeProvidentFundOrganisation = Common.Common.ToDataTable(new List<UDT_ContractorEmployeeProvidentFundOrganisation> { contractorDetails.ContractorEmployeeProvidentFundOrganisation }),
          contractorEmployeeStateInsuranceCorporation = Common.Common.ToDataTable(new List<UDT_ContractorEmployeeStateInsuranceCorporation> { contractorDetails.ContractorEmployeeStateInsuranceCorporation }),
          contractorEmploymentExchangeDepartment = Common.Common.ToDataTable(new List<UDT_ContractorEmploymentExchangeDepartment> { contractorDetails.ContractorEmploymentExchangeDepartment }),
          contractorGoodAndServicesTaxDepartment = Common.Common.ToDataTable(new List<UDT_ContractorGoodAndServicesTaxDepartment> { contractorDetails.ContractorGoodAndServicesTaxDepartment }),
          contractorLabourAndEmploymentDepartment = Common.Common.ToDataTable(new List<UDT_ContractorLabourAndEmploymentDepartment> { contractorDetails.ContractorLabourAndEmploymentDepartment }),
          contractorShopAndEstablishmentDepartment = Common.Common.ToDataTable(new List<UDT_ContractorShopAndEstablishmentDepartment> { contractorDetails.ContractorShopAndEstablishmentDepartment }),
          contractorGujaratLabourWelfareFundDepartment = Common.Common.ToDataTable(new List<UDT_ContractorGujaratLabourWelfareFundDepartment> { contractorDetails.ContractorGujaratLabourWelfareFundDepartment });



      SqlParameter contractorMasterParam = new SqlParameter("@contractorMaster", SqlDbType.Structured)
      {
        Value = contractorMaster,
        TypeName = "dbo.UDT_ContractorMaster"
      },
      contractorBankAccountDetailParam = new SqlParameter("@contractorBankAccountDetail", SqlDbType.Structured)
      {
        Value = contractorBankAccountDetail,
        TypeName = "dbo.UDT_ContractorBankAccountDetail"
      },
      contractorCommercialTaxDepartmentParam = new SqlParameter("@contractorCommercialTaxDepartment", SqlDbType.Structured)
      {
        Value = contractorCommercialTaxDepartment,
        TypeName = "dbo.UDT_ContractorCommercialTaxDepartment"
      },
      contractorEmployeeCompensationPolicyParam = new SqlParameter("@contractorEmployeeCompensationPolicy", SqlDbType.Structured)
      {
        Value = contractorEmployeeCompensationPolicy,
        TypeName = "dbo.UDT_ContractorEmployeeCompensationPolicy"
      },
      contractorEmployeeProvidentFundOrganisationParam = new SqlParameter("@contractorEmployeeProvidentFundOrganisation", SqlDbType.Structured)
      {
        Value = contractorEmployeeProvidentFundOrganisation,
        TypeName = "dbo.UDT_ContractorEmployeeProvidentFundOrganisation"
      },
      contractorEmployeeStateInsuranceCorporationParam = new SqlParameter("@contractorEmployeeStateInsuranceCorporation", SqlDbType.Structured)
      {
        Value = contractorEmployeeStateInsuranceCorporation,
        TypeName = "dbo.UDT_ContractorEmployeeStateInsuranceCorporation"
      },
      contractorEmploymentExchangeDepartmentParam = new SqlParameter("@contractorEmploymentExchangeDepartment", SqlDbType.Structured)
      {
        Value = contractorEmploymentExchangeDepartment,
        TypeName = "dbo.UDT_ContractorEmploymentExchangeDepartment"
      },
      contractorGoodAndServicesTaxDepartmentParam = new SqlParameter("@contractorGoodAndServicesTaxDepartment", SqlDbType.Structured)
      {
        Value = contractorGoodAndServicesTaxDepartment,
        TypeName = "dbo.UDT_ContractorGoodAndServicesTaxDepartment"
      },
      contractorLabourAndEmploymentDepartmentParam = new SqlParameter("@contractorLabourAndEmploymentDepartment", SqlDbType.Structured)
      {
        Value = contractorLabourAndEmploymentDepartment,
        TypeName = "dbo.UDT_ContractorLabourAndEmploymentDepartment"
      },
      contractorShopAndEstablishmentDepartmentParam = new SqlParameter("@contractorShopAndEstablishmentDepartment", SqlDbType.Structured)
      {
        Value = contractorShopAndEstablishmentDepartment,
        TypeName = "dbo.UDT_ContractorShopAndEstablishmentDepartment"
      },
      contractorGujaratLabourWelfareFundDepartmentParam = new SqlParameter("@contractorGujaratLabourWelfareFundDepartment", SqlDbType.Structured)
      {
        Value = contractorGujaratLabourWelfareFundDepartment,
        TypeName = "dbo.UDT_ContractorGujaratLabourWelfareFundDepartment"
      };
      return hrmsEntities.Database.ExecuteSqlCommand("exec dbo.ManageContractorDetails @contractorMaster, @contractorBankAccountDetail, @contractorCommercialTaxDepartment, @contractorEmployeeCompensationPolicy, @contractorEmployeeProvidentFundOrganisation, @contractorEmployeeStateInsuranceCorporation, @contractorEmploymentExchangeDepartment, @contractorGoodAndServicesTaxDepartment, @contractorLabourAndEmploymentDepartment, @contractorShopAndEstablishmentDepartment, @contractorGujaratLabourWelfareFundDepartment", contractorMasterParam, contractorBankAccountDetailParam, contractorCommercialTaxDepartmentParam, contractorEmployeeCompensationPolicyParam, contractorEmployeeProvidentFundOrganisationParam, contractorEmployeeStateInsuranceCorporationParam, contractorEmploymentExchangeDepartmentParam, contractorGoodAndServicesTaxDepartmentParam, contractorLabourAndEmploymentDepartmentParam, contractorShopAndEstablishmentDepartmentParam, contractorGujaratLabourWelfareFundDepartmentParam);
    }
  }
}