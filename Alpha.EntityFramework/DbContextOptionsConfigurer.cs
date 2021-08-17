using Microsoft.EntityFrameworkCore;

namespace Alpha.EntityFramework
{
    public static class DbContextOptionsConfigurer
    {
        public static void Configure(
            DbContextOptionsBuilder<AlphaDbContext> dbContextOptions, 
            string connectionString)
        {
            dbContextOptions.UseSqlServer(connectionString);
        }
    }
}
