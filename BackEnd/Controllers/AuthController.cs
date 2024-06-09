using BackEnd._Services.Interfaces;
using BackEnd.Data;
using BackEnd.Models.DTOs;
using BackEnd.Models.Entities;
using BackEnd.Models.Mappers;
using BCrypt.Net;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;

namespace BackEnd.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthController : ControllerBase
    {
        private readonly IAuthService service;
        private readonly IUnitOfWork repository;
        private readonly IMapper mapper;
        private readonly PasswordHasher<User> hasher;

        public AuthController(IAuthService service, IUnitOfWork repository, IMapper mapper)
        {
            this.service = service;
            this.repository = repository;
            this.mapper = mapper;
            this.hasher = new PasswordHasher<User>();
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register([FromBody] RegisterDTO dto)
        {
            if (await repository.UserRepository.GetByEmailAsync(dto.Email) != null)
            {
                return BadRequest("Email already exists!");
            }

            var user = new User()
            {
                Email = dto.Email,
                Username = dto.Username,
                Password = BCrypt.Net.BCrypt.EnhancedHashPassword(dto.Password, 13)
            };

            await repository.UserRepository.AddAsync(user);

            return CreatedAtAction(nameof(Register), new { id = user.Id}, user);
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] LoginDTO dto)
        {
            var user = !dto.Email.IsNullOrEmpty() ? await repository.UserRepository.GetByEmailAsync(dto.Email) : await repository.UserRepository.GetByUsernameAsync(dto.Username);
            if (user == null)
            {
                return NotFound("Who are you?");
            }else if(BCrypt.Net.BCrypt.EnhancedVerify(dto.Password, user.Password)){
                Authenticate();
            }else
            {
                return BadRequest("Smth is off...");
            }

            return Ok("Successfully logged in!");
        }

        private static void Authenticate()
        {
            //Do something with tokens
        }
    }
}
