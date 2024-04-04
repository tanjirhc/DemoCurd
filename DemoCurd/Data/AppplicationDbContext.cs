using Microsoft.EntityFrameworkCore;

namespace DemoCurd.Data
{
    public class AppplicationDbContext : DbContext 
    {
        public AppplicationDbContext(DbContextOptions<AppplicationDbContext> options): base(options) 
        {

        }

            
    }
}
