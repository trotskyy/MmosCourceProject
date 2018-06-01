using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MmosCourseProject.DAL.Abstract;

namespace MmosCourseProject.DAL.EfProviders
{
    public class TeamInfoViewRepository : GenericViewRepository<TeamInfoView, int>, ITeamInfoViewRepository
    {
        public TeamInfoViewRepository(MyTrelloContext dbContext) : base(dbContext)
        {
        }
    }
}
