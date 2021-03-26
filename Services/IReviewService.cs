using Howl.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Howl.Services
{
    public interface IReviewService
    {
        void AddReview(Review review);
        List<Review> GetReviews();
        List<Review> GetReviewsFromUserList(List<User> users);
        List<User> GetFollowers(User user);
        List<User> GetFollowers();
        User GetUser(Review review);
        Album GetAlbum(Review review);
        void Like(Review review);
        void Dislike(Review review);
        Review GetReviewById(Review review);
        void DeleteReview(int id);
    }
}
