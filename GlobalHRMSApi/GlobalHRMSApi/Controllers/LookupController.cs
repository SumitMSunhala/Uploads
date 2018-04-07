using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using GlobalHRMSApi.BLL;
using GlobalHRMSApi.Models;

namespace GlobalHRMSApi.Controllers
{
    //[Authorize]
	[RoutePrefix("lookup")]
    [EnableCors(origins: "*", headers: "*", methods: "*", exposedHeaders: "X-Custom-Header")]
    public class LookupController : ApiController
    {
		LookupLogic lookupLogic = new LookupLogic();

        [Route("countries/{id?}")]
        public List<Country> GetCountries(int? id = null)
        {
            return lookupLogic.GetCountries(id).ToList();
        }

        [Route("states/{countryId}/{id?}")]
        public List<State> GetStates(int countryId, int? id = null)
        {
            return lookupLogic.GetStates(countryId,id).ToList();
        }

        [Route("cities/{stateId?}/{id?}")]
        public List<City> GetCities(int? stateId = null, int? id = null)
        {
            return lookupLogic.GetCities(stateId, id);
        }

        [Route("bloodGroups/{id?}")]
        public List<BloodGroup> GetBloodGroups(int? id = null)
        {
            return lookupLogic.GetBloodGroups(id).ToList();
        }

        [Route("genders/{id?}")]
        public List<Gender> GetGenders(int? id = null)
        {
            return lookupLogic.GetGenders(id).ToList();
        }

        [Route("religions/{id?}")]
        public List<Religion> GetReligions(int? id = null)
        {
            return lookupLogic.GetReligions(id).ToList();
        }

        [Route("appointmentTypes/{id?}")]
        public List<AppointmentType> GetAppointmentTypes(int? id = null)
        {
            return lookupLogic.GetAppointmentTypes(id).ToList();
        }

        [Route("banks/{id?}")]
        public List<Bank> GetBanks(int? id = null)
        {
            return lookupLogic.GetBanks(id).ToList();
        }

        [Route("bankBranches/{bankId?}/{id?}")]
        public List<BankBranch> GetBankBranches(int? bankId = null, int? id = null)
        {
            return lookupLogic.GetBankBranches(bankId,id).ToList();
        }

        [Route("categories/{id?}")]
        public List<Category> GetCategories(int? id = null)
        {
            return lookupLogic.GetCategories(id).ToList();
        }

        [Route("designations/{id?}")]
        public List<Designation> GetDesignations(int? id = null)
        {
            return lookupLogic.GetDesignations(id).ToList();
        }

        [Route("educations/{id?}")]
        public List<Education> GetEducations(int? id = null)
        {
            return lookupLogic.GetEducations(id).ToList();
        }

        [Route("grades/{id?}")]
        public List<Grade> GetGrades(int? id = null)
        {
            return lookupLogic.GetGrades(id).ToList();
        }

        [Route("relations/{id?}")]
        public List<Relation> GetRelations(int? id = null)
        {
            return lookupLogic.GetRelations(id).ToList();
        }

        [Route("units/{id?}")]
        public List<Unit> GetUnits(int? id = null)
        {
            return lookupLogic.GetUnits(id).ToList();
        }

        [Route("modeOfPayments/{id?}")]
        public List<ModeOfPayment> GetModeOfPayments(int? id = null)
        {
            return lookupLogic.GetModeOfPayments(id).ToList();
        }

        [Route("maritalStatus/{id?}")]
        public List<MaritalStatus> GetMaritalStatus(int? id = null)
        {
            return lookupLogic.GetMaritalStatus(id).ToList();
        }

        [Route("departments/{id?}")]
        public List<Department> GETDepartments(int? id = null)
        {
            return lookupLogic.GETDepartments(id).ToList();
        }

        [Route("companies/{id?}")]
        public List<Company> GetCompanies(int? id = null)
        {
            return lookupLogic.GetCompanies(id).ToList();
        }

        [Route("contractors/{id?}")]
        public List<Contractor> GetContractors(int? id = null)
        {
            return lookupLogic.GetContractors(id).ToList();
        }
    }
}
