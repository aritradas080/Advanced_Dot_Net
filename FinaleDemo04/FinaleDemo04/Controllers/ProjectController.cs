using FinaleDemo04BLL.ModelDTO;
using FinaleDemo04BLL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace FinaleDemo04.Controllers
{
    public class ProjectController : ApiController
    {
        [HttpGet]
        [Route("api/projects")]
        public HttpResponseMessage Allproject()
        {
            try
            {
                var data = ProjectService.Get();
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex);
            }
        }

        [HttpGet]
        [Route("api/projects/{id}")]
        public HttpResponseMessage GetOneproject(int id)
        {
            try
            {
                var data = ProjectService.Get(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex);
            }
        }

        [HttpPost]
        [Route("api/projects/create")]
        public HttpResponseMessage Createproject(ProjectDTO projectDTO)
        {
            try
            {
                var data = ProjectService.Create(projectDTO);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex);
            }
        }

        [HttpPost]
        [Route("api/projects/update")]
        public HttpResponseMessage Updateproject(ProjectDTO projectDTO)
        {
            try
            {
                var data = ProjectService.Update(projectDTO);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex);
            }
        }

        [HttpGet]
        [Route("api/projects/delete/{id}")]
        public HttpResponseMessage Deleteproject(int id)
        {
            try
            {
                var data = ProjectService.Delete(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex);
            }
        }

        [HttpGet]
        [Route("api/projects/abc/{status}")]
        public HttpResponseMessage GetStatusproject(string status)
        {
            try
            {
                var data = ProjectService.GetStatusProject(status);
                return Request.CreateResponse(HttpStatusCode.OK, data);

            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex);
            }
        }

        [HttpGet]
        [Route("api/projects/abc/{status}/{date}")]
        public HttpResponseMessage GetStatusDateproject(string status, DateTime date)
        {
            try
            {
                var data = ProjectService.GetStatusDateProject(status, date);
                return Request.CreateResponse(HttpStatusCode.OK, data);

            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex);
            }
        }

    }
}
