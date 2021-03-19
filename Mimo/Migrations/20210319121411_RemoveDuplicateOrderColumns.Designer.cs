﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Mimo.EntityFrameworkCore;

namespace Mimo.Migrations
{
    [DbContext(typeof(MimoDbContext))]
    [Migration("20210319121411_RemoveDuplicateOrderColumns")]
    partial class RemoveDuplicateOrderColumns
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.4");

            modelBuilder.Entity("Mimo.Models.Achievement", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("AchievementTypeId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int?>("RequiredCount")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("AchievementTypeId");

                    b.ToTable("Achievements");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AchievementTypeId = 1,
                            Description = "Complete 5 lessons",
                            RequiredCount = 5
                        },
                        new
                        {
                            Id = 2,
                            AchievementTypeId = 1,
                            Description = "Complete 25 lessons",
                            RequiredCount = 25
                        },
                        new
                        {
                            Id = 3,
                            AchievementTypeId = 1,
                            Description = "Complete 50 lessons",
                            RequiredCount = 50
                        },
                        new
                        {
                            Id = 4,
                            AchievementTypeId = 2,
                            Description = "Complete 1 chapter",
                            RequiredCount = 1
                        },
                        new
                        {
                            Id = 5,
                            AchievementTypeId = 2,
                            Description = "Complete 5 chapters",
                            RequiredCount = 5
                        },
                        new
                        {
                            Id = 6,
                            AchievementTypeId = 3,
                            Description = "Complete the Swift course",
                            RequiredCount = 1
                        },
                        new
                        {
                            Id = 7,
                            AchievementTypeId = 4,
                            Description = "Complete the Javascript course",
                            RequiredCount = 1
                        },
                        new
                        {
                            Id = 8,
                            AchievementTypeId = 5,
                            Description = "Complete the C# course",
                            RequiredCount = 1
                        });
                });

            modelBuilder.Entity("Mimo.Models.AchievementType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("AchievementTypeName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("AchievementTypes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AchievementTypeName = "LessonCount"
                        },
                        new
                        {
                            Id = 2,
                            AchievementTypeName = "ChapterCount"
                        },
                        new
                        {
                            Id = 3,
                            AchievementTypeName = "CompleteSwiftCourse"
                        },
                        new
                        {
                            Id = 4,
                            AchievementTypeName = "CompleteJavascriptCourse"
                        },
                        new
                        {
                            Id = 5,
                            AchievementTypeName = "CompleteCSharpCourse"
                        });
                });

            modelBuilder.Entity("Mimo.Models.Chapter", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ChapterName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("ChapterPosition")
                        .HasColumnType("INTEGER");

                    b.Property<int>("CourseId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("CourseId");

                    b.ToTable("Chapters");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ChapterName = "Chapter 1",
                            ChapterPosition = 1,
                            CourseId = 1
                        },
                        new
                        {
                            Id = 2,
                            ChapterName = "Chapter 2",
                            ChapterPosition = 2,
                            CourseId = 1
                        },
                        new
                        {
                            Id = 3,
                            ChapterName = "Chapter 1",
                            ChapterPosition = 1,
                            CourseId = 2
                        },
                        new
                        {
                            Id = 4,
                            ChapterName = "Chapter 2",
                            ChapterPosition = 2,
                            CourseId = 2
                        },
                        new
                        {
                            Id = 5,
                            ChapterName = "Chapter 1",
                            ChapterPosition = 1,
                            CourseId = 3
                        },
                        new
                        {
                            Id = 6,
                            ChapterName = "Chapter 2",
                            ChapterPosition = 2,
                            CourseId = 3
                        });
                });

            modelBuilder.Entity("Mimo.Models.Course", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("CourseName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Courses");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CourseName = "Swift"
                        },
                        new
                        {
                            Id = 2,
                            CourseName = "Javascript"
                        },
                        new
                        {
                            Id = 3,
                            CourseName = "C#"
                        });
                });

            modelBuilder.Entity("Mimo.Models.Lesson", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("ChapterId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("LessonName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("LessonPosition")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Order")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("ChapterId");

                    b.ToTable("Lessons");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ChapterId = 1,
                            LessonName = "Lesson 1",
                            LessonPosition = 1,
                            Order = 0
                        },
                        new
                        {
                            Id = 2,
                            ChapterId = 1,
                            LessonName = "Lesson 2",
                            LessonPosition = 2,
                            Order = 0
                        },
                        new
                        {
                            Id = 3,
                            ChapterId = 2,
                            LessonName = "Lesson 1",
                            LessonPosition = 1,
                            Order = 0
                        },
                        new
                        {
                            Id = 4,
                            ChapterId = 2,
                            LessonName = "Lesson 2",
                            LessonPosition = 2,
                            Order = 0
                        },
                        new
                        {
                            Id = 5,
                            ChapterId = 3,
                            LessonName = "Lesson 1",
                            LessonPosition = 1,
                            Order = 0
                        },
                        new
                        {
                            Id = 6,
                            ChapterId = 3,
                            LessonName = "Lesson 2",
                            LessonPosition = 2,
                            Order = 0
                        },
                        new
                        {
                            Id = 7,
                            ChapterId = 4,
                            LessonName = "Lesson 1",
                            LessonPosition = 1,
                            Order = 0
                        },
                        new
                        {
                            Id = 8,
                            ChapterId = 4,
                            LessonName = "Lesson 2",
                            LessonPosition = 2,
                            Order = 0
                        },
                        new
                        {
                            Id = 9,
                            ChapterId = 5,
                            LessonName = "Lesson 1",
                            LessonPosition = 1,
                            Order = 0
                        },
                        new
                        {
                            Id = 10,
                            ChapterId = 5,
                            LessonName = "Lesson 2",
                            LessonPosition = 2,
                            Order = 0
                        },
                        new
                        {
                            Id = 11,
                            ChapterId = 6,
                            LessonName = "Lesson 1",
                            LessonPosition = 1,
                            Order = 0
                        },
                        new
                        {
                            Id = 12,
                            ChapterId = 6,
                            LessonName = "Lesson 2",
                            LessonPosition = 2,
                            Order = 0
                        });
                });

            modelBuilder.Entity("Mimo.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Password = "Password123",
                            Username = "Scott"
                        });
                });

            modelBuilder.Entity("Mimo.Models.UserAchievement", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("AchievementId")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("Completed")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("Progress")
                        .HasColumnType("INTEGER");

                    b.Property<int>("UserId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("AchievementId");

                    b.HasIndex("UserId");

                    b.ToTable("UserAchievements");
                });

            modelBuilder.Entity("Mimo.Models.UserLesson", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("EndTime")
                        .HasColumnType("TEXT");

                    b.Property<int>("LessonId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("StartTime")
                        .HasColumnType("TEXT");

                    b.Property<int>("UserId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("LessonId");

                    b.HasIndex("UserId");

                    b.ToTable("UserLessons");
                });

            modelBuilder.Entity("Mimo.Models.Achievement", b =>
                {
                    b.HasOne("Mimo.Models.AchievementType", "AchievementTypeFk")
                        .WithMany()
                        .HasForeignKey("AchievementTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AchievementTypeFk");
                });

            modelBuilder.Entity("Mimo.Models.Chapter", b =>
                {
                    b.HasOne("Mimo.Models.Course", "CourseFk")
                        .WithMany()
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CourseFk");
                });

            modelBuilder.Entity("Mimo.Models.Lesson", b =>
                {
                    b.HasOne("Mimo.Models.Chapter", "ChapterFk")
                        .WithMany()
                        .HasForeignKey("ChapterId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ChapterFk");
                });

            modelBuilder.Entity("Mimo.Models.UserAchievement", b =>
                {
                    b.HasOne("Mimo.Models.Achievement", "AchievementFk")
                        .WithMany()
                        .HasForeignKey("AchievementId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Mimo.Models.User", "UserFk")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AchievementFk");

                    b.Navigation("UserFk");
                });

            modelBuilder.Entity("Mimo.Models.UserLesson", b =>
                {
                    b.HasOne("Mimo.Models.Lesson", "LessonFk")
                        .WithMany()
                        .HasForeignKey("LessonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Mimo.Models.User", "UserFk")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("LessonFk");

                    b.Navigation("UserFk");
                });
#pragma warning restore 612, 618
        }
    }
}
