using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MmosCourseProject.BLL.Exceptions
{
    /// <summary>
    /// Thrown if there is an exception occured while retreaving / manipulating data. Covers original exception
    /// </summary>
    public class DomainModelException : MmosCourceProjectException
    {
        public DomainModelException(string message, Exception innerException):base(message, innerException) { }

        /// <summary>
        /// DomainModelException with general Message
        /// </summary>
        /// <param name="innerException">the real error</param>
        public DomainModelException(Exception innerException) :
            base("An exception occured while retreaving / manipulating data. Watch inner exception for more info", innerException) { }
    }
}
