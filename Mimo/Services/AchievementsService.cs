using Microsoft.EntityFrameworkCore;
using Mimo.EntityFrameworkCore;
using Mimo.Interfaces;
using Mimo.Models.Dtos.Achievements;
using Mimo.Models.Dtos.UserAchievements;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace Mimo.Services
{
    public class AchievementsService : IAchievementsService
    {
        private readonly MimoDbContext _mimoDbContext = new MimoDbContext();
        private readonly IUserAchievementsService _userAchievementsService;

        public AchievementsService(IUserAchievementsService userAchievementsService)
        {
            _userAchievementsService = userAchievementsService;
        }

        public async Task<HttpStatusCode> UpdateAchievementProgress(UpdateAchievementProgressDto input)
        {
            bool lessonPreviouslyCompleted = await LessonPreviouslyCompleted(input);

            if (lessonPreviouslyCompleted == true)
            {
                return HttpStatusCode.OK;
            }
            else
            {
                List<AchievementDto> achievementDtos = await GetAllAchievements();
                List<UserAchievementDto> userAchievementDtos = await _userAchievementsService.GetAllUserAchievements(input.UserId);

                int currentChapterId = await _mimoDbContext.Lessons
                    .Where(l => l.Id == input.LessonId)
                    .Select(l => l.ChapterId)
                    .FirstOrDefaultAsync();

                foreach (AchievementDto achievementDto in achievementDtos)
                {
                    switch (achievementDto.AchievementTypeName)
                    {
                        case "LessonCount":
                            await UpdateLessonCountAchievement(achievementDto, input.UserId, userAchievementDtos);
                            break;
                        case "ChapterCount":
                            await UpdateChapterCountAchievement(achievementDto, input.UserId, input.LessonId, currentChapterId, userAchievementDtos);
                            break;
                        case "CompleteSwiftCourse":
                            await UpdateCompleteSwiftCourseAchievement(achievementDto, input.UserId, input.LessonId, userAchievementDtos);
                            break;
                        case "CompleteJavascriptCourse":
                            await UpdateCompleteJavascriptCourseAchievement(achievementDto, input.UserId, input.LessonId, userAchievementDtos);
                            break;
                        case "CompleteCSharpCourse":
                            await UpdateCSharpCourseAchievement(achievementDto, input.UserId, input.LessonId, userAchievementDtos);
                            break;
                        default:
                            throw new Exception("Achievement type could not be found");
                    }
                }

                return HttpStatusCode.OK;
            }
        }

        private async Task<bool> LessonPreviouslyCompleted(UpdateAchievementProgressDto input)
        {
            int numberOfTimesCompleted = await _mimoDbContext.UserLessons
                .Where(ul => ul.LessonId == input.LessonId && ul.UserId == input.UserId)
                .CountAsync();

            return numberOfTimesCompleted > 1;
        }

        private async Task<List<AchievementDto>> GetAllAchievements()
        {
            var achievements = await _mimoDbContext.Achievements
                .Include(a => a.AchievementTypeFk)
                .Select(a => new
                {
                    a.Id,
                    a.AchievementTypeFk.AchievementTypeName,
                    a.RequiredCount
                })
                .ToListAsync();

            List<AchievementDto> achievementDtos = new List<AchievementDto>();

            foreach (var achievement in achievements)
            {
                AchievementDto achievementDto = new AchievementDto
                {
                    Id = achievement.Id,
                    AchievementTypeName = achievement.AchievementTypeName,
                    RequiredCount = achievement.RequiredCount
                };

                achievementDtos.Add(achievementDto);
            }

            return achievementDtos;
        }

        private async Task<HttpStatusCode> UpdateLessonCountAchievement(AchievementDto achievementDto, int userId, List<UserAchievementDto> userAchievementDtos)
        {
            UserAchievementDto lessonCountUserAchievementDto = userAchievementDtos
                .Where(uad => uad.AchievementId == achievementDto.Id)
                .FirstOrDefault();

            if (lessonCountUserAchievementDto == null)
            {
                PostUserAchievementDto postUserAchievementDto = new PostUserAchievementDto
                {
                    AchievementId = achievementDto.Id,
                    Completed = achievementDto.RequiredCount == 1,
                    Progress = 1,
                    UserId = userId
                };

                return await _userAchievementsService.PostUserAchievement(postUserAchievementDto);
            }
            else
            {
                await _userAchievementsService.ProgressUserAchievement(achievementDto, userId);

                return HttpStatusCode.OK;
            }     
        }

        private async Task<HttpStatusCode> UpdateChapterCountAchievement(AchievementDto achievementDto, int userId, int lessonId, int chapterId, List<UserAchievementDto> userAchievementDtos)
        {
            await HandleNewUserAchievement(achievementDto, userId, userAchievementDtos);

            int[] lessonIds = await _mimoDbContext.Lessons
                .Where(l => l.ChapterId == chapterId)
                .Select(c => c.Id)
                .ToArrayAsync();

            int[] completedLessonIds = await _mimoDbContext.UserLessons
                .Where(ul => ul.UserId == userId)
                .Select(ul => ul.LessonId)
                .ToArrayAsync();

            int[] uncompletedLessonIds = lessonIds.Where(l => completedLessonIds.All(c => c != l)).ToArray();

            if (uncompletedLessonIds.Length == 0)
            {
                return await _userAchievementsService.ProgressUserAchievement(achievementDto, userId);
            }

            return HttpStatusCode.OK;
        }

        private async Task<HttpStatusCode> UpdateCompleteSwiftCourseAchievement(AchievementDto achievementDto, int userId, int lessonId, List<UserAchievementDto> userAchievementDtos)
        {
            await HandleNewUserAchievement(achievementDto, userId, userAchievementDtos);

            var course = await _mimoDbContext.Lessons
                .Where(l => l.Id == lessonId)
                .Select(l => new
                {
                    l.ChapterFk.CourseId,
                    l.ChapterFk.CourseFk.CourseName
                })
                .FirstOrDefaultAsync();

            if (course.CourseName == "Swift")
            {
                return await UpdateCourseAchievement(achievementDto, userId, lessonId, course.CourseId, userAchievementDtos);
            }

            return HttpStatusCode.OK;
        }

        private async Task<HttpStatusCode> UpdateCompleteJavascriptCourseAchievement(AchievementDto achievementDto, int userId, int lessonId, List<UserAchievementDto> userAchievementDtos)
        {
            await HandleNewUserAchievement(achievementDto, userId, userAchievementDtos);

            var course = await _mimoDbContext.Lessons
                .Where(l => l.Id == lessonId)
                .Select(l => new
                {
                    l.ChapterFk.CourseId,
                    l.ChapterFk.CourseFk.CourseName
                })
                .FirstOrDefaultAsync();

            if (course.CourseName == "Javascript")
            {
                return await UpdateCourseAchievement(achievementDto, userId, lessonId, course.CourseId, userAchievementDtos);
            }

            return HttpStatusCode.OK;
        }

        private async Task<HttpStatusCode> UpdateCSharpCourseAchievement(AchievementDto achievementDto, int userId, int lessonId, List<UserAchievementDto> userAchievementDtos)
        {
            await HandleNewUserAchievement(achievementDto, userId, userAchievementDtos);

            var course = await _mimoDbContext.Lessons
                .Where(l => l.Id == lessonId)
                .Select(l => new
                {
                    l.ChapterFk.CourseId,
                    l.ChapterFk.CourseFk.CourseName
                })
                .FirstOrDefaultAsync();

            if (course.CourseName == "C#")
            {
                return await UpdateCourseAchievement(achievementDto, userId, lessonId, course.CourseId, userAchievementDtos);
            }

            return HttpStatusCode.OK;
        }

        private async Task<HttpStatusCode> HandleNewUserAchievement(AchievementDto achievementDto, int userId, List<UserAchievementDto> userAchievementDtos)
        {
            UserAchievementDto userAchievementDto = userAchievementDtos
            .Where(uad => uad.AchievementId == achievementDto.Id)
            .FirstOrDefault();

            if (userAchievementDto == null)
            {
                PostUserAchievementDto postUserAchievementDto = new PostUserAchievementDto
                {
                    AchievementId = achievementDto.Id,
                    Completed = false,
                    Progress = 0,
                    UserId = userId
                };

                return await _userAchievementsService.PostUserAchievement(postUserAchievementDto);
            }

            return HttpStatusCode.OK;
        }

        private async Task<HttpStatusCode> UpdateCourseAchievement(AchievementDto achievementDto, int userId, int lessonId, int courseId, List<UserAchievementDto> userAchievementDtos)
        {
            int[] lessonIds = await _mimoDbContext.Lessons
                .Where(l => l.ChapterFk.CourseId == courseId)
                .Select(c => c.Id)
                .ToArrayAsync();

            int[] completedLessonIds = await _mimoDbContext.UserLessons
                .Where(ul => ul.UserId == userId)
                .Select(ul => ul.LessonId)
                .ToArrayAsync();

            int[] uncompletedLessonIds = lessonIds.Where(l => completedLessonIds.All(c => c != l)).ToArray();

            if (uncompletedLessonIds.Length == 0)
            {
                return await _userAchievementsService.ProgressUserAchievement(achievementDto, userId);
            }

            return HttpStatusCode.OK;
        }
    }
}
