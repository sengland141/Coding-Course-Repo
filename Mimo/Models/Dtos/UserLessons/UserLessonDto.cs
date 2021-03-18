using System;

namespace Mimo.Models.Dtos.UserLessons
{
    public class UserLessonDto
    {
        public int UserId { get; set; }
        
        public int LessonId { get; set; }

        public DateTime StartTime { get; set; }

        public DateTime EndTime { get; set; }
    }
}
