using eTicaretCase.ViewModel;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace eTicaretCase.Pages
{
    public class KayitModel : PageModel
    {
        private readonly  UserManager<IdentityUser> userManager;
        private readonly SignInManager<IdentityUser> signInManager;

        [BindProperty]
        public Kayit Model { get; set; }
        public KayitModel(UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager)
        {
            this.userManager = userManager;
            this.signInManager = signInManager;
        }
        public void OnGet()
        {
        }

        public async Task<IActionResult> OnPostAsync()
        {

            if (ModelState.IsValid)
            {
                var user = new IdentityUser()
                {
                    UserName = Model.Email,
                    Email = Model.Email
                };
                
                var result = await userManager.CreateAsync(user, Model.Sifre);
                                
                if (result.Succeeded)
                {
                    await signInManager.SignInAsync(user, false);
                    return RedirectToPage("index");
                }

                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError(string.Empty, error.Description);
                }
            }
            return Page();
        }

        
    }
}
