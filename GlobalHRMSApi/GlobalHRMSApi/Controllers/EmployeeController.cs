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
	[RoutePrefix("api/employee")]
    public class EmployeeController : ApiController
    {
		EmployeeLogic employeeLogic = new EmployeeLogic();
        
        [Route("insertemployeedetails")]
        public int InsertEmployeeDetails(EmployeeDetails employeeDetails)
        {
            return employeeLogic.InsertEmployeeDetails(employeeDetails);
        }

    }
}
