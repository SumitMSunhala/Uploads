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
	public class UserLogic
	{
		HRMSManagementEntities hrmsEntities = new HRMSManagementEntities();

		public int LoginUser(LoginRequest login)
		{
			int userId = hrmsEntities.LoginUser(login.UserName, login.Password);
			return userId;
		}

		public int RegisterUser(RegisterRequest register)
		{
			int userId = hrmsEntities.RegisterUser(register.UserName, register.FirstName, register.LastName, register.Email, register.Mobile, register.Password);
			return userId;
		}
	}
}