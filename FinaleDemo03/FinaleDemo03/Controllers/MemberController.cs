using FinaleDemo03BLL.ModelDTO;
using FinaleDemo03BLL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace FinaleDemo03.Controllers
{
    public class MemberController : ApiController
    {
        [HttpGet]
        [Route("api/members")]
        public HttpResponseMessage AllMember()
        {
            try
            {
                var data = MemberService.Get();
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex);
            }
        }

        [HttpGet]
        [Route("api/members/{id}")]
        public HttpResponseMessage GetOneMember(int id)
        {
            try
            {
                var data = MemberService.Get(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex);
            }
        }

        [HttpPost]
        [Route("api/members/create")]
        public HttpResponseMessage Createmember(MemberDTO memberDTO)
        {
            try
            {
                var data = MemberService.Create(memberDTO);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex);
            }
        }

        [HttpPost]
        [Route("api/members/update")]
        public HttpResponseMessage Updatemember(MemberDTO memberDTO)
        {
            try
            {
                var data = MemberService.Update(memberDTO);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex);
            }
        }

        [HttpPost]
        [Route("api/members/delete/{id}")]
        public HttpResponseMessage DeleteMember(int id)
        {
            try
            {
                var data = MemberService.Delete(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex);
            }
        }
    }
}
