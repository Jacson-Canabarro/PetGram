using System.Collections.Generic;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PetGram.Application.services;
using PetGram.Domain.Entities;

namespace PetGram.Api.Controllers
{
    public class PostController : Controller
    {


        private readonly PostService _postService;

        public PostController(PostService postService)
        {
            _postService = postService;
        }
        
        
        
        [HttpGet]
        [Authorize]
        public List<Post> Get()
        {
            return _postService.GetAll();
        }
        
        
        
        
        [HttpPost]
        [Authorize]
        public void Post([FromBody] Post value)
        {
            _postService.Save(value);
        }

 
        [HttpPut("{id}")]
        [Authorize]
        public void Put([FromBody] Post value)
        {
            _postService.Update(value);
        }
        
        
        
    }
}