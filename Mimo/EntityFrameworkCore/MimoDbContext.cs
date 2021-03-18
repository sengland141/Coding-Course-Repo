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
            modelBuilder.Entity<Achievement>(a =>
            {
                a.HasData(new Achievement[]
                {
                    new Achievement { Id = 1, AchievementTypeId = 1, Description = "Complete 5 lessons", RequiredCount = 5 },
                    new Achievement { Id = 2, AchievementTypeId = 1, Description = "Complete 25 lessons", RequiredCount = 25 },
                    new Achievement { Id = 3, AchievementTypeId = 1, Description = "Complete 50 lessons", RequiredCount = 50 },
                    new Achievement { Id = 4, AchievementTypeId = 2, Description = "Complete 1 chapter", RequiredCount = 1 },
                    new Achievement { Id = 5, AchievementTypeId = 2, Description = "Complete 5 chapters", RequiredCount = 5 },
                    new Achievement { Id = 6, AchievementTypeId = 3, Description = "Complete the Swift course", RequiredCount = 1 },
                    new Achievement { Id = 7, AchievementTypeId = 4, Description = "Complete the Javascript course", RequiredCount = 1 },
                    new Achievement { Id = 8, AchievementTypeId = 5, Description = "Complete the C# course", RequiredCount = 1 }
                });
            });

            modelBuilder.Entity<AchievementType>(a =>
            {
                a.HasData(new AchievementType[]
                {
                    new AchievementType { Id = 1, AchievementTypeName = "LessonCount" },
                    new AchievementType { Id = 2, AchievementTypeName = "ChapterCount" },
                    new AchievementType { Id = 3, AchievementTypeName = "CompleteSwiftCourse" },
                    new AchievementType { Id = 4, AchievementTypeName = "CompleteJavascriptCourse" },
                    new AchievementType { Id = 5, AchievementTypeName = "CompleteCSharpCourse" }
                });
            });

            modelBuilder.Entity<Course>(c =>
            {
                c.HasData(new Course[]
                {
                    new Course { Id=1, CourseName="Swift" },
                    new Course { Id=2, CourseName="Javascript" },
                    new Course { Id=3, CourseName="C#" }
                });
            });

            modelBuilder.Entity<Chapter>(c =>
            {
                c.HasData(new Chapter[]
                {
                    new Chapter { Id=1, ChapterName="Chapter 1", ChapterPosition=1, CourseId=1 },
                    new Chapter { Id=2, ChapterName="Chapter 2", ChapterPosition=2, CourseId=1 },
                    new Chapter { Id=3, ChapterName="Chapter 1", ChapterPosition=1, CourseId=2 },
                    new Chapter { Id=4, ChapterName="Chapter 2", ChapterPosition=2, CourseId=2 },
                    new Chapter { Id=5, ChapterName="Chapter 1", ChapterPosition=1, CourseId=3 },
                    new Chapter { Id=6, ChapterName="Chapter 2", ChapterPosition=2, CourseId=3 },
                });
            });

            modelBuilder.Entity<Lesson>(l =>
            {
                l.HasData(new Lesson[]
                {
                    new Lesson { Id=1, LessonName="Lesson 1", LessonPosition=1, ChapterId=1 },
                    new Lesson { Id=2, LessonName="Lesson 2", LessonPosition=2, ChapterId=1 },
                    new Lesson { Id=3, LessonName="Lesson 3", LessonPosition=3, ChapterId=1 },
                    new Lesson { Id=4, LessonName="Lesson 4", LessonPosition=4, ChapterId=1 },
                    new Lesson { Id=5, LessonName="Lesson 5", LessonPosition=5, ChapterId=1 },
                    new Lesson { Id=6, LessonName="Lesson 6", LessonPosition=6, ChapterId=1 },
                });
            });

            modelBuilder.Entity<User>(u =>
            {
                u.HasData(new User { Id = 1, Username = "Scott", Password = "Password123" });
            });
        }
    }
}
