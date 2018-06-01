using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MmosCourseProject.BLL.Services.Abstract
{
    public interface IServiceFacade
    {
        IUserService UserService { get; }
        ITeamService TeamService { get; }
        IChannelService ChannelService { get; }
        ITaskService TaskService { get; }
    }
}
