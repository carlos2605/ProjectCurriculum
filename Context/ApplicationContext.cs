 using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProjetoCurriculum.Models;
using ProjetoCurriculum.Models.Configure;

namespace ProjetoCurriculum.Context
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {

        }

        public DbSet<Curriculum> Curriculums { get; set; }

        public DbSet<User> Users { get; set; }

        public DbSet<Register> Registers { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new UserConfig());

        }

    }
}
