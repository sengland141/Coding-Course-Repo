using System.ComponentModel.DataAnnotations.Schema;

namespace Mimo.Models
{
    public class Achievement
    {
        public int Id { get; set; }

        public string Description { get; set; }

        public int? RequiredCount { get; set; }

        public int AchievementTypeId { get; set; }

        [ForeignKey("AchievementTypeId")]
        public AchievementType AchievementTypeFk { get; set; }
    }
}
