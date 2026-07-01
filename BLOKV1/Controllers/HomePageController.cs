using BLOKV1.Context;
using BLOKV1.Models;
using Microsoft.AspNetCore.Mvc;

namespace BLOGV1.Controllers
{
    public class HomePageController : Controller
    {
        private readonly BlogDbContext _context;

        public HomePageController(BlogDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var homepage = _context.Blogs.FirstOrDefault();
            return View(homepage);
        }


        public IActionResult Edit(int ID)
        {
            var homepage = _context.Blogs.Find(ID);
            if (homepage == null)
            {
                return NotFound();
            }
            return View(homepage);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(Blog model, IFormFile ImageFile)
        {
            if (ModelState.IsValid)
            {
                var blog = _context.Blogs.Find(model.Id);
                if (blog == null)
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
                            blog.ImageUrl = "/img/" + randomfileName;
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
                blog.Name = model.Name;
                blog.Description = model.Description;
                _context.Blogs.Update(blog);
                _context.SaveChanges();
                return RedirectToAction("Index", "Blogs");
            }
            return View(model);
        }
    }
}
