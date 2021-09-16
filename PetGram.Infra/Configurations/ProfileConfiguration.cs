using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PetGram.Domain.Entities;

namespace PetGram.Infra.Configurations
{
    public class ProfileConfiguration : IEntityTypeConfiguration<Profile>
    {
        public void Configure(EntityTypeBuilder<Profile> builder)
        {
            builder.HasOne(p => p.Pet)
                .WithOne(p => p.Profile).HasForeignKey<Profile>(p => p.PetId);
        }
    }
}