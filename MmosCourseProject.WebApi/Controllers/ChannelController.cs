using MmosCourseProject.BLL.Dto.General;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MmosCourseProject.WebApi.Controllers
{
    public class ChannelController : ApiController
    {
        [HttpGet]
        public HttpResponseMessage GetChannelsForUser(int userId)
        {
            var channels = new List<ChannelDto>();
            var responce = this.Request.CreateResponse(HttpStatusCode.OK, channels);
            return responce;
        }

        [HttpGet]
        public HttpResponseMessage GetChannelParticipants(int channelId)
        {
            var participants = new List<UserDto>();
            var responce = this.Request.CreateResponse(HttpStatusCode.OK, participants);
            return responce;
        }

        [HttpPost]
        public HttpResponseMessage CreateChannel(ChannelDto channel)
        {
            var responce = this.Request.CreateResponse(HttpStatusCode.Created);
            return responce;
        }

        [HttpDelete]
        public HttpResponseMessage DeleteChannel(int channelId)
        {
            var responce = this.Request.CreateResponse(HttpStatusCode.OK);
            return responce;
        }

        [HttpPost]
        public HttpResponseMessage InviteUserToChannel(int channelId, int userId)
        {
            var responce = this.Request.CreateResponse(HttpStatusCode.OK);
            return responce;
        }

        [HttpDelete]
        public HttpResponseMessage DeleteUserFromChannel(int channelId, int userId)
        {
            var responce = this.Request.CreateResponse(HttpStatusCode.OK);
            return responce;
        }

        [HttpPost]
        public HttpResponseMessage SendMessage(ChatMessageDto message)
        {
            var responce = this.Request.CreateResponse(HttpStatusCode.OK);
            return responce;
        }
    }
}
