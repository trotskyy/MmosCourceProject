using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MmosCourseProject.DAL.Abstract;

namespace MmosCourseProject.DAL.EfProviders
{
    public class TeamRepository : EfGenericRepository<Team, int>, ITeamRepository
    {
        public TeamRepository(MyTrelloContext dbContext) : base(dbContext)
        {
        }

        /*
         * NOTE!
         * Due to absence of foreign key constraints in Teams table, hierarchical deletion is implemented by trigger
         */
        
    }
}
