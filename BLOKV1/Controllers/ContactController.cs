using BLOGV1.Models;
using BLOKV1.Context;
using BLOKV1.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BLOGV1.Controllers
{
    public class ContactController : Controller
    {
        private readonly BlogDbContext _context;

        public ContactController(BlogDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var contact = _context.Contacts.FirstOrDefault();
            return View(contact);
        }


        public IActionResult Edit(int ID)
        {
            var abouts = _context.Contacts.Find(ID);
            if (abouts == null)
            {
                return NotFound();
            }
            return View(abouts);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(Contact model)
        {
            if (ModelState.IsValid)
            {
                var contacts = _context.Contacts.Find(model.Id);
                if (contacts == null)
                {
                    return NotFound();
                }

                
                else
                {
                    ModelState.AddModelError("", "Bir resim seçiniz.");
                }
                contacts.Phone = model.Phone;
                contacts.Address = model.Address;
                contacts.Instagram = model.Instagram;
                contacts.Twitter = model.Twitter;
                contacts.LinkedIn = model.LinkedIn;
                _context.Contacts.Update(contacts);
                _context.SaveChanges();
                return RedirectToAction("Index", "Contact");
            }
            return View(model);
        }

        

    }
}
