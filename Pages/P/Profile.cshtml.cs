using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Howl.Services;
using Howl.Models;

namespace Howl.Pages.P
{
    public class ProfileModel : PageModel
    {
        private IReviewService _reviewService;
        private IUserService _userService;

        public ProfileModel(IReviewService reviewService, IUserService userService)
        {
            _reviewService = reviewService;
            _userService = userService;
        }

        [BindProperty]
        public IEnumerable<Review> Reviews { get; set; }
        [BindProperty]
        public User User { get; set; }
        [BindProperty]
        public int FollowerCount { get; set; }
        [BindProperty]
        public int FollowedCount { get; set; }
        [BindProperty]
        public int ReviewsWritten { get; set; }
        [BindProperty]
        public Review Review { get; set; }

        public void OnGet()
        {
            string testname;
            HttpContext.Request.Cookies.TryGetValue("UserName", out testname);
            //User1.Username = testname;
            User = _userService.GetUserById(testname);
            FollowerCount = _reviewService.GetFollowers().Where(u => u.Username == testname).Count();
            FollowedCount = _reviewService.GetFollowers(User).Count();
            Reviews = _reviewService.GetReviews().Where(r => r.User.Username == testname);

            if (Reviews.Count() > 0)
            {
                ReviewsWritten = Reviews.Count();
            }
            else
            {
                ReviewsWritten = 0;
            }
        }

        public IActionResult OnPostDelete()
        {
            _reviewService.DeleteReview(Review.ReviewID);
            return RedirectToPage("Profile");
        }

        public IActionResult OnPostLogout()
        {
            HttpContext.Response.Cookies.Delete("UserName");
            return RedirectToPage("AllReviews");
        }
    }
}
