﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MmosCourseProject.DAL.Abstract;

namespace MmosCourseProject.DAL.EfProviders
{
    public class TeamInfoViewRepository : GenericViewRepository<TeamInfoView, int>, ITeamInfoViewRepository
    {
        public TeamInfoViewRepository(DbContext dbContext) : base(dbContext)
        {
        }
    }
}
