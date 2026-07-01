using BLOGV1.Models;
namespace BLOGV1.Models
{
    public class Contact : Entity
    {
        public string? Phone { get; set; }
        public string? Name { get; set; }
        public string? Address { get; set; }
        public string? WorkingHours { get; set; }

        public string? Instagram { get; set; }
        public string? Twitter { get; set; }
        public string? LinkedIn { get; set; }


    }
}
