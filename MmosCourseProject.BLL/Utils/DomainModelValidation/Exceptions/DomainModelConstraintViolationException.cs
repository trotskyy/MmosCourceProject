using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace MmosCourseProject.BLL.Utils.DomainModelValidation.Exceptions
{
    public class DomainModelConstraintViolationException : Exception
    {
        public DomainModelConstraintViolationException()
        {

        }

        public DomainModelConstraintViolationException(string message) : base(message)
        {
        }

        public DomainModelConstraintViolationException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected DomainModelConstraintViolationException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
