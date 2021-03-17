using System.ComponentModel.DataAnnotations.Schema;

namespace Mimo.Models
{
    public class Chapter
    {
        public int Id { get; set; }

        public string ChapterName { get; set; }

        public int Order { get; set; }

        public int CourseId { get; set; }

        [ForeignKey("CourseId")]
        public Course CourseFk { get; set; }
    }
}
