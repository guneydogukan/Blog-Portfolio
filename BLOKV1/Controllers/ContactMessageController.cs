using BLOKV1.Context;
using Microsoft.AspNetCore.Mvc;

namespace BLOGV1.Controllers
{
    public class ContactMessageController : Controller
    {
        private readonly BlogDbContext _context;

        public ContactMessageController(BlogDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var messages = _context.Messages.ToList();
            return View(messages);
        }

        [HttpPost]
        public IActionResult Delete(int id)
        {
            var message = _context.Messages.Find(id);
            if (message != null)
            {
                _context.Messages.Remove(message);
                _context.SaveChanges();
            }
            return RedirectToAction("Index");
        }


        public IActionResult Details(int id)
        {
            var message = _context.Messages.Find(id);
            if (message == null)
            {
                return NotFound();
            }
            return View(message);
        }

        
    }
}
