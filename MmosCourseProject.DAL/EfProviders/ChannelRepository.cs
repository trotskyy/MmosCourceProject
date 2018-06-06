using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MmosCourseProject.DAL.Abstract;

namespace MmosCourseProject.DAL.EfProviders
{
    public class ChannelRepository : GenericRepository<Channel, int>, IChannelRepository
    {
        public ChannelRepository(DbContext dbContext) : base(dbContext) { }

        public IEnumerable<Channel> GetChannelsByTeam(int teamId)
        {
            var result = GetAll().Where(x => x.TeamId == teamId);
            return result;
        }

        public IEnumerable<User> GetMembers(int channelId)
        {
            var result = GetById(channelId).Users;
            return result;
        }

        public void RemoveUserFromChannel(Channel channel, User user)
        {
            channel.Users.Remove(user);
        }
    }
}
