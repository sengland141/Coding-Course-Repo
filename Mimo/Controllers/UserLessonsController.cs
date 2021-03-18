using Microsoft.AspNetCore.Mvc;
using Mimo.Interfaces;
using Mimo.Models.Dtos.UserLessons;
using System.Net;
using System.Threading.Tasks;

namespace Mimo.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class UserLessonsController : Controller
    {
        private readonly IUserLessonsService _userLessonsService;

        public UserLessonsController(IUserLessonsService userLessonsService)
        {
            _userLessonsService = userLessonsService;
        }

        public async Task<HttpStatusCode> PostUserLesson([FromBody] UserLessonDto userLessonDto)
        {
            return await _userLessonsService.PostUserLesson(userLessonDto);
        }
    }
}
