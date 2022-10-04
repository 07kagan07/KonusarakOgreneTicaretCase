using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace eTicaretCase.Pages
{
    public class CikisModel : PageModel
    {
        private readonly SignInManager<IdentityUser> signInManager;

        public CikisModel(SignInManager<IdentityUser> signInManager)
        {
            this.signInManager = signInManager;
        }
        public void OnGet()
        {
        }


        public async Task<IActionResult> OnPostLogoutAsync()
        {

            await signInManager.SignOutAsync();


            return RedirectToPage("Giris");
        }

        public async Task<IActionResult> OnPostDontLogoutAsync()
        {


            return RedirectToPage("Index");
        }



    }

}
