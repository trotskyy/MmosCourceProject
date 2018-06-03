using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace DomainModelValidation.Exceptions
{
    public class DomainModelConstraintViolationException : Exception
    {
        public List<Notification> Notifications { get; set; }
        public string ValidationMessage { get; set; }

        public DomainModelConstraintViolationException()
        {
            Notifications = new List<Notification>();
        }

        public DomainModelConstraintViolationException(string message) : base(message)
        {
            Notifications = new List<Notification>();
        }

        public DomainModelConstraintViolationException(string message, Exception innerException) : base(message, innerException)
        {
            Notifications = new List<Notification>();
        }

        protected DomainModelConstraintViolationException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
            Notifications = new List<Notification>();
        }
    }
}
