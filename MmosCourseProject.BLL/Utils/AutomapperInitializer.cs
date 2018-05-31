using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AutoMapper;
using MmosCourseProject.DAL;
using MmosCourseProject.BLL.Dto;
using MmosCourseProject.BLL.Dto.General;
using MmosCourseProject.BLL.Dto.Enum;

namespace MmosCourseProject.BLL.Utils
{
    public static class AutomapperInitializer
    {
        private static bool _isAutomapperInited;
        public static bool IsAutomapperInited => _isAutomapperInited;
        private static object _lockObject;

        private static Action<IMapperConfigurationExpression> _configurationDelegate =
            (cfg) => {
                //Dto.Enums
                cfg.CreateMap<TaskPriority, TaskPriorityDto>();
                cfg.CreateMap<TaskState, TaskStateDto>();
                cfg.CreateMap<UserLevel, UserLevelDto>();
                cfg.CreateMap<UserPosition, UserPositionDto>();

                //Dto.General
                cfg.CreateMap<Channel, ChannelDto>();
                cfg.CreateMap<ChatMessage, ChatMessageDto>();
                cfg.CreateMap<Comment, CommentDto>();
                cfg.CreateMap<Task, TaskDto>();
                cfg.CreateMap<Team, TeamDto>();
                cfg.CreateMap<User, UserDto>();
                cfg.CreateMap<UserTeam, UserTeamDto>();
                //----Views
                cfg.CreateMap<TaskInfoView, TaskInfoDto>();
                cfg.CreateMap<TeamInfoView, TeamInfoDto>();
            };
        /// <summary>
        /// Call it from other layer (e.g. web API) to combine with 3 - 2 layers mapping logic
        /// </summary>
        /// <param name="configurationDelegate"></param>
        public static void InitAutomapper(Action<IMapperConfigurationExpression> configurationDelegate)
        {
            lock (_lockObject)
            {
                if (_isAutomapperInited)
                    return;

                Mapper.Initialize(_configurationDelegate + configurationDelegate);

                _isAutomapperInited = true;
            }
        }

        public static void InitAutomapper()
        {
            InitAutomapper(null);
        }
    }
}
