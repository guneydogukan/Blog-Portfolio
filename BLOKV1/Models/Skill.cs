using BLOGV1.Models;

namespace BLOGV1.Models
{
    public class Skill: Entity
    {
        public string? SkillName { get; set; }
        public int ProficiencyPercentage { get; set; }
    }
}
