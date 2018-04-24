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
	public class CompanyLogic
	{
		HRMSManagementEntities hrmsEntities = new HRMSManagementEntities();
		LookupLogic lookupLogic = new LookupLogic();

		public int SaveCompany(Company company)
		{
			bool isNewCompany = company.ID <= 0,
				isDuplicateCompanyExists = hrmsEntities.CompanyMaster.Any(x => x.Name.ToLower().Equals(company.Name.ToLower()) && (company.ID == 0 || x.ID != company.ID));
			if (isDuplicateCompanyExists) return -1;
			CompanyMaster companyMaster = isNewCompany ? new CompanyMaster() : hrmsEntities.CompanyMaster.Find(company.ID) ;
			if (companyMaster != null)
			{
				companyMaster.Name = company.Name;
				companyMaster.Address = company.Address;
				companyMaster.CountryId = company.CountryId;
				companyMaster.StateId = company.StateId;
				companyMaster.CityId = company.CityId;
				companyMaster.ZipCode = company.ZipCode;
				companyMaster.Phone = company.Phone;
				companyMaster.EmailId = company.EmailId;
				companyMaster.WebSite = company.WebSite;
				companyMaster.IsActive = company.IsActive;
				companyMaster.CreatedDateTime = DateTime.Now;
				companyMaster.UpdatedDateTime = DateTime.Now;
				companyMaster.Logo = company.Logo;
				if (isNewCompany) hrmsEntities.CompanyMaster.Add(companyMaster);
			}
			return hrmsEntities.SaveChanges();
		}

		public int DeleteCompany(int id)
		{
			CompanyMaster companyMaster = hrmsEntities.CompanyMaster.Find(id);
			if (companyMaster != null) hrmsEntities.CompanyMaster.Remove(companyMaster);
			return hrmsEntities.SaveChanges();
		}
		public int UpdateCompanyActiveStatus(Company company)
		{
			CompanyMaster companyMaster = hrmsEntities.CompanyMaster.Find(company.ID);
			if (companyMaster != null)
			{
				companyMaster.IsActive = company.IsActive;
				companyMaster.UpdatedDateTime = DateTime.Now;
			}
			return hrmsEntities.SaveChanges();
		}
	}
}