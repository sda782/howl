using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Howl.Models;
using Howl.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Howl.Pages
{
    public class LoginModel : PageModel
    {
        private IUserService _userService;
        public LoginModel(IUserService userService)
        {
            _userService = userService;
        }
        [BindProperty]
        public User LoginUser { get; set; }
        public IActionResult OnGet()
        {
            
            return Page();
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            if (!_userService.UserLogin(LoginUser))
            {
                return Page();
            }
            HttpContext.Response.Cookies.Append("UserName", LoginUser.Username);
            return RedirectToPage("../P/HomePage");
        }

    }
}
