using FinaleDemo05.Auth;
using FinaleDemo05.Models;
using FinaleDemo05BLL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using System.Web.Services.Description;

namespace FinaleDemo05.Controllers
{
    [EnableCors("*", "*", "*")]
    public class AuthController : ApiController
    {

        [HttpPost]
        [Route("api/login")]
        public HttpResponseMessage Login(LoginModel loginmodel)
        {
            try
            {
                var data = AuthService.Authenticate(loginmodel.Uname, loginmodel.Password);
                if (data != null) { return Request.CreateResponse(HttpStatusCode.OK, data); }
                else return Request.CreateResponse(HttpStatusCode.NotFound, new { Message = "User not found" });

            } catch (Exception ex) {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Message = ex.Message });
            }


        }

        [Logged]
        [HttpGet]
        [Route("api/logout")]
        public HttpResponseMessage Logout()
        {

            var token = Request.Headers.Authorization.ToString();
            try
            {
                var res = AuthService.Logout(token);
                return Request.CreateResponse(HttpStatusCode.OK, res);
            }catch(Exception ex)
            {
               return Request.CreateResponse(HttpStatusCode.InternalServerError, new {Msg=ex.Message});

            }

    }
    }
}
