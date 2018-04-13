﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
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

		public List<EmployeePersonalDetailsList> GetEmployeeDetails(int contractorId, int? employeeId)
		{
			List<GetEmployeeDetails_Result> employeeDetailsResult = hrmsEntities.GetEmployeeDetails(contractorId, employeeId).ToList();
			List<EmployeePersonalDetailsList> employeesList = null;
			if (employeeDetailsResult != null)
			{
				employeesList = employeeDetailsResult.Where(x => x.TableName == Common.Constants.EmployeePersonalDetails)
					.Select(x => new GlobalHRMSApi.Models.EmployeePersonalDetailsList
					{
						ID = x.ID,
						DateOfBirth = x.DateOfBirth,
						MaritalStatusId = x.MaritalStatusId,
						DateOfMarriage = x.DateOfMarriage,
						Age = x.Age,
						ReligionId = x.ReligionId,
						GenderId = x.GenderId,
						BloodGroupId = x.BloodGroupId,
						Height = x.Height,
						Weight = x.Weight,
						Education = x.Education,
						MobileNo = x.MobileNo,
						EmergencyContactNo = x.EmergencyContactNo,
						EmailId = x.EmailId,
						PermenantAddressLine1 = x.PermenantAddressLine1,
						PermenantAddressLine2 = x.PermenantAddressLine2,
						TemporaryAddressLine1 = x.TemporaryAddressLine1,
						TemporaryAddressLine2 = x.TemporaryAddressLine2,
						PermenantAddressCountryId = x.PermenantAddressCountryId,
						PermenantAddressStateId = x.PermenantAddressStateId,
						PermenantAddressCityId = x.PermenantAddressCityId,
						TemporaryAddressCountryId = x.TemporaryAddressCountryId,
						TemporaryAddressStateId = x.TemporaryAddressStateId,
						TemporaryAddressCityId = x.TemporaryAddressCityId,
						EmployeeCompanyDetailsList = employeeDetailsResult.Where(z=>z.TableName == Common.Constants.EmployeeCompanyMaster && z.EmployeeId == x.EmployeeId).Select(z=>new EmployeeCompanyDetails
						{
							CompanyId = z.CompanyId,
							AppointmentTypeID = z.AppointmentTypeID,
							Designation = z.Designation,
							Category = z.Category,
							Grade = z.Grade,
							Department = z.Department,
							Plant = z.Plant,
							EmployeeId = z.EmployeeId,
							OverTimeApplicability = Convert.ToBoolean(z.OverTimeApplicability),
							ContractorId = z.ContractorId,
							EmployeeIdCode = z.EmployeeIdCode,
						}).ToList()
					})
					.ToList();
			}

			return employeesList;
		}
    }
}