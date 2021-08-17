using Microsoft.EntityFrameworkCore;

namespace Alpha.EntityFramework
{
    public class AlphaDbContext : DbContext
    {

        //Add DbSet properties for your entities...

        public AlphaDbContext(DbContextOptions<AlphaDbContext> options)
            :base(options)
        {

        }
    }
}
