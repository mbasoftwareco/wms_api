using Microsoft.EntityFrameworkCore;

namespace wms_api.Contexts
{
    public class ApplicationDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            
        }
    }
}
