using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MmosCourseProject.BLL.Utils.DomainModelValidation.Exceptions
{
    public class DomainModelValidatorConfigurationException : Exception
    {
        public DomainModelValidatorConfigurationException(string message):base(message)
        {

        }
    }
}
