using Howl.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Howl.Services
{
    public interface IAlbumService
    {
        Album GetAlbumByID(int id);
        IEnumerable<Album> GetAlbums();
        void AddAlbum(Album album);
    }
}
