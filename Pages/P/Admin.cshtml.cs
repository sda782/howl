using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Howl.Models;
using Howl.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Howl.Pages.P
{
    public class AdminModel : PageModel
    {
        private IUserService userService;
        private IAlbumService albumService;
        private IReviewService reviewService;
        public AdminModel(IUserService uService, IAlbumService aService, IReviewService rService)
        {
            userService = uService;
            albumService = aService;
            reviewService = rService;
        }
        [BindProperty]
        public IEnumerable<User> Users { get; set; }
        [BindProperty]
        public IEnumerable<Album> Albums { get; set; }
        [BindProperty]
        public IEnumerable<Review> Reviews { get; set; }

        public IActionResult OnGet()
        {
            /*string testname;
            HttpContext.Request.Cookies.TryGetValue("UserName", out testname);*/
            if (HttpContext.Request.Cookies["UserName"] != "Admin")
            {
                return RedirectToPage("../Index");
            }
            Users = userService.GetUsers();
            Albums = albumService.GetAlbums();
            Reviews = reviewService.GetReviews();
            return Page();
        }
    }
}
