using Howl.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Howl.Services
{
    public class UserService : IUserService
    {
        private DBClient dbc = new DBClient();

        public void FollowUser(User user, User followUser)
        {
            dbc.NoReturnQuery($"INSERT INTO Followers VALUES ('{user.Username}','{followUser.Username}')");
        }

        public void UnFollowUser(User user, User followUser)
        {
            dbc.NoReturnQuery($"DELETE FROM Followers WHERE Username='{user.Username}' AND Followername='{followUser.Username}'");
        }

        public bool UserLogin(User user)
        {
            try
            {
                User user1 = dbc.UserReturn($"SELECT * FROM Users WHERE Username='{user.Username}'");
                return user1.Password == user.Password;
            }
            catch (Exception e)
            {
                throw new Exception("User not found");
            }

        }

        public void AddUser(User user)
        {
            dbc.NoReturnQuery($"INSERT INTO Users VALUES ('{user.Username}', '{user.Password}')");
        }

        public IEnumerable<User> GetUsers()
        {
            return dbc.UsersListReturn("SELECT * FROM USERS");
        }

        public User GetUserById(string un)
        {
            return GetUsers().Where(u => u.Username == un).FirstOrDefault();
        }
    }
}
