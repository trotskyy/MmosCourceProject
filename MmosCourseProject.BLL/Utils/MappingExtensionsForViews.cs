using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AutoMapper;
using MmosCourseProject.BLL.Dto.Enum;
using MmosCourseProject.BLL.Dto.General;
using MmosCourseProject.DAL;

namespace MmosCourseProject.BLL.Utils
{
    static class MappingExtensionsForViews
    {
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
