using BackEnd._Services.Interfaces;
using BackEnd.Data;
using BackEnd.Models.DTOs;
using BackEnd.Models.Entities;
using BackEnd.Models.Mappers;
using Microsoft.AspNetCore.Mvc;

namespace BackEnd._Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsersController : ControllerBase
    {
        private readonly DataContext context;
        private readonly IAuthService authService;
        private readonly IMapper mapper;

        public UsersController(DataContext context, IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }

        [HttpPost("register")]
        public async Task<ActionResult> Register(UserDTO register)
        {
            var user = mapper.forUser().map(register);

            context.Users.Add(user);
            await context.SaveChangesAsync();

            return CreatedAtAction("GetUser", new { email = user.Email }, user);
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
