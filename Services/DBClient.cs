using Howl.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace Howl.Services
{
    public class DBClient
    {
        private const string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=HowlDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        public void Start()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                Console.WriteLine("Connected to DB: " + connection.Database);
            }
        }
        public void NoReturnQuery(string queryString)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand sqlCommand = new SqlCommand(queryString, connection);
                sqlCommand.ExecuteNonQuery();
            }
        }

        public List<Review> ReviewListReturn(string queryString)
        {
            List<Review> List = new List<Review>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand sqlCommand = new SqlCommand(queryString, connection);
                connection.Open();
                SqlDataReader reader = sqlCommand.ExecuteReader();
                while (reader.Read())
                {
                    Review review = new Review();
                    review.User = new User();
                    review.Album = new Album();
                    review.ReviewID = reader.GetInt32(0);
                    review.User.Username = reader.GetString(1);
                    review.Album.AlbumID = reader.GetInt32(2);
                    review.ReviewTitle = reader.GetString(3);
                    review.ReviewText = reader.GetString(4);
                    review.PublishDateTime = reader.GetDateTime(5);
                    review.Like = reader.GetInt32(6);
                    review.Dislike = reader.GetInt32(7);
                    review.StarRating = reader.GetInt32(8);
                    List.Add(review);
                }
            }
            return List;
        }

        public List<Review> FollowerReviewListReturn(string queryString, List<User> users)
        {
            List<Review> List = new List<Review>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand sqlCommand = new SqlCommand(queryString, connection);
                connection.Open();
                SqlDataReader reader = sqlCommand.ExecuteReader();
                while (reader.Read())
                {
                    if (users.Contains(users.Find(u => u.Username == reader.GetString(1))))
                    {
                        Review review = new Review();
                        review.User = new User();
                        review.Album = new Album();
                        review.ReviewID = reader.GetInt32(0);
                        review.User.Username = reader.GetString(1);
                        review.Album.AlbumID = reader.GetInt32(2);
                        review.ReviewTitle = reader.GetString(3);
                        review.ReviewText = reader.GetString(4);
                        review.PublishDateTime = reader.GetDateTime(5);
                        review.Like = reader.GetInt32(6);
                        review.Dislike = reader.GetInt32(7);
                        review.StarRating = reader.GetInt32(8);
                        List.Add(review);
                    }

                }
            }
            return List;
        }

        public List<User> UserFollwersListReturn(string queryString)
        {
            List<User> List = new List<User>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand sqlCommand = new SqlCommand(queryString, connection);
                connection.Open();
                SqlDataReader reader = sqlCommand.ExecuteReader();
                while (reader.Read())
                {
                    User user = new User();
                    user.Username = reader.GetString(1);
                    List.Add(user);
                }
            }
            return List;
        }

        public Review ReviewReturn(string queryString)
        {
            Review review = new Review();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand sqlCommand = new SqlCommand(queryString, connection);
                connection.Open();
                SqlDataReader reader = sqlCommand.ExecuteReader();
                while (reader.Read())
                {
                    //Review review = new Review();
                    review.User = new User();
                    review.Album = new Album();
                    review.ReviewID = reader.GetInt32(0);
                    review.User.Username = reader.GetString(1);
                    review.Album.AlbumID = reader.GetInt32(2);
                    review.ReviewTitle = reader.GetString(3);
                    review.ReviewText = reader.GetString(4);
                    review.PublishDateTime = reader.GetDateTime(5);
                    review.Like = reader.GetInt32(6);
                    review.Dislike = reader.GetInt32(7);
                    review.StarRating = reader.GetInt32(8);
                }
            }
            return review;
        }

        public User UserReturn(string queryString)
        {
            User user = new User();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand sqlCommand = new SqlCommand(queryString, connection);
                connection.Open();
                SqlDataReader reader = sqlCommand.ExecuteReader();
                while (reader.Read())
                {
                    user.Username = reader.GetString(0);
                    user.Password = reader.GetString(1);
                }
            }
            return user;
        }
        public List<User> UsersListReturn(string queryString)
        {
            List<User> List = new List<User>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand sqlCommand = new SqlCommand(queryString, connection);
                connection.Open();
                SqlDataReader reader = sqlCommand.ExecuteReader();
                while (reader.Read())
                {
                    User user = new User();
                    user.Username = reader.GetString(0);
                    user.Password = reader.GetString(1);
                    List.Add(user);
                }
            }
            return List;
        }

        public Album AlbumReturn(string queryString)
        {
            Album album = new Album();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand sqlCommand = new SqlCommand(queryString, connection);
                connection.Open();
                SqlDataReader reader = sqlCommand.ExecuteReader();
                while (reader.Read())
                {
                    album.AlbumID = reader.GetInt32(0);
                    album.AlbumTitle = reader.GetString(1);
                    album.Artist = reader.GetString(2);
                    album.Year = reader.GetDateTime(3);
                    album.MusicGenre = (Album.Genre)Enum.Parse(typeof(Album.Genre), reader.GetString(4));
                    album.CoverUrl = reader.GetString(5);
                }
            }
            return album;
        }

        public List<Album> AlbumListReturn(string queryString)
        {
            List<Album> List = new List<Album>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand sqlCommand = new SqlCommand(queryString, connection);
                connection.Open();
                SqlDataReader reader = sqlCommand.ExecuteReader();
                while (reader.Read())
                {
                    Album album = new Album();
                    album.AlbumID = reader.GetInt32(0);
                    album.AlbumTitle = reader.GetString(1);
                    album.Artist = reader.GetString(2);
                    album.Year = reader.GetDateTime(3);
                    album.MusicGenre = (Album.Genre)Enum.Parse(typeof(Album.Genre), reader.GetString(4));
                    album.CoverUrl = reader.GetString(5);
                    List.Add(album);
                }
            }
            return List;
        }
    }
}
