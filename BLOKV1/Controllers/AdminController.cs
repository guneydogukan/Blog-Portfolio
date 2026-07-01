using BLOGV1.Identity;
using BLOGV1.Models.ViewModels;
using BLOKV1.Context;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Identity.Client;

namespace BLOGV1.Controllers
{
    
    public class AdminController : Controller
    {
        private readonly BlogDbContext _context;
       
        public AdminController(BlogDbContext context)
        {
            _context = context;
           
        }

        public IActionResult Index()
        {
            return View();
        }

        


        
    }
}
