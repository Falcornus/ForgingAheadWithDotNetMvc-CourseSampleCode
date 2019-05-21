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
            var connectionString = @"Server=CPX-E8OWI27UK0V\SQLEXPRESS;Database=ForgingAhead.NewDb;Trusted_Connection=True;";
            options.UseSqlServer(connectionString);
            base.OnConfiguring(options);
        }
    }
}
