using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectTasksManagement.Application.Dtos.Authentication
{
    public class AuthResponseDto
    {
        public string Token { get; set; }
        public string Email { get; set; }
        public string Username { get; set; }
        public DateTime Expiration { get; set; }

        //public UserDto User { get; set; }
    }
}
