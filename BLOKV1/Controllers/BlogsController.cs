using BLOGV1.Models;
using BLOKV1.Context;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BLOGV1.Controllers
{
    public class BlogsController : Controller
    {
        private readonly BlogDbContext _context;

        public object Abouts { get; internal set; }

        public BlogsController(BlogDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var result = _context.Blogs.FirstOrDefault();
            return View(result);
        }

        public IActionResult Details(string slug)
        {
            var blog = _context.Projects.FirstOrDefault(b => b.Slug == slug);
            var result = _context.Details.Include(x => x.ProjectImageUrl).Where(x => x.ProjectId == blog!.Id).FirstOrDefault();
            return View(result);
        }

        public IActionResult Projects()
        {
            var result = _context.Projects.ToList();
            return View(result);
        }

        public IActionResult About()
        {
            var result = _context.Abouts.FirstOrDefault();
            return View(result);
        }


        public IActionResult Contact()
        {
            var result = _context.Contacts.FirstOrDefault();
            return View(result);
        }


        [HttpPost]
        public IActionResult Mesaj(string nameSurname, string email, string messages)
        {
            var model = new Message () {
              NameSurname = nameSurname,
              Email = email,
              Messages = messages
            };
            _context.Messages.Add(model);
            _context.SaveChanges();
            return RedirectToAction("Index");

        }
    }
}
