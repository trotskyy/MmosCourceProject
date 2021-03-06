﻿using MmosCourseProject.BLL.Dto.General;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Selectional = MmosCourseProject.BLL.Dto.Parameters.Selectional;


namespace MmosCourseProject.BLL.Services.Abstract
{
    /// <summary>
    /// Provides entry point to SELECT operations
    /// </summary>
    public interface IChannelSelectService
    {
        IEnumerable<ChannelDto> ChannelsByTeam(Selectional.TeamDto team);

        IEnumerable<UserDto> ChannelMembers(Selectional.ChannelDto channel);
    }
}
