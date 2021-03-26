using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Howl.Models;
using Howl.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Howl.Pages
{
    public class HomePageModel : PageModel
    {
        private IReviewService _reviewService;
        private IUserService _userService;
        private IAlbumService _albumService;
        public HomePageModel(IReviewService reviewService, IUserService userService, IAlbumService albumService)
        {
            _reviewService = reviewService;
            _userService = userService;
            _albumService = albumService;
        }
        [BindProperty]
        public List<Review> Reviews { get; set; }
        [BindProperty]
        public List<Review> FollowerReview { get; set; }
        [BindProperty]
        public List<User> Followers { get; set; }
        [BindProperty]
        public User User1 { get; set; } = new User();
        [BindProperty]
        public User fu { get; set; } = new User();
        [BindProperty]
        public Review likedislike { get; set; }

        public IActionResult OnGet()
        {
            //bool test = HttpContext.Request.Cookies.ContainsKey("UserName");
            string testname;
            HttpContext.Request.Cookies.TryGetValue("UserName",out testname);
            User1.Username = testname;
            //  Get newest reviews
            Reviews = _reviewService.GetReviews();
            foreach (Review item in Reviews)
            {
                item.Album = _albumService.GetAlbumByID(item.Album.AlbumID);
            }
            Reviews = Reviews.OrderByDescending(r => r.PublishDateTime).ToList();

            //  Get followers reviews
            Followers = _reviewService.GetFollowers(User1);
            FollowerReview = _reviewService.GetReviewsFromUserList(Followers).OrderByDescending(r=>r.PublishDateTime).ToList();
            foreach (Review item in FollowerReview)
            {
                item.Album = _albumService.GetAlbumByID(item.Album.AlbumID);
            }
            return Page();
        }

        public IActionResult OnPostFollow()
        {
            _userService.FollowUser(User1, fu);
            return RedirectToPage("HomePage");
        }

        public IActionResult OnPostUnfollow()
        {
            _userService.UnFollowUser(User1, fu);
            return RedirectToPage("HomePage");
        }

        public IActionResult OnPostLike()
        {
            Review review = _reviewService.GetReviewById(likedislike);
            _reviewService.Like(review);
            return RedirectToPage("HomePage");
        }

        public IActionResult OnPostDislike()
        {
            Review review = _reviewService.GetReviewById(likedislike);
            _reviewService.Dislike(review);
            return RedirectToPage("HomePage");
        }

    }
}
