using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PetGram.Domain.Entities;
using PetGram.Application.services;

namespace PetGram.Api.Controllers {
    [Route("/v1/comment")]
    [ApiController]
    public class CommentController : ControllerBase {

        private readonly CommentService _service;

        public CommentController(CommentService commentService) {
            _service = commentService;
        }

        [HttpGet]
        public List<Comment> Get() {
            return _service.GetAll();
        }

        [HttpPost]
        public void Post([FromBody] Comment value) {
            _service.Save(value);
        }

        [HttpGet ("{id}")]
        public async Task<Comment> GetAsync(Guid id) {
            return await _service.Get(id);
        }

        [HttpDelete("{id}")]
        public void Delete(Comment id) {
            _service.Delete(id);
        }

        [HttpPut("{id}")]
        public void Put([FromBody] Comment value) {
            _service.Update(value);
        }

    }
}
