using MmosCourseProject.BLL.DataStructures;
using MmosCourseProject.BLL.Dto.General;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MmosCourseProject.WebApi.Controllers
{
    public class TeamController : ApiController
    {
        [HttpGet]
        public HttpResponseMessage GetTeamsForUser(int userId)
        {
            var teams = new List<TeamDto>();
            var responce = this.Request.CreateResponse(HttpStatusCode.OK, teams);
            return responce;
        }

        [HttpGet]
        public HttpResponseMessage GetSubteamsForUser(int teamId, int userId)
        {
            var rootTeam = new TeamDto();
            var teams = new Tree<TeamDto>(rootTeam);
            var responce = this.Request.CreateResponse(HttpStatusCode.OK, teams);
            return responce;
        }
    
        [HttpGet]
        public HttpResponseMessage GetTeamParticipants(int teamId)
        {
            var users = new List<UserDto>();
            var responce = this.Request.CreateResponse(HttpStatusCode.OK, users);
            return responce;
        }

        [HttpPost]
        public HttpResponseMessage CreateTeam(TeamDto team)
        {
            var responce = this.Request.CreateResponse(HttpStatusCode.Created);
            return responce;
        }

        [HttpDelete]
        public HttpResponseMessage DeleteTeam(int teamId, int creatorId)
        {
            var responce = this.Request.CreateResponse(HttpStatusCode.OK);
            return responce;
        }

        [HttpPost]
        public HttpResponseMessage InviteUserToTeam(int teamId, string userEmail)
        {
            var responce = this.Request.CreateResponse(HttpStatusCode.OK);
            return responce;
        }

        [HttpDelete]
        public HttpResponseMessage DeleteUserFromTeam(int teamId, int userId)
        {
            var responce = this.Request.CreateResponse(HttpStatusCode.OK);
            return responce;
        }
    }
}