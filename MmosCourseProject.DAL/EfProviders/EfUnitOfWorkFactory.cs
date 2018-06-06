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
    public class EfUnitOfWorkFactory : IUnitOfWorkFactory
    {
        private DbContext _context;

        public EfUnitOfWorkFactory(DbContext context)
        {
            _context = context;
        }

        public IUnitOfWork GetUnitOfWork()
        {
            return new UnitOfWork(_context);
        }
    }
}
