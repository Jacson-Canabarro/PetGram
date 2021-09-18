using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PetGram.Api.models;
using PetGram.Api.Token;
using PetGram.Domain.Interfaces.Services;

namespace PetGram.Api.Controllers
{
    
    [Route("/auth")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        
        
        private readonly IPetService _service;

        public AuthController(IPetService petService)
        {
            _service = petService;
        }
        
        
        [HttpPost]
        [AllowAnonymous]
        public ActionResult<dynamic> Authenticate([FromBody] PetLoginDto value)
        {
            var pet =  _service.Login(value.Email, value.Password);
            if (pet == null)
                return NotFound(new { message = "Email ou senha inválidos" });

            var token = TokenService.GenerateToken(pet);
            pet.Password = "";
            return new
            {
                token = token
            };
        }
        
        
        
    }
}