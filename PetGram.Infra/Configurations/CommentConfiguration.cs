using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PetGram.Domain.Entities;

namespace PetGram.Infra.Configurations
{
    public class CommentConfiguration: IEntityTypeConfiguration<Comment>
    {
        public void Configure(EntityTypeBuilder<Comment> builder)
        {
            builder.HasOne(c => c.Post)
                .WithMany(p => p.Comments).OnDelete(DeleteBehavior.Cascade);
        }
    }
}