using Howl.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Howl.Services
{
    public interface IUserService
    {
        bool UserLogin(User user);
        void FollowUser(User user, User followUser);
        void UnFollowUser(User user, User followUser);
        void AddUser(User user);
        IEnumerable<User> GetUsers();
        User GetUserById(string username);
    }
}
