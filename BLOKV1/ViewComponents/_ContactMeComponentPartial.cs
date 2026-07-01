using BLOKV1.Context;
using Microsoft.AspNetCore.Mvc;

namespace BLOGV1.ViewComponents

{
    public class _ContactMeComponentPartial : ViewComponent
    {
        private readonly BlogDbContext _blogDbContext;

        public _ContactMeComponentPartial(BlogDbContext blogDbContext)
        {
            _blogDbContext = blogDbContext;
        }

        public IViewComponentResult Invoke()
        {
            var result=_blogDbContext.Contacts.FirstOrDefault();
            return View(result);
        }
    }
}
