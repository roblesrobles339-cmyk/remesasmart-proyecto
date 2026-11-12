using Microsoft.EntityFremeworkCore;

namespace RemesaSmart.Api.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        
        }
        //aqeui agregaremos los DbSet para las tablas mas adelante
    }
}