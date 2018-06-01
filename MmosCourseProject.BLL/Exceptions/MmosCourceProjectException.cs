using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MmosCourseProject.BLL.Exceptions
{
    /// <summary>
    /// Basic class for custom exceptions
    /// </summary>
    public abstract class MmosCourceProjectException : Exception
    {
        public MmosCourceProjectException(){ }

        public MmosCourceProjectException(string message):base(message){}

        public MmosCourceProjectException(string message, Exception innerException):base(message, innerException){}
    }
}
