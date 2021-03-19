namespace Mimo.Models.Dtos.UserAchievements
{
    public class PostUserAchievementDto
    {
        public int UserId { get; set; }

        public int AchievementId { get; set; }

        public bool Completed { get; set; }

        public int? Progress { get; set; }
    }
}
