using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using GlobalHRMSApi.Repositories;

namespace GlobalHRMSApi.Controllers
{
    //[Authorize]
	[RoutePrefix("api/values")]
    public class ValuesController : ApiController
    {
        HRMSManagementEntities hrmsEntities = new HRMSManagementEntities();

		[Route("cities/{stateId?}/{id?}")]
        public List<GetCities_Result> GetCities(int? stateId = null, int? id = null)
        {
            return hrmsEntities.GetCities(id, stateId).ToList();
        }

		[Route("countries/{id?}")]
		public List<GetCountries_Result> GetCountries(int? id = null)
        {
            return hrmsEntities.GetCountries(id).ToList();
        }

		[Route("states/{countryId}/{id?}")]
		public List<GetStates_Result> GetStates(int countryId, int? id = null)
        {
            return hrmsEntities.GetStates(id, countryId).ToList();
        }

        [Route("bloodGroups/{id?}")]
        public List<GetBloodGroups_Result> GetBloodGroups(int? id = null)
        {
            return hrmsEntities.GetBloodGroups(id).ToList();
        }

        [Route("genders/{id?}")]
        public List<GetGenders_Result> GetGenders(int? id = null)
        {
            return hrmsEntities.GetGenders(id).ToList();
        }

        [Route("religions/{id?}")]
        public List<GetReligions_Result> GetReligions(int? id = null)
        {
            return hrmsEntities.GetReligions(id).ToList();
        }

        // GET api/values
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
