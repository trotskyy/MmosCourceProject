using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MmosCourseProject.DAL.Abstract;

namespace MmosCourseProject.DAL.EfProviders
{
    public class UserTeamRepository : GenericRepository<UserTeam, int>, IUserTeamRepository
    {
        public UserTeamRepository(DbContext dbContext) : base(dbContext)
        {
        }
    }
}
