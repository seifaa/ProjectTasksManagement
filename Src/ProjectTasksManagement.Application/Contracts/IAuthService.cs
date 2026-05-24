using ProjectTasksManagement.Application.Dtos.Authentication;
using ProjectTasksManagement.Application.GenericResponse;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectTasksManagement.Application.Contracts
{
   public interface IAuthService
     {
        Task<ApiResponse<AuthResponseDto>> RegisterAsync(RegisterRequestDto userDto);
        Task<ApiResponse<AuthResponseDto>> LoginAsync(LoginRequestDto userDto);
    }
}
