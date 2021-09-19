using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PetGram.Domain.Entities;
using PetGram.Domain.Interfaces.Repositories;
using PetGram.Domain.Interfaces.Services;
using PetGram.Infra.Repositories;

namespace PetGram.Application.services
{
    public class PostService : IPostService
    {
        private readonly IPostRepository _ptr;
        private readonly IPetRepository _petRepository;
        private readonly ImageUpload _imageUpload;

        public PostService(IPostRepository postRepository, IPetRepository petRepository, ImageUpload imageUpload)
        {
            _ptr = postRepository;
            _petRepository = petRepository;
            _imageUpload = imageUpload;
        }

        public void Delete(Post id)
        {
            _ptr.Delete(id);
        }

        public async Task<Post> Get(Guid id)
        {
            return await _ptr.Get(id);
        }

        public List<Post> GetAll()
        {
            return _ptr.GetAll().ToList();
        }

        public async Task Save(Post entity)
        {
            var pet = await _petRepository.Get(entity.petId);
            entity.pet = pet;
            var uploadBase64Img = _imageUpload.UploadBase64Img(entity.Photo,"images");
            entity.Photo = uploadBase64Img;
            await _ptr.Save(entity);
        }

        public void Update(Post entity)
        {
            _ptr.Update(entity);
        }
    }
}