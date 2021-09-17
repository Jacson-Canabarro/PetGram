using Microsoft.AspNetCore.Mvc;
using PetGram.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using PetGram.Api.models;
using PetGram.Api.Token;
using PetGram.Domain.Interfaces.Services;

namespace PetGram.Api.Controllers
{
    [Route("/v1/pet")]
    [ApiController]
    public class PetController : ControllerBase
    {

        private readonly IPetService _service;

        public PetController(IPetService petService)
        {
            _service = petService;
        }

        [HttpGet]
        [Authorize]
        public List<Pet> Get()
        {
            return _service.GetAll();
        }

        [HttpPost]
        [Route("login")]
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

   
        [HttpGet("{id}")]
        [Authorize]
        public async Task<Pet> GetAsync(Guid id)
        {
            return await _service.Get(id);
        }


        [HttpPost]
        [AllowAnonymous]
        public async Task Post([FromBody] Pet value)
        {
            await _service.Save(value);
        }

 
        [HttpPut]
        [Authorize]
        public void Put([FromBody] Pet value)
        {
            _service.Update(value);
        }


        [HttpDelete]
        [Authorize]
        public void Delete([FromBody] Pet value)
        {
            _service.Delete(value);
        }
    }
}
