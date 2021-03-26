using Howl.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Howl.Services
{
    public class ReviewService : IReviewService
    {
        private DBClient dbc = new DBClient();

        public void AddReview(Review review)
        {
            dbc.NoReturnQuery($"INSERT INTO Reviews VALUES ('{review.User.Username}', {review.Album.AlbumID}, '{review.ReviewTitle}', '{review.ReviewText}', '{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")}', 0, 0, {review.StarRating})");
        }

        public List<Review> GetReviews()
        {
            List<Review> reviews = new List<Review>();

            reviews = dbc.ReviewListReturn("SELECT * FROM Reviews");
            
            return reviews;
        }

        public List<Review> GetReviewsFromUserList(List<User> users)
        {
            List<Review> reviews = new List<Review>();

            reviews = dbc.FollowerReviewListReturn($"SELECT * FROM Reviews", users);
            return reviews;
        }

        public List<User> GetFollowers(User user)
        {
            List<User> users = new List<User>();
            users = dbc.UserFollwersListReturn($"SELECT * FROM Followers WHERE Username='{user.Username}'");
            return users;
        }

        public List<User> GetFollowers()
        {
            List<User> users = new List<User>();
            users = dbc.UserFollwersListReturn($"SELECT * FROM Followers");
            return users;
        }

        public User GetUser(Review review)
        {
            User user = new User();
            user = dbc.UserReturn($"SELECT * FROM Reviews WHERE Username='{review.User.Username}'");
            return user;
        }

        public Album GetAlbum(Review review)
        {
            Album album = new Album();
            album = dbc.AlbumReturn($"SELECT * FROM Reviews WHERE AlbumID={review.Album.AlbumID}");
            return album;
        }

        public void Like(Review review)
        {
            dbc.NoReturnQuery($"UPDATE Reviews SET LikeInt={review.Like + 1} WHERE ReviewID={review.ReviewID}");
        }

        public void Dislike(Review review)
        {
            dbc.NoReturnQuery($"UPDATE Reviews SET DislikeInt={review.Dislike + 1} WHERE ReviewID={review.ReviewID}");
        }

        public Review GetReviewById(Review review)
        {
            return dbc.ReviewReturn($"SELECT * FROM Reviews WHERE ReviewID={review.ReviewID}");
        }

        public void DeleteReview(int id)
        {
            dbc.NoReturnQuery($"DELETE FROM Reviews WHERE ReviewID={id}");
        }
    }
}
