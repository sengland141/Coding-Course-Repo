using Mimo.Models.Dtos.UserAchievements;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;

namespace Mimo.Interfaces
{
    public interface IUserAchievementsService
    {
        Task<List<UserAchievementDto>> GetAllUserAchievements(int userId);

        Task<HttpStatusCode> PostUserAchievement(PostUserAchievementDto input);
    }
}
