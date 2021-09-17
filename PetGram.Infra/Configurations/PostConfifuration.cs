using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PetGram.Domain.Entities;

namespace PetGram.Infra.Configurations
{
    public class PostConfifuration : IEntityTypeConfiguration<Post>
    {
        public void Configure(EntityTypeBuilder<Post> builder)
        {
            builder.HasOne(p => p.pet).
                WithMany(p => p.Posts).
                HasForeignKey(p => p.petId);
        }
    }
}