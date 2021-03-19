using Mimo.Models.Dtos.UserLessons;
using System.Net.Http;
using System.Threading.Tasks;

namespace Mimo.Interfaces
{
    public interface ILessonCompletedService
    {
        Task<HttpResponseMessage> PostLessonCompleted(UserLessonDto userLessonDto);
    }
}
