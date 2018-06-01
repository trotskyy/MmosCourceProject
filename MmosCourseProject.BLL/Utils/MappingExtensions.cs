using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AutoMapper;
using MmosCourseProject.BLL.Dto.Enum;
using MmosCourseProject.BLL.Dto.General;
using MmosCourseProject.BLL.Dto;
using MmosCourseProject.DAL;

namespace MmosCourseProject.BLL.Utils
{
    static class MappingExtensions
    {
        /*
         * TaskPriority
         */
        /// <summary>
        /// Map using Automapper
        /// </summary>
        public static TaskPriority MapToDbEntity(this TaskPriorityDto dto)
        {
            return Mapper.Map<TaskPriority>(dto);
        }
        /// <summary>
        /// Map using Automapper
        /// </summary>
        public static TaskPriorityDto MapToDto(this TaskPriority dbe)
        {
            return Mapper.Map<TaskPriorityDto>(dbe);
        }
        /// <summary>
        /// Map using Automapper
        /// </summary>
        public static List<TaskPriority> MapToDbEntity(this List<TaskPriorityDto> dto)
        {
            return Mapper.Map<List<TaskPriority>>(dto);
        }
        /// <summary>
        /// Map using Automapper
        /// </summary>
        public static List<TaskPriorityDto> MapToDto(this List<TaskPriority> dbe)
        {
            return Mapper.Map< List<TaskPriorityDto>>(dbe);
        }

        /*
         * TaskState
         */
        /// <summary>
        /// Map using Automapper
        /// </summary>
        public static TaskState MapToDbEntity(this TaskStateDto dto)
        {
            return Mapper.Map<TaskState>(dto);
        }
        /// <summary>
        /// Map using Automapper
        /// </summary>
        public static TaskStateDto MapToDto(this TaskState dbe)
        {
            return Mapper.Map<TaskStateDto>(dbe);
        }
        /// <summary>
        /// Map using Automapper
        /// </summary>
        public static List<TaskState> MapToDbEntity(this List<TaskStateDto> dto)
        {
            return Mapper.Map<List<TaskState>>(dto);
        }
        /// <summary>
        /// Map using Automapper
        /// </summary>
        public static List<TaskStateDto> MapToDto(this List<TaskState> dbe)
        {
            return Mapper.Map<List<TaskStateDto>>(dbe);
        }


        /*
         * UserLevel
         */
        /// <summary>
        /// Map using Automapper
        /// </summary>
        public static UserLevel MapToDbEntity(this UserLevelDto dto)
        {
            return Mapper.Map<UserLevel>(dto);
        }
        /// <summary>
        /// Map using Automapper
        /// </summary>
        public static UserLevelDto MapToDto(this UserLevel dbe)
        {
            return Mapper.Map<UserLevelDto>(dbe);
        }
        /// <summary>
        /// Map using Automapper
        /// </summary>
        public static List<UserLevel> MapToDbEntity(this List<UserLevelDto> dto)
        {
            return Mapper.Map<List<UserLevel>>(dto);
        }
        /// <summary>
        /// Map using Automapper
        /// </summary>
        public static List<UserLevelDto> MapToDto(this List<UserLevel> dbe)
        {
            return Mapper.Map<List<UserLevelDto>>(dbe);
        }

        /*
         * UserPosition
         */
        /// <summary>
        /// Map using Automapper
        /// </summary>
        public static UserPosition MapToDbEntity(this UserPositionDto dto)
        {
            return Mapper.Map<UserPosition>(dto);
        }
        /// <summary>
        /// Map using Automapper
        /// </summary>
        public static UserPositionDto MapToDto(this UserPosition dbe)
        {
            return Mapper.Map<UserPositionDto>(dbe);
        }
        /// <summary>
        /// Map using Automapper
        /// </summary>
        public static List<UserPosition> MapToDbEntity(this List<UserPositionDto> dto)
        {
            return Mapper.Map<List<UserPosition>>(dto);
        }
        /// <summary>
        /// Map using Automapper
        /// </summary>
        public static List<UserPositionDto> MapToDto(this List<UserPosition> dbe)
        {
            return Mapper.Map<List<UserPositionDto>>(dbe);
        }


        ////////////////////// GENERAL DTOs //////////////////////////////////////////
        
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

        /*
         * TeamInfoView
         */
        /// <summary>
        /// Map using Automapper
        /// </summary>
        public static TeamInfoView MapToDbView(this TeamInfoDto dto)
        {
            return Mapper.Map<TeamInfoView>(dto);
        }
        /// <summary>
        /// Map using Automapper
        /// </summary>
        public static TeamInfoDto MapToDto(this TeamInfoView dbe)
        {
            return Mapper.Map<TeamInfoDto>(dbe);
        }
        /// <summary>
        /// Map using Automapper
        /// </summary>
        public static List<TeamInfoView> MapToDbView(this List<TeamInfoDto> dto)
        {
            return Mapper.Map<List<TeamInfoView>>(dto);
        }
        /// <summary>
        /// Map using Automapper
        /// </summary>
        public static List<TeamInfoDto> MapToDto(this List<TeamInfoView> dbe)
        {
            return Mapper.Map<List<TeamInfoDto>>(dbe);
        }

        /*
         * TaskInfoView
         */
        /// <summary>
        /// Map using Automapper
        /// </summary>
        public static TaskInfoView MapToDbView(this TaskInfoDto dto)
        {
            return Mapper.Map<TaskInfoView>(dto);
        }
        /// <summary>
        /// Map using Automapper
        /// </summary>
        public static TaskInfoDto MapToDto(this TaskInfoView dbe)
        {
            return Mapper.Map<TaskInfoDto>(dbe);
        }
        /// <summary>
        /// Map using Automapper
        /// </summary>
        public static List<TaskInfoView> MapToDbView(this List<TaskInfoDto> dto)
        {
            return Mapper.Map<List<TaskInfoView>>(dto);
        }
        /// <summary>
        /// Map using Automapper
        /// </summary>
        public static List<TaskInfoDto> MapToDto(this List<TaskInfoView> dbe)
        {
            return Mapper.Map<List<TaskInfoDto>>(dbe);
        }
    }
}
