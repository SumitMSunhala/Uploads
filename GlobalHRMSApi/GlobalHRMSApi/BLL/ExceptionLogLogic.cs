using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using GlobalHRMSApi.Repositories;
using GlobalHRMSApi.Models;

namespace GlobalHRMSApi.BLL
{
  public class ExceptionLogLogic
  {
    HRMSManagementEntities hrmsEntities = new HRMSManagementEntities();

    public int InsertExceptionLog(ExceptionLogDetails exceptionLogDetails)
    {
      List<ExceptionLogDetails> exceptionLogDetailsList = exceptionLogDetails != null ? new List<ExceptionLogDetails>() { exceptionLogDetails } : new List<ExceptionLogDetails>();
      DataTable exceptionLogDetailsDt = Common.Common.ToDataTable(exceptionLogDetailsList);
      SqlParameter exceptionLogDetailsDtParam = new SqlParameter("@exceptionLog", SqlDbType.Structured)
      {
        Value = exceptionLogDetailsDt,
        TypeName = "dbo.UDT_ExceptionLog"
      },
      idParam = new SqlParameter()
      {
        ParameterName = "@id",
        SqlDbType = SqlDbType.Int,
        Direction = ParameterDirection.Output
      };

      hrmsEntities.Database.ExecuteSqlCommand("exec dbo.InsertExceptionLog @exceptionLog,@id output", exceptionLogDetailsDtParam, idParam);
      return Convert.ToInt32(idParam.Value);
    }

  }
}