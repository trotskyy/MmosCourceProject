using MmosCourseProject.DAL.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MmosCourseProject.DAL.EfProviders
{
    public interface IRepositoryFactory
    {
        T CreateRepository<T>() where T : class, IRepository;
    }
}
