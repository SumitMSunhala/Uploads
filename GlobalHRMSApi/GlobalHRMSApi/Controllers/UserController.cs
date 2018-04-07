using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Security.Claims;
using System.Web;
using System.Web.Http;
using GlobalHRMSApi.Models;
using GlobalHRMSApi.BLL;
using System.Web.Http.Cors;

namespace GlobalHRMSApi.Controllers
{

	[RoutePrefix("user")]
    [EnableCors(origins: "*", headers: "*", methods: "*", exposedHeaders: "X-Custom-Header")]
    public class UserController : ApiController
	{
		UserLogic userLogic = new UserLogic();

		[Route("login")]
		[HttpPost]
		public IHttpActionResult Login([FromBody] LoginRequest login)
		{
			var loginResponse = new LoginResponse { };
			LoginRequest loginrequest = new LoginRequest { };
			loginrequest.UserName = login.UserName.ToLower();
			loginrequest.Password = login.Password;

			IHttpActionResult response;
			HttpResponseMessage responseMsg = new HttpResponseMessage();
			int loginUserId = 0;

			if (login != null)
				loginUserId = userLogic.LoginUser(login);
			// if credentials are valid
			if (loginUserId > 0)
			{
				string token = createToken(loginrequest.UserName);
				//return the token
				return Ok<string>(token);
			}
			else
			{
				// if credentials are not valid send unauthorized status code in response
				loginResponse.responseMsg.StatusCode = HttpStatusCode.Unauthorized;
				response = ResponseMessage(loginResponse.responseMsg);
				return response;
			}
		}


		[Route("register")]
		[HttpPost]
		public IHttpActionResult Register([FromBody] RegisterRequest register)
		{
			var registerResponse = new RegisterResponse { };
			RegisterRequest registerRequest = new RegisterRequest { };
			registerRequest.UserName = register.UserName.ToLower();
			registerRequest.Password = register.Password;

			IHttpActionResult response;
			HttpResponseMessage responseMsg = new HttpResponseMessage();
			int registeredUserId = 0;

			if (register != null)
				registeredUserId = userLogic.RegisterUser(register);
			// if credentials are valid
			if (registeredUserId > 0)
			{
				string token = createToken(registerRequest.UserName);
				//return the token
				return Ok<string>(token);
			}
			else
			{
				// if credentials are not valid send unauthorized status code in response
				registerResponse.responseMsg.StatusCode = HttpStatusCode.Unauthorized;
				response = ResponseMessage(registerResponse.responseMsg);
				return response;
			}
		}

		private string createToken(string username)
		{
			//Set issued at date
			DateTime issuedAt = DateTime.UtcNow;
			//set the time when it expires
			DateTime expires = DateTime.UtcNow.AddDays(7);

			//http://stackoverflow.com/questions/18223868/how-to-encrypt-jwt-security-token
			var tokenHandler = new JwtSecurityTokenHandler();

			//create a identity and add claims to the user which we want to log in
			ClaimsIdentity claimsIdentity = new ClaimsIdentity(new[]
			{
				new Claim(ClaimTypes.Name, username)
			});

			const string sec = "401b09eab3c013d4ca54922bb802bec8fd5318192b0a75f201d8b3727429090fb337591abd3e44453b954555b7a0812e1081c39b740293f765eae731f5a65ed1";
			var now = DateTime.UtcNow;
			var securityKey = new Microsoft.IdentityModel.Tokens.SymmetricSecurityKey(System.Text.Encoding.Default.GetBytes(sec));
			var signingCredentials = new Microsoft.IdentityModel.Tokens.SigningCredentials(securityKey, Microsoft.IdentityModel.Tokens.SecurityAlgorithms.HmacSha256Signature);


			//create the jwt
			var token =
				(JwtSecurityToken)
					tokenHandler.CreateJwtSecurityToken(issuer: "http://localhost:50191", audience: "http://localhost:50191",
						subject: claimsIdentity, notBefore: issuedAt, expires: expires, signingCredentials: signingCredentials);
			var tokenString = tokenHandler.WriteToken(token);

			return tokenString;
		}

	}
}