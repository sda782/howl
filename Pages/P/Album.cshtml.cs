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
    public class AlbumModel : PageModel
    {
        private IAlbumService _albumService;
        private IReviewService _reviewService;

        public AlbumModel(IAlbumService albumService, IReviewService reviewService)
        {
            _albumService = albumService;
            _reviewService = reviewService;
        }

        [BindProperty]
        public IEnumerable<Review> Reviews { get; set; }
        [BindProperty]
        public double Rating { get; set; }
        [BindProperty]
        public Album Album { get; set; }

        public void OnGet(int id)
        {
            Album = _albumService.GetAlbumByID(id);
            Reviews = _reviewService.GetReviews().Where(r  =>  r.Album.AlbumID  ==  id);
            //List<Review> test = new List<Review>();
            //test = Reviews.Where(r => r.ReviewID == id);
            if (Reviews.Count() !=  0)
            {
                Rating = Reviews.Average(r => r.StarRating);
            }
        }
    }
}
