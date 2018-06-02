using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AutoMapper;
using MmosCourseProject.BLL.Dto.Enum;
using MmosCourseProject.BLL.Dto;
using MmosCourseProject.DAL;
using MmosCourseProject.BLL.Dto.Parameters.Creational;

namespace MmosCourseProject.BLL.Utils
{
    static class MappingExtensionsForEnums
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
    }
}
