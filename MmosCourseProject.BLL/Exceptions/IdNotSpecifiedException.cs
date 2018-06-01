using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MmosCourseProject.BLL.Exceptions
{
    public class IdNotSpecifiedException : DtoValidationFailedException
    {
        public IdNotSpecifiedException(object dtoWithoutId) : base($"Id wasn't specified for {dtoWithoutId.GetType().Name}")
        {
        }
    }
}
