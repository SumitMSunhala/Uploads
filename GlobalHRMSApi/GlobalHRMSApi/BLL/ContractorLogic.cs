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
	}
}