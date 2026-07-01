namespace BLOGV1.Models
{
    public class Projects : Entity
    {
        public string? ProjectName { get; set; }

        public string? Description { get; set; }

        public string ProjectImageUrl { get; set; } = "";

        public string? footer { get; set; }

        public string? Slug { get; set; }

    }
}
