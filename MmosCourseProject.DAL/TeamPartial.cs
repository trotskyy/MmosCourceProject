using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainModelValidation;

namespace MmosCourseProject.DAL
{
    [ValidateDomainConstraints(ValidationType.OnCreate | ValidationType.OnUpdate)]
    public partial class Team
    {
    }
}
