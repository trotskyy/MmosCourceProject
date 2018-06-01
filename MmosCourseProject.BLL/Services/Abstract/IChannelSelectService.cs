using MmosCourseProject.BLL.Dto.General;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MmosCourseProject.BLL.Services.Abstract
{
    /// <summary>
    /// Provides entry point to SELECT operations
    /// </summary>
    public interface IChannelSelectService
    {
        List<ChannelDto> ChannelsByTeam(TeamDto team);

        List<UserDto> ChannelMembers(ChannelDto channel);
    }
}
