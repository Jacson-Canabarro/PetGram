using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using PetGram.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PetGram.Infra.Context
{
    public class PetGramContext : DbContext
    {

        private IConfiguration configuration;
        public PetGramContext(DbContextOptions<PetGramContext> options, IConfiguration config) : base(options)
        {
            configuration = config;
        }

   


        public virtual DbSet<Pet> Pets { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
                => options.UseSqlServer(configuration.GetConnectionString("DbConn"));




    }
}
