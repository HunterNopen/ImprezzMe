using BackEnd._Services.Interfaces;
using BackEnd.Models.Entities;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace BackEnd.Services
{
    public class AuthService : IAuthService
    {
        public string CreateAuthToken(User user)
        {
            var secretKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("secretkey@0506"));
            var loginCredentials = new SigningCredentials(secretKey, SecurityAlgorithms.HmacSha256);
            var tokenOptions = new JwtSecurityToken(
                issuer: "Echonos",
                audience: "https://localhost:5001",
                claims: new List<Claim>(),
                expires: DateTime.Now.AddMinutes(5),
                signingCredentials: loginCredentials
            );
            var tokenString = new JwtSecurityTokenHandler().WriteToken(tokenOptions);
            return tokenString;
        }
    }
}
