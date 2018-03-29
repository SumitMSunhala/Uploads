using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using GlobalHRMSApi.Repositories;
using GlobalHRMSApi.Models;
using System.Data.Entity.Core.Objects;

namespace GlobalHRMSApi.BLL
{
	public class LookupLogic
	{
		HRMSManagementEntities hrmsEntities = new HRMSManagementEntities();

		public List<Country> GetCountries(int? id)
		{
			List<Country> retCountryList = null;
			ObjectResult<GetCountries_Result> countryList = hrmsEntities.GetCountries(id);
			if (countryList != null)
			{
				retCountryList = countryList.ToList().Select(x => new Country()
				{
					ID = x.ID,
					Name = x.Name,
					IsActive = x.IsActive
				}).ToList();
			}
			return retCountryList;
		}

		public List<State> GetStates(int? countryId, int? id)
		{
			List<State> retStateList = null;
			ObjectResult<GetStates_Result> stateList = hrmsEntities.GetStates(id, countryId);
			if (stateList != null)
			{
				retStateList = stateList.ToList().Select(x => new State()
				{
					ID = x.ID,
					Name = x.Name,
					CountryId = x.CountryId,
					IsActive = x.IsActive
				}).ToList();
			}
			return retStateList;
		}

		public List<City> GetCities(int? stateId, int? id)
		{
			List<City> retCityList = null;
			ObjectResult<GetCities_Result> citiesList = hrmsEntities.GetCities(id, stateId);
			if (citiesList != null)
			{
				retCityList = citiesList.ToList().Select(x => new City()
				{
					ID = x.ID,
					Name = x.Name,
					StateId = x.StateId,
					IsActive = x.IsActive
				}).ToList();
			}
			return retCityList;
		}

		public List<BloodGroup> GetBloodGroups(int? id)
		{
			List<BloodGroup> retBloodGroupList = null;
			ObjectResult<GetBloodGroups_Result> bloodGroupList = hrmsEntities.GetBloodGroups(id);
			if (bloodGroupList != null)
			{
				retBloodGroupList = bloodGroupList.ToList().Select(x => new BloodGroup()
				{
					ID = x.ID,
					Name = x.Name,
					IsActive = x.IsActive
				}).ToList();
			}
			return retBloodGroupList;
		}

		public List<Gender> GetGenders(int? id)
		{
			List<Gender> retGenderList = null;
			ObjectResult<GetGenders_Result> genderList = hrmsEntities.GetGenders(id);
			if (genderList != null)
			{
				retGenderList = genderList.ToList().Select(x => new Gender()
				{
					ID = x.ID,
					Name = x.Name,
					IsActive = x.IsActive
				}).ToList();
			}
			return retGenderList;
		}

		public List<Religion> GetReligions(int? id)
		{
			List<Religion> retReligionList = null;
			ObjectResult<GetReligions_Result> religionList = hrmsEntities.GetReligions(id);
			if (religionList != null)
			{
				retReligionList = religionList.ToList().Select(x => new Religion()
				{
					ID = x.ID,
					Name = x.Name,
					IsActive = x.IsActive
				}).ToList();
			}
			return retReligionList;
		}

		public int InsertEmployeeDetails()
		{
			DataTable employeePersonalDetails = new DataTable(),
				employeeDocumentMaster = new DataTable(),
				employeeContractorMaster = new DataTable(),
				employeeCompanyMaster = new DataTable();
			SqlParameter employeePersonalDetailsParam = new SqlParameter("@employeePersonalDetails", SqlDbType.Structured)
			{
				Value = employeePersonalDetails,
				TypeName = "dbo.UDT_EmployeePersonalDetails"
			},
				employeeDocumentMasterParam = new SqlParameter("@employeeDocumentMaster", SqlDbType.Structured)
				{
					Value = employeeDocumentMaster,
					TypeName = "dbo.UDT_EmployeeDocumentMaster"
				},
				employeeContractorMasterParam = new SqlParameter("@employeeContractorMaster", SqlDbType.Structured)
				{
					Value = employeeContractorMaster,
					TypeName = "dbo.UDT_EmployeeContractorMaster"
				},
				employeeCompanyMasterParam = new SqlParameter("@employeeCompanyMaster", SqlDbType.Structured)
				{
					Value = employeeCompanyMaster,
					TypeName = "dbo.UDT_EmployeeCompanyMaster"
				};
			int employeeId = hrmsEntities.Database.ExecuteSqlCommand("dbo.InsertEmployeeDetails", employeePersonalDetailsParam, employeeDocumentMasterParam, employeeContractorMasterParam, employeeCompanyMasterParam);
			return employeeId;
		}



	}
}