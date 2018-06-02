using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModelValidation
{
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false)]
    public class ValidateDomainConstraintsAttribute : Attribute
    {
        private ValidationType _validationType;

        public ValidateDomainConstraintsAttribute(ValidationType validationType)
        {
            _validationType = validationType;
        }

        public ValidationType GetValidationType()
        {
            return _validationType;
        }
    }
}
