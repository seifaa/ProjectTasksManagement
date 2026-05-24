using ProjectTasksManagement.Application.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectTasksManagement.Application.GenericResponse
{
    public record ValidationErrorDetail(string PropertyName, string ErrorMessage);

    public record ValidationError : Error
    {
        public List<ValidationErrorDetail> ValidationErrors { get; }

        public ValidationError(string code, string message, List<ValidationErrorDetail> validationErrors)
            : base(code, message, ErrorType.BadRequest)
        {
            ValidationErrors = validationErrors;
        }

    }
}
