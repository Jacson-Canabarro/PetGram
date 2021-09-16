using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PetGram.Domain.Entities;

namespace PetGram.Infra.Configurations
{
    public class PostConfiguration: IEntityTypeConfiguration<Post>
    {
        public void Configure(EntityTypeBuilder<Post> builder)
        {
            throw new System.NotImplementedException();
        }
    }
}