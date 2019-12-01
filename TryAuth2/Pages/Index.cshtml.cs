using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace TryAuth2.Pages
{
    public class IndexModel : PageModel
    {
        [BindProperty]
        public string Username { get; set; }

        [BindProperty]
        public string Password { get; set; }

        public string Message { get; set; }

        public void OnGet()
        {

        }

        public IActionResult OnGetLogout()
        {
            HttpContext.Session.Remove("username");
            return Page();
        }

        public IActionResult OnPostLogIn()
        {
            if (Username == "admin")
            {
                if (Password == "nimda")
                {
                    HttpContext.Session.SetString("username", Username);
                    return RedirectToPage("Account");
                }
                else
                {
                    Message = "Invalid Password or Login";
                    return Page();
                }
            }
            else
            {
                Message = "Invalid Login";
                return Page();
            }
        }
    }
}