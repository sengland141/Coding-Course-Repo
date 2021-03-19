using Microsoft.AspNetCore.Mvc;
using Mimo.Interfaces;
using Mimo.Models.Dtos.UserAchievements;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Mimo.Controllers
{
    [ApiController]
    [Route("user/{userId}/achievements")]
    public class UserAchievementsController : Controller
    {
        private readonly IUserAchievementsService _userAchievementsService;

        public UserAchievementsController(IUserAchievementsService userAchievementsService)
        {
            _userAchievementsService = userAchievementsService;
        }

        [HttpGet]
        public async Task<List<GetUserAchievementDto>> GetUserAchievements(int userId)
        {
            return await _userAchievementsService.GetUserAchievements(userId);
        }
    }
}
