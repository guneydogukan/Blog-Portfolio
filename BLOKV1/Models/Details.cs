using BLOGV1.Models;
using System.ComponentModel.DataAnnotations;
namespace BLOGV1.Models
{
    public class Details: Entity
    {
        public string? ProjectDescriptions { get; set; }
        [Required]
        public ICollection<ProjectImages> ProjectImageUrl { get; set; } = new List<ProjectImages>();
        public string? Category { get; set; }
        public string? Client { get; set; }
        public DateTime? ProjectDate { get; set; }
        public string? ProjectUrl { get; set; }
        public int? ProjectId { get; set; }
      


    }
}
