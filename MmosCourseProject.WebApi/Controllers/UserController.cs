using MmosCourseProject.BLL.Dto.General;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Results;

namespace MmosCourseProject.WebApi.Controllers
{
    public class UserController : ApiController
    {

        [HttpPost]
        public HttpResponseMessage Login(string login, string password)
        {
            var token = string.Empty;
            var responce = this.Request.CreateResponse(HttpStatusCode.OK, token);
            return responce;
        }

        [HttpPost]
        public HttpResponseMessage Register(string login, string password)
        {
            var user = new UserDto();
            var responce = this.Request.CreateResponse(HttpStatusCode.Created, user);
            return responce;
        }

        [HttpPost]
        public HttpResponseMessage EditBio(UserDto user)
        {
            var responce = this.Request.CreateResponse(HttpStatusCode.OK);
            return responce;
        }
    }
}
