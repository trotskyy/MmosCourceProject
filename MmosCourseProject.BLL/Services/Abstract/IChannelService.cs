using MmosCourseProject.BLL.Dto.Enum;
using MmosCourseProject.BLL.Dto.General;
using MmosCourseProject.BLL.Dto;
using System.Collections.Generic;
using System;
using MmosCourseProject.BLL.DataStructures;

namespace MmosCourseProject.BLL.Services.Abstract
{
    public interface IChannelService
    {
        IChannelSelectService Get { get; }

        void CreateChannel(ChannelDto channel);

        void DeleteChannel(ChannelDto channel);
        
        /// <summary>
        /// Пригласить пользова-теля в канал
        /// </summary>
        /// <param name="channel"></param>
        /// <param name="userLogin"></param>
        void InviteUserToChannel(ChannelDto channel, string userLogin);

        void DeleteUserFromChannel(ChannelDto channel, UserDto user);

        void SendMessage(ChatMessageDto chatMessage);
    }
}