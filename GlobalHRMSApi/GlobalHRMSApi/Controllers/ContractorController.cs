using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using GlobalHRMSApi.BLL;
using GlobalHRMSApi.Models;
using GlobalHRMSApi.Common;

namespace GlobalHRMSApi.Controllers
{
  //[Authorize]
  [CustomExceptionHandler]
  [RoutePrefix("contractor")]
  //[EnableCors(origins: "*", headers: "*", methods: "*", exposedHeaders: "X-Custom-Header")]
  public class ContractorController : ApiController
  {
    ContractorLogic contractorLogic = new ContractorLogic();

    [Route("save")]
    [HttpPost]
    public int SaveContractor([FromBody]Contractor contractor)
    {
      return contractorLogic.SaveContractor(contractor);
    }

    [Route("delete/{id}")]
    [HttpPost]
    public int DeleteContractor(int id)
    {
      return contractorLogic.DeleteContractor(id);
    }

    [Route("updateactivestatus")]
    [HttpPost]
    public int UpdateContractorActiveStatus([FromBody]Contractor contractor)
    {
      return contractorLogic.UpdateContractorActiveStatus(contractor);
    }
  }
}
