﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MmosCourseProject.DAL;

namespace MmosCourseProject.DAL.Abstract
{
    public interface IUnitOfWork : IDisposable
    {
        T Repository<T>() where T : class, IRepository;

        int SaveChanges();
    }
}
