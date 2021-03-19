using Mimo.Models.Dtos.Achievements;
using Mimo.Models.Dtos.UserAchievements;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;

namespace Mimo.Interfaces
{
    public interface IUserAchievementsService
    {
        Task<List<GetUserAchievementDto>> GetUserAchievements(int userId);

        Task<List<UserAchievementDto>> GetAllUserAchievements(int userId);

        Task<HttpStatusCode> PostUserAchievement(PostUserAchievementDto input);

        Task ProgressUserAchievement(AchievementDto achievementDto, int userId);
    }
}
