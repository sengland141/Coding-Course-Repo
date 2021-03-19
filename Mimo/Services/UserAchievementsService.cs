using Microsoft.EntityFrameworkCore;
using Mimo.EntityFrameworkCore;
using Mimo.Interfaces;
using Mimo.Models;
using Mimo.Models.Dtos.Achievements;
using Mimo.Models.Dtos.UserAchievements;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace Mimo.Services
{
    public class UserAchievementsService : IUserAchievementsService
    {
        private readonly MimoDbContext _mimoDbContext = new MimoDbContext();

        public async Task<List<GetUserAchievementDto>> GetUserAchievements(int userId)
        {
            var userAchievements = await _mimoDbContext.UserAchievements
                .Where(ua => ua.UserId == userId)
                .Select(ua => new
                {
                    ua.AchievementId,
                    ua.Completed,
                    ua.Progress,
                    ua.AchievementFk.Description
                })
                .ToListAsync();

            List<GetUserAchievementDto> getUserAchievementDtos = new List<GetUserAchievementDto>();

            foreach (var userAchievement in userAchievements)
            {
                GetUserAchievementDto getUserAchievementDto = new GetUserAchievementDto
                {
                    AchievementId = userAchievement.AchievementId,
                    AchievementDescription = userAchievement.Description,
                    Completed = userAchievement.Completed,
                    Progress = userAchievement.Progress
                };

                getUserAchievementDtos.Add(getUserAchievementDto);
            }

            return getUserAchievementDtos;
        }

        public async Task<List<UserAchievementDto>> GetAllUserAchievements(int userId)
        {
            var userAchievements = await _mimoDbContext.UserAchievements
                .Include(ua => ua.AchievementFk)
                .Include(ua => ua.AchievementFk.AchievementTypeFk)
                .Where(ua => ua.UserId == userId)
                .ToListAsync();

            List<UserAchievementDto> userAchievementDtos = new List<UserAchievementDto>();

            foreach (var userAchievement in userAchievements)
            {
                UserAchievementDto userAchievementDto = new UserAchievementDto
                {
                    AchievementId = userAchievement.AchievementId,
                    AchievementTypeName = userAchievement.AchievementFk.AchievementTypeFk.AchievementTypeName,
                    Completed = userAchievement.Completed,
                    Id = userAchievement.Id,
                    Progress = userAchievement.Progress,
                    UserId = userAchievement.UserId
                };

                userAchievementDtos.Add(userAchievementDto);
            }

            return userAchievementDtos;
        }

        public async Task<HttpStatusCode> PostUserAchievement(PostUserAchievementDto input)
        {
            UserAchievement userAchievement = new UserAchievement
            {
                UserId = input.UserId,
                AchievementId = input.AchievementId,
                Completed = input.Completed,
                Progress = input.Progress
            };

            await _mimoDbContext.UserAchievements.AddAsync(userAchievement);
            await _mimoDbContext.SaveChangesAsync();

            return HttpStatusCode.OK;
        }

        public async Task<HttpStatusCode> ProgressUserAchievement(AchievementDto achievementDto, int userId)
        {
            UserAchievement userAchievement = await _mimoDbContext.UserAchievements
                .Where(ua => ua.UserId == userId && ua.AchievementId == achievementDto.Id)
                .FirstOrDefaultAsync();

            userAchievement.Progress += 1;

            if (userAchievement.Progress == achievementDto.RequiredCount)
            {
                userAchievement.Completed = true;
            }

            await _mimoDbContext.SaveChangesAsync();

            return HttpStatusCode.OK;
        }
    }
}
