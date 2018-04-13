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
	[RoutePrefix("employee")]
    //[EnableCors(origins: "*", headers: "*", methods: "*", exposedHeaders: "X-Custom-Header")]
    public class EmployeeController : ApiController
    {
		EmployeeLogic employeeLogic = new EmployeeLogic();
        
        [Route("insertemployeedetails")]
        [HttpPost]
        public int InsertEmployeeDetails([FromBody]EmployeeDetails employeeDetails)
        {
            return employeeLogic.InsertEmployeeDetails(employeeDetails);
        }

		[Route("getEmployeeDetails/{contractorId}/{employeeId?}")]
		[HttpGet]
		public List<EmployeePersonalDetailsList> GetEmployeeDetails(int contractorId, int? employeeId = null)
		{
			return employeeLogic.GetEmployeeDetails(contractorId, employeeId);
		}

	}
}
