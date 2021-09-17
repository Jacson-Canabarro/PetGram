using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using PetGram.Domain.Entities;
using PetGram.Domain.Interfaces.Services;

namespace PetGram.Api.Controllers {
    [Route("/v1/comment")]
    [ApiController]
    public class CommentController : ControllerBase {

        private readonly ICommentService _service;

        public CommentController(ICommentService commentService) {
            _service = commentService;
        }

        [HttpGet]
        [Authorize]
        public List<Comment> Get() {
            return _service.GetAll();
        }

        [HttpPost]
        [Authorize]
        public void Post([FromBody] Comment value) {
            _service.Save(value);
        }

        [HttpGet ("{id}")]
        [Authorize]
        public async Task<Comment> GetAsync(Guid id) {
            return await _service.Get(id);
        }

        [HttpDelete]
        [Authorize]
        public void Delete([FromBody] Comment value) {
            _service.Delete(value);
        }

        [HttpPut]
        [Authorize]
        public void Put([FromBody] Comment value) {
            _service.Update(value);
        }

    }
}
