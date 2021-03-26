using Howl.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Howl.Services
{
    public class AlbumService : IAlbumService
    {
        private DBClient dbc = new DBClient();
        public void AddAlbum(Album album)
        {
            throw new NotImplementedException();
        }

        public Album GetAlbumByID(int id)
        {
            return GetAlbums().Where(a => a.AlbumID == id).FirstOrDefault();
        }

        public IEnumerable<Album> GetAlbums()
        {
            List<Album> albums = dbc.AlbumListReturn($"SELECT * FROM Albums");
            return albums;
        }
    }
}
