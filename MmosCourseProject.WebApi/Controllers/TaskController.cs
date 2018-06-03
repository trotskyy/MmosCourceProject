using MmosCourseProject.BLL.Dto.General;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MmosCourseProject.WebApi.Controllers
{
    public class TaskController : ApiController
    {
        [HttpGet]
        public HttpResponseMessage GetTaskForUser(int userId)
        {
            var tasks = new List<TaskDto>();
            var responce = this.Request.CreateResponse(HttpStatusCode.OK, tasks);
            return responce;
        }

        [HttpPost]
        public HttpResponseMessage CreateTask(TaskDto task)
        {
            var responce = this.Request.CreateResponse(HttpStatusCode.Created);
            return responce;
        }

        [HttpPatch]
        public HttpResponseMessage UpdateTask(TaskDto task)
        {
            var responce = this.Request.CreateResponse(HttpStatusCode.OK);
            return responce;
        }

        [HttpDelete]
        public HttpResponseMessage DeleteTask(int taskId, int userId)
        {
            var responce = this.Request.CreateResponse(HttpStatusCode.OK);
            return responce;
        }

        [HttpPost]
        public HttpResponseMessage CreateTaskComment(CommentDto comment)
        {
            var responce = this.Request.CreateResponse(HttpStatusCode.Created);
            return responce;
        }

        [HttpDelete]
        public HttpResponseMessage DeleteTaskComment(int taskId, int userId)
        {
            var responce = this.Request.CreateResponse(HttpStatusCode.OK);
            return responce;
        }
    }
}
