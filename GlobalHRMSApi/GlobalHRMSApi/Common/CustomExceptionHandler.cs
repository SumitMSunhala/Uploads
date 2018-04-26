using GlobalHRMSApi.BLL;
using GlobalHRMSApi.Models;
using GlobalHRMSApi.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http.Filters;

namespace GlobalHRMSApi.Common
{
  public class CustomExceptionHandler : ExceptionFilterAttribute
  {
    ExceptionLogLogic exceptionLogLogic = new ExceptionLogLogic();
    public override void OnException(HttpActionExecutedContext actionExecutedContext)
    {
      ExceptionLogDetails exceptionLogDetails = new ExceptionLogDetails();
      var errorMessagError = new System.Web.Http.HttpError();
      if (actionExecutedContext.Exception != null)
      {
        exceptionLogDetails.ExceptionDateTime = DateTime.Now;

        exceptionLogDetails.Message = actionExecutedContext.Exception.Message;
        exceptionLogDetails.StackTrace = actionExecutedContext.Exception.StackTrace;
        exceptionLogDetails.Source = actionExecutedContext.Exception.Source;

        if (actionExecutedContext.Exception.InnerException != null)
        {
          exceptionLogDetails.InnerExceptionMessage = actionExecutedContext.Exception.Message;
          exceptionLogDetails.InnerExceptionStackTrace = actionExecutedContext.Exception.Message;
          exceptionLogDetails.InnerExceptionSource = actionExecutedContext.Exception.Message;
        }
        errorMessagError = new System.Web.Http.HttpError(actionExecutedContext.Exception.Message) { { "ErrorCode", 500 } };
      }
      int id = exceptionLogLogic.InsertExceptionLog(exceptionLogDetails);
      actionExecutedContext.Response = actionExecutedContext.Request.CreateErrorResponse(HttpStatusCode.InternalServerError, errorMessagError);
    }
  }
}