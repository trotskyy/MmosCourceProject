using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MmosCourseProject.DAL.Abstract;

namespace MmosCourseProject.DAL
{
    public class ChannelRepository : GenericRepository<Channel, int>, IChannelRepository
    {
        public ChannelRepository(MyTrelloContext dbContext) : base(dbContext)
        {
        }
    }
}
