
using Microsoft.EntityFrameworkCore;
using Microsoft.Net.Http.Headers;
using MyApp.Models;

namespace MyApp.Data
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options): base(options)
        {
            
        }

        public DbSet<Catergory> Catergories {get; set;}
    }

}