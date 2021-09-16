using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PetGram.Domain.Entities;

namespace PetGram.Infra.Configurations
{
    public class AddressConfiguration: IEntityTypeConfiguration<Address>
    {
        public void Configure(EntityTypeBuilder<Address> builder)
        {
            builder.HasOne(p => p.Pet)
                .WithOne(p => p.Address).HasForeignKey<Address>(p => p.PetId);
        }
    }
}