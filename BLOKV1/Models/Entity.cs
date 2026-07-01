using System.ComponentModel.DataAnnotations;

namespace BLOGV1.Models
{
    public class Entity
    {
        [Key]
        public int Id { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime UpdatedAt { get; set; }

        public bool Deleted { get; set; }
        public Entity() {
            Deleted = false;
            CreatedAt = DateTime.Now;
            UpdatedAt= DateTime.Now;
        }
    }
}
