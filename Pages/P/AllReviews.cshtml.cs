using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Howl.Models;
using Howl.Services;

namespace Howl.Pages.P
{
    public class AllReviewsModel : PageModel
    {
        private IAlbumService _albumService;
        private IReviewService _reviewService;

        public AllReviewsModel(IAlbumService albumService, IReviewService reviewService)
        {
            _albumService = albumService;
            _reviewService = reviewService;
        }

        [BindProperty]
        public List<Review> Reviews { get; set; }

        public IActionResult OnGet()
        {
            Reviews = _reviewService.GetReviews();
            foreach (Review item in Reviews)
            {
                item.Album = _albumService.GetAlbumByID(item.Album.AlbumID);
            }
            Reviews = Reviews.OrderByDescending(r => r.PublishDateTime).ToList();
            return Page();
        }
    }
}
