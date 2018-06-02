using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AutoMapper;
using MmosCourseProject.BLL.Dto;
using MmosCourseProject.DAL;
using MmosCourseProject.BLL.Dto.Parameters.Selectional;

namespace MmosCourseProject.BLL.Utils
{
    static class MappingExtensionsForSelectionalDtos
    {        
        /*
         * Channel
         */
        /// <summary>
        /// Map using Automapper
        /// </summary>
        public static Channel MapToDbEntity(this ChannelDto dto)
        {
            return Mapper.Map<Channel>(dto);
        }
        /// <summary>
        /// Map using Automapper
        /// </summary>
        public static ChannelDto MapToDto(this Channel dbe)
        {
            return Mapper.Map<ChannelDto>(dbe);
        }
        /// <summary>
        /// Map using Automapper
        /// </summary>
        public static List<Channel> MapToDbEntity(this List<ChannelDto> dto)
        {
            return Mapper.Map<List<Channel>>(dto);
        }
        /// <summary>
        /// Map using Automapper
        /// </summary>
        public static List<ChannelDto> MapToDto(this List<Channel> dbe)
        {
            return Mapper.Map<List<ChannelDto>>(dbe);
        }

        /*
         * ChatMessage
         */
        /// <summary>
        /// Map using Automapper
        /// </summary>
        public static ChatMessage MapToDbEntity(this ChatMessageDto dto)
        {
            return Mapper.Map<ChatMessage>(dto);
        }
        /// <summary>
        /// Map using Automapper
        /// </summary>
        public static ChatMessageDto MapToDto(this ChatMessage dbe)
        {
            return Mapper.Map<ChatMessageDto>(dbe);
        }
        /// <summary>
        /// Map using Automapper
        /// </summary>
        public static List<ChatMessage> MapToDbEntity(this List<ChatMessageDto> dto)
        {
            return Mapper.Map<List<ChatMessage>>(dto);
        }
        /// <summary>
        /// Map using Automapper
        /// </summary>
        public static List<ChatMessageDto> MapToDto(this List<ChatMessage> dbe)
        {
            return Mapper.Map<List<ChatMessageDto>>(dbe);
        }

        /*
         * Comment
         */
        /// <summary>
        /// Map using Automapper
        /// </summary>
        public static Comment MapToDbEntity(this CommentDto dto)
        {
            return Mapper.Map<Comment>(dto);
        }
        /// <summary>
        /// Map using Automapper
        /// </summary>
        public static CommentDto MapToDto(this Comment dbe)
        {
            return Mapper.Map<CommentDto>(dbe);
        }
        /// <summary>
        /// Map using Automapper
        /// </summary>
        public static List<Comment> MapToDbEntity(this List<CommentDto> dto)
        {
            return Mapper.Map<List<Comment>>(dto);
        }
        /// <summary>
        /// Map using Automapper
        /// </summary>
        public static List<CommentDto> MapToDto(this List<Comment> dbe)
        {
            return Mapper.Map<List<CommentDto>>(dbe);
        }

        /*
         * Task
         */
        /// <summary>
        /// Map using Automapper
        /// </summary>
        public static Task MapToDbEntity(this TaskDto dto)
        {
            return Mapper.Map<Task>(dto);
        }
        /// <summary>
        /// Map using Automapper
        /// </summary>
        public static TaskDto MapToDto(this Task dbe)
        {
            return Mapper.Map<TaskDto>(dbe);
        }
        /// <summary>
        /// Map using Automapper
        /// </summary>
        public static List<Task> MapToDbEntity(this List<TaskDto> dto)
        {
            return Mapper.Map<List<Task>>(dto);
        }
        /// <summary>
        /// Map using Automapper
        /// </summary>
        public static List<TaskDto> MapToDto(this List<Task> dbe)
        {
            return Mapper.Map<List<TaskDto>>(dbe);
        }

        /*
         * User
         */
        /// <summary>
        /// Map using Automapper
        /// </summary>
        public static User MapToDbEntity(this UserDto dto)
        {
            return Mapper.Map<User>(dto);
        }
        /// <summary>
        /// Map using Automapper
        /// </summary>
        public static UserDto MapToDto(this User dbe)
        {
            return Mapper.Map<UserDto>(dbe);
        }
        /// <summary>
        /// Map using Automapper
        /// </summary>
        public static List<User> MapToDbEntity(this List<UserDto> dto)
        {
            return Mapper.Map<List<User>>(dto);
        }
        /// <summary>
        /// Map using Automapper
        /// </summary>
        public static List<UserDto> MapToDto(this List<User> dbe)
        {
            return Mapper.Map<List<UserDto>>(dbe);
        }
    }
}
