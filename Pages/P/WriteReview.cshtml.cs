using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Howl.Services;
using Howl.Models;

namespace Howl.Pages
{
    public class WriteReviewModel : PageModel
    {
        /*public List<Review> reviews { get; set; }*/
        private IReviewService _reviewService;
        private IAlbumService _albumService;

        [BindProperty]
        public Review Review { get; set; }
        [BindProperty]
        public int albumid { get; set; }
        [BindProperty]
        public int StarRating { get; set; }
        public WriteReviewModel(IReviewService reviewService, IAlbumService albumService)
        {
            _reviewService = reviewService;
            _albumService = albumService;
        }
        
        public IActionResult OnGet(int id)
        {
            Review = new Review();
            Review.StarRating = 0;
            albumid = id;
            Review.Album = _albumService.GetAlbumByID(id);
            //Review.User.Username = "testerman";
            //Review.Album.AlbumID = 666;
            /*reviews = ReviewService.GetReviews();*/
            //Review.User = _reviewService.GetUser(Review);
            //Review.Album = _reviewService.GetAlbum(Review);
            return Page();
        }

        public IActionResult OnPost()
        {
            Review.User = new User();
            string testname;
            HttpContext.Request.Cookies.TryGetValue("UserName", out testname);
            Review.User.Username = testname;
            Review.Album = new Album();
            Review.Album.AlbumID = albumid;
            Review.StarRating = StarRating;
            //Review.PublishDateTime = DateTime.Now;
            _reviewService.AddReview(Review);
            return RedirectToPage("HomePage");
        }
    }
}
