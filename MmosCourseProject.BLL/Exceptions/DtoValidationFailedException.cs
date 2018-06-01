using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MmosCourseProject.BLL.Exceptions
{
    public class DtoValidationFailedException : MmosCourceProjectException
    {
        /// <summary>
        /// Use to define which DTO elements failed validation. If null watch Message property.
        /// </summary>
        public List<ValidationResult> ValidationResults { get; set; }

        public DtoValidationFailedException(List<ValidationResult> validationResults)
        {
            ValidationResults = validationResults;
        }

        public DtoValidationFailedException(string message) : base(message) { }
    }
}
