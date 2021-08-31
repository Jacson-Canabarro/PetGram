using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using PetGram.Domain.Entities;
using Microsoft.IdentityModel.Tokens;

namespace PetGram.Api.Token
{
    public static class TokenService
    {


        public static string GenerateToken(Pet pet)
        {
            var tokenHandle = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(Settings.Secret);
            var tokenDescroptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new Claim[] { 
                    new Claim(ClaimTypes.Name, pet.Email.ToString())
                }),
                Expires = DateTime.UtcNow.AddHours(2),
                SigningCredentials = new SigningCredentials(
                    new SymmetricSecurityKey(key),
                    SecurityAlgorithms.HmacSha256Signature)
            };
           var token = tokenHandle.CreateToken(tokenDescroptor);
           return tokenHandle.WriteToken(token);
        }


    }
}
