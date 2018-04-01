using System;
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

    public class Country
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public bool IsActive { get; set; }
    }

    public class State
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int CountryId { get; set; }
        public bool IsActive { get; set; }
    }

    public class City
	{
		public int ID { get; set; }
		public string Name { get; set; }
		public int StateId { get; set; }
		public bool IsActive { get; set; }
	}

    public class Gender
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public bool IsActive { get; set; }
    }

    public class MaritalStatus
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public bool IsActive { get; set; }
    }

    public class ModeOfPayment
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public bool IsActive { get; set; }
    }

    public class Religion
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public bool IsActive { get; set; }
    }

    public class BloodGroup
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public bool IsActive { get; set; }
    }


    public class AppointmentType
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public bool IsActive { get; set; }
    }

    public class Bank
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public bool IsActive { get; set; }
    }

    public class BankBranch
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int BankId { get; set; }
        public bool IsActive { get; set; }
    }

    public class Category
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public bool IsActive { get; set; }
    }

    public class Education
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public bool IsActive { get; set; }
    }

    public class Designation
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public bool IsActive { get; set; }
    }

    public class Grade
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public bool IsActive { get; set; }
    }

    public class Relation
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public bool IsActive { get; set; }
    }

    public class Unit
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public bool IsActive { get; set; }
    }

    public class Department
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public bool IsActive { get; set; }
    }

    public class Company
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public bool IsActive { get; set; }
        public string Address { get; set; }
        public int CountryId { get; set; }
        public int StateId { get; set; }
        public int CityId { get; set; }
        public string ZipCode { get; set; }
        public string Phone { get; set; }
        public string EmailId { get; set; }
        public string WebSite { get; set; }
		public string Logo { get; set; }
    }

    public class Contractor
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public bool IsActive { get; set; }
    }

}