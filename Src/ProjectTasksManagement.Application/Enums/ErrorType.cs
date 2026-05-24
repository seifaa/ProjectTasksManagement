using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectTasksManagement.Application.Enums
{
  
    public enum ErrorType
    {
        NotFound = 404,
        BadRequest = 400,
        Conflict = 409,
        Unauthorized = 401,
        InternalServerError = 500
    }
}
