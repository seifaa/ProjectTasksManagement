using ProjectTasksManagement.Application.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ProjectTasksManagement.Application.GenericResponse
{
    public record Error
    {
        public string Code { get; init; }
        public string Message { get; init; }
        [JsonIgnore]
        public ErrorType ErrorType { get; init; }

        public Error(string code, string message, ErrorType errorType)
        {
            Code = code;
            Message = message;
            ErrorType = errorType;
        }

        public static Error NotFound(string message) =>
            new("NOT_FOUND", message, ErrorType.NotFound);
        public static Error IntervalServerError(string message) =>
            new("Interval_Server_Error", message, ErrorType.InternalServerError);

        // for single line validation
        public static Error BadRequest(string message) =>
            new("Bad_Request", message, ErrorType.BadRequest);

      
    }
}
