using System.ComponentModel.DataAnnotations.Schema;

namespace Mimo.Models
{
    public class Lesson
    {
        public int Id { get; set; }

        public string LessonName { get; set; }

        public int LessonPosition { get; set; }

        public int ChapterId { get; set; }

        [ForeignKey("ChapterId")]
        public Chapter ChapterFk { get; set; }
    }
}
