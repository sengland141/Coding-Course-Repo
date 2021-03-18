using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;
using Mimo.Models;

namespace Mimo.EntityFrameworkCore
{
    public class MimoDbContext : DbContext
    {
        public DbSet<Achievement> Achievements { get; set; }

        public DbSet<AchievementType> AchievementTypes { get; set; }

        public DbSet<Chapter> Chapters { get; set; }

        public DbSet<Course> Courses { get; set; }

        public DbSet<Lesson> Lessons { get; set; }

        public DbSet<UserAchievement> UserAchievements { get; set; }

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
                    new Course{ Id=1, CourseName="Swift" },
                    new Course{ Id=2, CourseName="Javascript" },
                    new Course{ Id=3, CourseName="C#" }
                });
            });

            modelBuilder.Entity<Chapter>(c =>
            {
                c.HasData(new Chapter[]
                {
                    new Chapter{ Id=1, ChapterName="Chapter 1", ChapterPosition=1, CourseId=1},
                    new Chapter{ Id=2, ChapterName="Chapter 2", ChapterPosition=2, CourseId=1},
                    new Chapter{ Id=3, ChapterName="Chapter 1", ChapterPosition=1, CourseId=2},
                    new Chapter{ Id=4, ChapterName="Chapter 2", ChapterPosition=2, CourseId=2},
                    new Chapter{ Id=5, ChapterName="Chapter 1", ChapterPosition=1, CourseId=3},
                    new Chapter{ Id=6, ChapterName="Chapter 2", ChapterPosition=2, CourseId=3},
                });
            });

            modelBuilder.Entity<Lesson>(l =>
            {
                l.HasData(new Lesson[]
                {
                    new Lesson{ Id=1, LessonName="Lesson 1", LessonPosition=1, ChapterId=1},
                    new Lesson{ Id=2, LessonName="Lesson 2", LessonPosition=2, ChapterId=1},
                    new Lesson{ Id=3, LessonName="Lesson 3", LessonPosition=3, ChapterId=1},
                    new Lesson{ Id=4, LessonName="Lesson 4", LessonPosition=4, ChapterId=1},
                    new Lesson{ Id=5, LessonName="Lesson 5", LessonPosition=5, ChapterId=1},
                    new Lesson{ Id=6, LessonName="Lesson 6", LessonPosition=6, ChapterId=1},
                });
            });

            modelBuilder.Entity<User>(u =>
            {
                u.HasData(new User { Id = 1, Username = "Scott", Password = "Password123" });
            });
        }
    }
}
