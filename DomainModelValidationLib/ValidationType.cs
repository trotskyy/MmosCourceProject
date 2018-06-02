using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModelValidation
{
    [Flags]
    public enum ValidationType
    {
        OnUpdate = 1,
        OnCreate = 2,
        OnDelete = 4
    }
}
