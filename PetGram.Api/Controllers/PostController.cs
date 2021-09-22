using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PetGram.Api.models;
using PetGram.Domain.Entities;
using PetGram.Domain.Interfaces.Services;

namespace PetGram.Api.Controllers
{
    [Route("/v1/post")]
    [ApiController]
    public class PostController : Controller
    {
        private readonly IPostService _postService;

        public PostController(IPostService postService)
        {
            _postService = postService;
        }


        [HttpGet]
        [AllowAnonymous]
        public List<Post> Get()
        {
            return _postService.GetAll();
        }


        [HttpPost]
        [Authorize]
        public async Task Post([FromBody] PostCreateDto value)
        {
            var post = this.mapToPost(value);
            await _postService.Save(post);
        }


        [HttpPut]
        [Authorize]
        public void Put([FromBody] Post value)
        {
            _postService.Update(value);
        }

        [HttpDelete]
        [Authorize]
        public void Delete([FromBody] Post value)
        {
            _postService.Delete(value);
        }


        private Post mapToPost(PostCreateDto dto)
        {
            return new Post
            {
                Description = dto.Description,
                petId = dto.petId,
                Date = DateTime.Now,
                Photo = dto.Photo,
            };
        }
    }
}