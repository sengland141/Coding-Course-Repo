using Mimo.Models.Dtos.Achievements;
using System.Net;
using System.Threading.Tasks;

namespace Mimo.Interfaces
{
    public interface IAchievementsService
    {
        public Task<HttpStatusCode> UpdateAchievementProgress(UpdateAchievementProgressDto input);
    }
}
