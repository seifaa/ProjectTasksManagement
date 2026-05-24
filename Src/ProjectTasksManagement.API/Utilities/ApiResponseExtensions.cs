using Microsoft.AspNetCore.Mvc;
using ProjectTasksManagement.Application.Enums;
using ProjectTasksManagement.Application.GenericResponse;

namespace ProjectTasksManagement.API.Utilities
{

    public static class ApiResponseExtensions
    {
        public static IActionResult ToActionResult<T>(this ApiResponse<T> response)
        {
            if (response.IsSuccess)
            {

                return response.SucessType switch
                {
                    SucessType.Ok => new OkObjectResult(response),
                    SucessType.Created => new CreatedResult("", response),
                    _ => new ObjectResult(response.Error) { StatusCode = 500 } // refactor this
                };
            }

            return response.Error.ErrorType switch
            {
                ErrorType.NotFound => new NotFoundObjectResult(response),
                ErrorType.BadRequest => new BadRequestObjectResult(response),
                ErrorType.Conflict => new ConflictObjectResult(response),
                _ => new ObjectResult(response.Error) { StatusCode = 500 } //refactor this
            };
        }
        public static IActionResult ToActionResult(this ApiResponse response)
        {
            if (response.IsSuccess)
            {


                return new OkObjectResult(response);
                  
                
            }

            return response.Error.ErrorType switch
            {
                ErrorType.NotFound => new NotFoundObjectResult(response),
                ErrorType.BadRequest => new BadRequestObjectResult(response),
                ErrorType.Conflict => new ConflictObjectResult(response),
                _ => new ObjectResult(response.Error) { StatusCode = 500 } //refactor this
            };
        }

    }
}