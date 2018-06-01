using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MmosCourseProject.DAL.Abstract;

namespace MmosCourseProject.DAL.EfProviders
{
    /// <summary>
    /// Entity framewor unit of work factory
    /// </summary>
    public class EfUnitOfWorkFactory : IUnitOfWorkFactory
    {
        public IUnitOfWork GetUnitOfWork()
        {
            return new UnitOfWork();
        }
    }
}
