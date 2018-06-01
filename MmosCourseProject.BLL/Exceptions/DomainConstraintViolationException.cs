using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MmosCourseProject.BLL.Exceptions
{
    /// <summary>
    /// Для всех вручную проверенных ограничений, которые задаются схемой
    /// </summary>
    public class DomainConstraintViolationException : DomainModelException
    {
        public DomainConstraintViolationException(string message) : base(message, null)
        {
        }
    }
}
