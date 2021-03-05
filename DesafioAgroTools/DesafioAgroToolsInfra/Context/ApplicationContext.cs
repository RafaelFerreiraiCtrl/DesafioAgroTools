using DesafioAgroToolsDomain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesafioAgroToolsInfra.Context
{
    public class ApplicationContext : DbContext
    {

        public ApplicationContext()
        {

        }
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {
               
        }

        public DbSet<Questionary> Questionary { get; set; }
        public DbSet<Question> Question { get; set; }
        public DbSet<Answer> Answer { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Questionary>().HasKey(m => m.Id);
            base.OnModelCreating(builder);

            builder.Entity<Question>().HasKey(m => m.Id);
            base.OnModelCreating(builder);

            builder.Entity<Answer>().HasKey(m => m.Id);
            base.OnModelCreating(builder);
        }

    }
}
