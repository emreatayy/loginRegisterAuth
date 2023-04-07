using edX.ViewModel;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks;

namespace edX.Pages
{
    public class LoginModel : PageModel
    {
        [BindProperty]
        public Login Model { get; set; }
        public SignInManager<IdentityUser> SignInManager { get; }

        public LoginModel(SignInManager<IdentityUser> signInManager)
        {
            SignInManager = signInManager;
        }

        public void OnGet()
        {
        }

        public async Task<IActionResult> OnPostAsync(string returnUrl = null)
        {
            if (ModelState.IsValid)
            {
                var identityResult = await SignInManager.PasswordSignInAsync(Model.Email, Model.Password, false, false);
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
            ModelState.AddModelError("", "Username or Password incorrect");
            }
            return Page();
        }
            
    }
        
}