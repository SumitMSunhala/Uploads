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
	[RoutePrefix("company")]
    //[EnableCors(origins: "*", headers: "*", methods: "*", exposedHeaders: "X-Custom-Header")]
    public class CompanyController : ApiController
    {
		CompanyLogic companyLogic = new CompanyLogic();
        
        [Route("save")]
        [HttpPost]
        public int SaveCompany([FromBody]Company company)
        {
            return companyLogic.SaveCompany(company);
        }

		[Route("delete/{id}")]
		[HttpPost]
		public int DeleteCompany(int id)
		{
			return companyLogic.DeleteCompany(id);
		}

		[Route("updateactivestatus")]
		[HttpPost]
		public int UpdateCompanyActiveStatus([FromBody]Company company)
		{
			return companyLogic.UpdateCompanyActiveStatus(company);
		}
	}
}
