using Microsoft.AspNetCore.Mvc;
using Mimo.Interfaces;
using Mimo.Models.Dtos.UserLessons;
using System.Net.Http;
using System.Threading.Tasks;

namespace Mimo.Controllers
{
    [ApiController]
    [Route("lesson-completed")]
    public class LessonCompletedController : Controller
    {
        private readonly ILessonCompletedService _lessonCompletedService;

        public LessonCompletedController(ILessonCompletedService lessonCompletedService)
        {
            _lessonCompletedService = lessonCompletedService;
        }

        [HttpPost]
        public async Task<HttpResponseMessage> PostLessonCompleted([FromBody] UserLessonDto userLessonDto)
        {
            return await _lessonCompletedService.PostLessonCompleted(userLessonDto);
        }
    }
}
