using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Howl.Models
{
    public class Album
    {
        public int AlbumID { get; set; }
        public string CoverUrl { get; set; }
        public string AlbumTitle { get; set; }
        public string Artist { get; set; }
        public DateTime Year { get; set; }
        public Genre MusicGenre { get; set; }
        public enum Genre { ALTERNATIVE, BLUES, CLASSICAL, COMEDY, COUNTRY, DANCE, ELECTRONIC, RAP, ROCK}
    }
}
