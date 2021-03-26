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
    public class SearchResultModel : PageModel
    {
        private IAlbumService service;
        public SearchResultModel(IAlbumService albumService)
        {
            service = albumService;
        }

        [BindProperty(SupportsGet = true)]
        public string SearchTerm { get; set; }
        [BindProperty]
        public IEnumerable<Album> Albums { get; set; }
        public void OnGet()
        {
            Albums = service.GetAlbums();
            if (!String.IsNullOrEmpty(SearchTerm))
            {
                Albums = Albums.Where(a => a.AlbumTitle.ToLower().Contains(SearchTerm.ToLower()));
            }
        }
    }
}
