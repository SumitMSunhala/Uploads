﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;

namespace GlobalHRMSApi.Models
{
	public class Models
	{

	}

	public class LoginRequest
	{
		public string Username { get; set; }
		public string Password { get; set; }
	}

	public class LoginResponse
	{
		public LoginResponse()
		{

			this.Token = "";
			this.responseMsg = new HttpResponseMessage() { StatusCode = System.Net.HttpStatusCode.Unauthorized };
		}

		public string Token { get; set; }
		public HttpResponseMessage responseMsg { get; set; }

	}

	public class City
	{
		public int ID { get; set; }
		public string Name { get; set; }
		public int StateId { get; set; }
		public bool IsActive { get; set; }
	}


}