using Microsoft.EntityFrameworkCore;
using WebApplication2.Models;

namespace WebApplication2.Data
{
    public class CommunityDatabaseDbContext : DbContext
    {

        public CommunityDatabaseDbContext(DbContextOptions<CommunityDatabaseDbContext> options)
           : base(options)
        {
        }
        public DbSet<category> Categories { set; get; }
        public DbSet<comment> Comments { set; get; }

        public DbSet<notification> Notifications { set; get; }

        public DbSet<post> Posts { set; get; }

        public DbSet<postcategory> Postcategories { set; get; }


        public DbSet<user> Users { set; get; }

        public DbSet<vote> Votes { set; get; }





    }
}
