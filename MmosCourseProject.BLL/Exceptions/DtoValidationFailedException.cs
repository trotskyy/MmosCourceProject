using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MmosCourseProject.BLL.Exceptions
{
    public class DtoValidationFailedException : MmosCourceProjectException
    {
        public DtoValidationFailedException(string message) : base(message) { }
    }
}
