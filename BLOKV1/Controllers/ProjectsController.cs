using BLOGV1.Helper;
using BLOGV1.Models;
using BLOKV1.Context;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BLOGV1.Controllers
{
    public class ProjectsController : Controller
    {
        private readonly BlogDbContext _context;

        public ProjectsController(BlogDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var projects = _context.Projects.ToList();
            return View(projects);
        }
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Projects model,IFormFile? ImageFile)
        {
            if(ModelState.IsValid)
            {
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
                           model.ProjectImageUrl = "/img/" + randomfileName;
                        }
                        catch
                        {
                            ModelState.AddModelError("", "Dosya yüklenirken bir hata oluştu.");
                        }
                    }
                }
                else
                {
                    ModelState.AddModelError("", "Bir resim seçiniz.");
                }
                model.Slug = SlugHelper.ToSlugUrl(model.ProjectName);
                _context.Projects.Add(model);             
                _context.SaveChanges();
                _context.Details.Add(new Details
                {
                    ProjectId = model.Id
                });
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(model);

        }
        public IActionResult Edit(int id) 
        {
            var project = _context.Projects.Find(id);
            if (project == null)
            {
                return NotFound();
            }
            return View(project);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(Projects model,IFormFile? ImageFile)
        {
            if(ModelState.IsValid)
            {
                var project = _context.Projects.Find(model.Id);
                if (project == null)
                {
                    return NotFound();
                }
                project.ProjectName = model.ProjectName;
                project.Description = model.Description;
                project.footer = model.footer;
                project.Slug = SlugHelper.ToSlugUrl(model.ProjectName);
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
                            project.ProjectImageUrl = "/img/" + randomfileName;
                        }
                        catch
                        {
                            ModelState.AddModelError("", "Dosya yüklenirken bir hata oluştu.");
                        }
                    }
                }
                else
                {
                    ModelState.AddModelError("", "Bir resim seçiniz.");
                }
                _context.Projects.Update(project);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
                return View(model);
        }


        [HttpPost]
        public IActionResult Delete(int id)
        {
            var project = _context.Projects.Find(id);
            if (project == null)
            {
                return NotFound();
            }
            var detail = _context.Details.Include(x => x.ProjectImageUrl).FirstOrDefault(d => d.ProjectId == project.Id);
            _context.Projects.Remove(project);
            _context.SaveChanges();
            if (detail != null)
            {
                _context.Details.Remove(detail);
                _context.SaveChanges();
            }
            return RedirectToAction("Index");
        }
    }
}
