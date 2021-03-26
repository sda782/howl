using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Howl.Services;
using Howl.Models;

namespace Howl.Pages.Control
{
    public class CreateUserModel : PageModel
    {
        private IUserService _userService;

        [BindProperty]
        public User User1 { get; set; } = new User();

        public CreateUserModel(IUserService userService)
        {
            _userService = userService;
        }
        public IActionResult OnGet()
        {
            return Page();
        }

        public IActionResult OnPost()
        {
            _userService.AddUser(User1);
            HttpContext.Response.Cookies.Append("UserName", User1.Username);
            return RedirectToPage("../P/HomePage");
        }
    }
}
