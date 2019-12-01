using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace TryAuth2.Pages
{
    public class AccountModel : PageModel
    {
        public string Username;

        public void OnGet()
        {
            Username = HttpContext.Session.GetString("username");
        }
    }
}