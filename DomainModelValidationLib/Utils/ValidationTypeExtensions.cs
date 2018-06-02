using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainModelValidation;

namespace DomainModelValidation.Utils
{
    public static class ValidationTypeExtensions
    {
        public static bool IsOnUpdate(this ValidationType validationType)
        {
            return (validationType & ValidationType.OnUpdate) == ValidationType.OnUpdate;
        }

        public static bool IsOnCreate(this ValidationType validationType)
        {
            return (validationType & ValidationType.OnCreate) == ValidationType.OnCreate;
        }

        public static bool IsOnDelete(this ValidationType validationType)
        {
            return (validationType & ValidationType.OnDelete) == ValidationType.OnDelete;
        }
    }
}
