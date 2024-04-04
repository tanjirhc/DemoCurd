using Microsoft.EntityFrameworkCore;

namespace DemoCurd.Data
{
    public class AppplicationDbContext : DbContext 
    {
        public AppplicationDbContext(DbContextOptions<ApplicationDbContext>options): base(options) 
        {

        }

            
    }
}
