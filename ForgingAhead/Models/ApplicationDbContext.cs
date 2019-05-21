using Microsoft.EntityFrameworkCore;

namespace ForgingAhead.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) :
            base(options)
        { }
        public ApplicationDbContext() { }
        public DbSet<Character> Characters { get; set; }
        public DbSet<Equipment> Equipment { get; set; }
        public DbSet<Quest> Quests { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            var connectionString = Startup.ConnectionString;
            options.UseSqlServer(connectionString);
            base.OnConfiguring(options);
        }
    }
}
