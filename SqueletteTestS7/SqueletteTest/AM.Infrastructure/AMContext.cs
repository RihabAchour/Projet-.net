using ApplicationCore.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure
{
    public class AMContext : DbContext
    {
        public DbSet<Chanson> Chansons { get; set; }
        public DbSet<Artiste> Artistes { get; set; }
        public DbSet<Festival> Festivales { get; set; }

        public DbSet<Concert> Concerts { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\mssqllocaldb;
                Initial Catalog=TestManagementDB;
                Integrated Security=true;MultipleActiveResultSets=true");
            ;
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder) { 

            modelBuilder.Entity<Concert>()
                    .HasKey(C => new { C.DateConcert ,C.ArtisteFk,C.Festivalfk
          });
            base.OnModelCreating(modelBuilder); } 
    protected override void ConfigureConventions(ModelConfigurationBuilder configurationBuilder)
        {
           
            configurationBuilder.Properties<string>().HaveMaxLength(50);

            base.ConfigureConventions(configurationBuilder);
        }

    }
}
