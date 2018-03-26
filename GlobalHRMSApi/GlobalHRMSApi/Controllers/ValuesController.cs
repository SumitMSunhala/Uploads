using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using GlobalHRMSApi.Repositories;

namespace GlobalHRMSApi.Controllers
{
	[Authorize]
	public class ValuesController : ApiController
	{
		HRMSManagementEntities hrmsEntities = new HRMSManagementEntities();

		public List<GetCities_Result> GetCities(int? stateId, int? id)
		{
			return hrmsEntities.GetCities(id, stateId).ToList();
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
