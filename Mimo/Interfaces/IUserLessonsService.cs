using Mimo.Models.Dtos.UserLessons;
using System.Net;
using System.Threading.Tasks;

namespace Mimo.Interfaces
{
    public interface IUserLessonsService
    {
        Task<HttpStatusCode> PostUserLesson(UserLessonDto userLessonDto);
    }
}
