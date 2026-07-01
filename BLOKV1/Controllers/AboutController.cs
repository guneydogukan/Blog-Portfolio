using BLOGV1.Models;
using BLOKV1.Context;
using BLOKV1.Models;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace BLOGV1.Controllers
{
    public class AboutController : Controller
    {
        private readonly BlogDbContext _context;

        public AboutController(BlogDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var About = _context.Abouts.FirstOrDefault();
            return View(About);
            
        }

        public IActionResult Edit(int ID)
        {
            var abouts = _context.Abouts.Find(ID);
            if (abouts == null)
            {
                return NotFound();
            }
            return View(abouts);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(About model, IFormFile ImageFile)
        { 
            if (ModelState.IsValid)
            {
                var abouts = _context.Abouts.Find(model.Id);
                if (abouts == null)
                {
                    return NotFound();
                }

                if (ImageFile != null)
                {
                    var allowenExtensions = new[] { ".jpg", ".png", ".jpeg" };
                    var extensions = Path.GetExtension(ImageFile.FileName).ToLowerInvariant();
                    if (!allowenExtensions.Contains(extensions))
                    {
                        ModelState.AddModelError("", "Sadece .jpg .png,.jpeg türlerinde dosya yükleyebilirsiniz.");
                    }
                    else
                    {
                        var randomfileName = string.Format($"{Guid.NewGuid().ToString()}{extensions}");
                        var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/img", randomfileName);

                        try
                        {
                            using (var stream = new FileStream(path, FileMode.Create))
                            {
                                await ImageFile.CopyToAsync(stream);
                            }
                            abouts.ProfileImageUrl = "/img/" + randomfileName;
                        }
                        catch
                        {
                            ModelState.AddModelError("", "Dosya yüklenirken bir hata oluştu.");
                        }
                    }
                }
                else
                {
                    ModelState.AddModelError("", "Bir resim seçiniz.");
                }
                abouts.Name = model.Name;
                abouts.Profession = model.Profession;
                abouts.Email = model.Email;
                abouts.Phone = model.Phone;
                abouts.AboutMe = model.AboutMe;
                _context.Abouts.Update(abouts);
                _context.SaveChanges();
                return RedirectToAction("Index", "About");
            }
            return View(model);
        }


    }
}
