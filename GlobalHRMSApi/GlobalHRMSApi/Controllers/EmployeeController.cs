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

    [Route("updateemployeedetails")]
    [HttpPost]
    public int UpdateEmployeeDetails([FromBody]EmployeeDetails employeeDetails)
    {
      return employeeLogic.UpdateEmployeeDetails(employeeDetails);
    }

    [Route("getEmployeeDetails/{contractorId}/{employeeId?}")]
    [HttpGet]
    public List<EmployeePersonalDetailsList> GetEmployeeDetails(int contractorId, int? employeeId = null)
    {
      return employeeLogic.GetEmployeeDetails(contractorId, employeeId);
    }

    [Route("IsMobileNumberExists/{mobileNumber}/{employeeId?}")]
    [HttpGet]
    public bool IsMobileNumberExists(string mobileNumber, int? employeeId = null)
    {
      return employeeLogic.IsMobileNumberExists(mobileNumber, employeeId);
    }
    [Route("IsEmailIdExists/{emailId}/{employeeId?}")]
    [HttpGet]
    public bool IsEmailIdExists(string emailId, int? employeeId = null)
    {
      return employeeLogic.IsEmailIdExists(emailId, employeeId);
    }
    [Route("IsAadharCardNumberExists/{aadharCardNumber}/{employeeId?}")]
    [HttpGet]
    public bool IsAadharCardNumberExists(string aadharCardNumber, int? employeeId = null)
    {
      return employeeLogic.IsAadharCardNumberExists(aadharCardNumber, employeeId);
    }
    [Route("IsAadharEnrolmentNumberExists/{aadharEnrolmentNumber}/{employeeId?}")]
    [HttpGet]
    public bool IsAadharEnrolmentNumberExists(string aadharEnrolmentNumber, int? employeeId = null)
    {
      return employeeLogic.IsAadharEnrolmentNumberExists(aadharEnrolmentNumber, employeeId);
    }
    [Route("IsPANCardNumberExists/{panCardNumber}/{employeeId?}")]
    [HttpGet]
    public bool IsPANCardNumberExists(string panCardNumber, int? employeeId = null)
    {
      return employeeLogic.IsPANCardNumberExists(panCardNumber, employeeId);
    }
    [Route("IsElectionCardNumberExists/{electionCardNumber}/{employeeId?}")]
    [HttpGet]
    public bool IsElectionCardNumberExists(string electionCardNumber, int? employeeId = null)
    {
      return employeeLogic.IsElectionCardNumberExists(electionCardNumber, employeeId);
    }
    [Route("IsRationCardNumberExists/{rationCardNumber}/{employeeId?}")]
    [HttpGet]
    public bool IsRationCardNumberExists(string rationCardNumber, int? employeeId = null)
    {
      return employeeLogic.IsRationCardNumberExists(rationCardNumber, employeeId);
    }
    [Route("IsNationalPopulationRegisterExists/{nationalPopulationRegister}/{employeeId?}")]
    [HttpGet]
    public bool IsNationalPopulationRegisterExists(string nationalPopulationRegister, int? employeeId = null)
    {
      return employeeLogic.IsNationalPopulationRegisterExists(nationalPopulationRegister, employeeId);
    }
    [Route("IsDrivingLicenceNumberExists/{drivingLicenceNumber}/{employeeId?}")]
    [HttpGet]
    public bool IsDrivingLicenceNumberExists(string drivingLicenceNumber, int? employeeId = null)
    {
      return employeeLogic.IsDrivingLicenceNumberExists(drivingLicenceNumber, employeeId);
    }
    [Route("IsPassportNumberExists/{passportNumber}/{employeeId?}")]
    [HttpGet]
    public bool IsPassportNumberExists(string passportNumber, int? employeeId = null)
    {
      return employeeLogic.IsPassportNumberExists(passportNumber, employeeId);
    }

  }
}
