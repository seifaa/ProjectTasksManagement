using ProjectTasksManagement.Application.Contracts;
using ProjectTasksManagement.Application.Dtos.Authentication;
using ProjectTasksManagement.Application.GenericResponse;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectTasksManagement.Infrastructure.Services.Identity
{
    public class AuthService : IAuthService
    {
        public Task<ApiResponse<AuthResponseDto>> LoginAsync(LoginRequestDto userDto)
        {
            throw new NotImplementedException();
        }

        public Task<ApiResponse<AuthResponseDto>> RegisterAsync(RegisterRequestDto userDto)
        {
            throw new NotImplementedException();
        }
    }
}
