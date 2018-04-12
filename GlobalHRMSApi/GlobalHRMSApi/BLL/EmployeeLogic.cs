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
				employeeCompanyMaster = Common.Common.ToDataTable(employeeDetails.EmployeeCompanyDetails),
				employeeNominationMaster = Common.Common.ToDataTable(employeeDetails.EmployeeNominationDetails);
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
				},
				employeeNominationMasterParam = new SqlParameter("@employeeNominationMaster", SqlDbType.Structured)
				{
					Value = employeeNominationMaster,
					TypeName = "dbo.UDT_EmployeeNominationMaster"
				},
				employeeIdParam =  new SqlParameter(){
					ParameterName = "@employeeId",
					SqlDbType = SqlDbType.Int,
					Direction = ParameterDirection.Output
				};
			
			hrmsEntities.Database.ExecuteSqlCommand("exec dbo.InsertEmployeeDetails @employeePersonalDetails,@employeeDocumentMaster,@employeeContractorMaster,@employeeCompanyMaster,@employeeNominationMaster,@employeeId output", employeePersonalDetailsParam, employeeDocumentMasterParam, employeeContractorMasterParam, employeeCompanyMasterParam, employeeNominationMasterParam, employeeIdParam);
			return Convert.ToInt32(employeeIdParam.Value);
		}
    }
}