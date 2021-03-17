using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mimo.Models
{
    public class UserLesson
    {
        public int Id { get; set; }

        public DateTime StartTime { get; set; }

        public DateTime? EndTime { get; set; }

        public int UserId { get; set; }

        [ForeignKey("UserId")]
        public User UserFk { get; set; }

        public int LessonId { get; set; }

        [ForeignKey("LessonId")]
        public Lesson LessonFk { get; set; }
    }
}
