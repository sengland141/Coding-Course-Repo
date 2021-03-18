using Microsoft.AspNetCore.Mvc;
using Mimo.Interfaces;
using Mimo.Models.Dtos.UserLessons;
using System.Net;
using System.Threading.Tasks;

namespace Mimo.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LessonCompletedController : Controller
    {
        private readonly ILessonCompletedService _lessonCompletedService;

        public LessonCompletedController(ILessonCompletedService lessonCompletedService)
        {
            _lessonCompletedService = lessonCompletedService;
        }

        [HttpPost]
        public async Task<HttpStatusCode> PostLessonCompleted([FromBody] UserLessonDto userLessonDto)
        {
            return await _lessonCompletedService.PostLessonCompleted(userLessonDto);
        }
    }
}
