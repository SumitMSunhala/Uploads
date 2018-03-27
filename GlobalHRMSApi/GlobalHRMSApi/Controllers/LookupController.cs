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
	[RoutePrefix("api/lookup")]
    public class LookupController : ApiController
    {
		LookupLogic lookupLogic = new LookupLogic();

		[Route("cities/{stateId?}/{id?}")]
        public List<City> GetCities(int? stateId = null, int? id = null)
        {
            return lookupLogic.GetCities(stateId, id);
        }

		//[Route("countries/{id?}")]
		//public List<GetCountries_Result> GetCountries(int? id = null)
  //      {
  //          return hrmsEntities.GetCountries(id).ToList();
  //      }

		//[Route("states/{countryId?}/{id?}")]
		//public List<GetStates_Result> GetStates(int? countryId = null, int? id = null)
  //      {
  //          return hrmsEntities.GetStates(id, countryId).ToList();
  //      }

		//[Route("bloodgroups/{id?}")]
  //      public List<GetBloodGroups_Result> GetBloodGroups(int? id = null)
  //      {
  //          return hrmsEntities.GetBloodGroups(id).ToList();
  //      }

		//[Route("genders/{id?}")]
		//public List<GetGenders_Result> GetGenders(int? id = null)
  //      {
  //          return hrmsEntities.GetGenders(id).ToList();
  //      }

		//[Route("religions/{id?}")]
		//public List<GetReligions_Result> GetReligions(int? id = null)
  //      {
  //          return hrmsEntities.GetReligions(id).ToList();
  //      }
    }
}
