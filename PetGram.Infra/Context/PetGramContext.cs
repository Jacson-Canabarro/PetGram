using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using PetGram.Domain.Entities;
using PetGram.Infra.Configurations;

namespace PetGram.Infra.Context
{
    public class PetGramContext : DbContext
    {

        private IConfiguration configuration;
        public PetGramContext(DbContextOptions<PetGramContext> options, IConfiguration config) : base(options)
        {
            configuration = config;
        }
        
        public virtual DbSet<Post> Posts { get; set; }

        public virtual DbSet<Pet> Pets { get; set; }

        public virtual DbSet<Comment> Comments { get; set; }

        public virtual DbSet<Profile> Profiles { get; set; }

        public virtual DbSet<Address> Addresses { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
                => options.UseSqlServer(configuration.GetConnectionString("DbConn"));


        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            modelBuilder.ApplyConfiguration(new ProfileConfiguration());
            modelBuilder.ApplyConfiguration(new AddressConfiguration());
            modelBuilder.ApplyConfiguration(new CommentConfiguration());
            modelBuilder.ApplyConfiguration(new PostConfifuration());
        }
    }
}
