namespace Mimo.Models.Dtos.UserAchievements
{
    public class UserAchievementDto
    {
        public int Id { get; set; }

        public int UserId { get; set; }

        public int AchievementId { get; set; }

        public bool Completed { get; set; }

        public int? Progress { get; set; }

        public string AchievementTypeName { get; set; }
    }
}
