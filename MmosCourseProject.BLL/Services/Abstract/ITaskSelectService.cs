using MmosCourseProject.BLL.Dto.Enum;
using MmosCourseProject.BLL.Dto.General;
using MmosCourseProject.BLL.Dto;
using System.Collections.Generic;
using System;
using MmosCourseProject.BLL.DataStructures;

namespace MmosCourseProject.BLL.Services.Abstract
{
    /// <summary>
    /// Provides entry point to SELECT operations
    /// </summary>
    public interface ITaskSelectService
    {
        List<TaskDto> TasksByExecutor(UserDto executor);
    }
}
