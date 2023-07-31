using Microsoft.EntityFrameworkCore;
using thales.Models;

namespace thales.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) :base(options)
        {
            
        }

        public DbSet<ArquivoModel> Arquivo {get; set;}
        public DbSet<KitModel> Kit {get; set;}
        
    }
}