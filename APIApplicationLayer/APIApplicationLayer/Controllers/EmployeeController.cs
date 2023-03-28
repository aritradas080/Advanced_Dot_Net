using BusinessLogic01Layer.ModelDTOs;
using BusinessLogic01Layer.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace APIApplicationLayer.Controllers
{
    public class EmployeeController : ApiController
    {
        [HttpGet]
        [Route("api/employees")]

        public HttpResponseMessage AllEmployees()
        {
            try
            {
                var data = EmployeeService.Get();
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }catch(Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }


        [HttpGet]
        [Route("api/employees/{id}")]
        public HttpResponseMessage SingleEmployee(int id)
        {
            try
            {
                var data = EmployeeService.Get(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }

        [HttpPost]
        [Route("api/employees/Create")]
        public HttpResponseMessage CreateEmployee(EmployeeDTO employeeDTO)
        {
            try
            {
                var data = EmployeeService.Create(employeeDTO);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }

        [HttpPost]
        [Route("api/employees/Update")]
        public HttpResponseMessage UpdateEmployee(EmployeeDTO employeeDTO)
        {
            try
            {
                var data = EmployeeService.Update(employeeDTO);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }

        [HttpGet]
        [Route("api/employees/Delete/{id}")]
        public HttpResponseMessage DeleteEmployee(int id)
        {
            try
            {
                var data = EmployeeService.Delete(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }
    }
}
