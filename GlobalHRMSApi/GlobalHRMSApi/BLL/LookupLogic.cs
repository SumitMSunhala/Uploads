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

        public List<AppointmentType> GetAppointmentTypes(int? id)
        {
            List<AppointmentType> retAppointmentTypeList = null;
            ObjectResult<GetAppointmentTypes_Result> appointmentTypeList = hrmsEntities.GetAppointmentTypes(id);
            if (appointmentTypeList != null)
            {
                retAppointmentTypeList = appointmentTypeList.ToList().Select(x => new AppointmentType()
                {
                    ID = x.ID,
                    Name = x.Name,
                    IsActive = x.IsActive
                }).ToList();
            }
            return retAppointmentTypeList;
        }

        public List<Bank> GetBanks(int? id)
        {
            List<Bank> retBankList = null;
            ObjectResult<GetBanks_Result> bankList = hrmsEntities.GetBanks(id);
            if (bankList != null)
            {
                retBankList = bankList.ToList().Select(x => new Bank()
                {
                    ID = x.ID,
                    Name = x.Name,
                    IsActive = x.IsActive
                }).ToList();
            }
            return retBankList;
        }

        public List<Category> GetCategories(int? id)
        {
            List<Category> retCategoryList = null;
            ObjectResult<GetCategories_Result> categoryList = hrmsEntities.GetCategories(id);
            if (categoryList != null)
            {
                retCategoryList = categoryList.ToList().Select(x => new Category()
                {
                    ID = x.ID,
                    Name = x.Name,
                    IsActive = x.IsActive
                }).ToList();
            }
            return retCategoryList;
        }

        public List<Designation> GetDesignations(int? id)
        {
            List<Designation> retDesignationList = null;
            ObjectResult<GetDesignations_Result> designationList = hrmsEntities.GetDesignations(id);
            if (designationList != null)
            {
                retDesignationList = designationList.ToList().Select(x => new Designation()
                {
                    ID = x.ID,
                    Name = x.Name,
                    IsActive = x.IsActive
                }).ToList();
            }
            return retDesignationList;
        }

        public List<Education> GetEducations(int? id)
        {
            List<Education> retEducationList = null;
            ObjectResult<GetEducations_Result> educationList = hrmsEntities.GetEducations(id);
            if (educationList != null)
            {
                retEducationList = educationList.ToList().Select(x => new Education()
                {
                    ID = x.ID,
                    Name = x.Name,
                    IsActive = x.IsActive
                }).ToList();
            }
            return retEducationList;
        }

        public List<Grade> GetGrades(int? id)
        {
            List<Grade> retGradeList = null;
            ObjectResult<GetGrades_Result> gradeList = hrmsEntities.GetGrades(id);
            if (gradeList != null)
            {
                retGradeList = gradeList.ToList().Select(x => new Grade()
                {
                    ID = x.ID,
                    Name = x.Name,
                    IsActive = x.IsActive
                }).ToList();
            }
            return retGradeList;
        }

        public List<Relation> GetRelations(int? id)
        {
            List<Relation> retRelationList = null;
            ObjectResult<GetRelations_Result> relationList = hrmsEntities.GetRelations(id);
            if (relationList != null)
            {
                retRelationList = relationList.ToList().Select(x => new Relation()
                {
                    ID = x.ID,
                    Name = x.Name,
                    IsActive = x.IsActive
                }).ToList();
            }
            return retRelationList;
        }

        public List<Unit> GetUnits(int? id)
        {
            List<Unit> retUnitList = null;
            ObjectResult<GetUnits_Result> unitList = hrmsEntities.GetUnits(id);
            if (unitList != null)
            {
                retUnitList = unitList.ToList().Select(x => new Unit()
                {
                    ID = x.ID,
                    Name = x.Name,
                    IsActive = x.IsActive
                }).ToList();
            }
            return retUnitList;
        }

    }
}