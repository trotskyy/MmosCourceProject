using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MmosCourseProject.BLL.Utils.DomainModelValidation.Exceptions
{
    public class ValidationRuleUnregisteredException : Exception
    {
        public ValidationRuleUnregisteredException(string message):base(message)
        {

        }
    }
}
