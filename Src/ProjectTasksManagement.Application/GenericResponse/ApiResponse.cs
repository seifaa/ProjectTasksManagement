using ProjectTasksManagement.Application.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ProjectTasksManagement.Application.GenericResponse
{
    public class ApiResponse
    {
        public bool IsSuccess { get; }
        public Error Error { get; }
        public string Messsage { get; }
        [JsonIgnore]
        public SucessType SucessType { get; set; } = SucessType.Ok;
        protected ApiResponse(bool isSuccess, Error error, string messsage)
        {
            IsSuccess = isSuccess;
            Error = error;
            Messsage = messsage;
        }

        public static ApiResponse Success(string messsage = "") => new ApiResponse(true, null!,messsage);
        public static ApiResponse Failure(Error error) => new ApiResponse(false, error, error.Message);
    }
    public class ApiResponse<T> : ApiResponse
    {
        public T Data { get; }

        private ApiResponse(T data, bool isSuccess, Error error, string messsage)
            : base(isSuccess, error, messsage)
        {
            Data = data;
        }

        public static ApiResponse<T> Success(T data, string messsage = "") => new ApiResponse<T>(data, true, null!, messsage);
        public static new ApiResponse<T> Failure(Error error) => new ApiResponse<T>(default, false, error, error.Message);
    }
}
