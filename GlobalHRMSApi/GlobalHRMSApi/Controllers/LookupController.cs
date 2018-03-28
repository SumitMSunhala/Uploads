using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using GlobalHRMSApi.BLL;
using GlobalHRMSApi.Models;

namespace GlobalHRMSApi.Controllers
{
    //[Authorize]
	[RoutePrefix("lookup")]
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
    }
}
