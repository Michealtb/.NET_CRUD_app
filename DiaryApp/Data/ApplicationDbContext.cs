using Microsoft.EntityFrameworkCore;
using DiaryApp.Models;

namespace DiaryApp.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

       
        }
        public DbSet<DiaryEntry> DiaryEntries { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<DiaryEntry>().HasData(
new DiaryEntry
{
    Id = 1,
    Title = "Morning Jog",
    Content = "Knocked out a 5 km run before sunrise—felt great!",
    Created = new DateTime(2025, 04, 10, 06, 30, 00, DateTimeKind.Utc)
},
    new DiaryEntry
    {
        Id = 2,
        Title = "UX Lecture Notes",
        Content = "Sketching vs. wireframing takeaways from today’s class.",
        Created = new DateTime(2025, 04, 12, 14, 00, 00, DateTimeKind.Utc)
    }
                );
        }
    }
}
