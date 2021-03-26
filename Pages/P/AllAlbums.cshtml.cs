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
    public class AllAlbumsModel : PageModel
    {
        private IAlbumService _albumService;
        public AllAlbumsModel(IAlbumService albumService)
        {
            _albumService = albumService;
        }

        [BindProperty]
        public IEnumerable<Album> Albums { get; set; }
        [BindProperty(SupportsGet =true)]
        public Album.Genre? Genre { get; set; }
        public IActionResult OnGet(Album.Genre? genre)
        {
            Albums = _albumService.GetAlbums();
            if (Genre != null)
            {
                Albums = Albums.Where(a => a.MusicGenre == Genre);
            }
            return Page();
        }

        /*public IActionResult OnPost()
        {
            return RedirectToPage("AllAlbums", new { genre = Genre });
        }*/
    }
}
