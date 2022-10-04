using eTicaretCase.ViewModel;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace eTicaretCase.Pages
{
    public class GirisModel : PageModel
    {
        private readonly SignInManager<IdentityUser> signInManager;

        [BindProperty]
        public Giris Model { get; set; }
        public GirisModel(SignInManager<IdentityUser> signInManager)
        {

            this.signInManager = signInManager;
        }
        public void OnGet()
        {
        }

        public async Task<IActionResult> OnPostAction(string returnUrl = null)
        {
            if (ModelState.IsValid)
            {
                var identityResult = await signInManager.PasswordSignInAsync(Model.Email, Model.Sifre, Model.BeniHatirla, false);
                if (identityResult.Succeeded)
                {
                    if (returnUrl == null || returnUrl == "/")
                    {
                        return RedirectToPage("Index");
                    }
                    else
                    {
                        return RedirectToPage(returnUrl);
                    }
                }

                ModelState.AddModelError("", "Mail ya da Þifre yanlýþ");
            }

            return Page();
        }

    }
}

