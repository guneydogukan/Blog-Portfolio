using BLOGV1.Identity;
using BLOGV1.Models.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

public class ProfileController : Controller
{
    private readonly UserManager<BlogIdentityUser> _userManager;

    public ProfileController(UserManager<BlogIdentityUser> userManager)
    {
        _userManager = userManager;
    }

    [HttpGet]
    public async Task<IActionResult> Index()
    {
        var user = await _userManager.FindByNameAsync(User.Identity.Name);

        UserEditViewModel model = new UserEditViewModel();
        model.Name = user.Name;
        model.Surname = user.Surname;
        model.Email = user.Email;
        model.PhoneNumber = user.PhoneNumber;

        return View(model);
    }

    [HttpPost]
    public async Task<IActionResult> Index(UserEditViewModel model)
    {
        var user = await _userManager.FindByNameAsync(User.Identity.Name);

        user.Name = model.Name;
        user.Surname = model.Surname;
        user.Email = model.Email;
        user.PhoneNumber = model.PhoneNumber;

        // Eğer şifre kutusuna bir şey yazıldıysa şifreyi güncelle
        if (!string.IsNullOrEmpty(model.Password))
        {
            user.PasswordHash = _userManager.PasswordHasher.HashPassword(user, model.Password);
        }

        var result = await _userManager.UpdateAsync(user);

        if (result.Succeeded)
        {
            return RedirectToAction("Index", "Profile");
        }

        return View(model);
    }
}
