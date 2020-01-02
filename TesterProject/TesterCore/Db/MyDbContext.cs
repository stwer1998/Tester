using Microsoft.EntityFrameworkCore;
using TesterCore.Model;

namespace TesterCore
{
    public class MyDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Test> Tests { get; set; }
        public DbSet<Answer> Answers { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DbSet<TestHistory> TestHistories { get; set; }


        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options)
        {
            Database.EnsureCreated();
        }
    }
}
