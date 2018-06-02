using System;
using System.Runtime.Serialization;

namespace DomainModelValidation.Exceptions
{
    [Serializable]
    internal class RulesSetNotSpecifiedException : Exception
    {
        public RulesSetNotSpecifiedException()
        {
        }

        public RulesSetNotSpecifiedException(string message) : base(message)
        {
        }

        public RulesSetNotSpecifiedException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected RulesSetNotSpecifiedException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}