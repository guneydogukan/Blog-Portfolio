using BLOGV1.Models;

namespace BLOKV1.Models

{
    public class About : Entity
    {
        public string? Name { get; set; }

        public string? Profession { get; set; }

        public string? Email { get; set; }

        public string ProfileImageUrl { get; set; } = "";

        public string? Phone { get; set; }

        public string? AboutMe{ get; set; }

    }
}
