using Microsoft.EntityFrameworkCore;
using MyApp.Models;

namespace MyApp.Data
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options): base(options)
        {
            
        }

        public DbSet<Catergory> Catergories {get; set;}
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Catergory>().HasData(
                new Catergory{Id =1, Name="action", DisplayOrder=1},
                new Catergory{Id =2, Name="scifi", DisplayOrder=2},
                new Catergory{Id =3, Name="drama", DisplayOrder=12}


            );
        }
    }

}