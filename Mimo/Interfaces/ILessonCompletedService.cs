using Mimo.Models.Dtos.UserLessons;
using System.Net;
using System.Threading.Tasks;

namespace Mimo.Interfaces
{
    public interface ILessonCompletedService
    {
        Task<HttpStatusCode> PostLessonCompleted(UserLessonDto userLessonDto);
    }
}
