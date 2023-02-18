using APICQRS.Models;
using Microsoft.EntityFrameworkCore;
namespace APICQRS.Data
{
    public class AppDBContext : DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options) 
        {

        }

        public DbSet<Categorias> categorias { get; set; }
    }
}
