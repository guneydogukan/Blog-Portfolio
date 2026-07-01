namespace BLOGV1.Models
{
    public class ProjectImages : Entity
    {
        public string? ImageUrl { get; set; }

        public int ProjectId { get; set; }    
        public Details? ProjectDetail { get; set; }  
    }
}
