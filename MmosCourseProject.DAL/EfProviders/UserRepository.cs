﻿using MmosCourseProject.DAL.Abstract;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MmosCourseProject.DAL.EfProviders
{
    public class UserRepository : GenericRepository<User, int, MyTrelloContext>, IUserRepository
    {
        public UserRepository(MyTrelloContext dbContext) : base(dbContext)
        {
        }
    }
}
