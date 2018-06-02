using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModelValidation.Exceptions
{
    public class DomainModelValidatorConfigurationException : Exception
    {
        public DomainModelValidatorConfigurationException(string message):base(message)
        {

        }

        public DomainModelValidatorConfigurationException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
