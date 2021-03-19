namespace Mimo.Models.Dtos.UserAchievements
{
    public class GetUserAchievementDto
    {
        public int AchievementId { get; set; }

        public int? Progress { get; set; }

        public bool Completed { get; set; }

        public string AchievementDescription { get; set; }
    }
}
