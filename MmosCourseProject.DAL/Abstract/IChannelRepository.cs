using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MmosCourseProject.DAL;

namespace MmosCourseProject.DAL.Abstract
{
    public interface IChannelRepository : IRepository<Channel, int>
    {
        /// <summary>
        /// Все учасники канала
        /// </summary>
        List<User> GetMembers(int channelId);

        /// <summary>
        /// Все каналы, которые относятся к данной команде (без учета вложенных)
        /// </summary>
        List<Channel> GetChannelsByTeam(int teamId);
    }
}
