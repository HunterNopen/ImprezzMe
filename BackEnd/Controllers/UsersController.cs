using BackEnd.Data;
using BackEnd.Models.DTOs;
using BackEnd.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace BackEnd.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsersController : ControllerBase
    {
        private readonly DataContext context;
        private readonly IAuthService authService;

        public UsersController(DataContext context, IAuthService authService)
        {
            this.context = context;
            this.authService = authService;
        }

        [HttpPost("register")]
        public async Task<ActionResult<UserDTO>> Register(RegisterDTO dto)
        {
            throw new NotImplementedException();
        }

        [HttpPost("login")]
        public async Task<ActionResult<UserDTO>> Login(LoginDTO dto)
        {
            throw new NotImplementedException();
        }

        private async Task<bool> doesUserExist(string login)
        {
            throw new NotImplementedException();
        }
    }
}
