using BLOGV1.Models;
using BLOKV1.Context;
using Microsoft.AspNetCore.Mvc;

namespace BLOGV1.Controllers
{
    public class DetailsController : Controller
    {
        private readonly BlogDbContext _context;

        public DetailsController(BlogDbContext context)
        {
            _context = context;
        }

        public IActionResult Edit(int projectID)
        {
            var projectDetails = _context.Details.FirstOrDefault(p => p.ProjectId == projectID);
            if (projectDetails == null) { 
                return NotFound();
            }
            return View(projectDetails);
        }

        [HttpPost]
        public IActionResult Edit(Details model, List<IFormFile> ImageFile)
        {
            if (ModelState.IsValid)
            {
                var details = _context.Details.Find(model.Id);
                if (details == null)
                {
                    return NotFound();
                }
                // Handle multiple image uploads
                if (ImageFile != null && ImageFile.Count > 0)
                {
                    foreach (var file in ImageFile)
                    {
                        if (file.Length > 0)
                        {
                            var uploadsFolder = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/img/projects");
                            var uniqueFileName = Guid.NewGuid().ToString() + "_" + file.FileName;
                            var filePath = Path.Combine(uploadsFolder, uniqueFileName);
                            using (var fileStream = new FileStream(filePath, FileMode.Create))
                            {
                                file.CopyTo(fileStream);
                            }
                            var projectImage = new ProjectImages
                            {
                                ProjectId = (int)model.ProjectId!, 
                                ProjectDetail = details,
                                ImageUrl = "/img/projects/" + uniqueFileName
                            };
                            _context.ProjectImages.Add(projectImage);
                            _context.SaveChanges();
                        }
                    }
                }
                details.ProjectDescriptions = model.ProjectDescriptions;
                details.Category = model.Category;
                details.Client = model.Client;
                details.ProjectDate = model.ProjectDate;
                details.ProjectUrl = model.ProjectUrl;
                _context.Details.Update(details);
                _context.SaveChanges();
                return RedirectToAction("Index", "Projects");
            }
            return View(model);
        }
    }
}
