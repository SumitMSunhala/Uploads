using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using GlobalHRMSApi.Repositories;
using GlobalHRMSApi.Models;
using System.Data.Entity.Core.Objects;

namespace GlobalHRMSApi.BLL
{
	public class EmployeeLogic
	{
		HRMSManagementEntities hrmsEntities = new HRMSManagementEntities();

		public int InsertEmployeeDetails(EmployeeDetails employeeDetails)
		{
			DataTable employeePersonalDetails = Common.Common.ToDataTable(employeeDetails.EmployeePersonalDetails),
				employeeDocumentMaster = Common.Common.ToDataTable(employeeDetails.EmployeeDocumentDetails),
				employeeContractorMaster = Common.Common.ToDataTable(employeeDetails.EmployeeContractorDetails),
				employeeCompanyMaster = Common.Common.ToDataTable(employeeDetails.EmployeeCompanyDetails);
			SqlParameter employeePersonalDetailsParam = new SqlParameter("@employeePersonalDetails", SqlDbType.Structured)
			{
				Value = employeePersonalDetails,
				TypeName = "dbo.UDT_EmployeePersonalDetails"
			},
				employeeDocumentMasterParam = new SqlParameter("@employeeDocumentMaster", SqlDbType.Structured)
				{
					Value = employeeDocumentMaster,
					TypeName = "dbo.UDT_EmployeeDocumentMaster"
				},
				employeeContractorMasterParam = new SqlParameter("@employeeContractorMaster", SqlDbType.Structured)
				{
					Value = employeeContractorMaster,
					TypeName = "dbo.UDT_EmployeeContractorMaster"
				},
				employeeCompanyMasterParam = new SqlParameter("@employeeCompanyMaster", SqlDbType.Structured)
				{
					Value = employeeCompanyMaster,
					TypeName = "dbo.UDT_EmployeeCompanyMaster"
				};
			int employeeId = hrmsEntities.Database.ExecuteSqlCommand("dbo.InsertEmployeeDetails", employeePersonalDetailsParam, employeeDocumentMasterParam, employeeContractorMasterParam, employeeCompanyMasterParam);
			return employeeId;
		}
    }
}