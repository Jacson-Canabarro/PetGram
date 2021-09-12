using Microsoft.AspNetCore.Mvc;
using PetGram.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using PetGram.Api.models;
using PetGram.Api.Token;
using PetGram.Application.services;

namespace PetGram.Api.Controllers
{
    [Route("/v1/pet")]
    [ApiController]
    public class PetController : ControllerBase
    {

        private readonly PetService _service;

        public PetController(PetService petService)
        {
            _service = petService;
        }

        [HttpGet]
        [AllowAnonymous]
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
                pet = pet,
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
        public void Post([FromBody] Pet value)
        {
            _service.Save(value);
        }

 
        [HttpPut("{id}")]
        [Authorize]
        public void Put([FromBody] Pet value)
        {
            _service.Update(value);
        }


        [HttpDelete("{id}")]
        [Authorize]
        public void Delete(Pet id)
        {
            _service.Delete(id);
        }
    }
}
