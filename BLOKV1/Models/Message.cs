using BLOGV1.Models;
namespace BLOGV1.Models
{
    public class Message: Entity
    {
        public string? NameSurname { get; set; }
        public string? Email { get; set; }
        public string? Messages { get; set; }
    }
}
