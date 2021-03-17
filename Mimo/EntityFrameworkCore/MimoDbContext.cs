using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;
using Mimo.Models;

namespace Mimo.EntityFrameworkCore
{
    public class MimoDbContext : DbContext
    {
        public DbSet<Chapter> Chapters { get; set; }

        public DbSet<Course> Courses { get; set; }

        public DbSet<Lesson> Lessons { get; set; }

        public DbSet<UserLesson> UserLessons { get; set; }

        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionStringBuilder = new SqliteConnectionStringBuilder { DataSource = "MimoDb.db" };
            var connectionString = connectionStringBuilder.ToString();
            var connection = new SqliteConnection(connectionString);

            optionsBuilder.UseSqlite(connection);
        }
    }
}
