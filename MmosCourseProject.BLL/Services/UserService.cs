﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MmosCourseProject.BLL.Dto.General;
using MmosCourseProject.BLL.Services.Abstract;
using MmosCourseProject.DAL;

namespace MmosCourseProject.BLL.Services
{
    public class UserService : GenericService<UserDto, User>, IUserService
    {
    }
}
