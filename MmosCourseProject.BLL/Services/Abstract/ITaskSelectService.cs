using MmosCourseProject.BLL.Dto.Enum;
using MmosCourseProject.BLL.Dto;
using System.Collections.Generic;
using System;
using MmosCourseProject.BLL.DataStructures;
using General = MmosCourseProject.BLL.Dto.General;
using Selectional = MmosCourseProject.BLL.Dto.Parameters.Selectional;
using Creational = MmosCourseProject.BLL.Dto.Parameters.Creational;

namespace MmosCourseProject.BLL.Services.Abstract
{
    /// <summary>
    /// Provides entry point to SELECT operations
    /// </summary>
    public interface ITaskSelectService
    {
        IEnumerable<General.TaskDto> TasksByExecutor(Selectional.UserDto executor);
    }
}
