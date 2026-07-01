using BLOGV1.Models;

namespace BLOKV1.Models;

public class Blog: Entity
{
    

    public string? Name { get; set; }

    public string? Description { get; set; }

    public string ImageUrl { get; set; } = "";

   
   
}
