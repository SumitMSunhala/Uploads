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
    //[EnableCors(origins: "*", headers: "*", methods: "*", exposedHeaders: "X-Custom-Header")]
    public class LookupController : ApiController
    {
		LookupLogic lookupLogic = new LookupLogic();

        [Route("countries/{id?}")]
        [HttpGet]
        public List<Country> GetCountries(int? id = null)
        {
            return lookupLogic.GetCountries(id).ToList();
        }

        [Route("states/{countryId}/{id?}")]
        [HttpGet]
        public List<State> GetStates(int countryId, int? id = null)
        {
            return lookupLogic.GetStates(countryId,id).ToList();
        }

        [Route("cities/{stateId?}/{id?}")]
        [HttpGet]
        public List<City> GetCities(int? stateId = null, int? id = null)
        {
            return lookupLogic.GetCities(stateId, id);
        }

        [Route("bloodGroups/{id?}")]
        [HttpGet]
        public List<BloodGroup> GetBloodGroups(int? id = null)
        {
            return lookupLogic.GetBloodGroups(id).ToList();
        }

        [Route("genders/{id?}")]
        [HttpGet]
        public List<Gender> GetGenders(int? id = null)
        {
            return lookupLogic.GetGenders(id).ToList();
        }

        [Route("religions/{id?}")]
        [HttpGet]
        public List<Religion> GetReligions(int? id = null)
        {
            return lookupLogic.GetReligions(id).ToList();
        }

        [Route("appointmentTypes/{id?}")]
        [HttpGet]
        public List<AppointmentType> GetAppointmentTypes(int? id = null)
        {
            return lookupLogic.GetAppointmentTypes(id).ToList();
        }

        [Route("banks/{id?}")]
        [HttpGet]
        public List<Bank> GetBanks(int? id = null)
        {
            return lookupLogic.GetBanks(id).ToList();
        }

        [Route("bankBranches/{bankId?}/{id?}")]
        [HttpGet]
        public List<BankBranch> GetBankBranches(int? bankId = null, int? id = null)
        {
            return lookupLogic.GetBankBranches(bankId,id).ToList();
        }

        [Route("categories/{id?}")]
        [HttpGet]
        public List<Category> GetCategories(int? id = null)
        {
            return lookupLogic.GetCategories(id).ToList();
        }

        [Route("designations/{id?}")]
        [HttpGet]
        public List<Designation> GetDesignations(int? id = null)
        {
            return lookupLogic.GetDesignations(id).ToList();
        }

        [Route("educations/{id?}")]
        [HttpGet]
        public List<Education> GetEducations(int? id = null)
        {
            return lookupLogic.GetEducations(id).ToList();
        }

        [Route("grades/{id?}")]
        [HttpGet]
        public List<Grade> GetGrades(int? id = null)
        {
            return lookupLogic.GetGrades(id).ToList();
        }

        [Route("relations/{id?}")]
        [HttpGet]
        public List<Relation> GetRelations(int? id = null)
        {
            return lookupLogic.GetRelations(id).ToList();
        }

        [Route("units/{id?}")]
        [HttpGet]
        public List<Unit> GetUnits(int? id = null)
        {
            return lookupLogic.GetUnits(id).ToList();
        }

        [Route("modeOfPayments/{id?}")]
        [HttpGet]
        public List<ModeOfPayment> GetModeOfPayments(int? id = null)
        {
            return lookupLogic.GetModeOfPayments(id).ToList();
        }

        [Route("maritalStatus/{id?}")]
        [HttpGet]
        public List<MaritalStatus> GetMaritalStatus(int? id = null)
        {
            return lookupLogic.GetMaritalStatus(id).ToList();
        }

        [Route("departments/{id?}")]
        [HttpGet]
        public List<Department> GETDepartments(int? id = null)
        {
            return lookupLogic.GETDepartments(id).ToList();
        }

        [Route("companies/{id?}")]
        [HttpGet]
        public List<Company> GetCompanies(int? id = null)
        {
            return lookupLogic.GetCompanies(id).ToList();
        }

        [Route("contractors/{id?}")]
        [HttpGet]
        public List<Contractor> GetContractors(int? id = null)
        {
            return lookupLogic.GetContractors(id).ToList();
        }
    }
}
