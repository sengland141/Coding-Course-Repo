using System.ComponentModel.DataAnnotations.Schema;

namespace Mimo.Models
{
    public class UserAchievement
    {
        public int Id { get; set; }

        public int UserId { get; set; }

        [ForeignKey("UserId")]
        public User UserFk { get; set; }

        public int AchievementId { get; set; }

        [ForeignKey("AchievementId")]
        public Achievement AchievementFk { get; set; }

        public bool Completed { get; set; }

        public int? Progress { get; set; }
    }
}
