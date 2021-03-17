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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Course>(c =>
            {
                c.HasData(new Course[]
                {
                    new Course{Id=1,CourseName="Swift"},
                    new Course{Id=2,CourseName="Javascript"},
                    new Course{Id=3,CourseName="C#"}
                });
            });
        }
    }
}
