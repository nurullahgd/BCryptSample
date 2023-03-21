using BCryptSample.Common;
using BCryptSample.IService;
using BCryptSample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BCryptSample.Service
{
    public class UserService : IUserService
    {
        public List<User> GetAllUsers()
        {
            return Global.Users;
        }

        public User Login(User user)
        {
            var useracc = Global.Users.SingleOrDefault(x => x.Username == user.Username);
            bool isValidPassword = BCrypt.Net.BCrypt.Verify(user.Password, useracc.Password);
            if(isValidPassword)
            {
                return useracc;
            }
            return null;
        }

        public User SignUp(User user)
        {
            user.Password = BCrypt.Net.BCrypt.HashPassword(user.Password);
            Global.Users.Add(user);
            return user;
        }
    }
}
