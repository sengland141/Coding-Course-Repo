using Microsoft.AspNetCore.Mvc;
using Mimo.EntityFrameworkCore;
using Mimo.Interfaces;
using Mimo.Models;
using Mimo.Models.Dtos.UserLessons;
using System.Net;
using System.Threading.Tasks;

namespace Mimo.Services
{
    public class LessonCompletedService : ILessonCompletedService
    {
        private readonly MimoDbContext _mimoDbContext = new MimoDbContext();

        public async Task<HttpStatusCode> PostLessonCompleted([FromBody] UserLessonDto userLessonDto)
        {
            UserLesson userLesson = new UserLesson()
            {
                LessonId = userLessonDto.LessonId,
                UserId = userLessonDto.UserId,
                EndTime = userLessonDto.EndTime,
                StartTime = userLessonDto.StartTime
            };

            await _mimoDbContext.UserLessons.AddAsync(userLesson);
            await _mimoDbContext.SaveChangesAsync();    

            return HttpStatusCode.OK;
        }
    }
}
