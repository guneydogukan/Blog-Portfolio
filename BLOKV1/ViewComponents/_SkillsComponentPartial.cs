using BLOKV1.Context;
using Microsoft.AspNetCore.Mvc;

namespace BLOGV1.ViewComponents
{
    public class _SkillsComponentPartial : ViewComponent
    {
        private readonly BlogDbContext _blogDbContext;

        public _SkillsComponentPartial(BlogDbContext blogDbContext)
        {
            _blogDbContext = blogDbContext;
        }

        public IViewComponentResult Invoke()
        {
            var result = _blogDbContext.Skills.ToList();
            return View(result);
        }
    }
}
