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
    public class ValuesController : ApiController
    {
        HRMSManagementEntities hrmsEntities = new HRMSManagementEntities();

        public List<GetCities_Result> GetCities(int? stateId, int? id)
        {
            return hrmsEntities.GetCities(id, stateId).ToList();
        }

        public List<GetCountries_Result> GetCountries(int? id)
        {
            return hrmsEntities.GetCountries(id).ToList();
        }

        public List<GetStates_Result> GetStates(int? id, int countryId)
        {
            return hrmsEntities.GetStates(id, countryId).ToList();
        }

        public List<GetBloodGroups_Result> GetBloodGroups(int? id)
        {
            return hrmsEntities.GetBloodGroups(id).ToList();
        }

        public List<GetGenders_Result> GetGenders(int? id)
        {
            return hrmsEntities.GetGenders(id).ToList();
        }

        public List<GetReligions_Result> GetReligions(int? id)
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
