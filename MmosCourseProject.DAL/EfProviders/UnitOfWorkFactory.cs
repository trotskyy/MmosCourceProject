using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MmosCourseProject.DAL.Abstract;

namespace MmosCourseProject.DAL.EfProviders
{
    /// <summary>
    /// Entity framewor unit of work factory
    /// </summary>
    public class UnitOfWorkFactory : IUnitOfWorkFactory
    {
        private Func<IUnitOfWork> _resolveUOW;

        public UnitOfWorkFactory(Func<IUnitOfWork> resolveUOW)
        {
            _resolveUOW = resolveUOW;
        }

        public IUnitOfWork GetUnitOfWork()
        {
            return _resolveUOW();
        }
    }
}
