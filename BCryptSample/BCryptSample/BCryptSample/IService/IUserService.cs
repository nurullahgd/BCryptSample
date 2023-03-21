using BCryptSample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BCryptSample.IService
{
    public interface IUserService
    {
        User SignUp(User user);
        User Login(User user);
        List<User> GetAllUsers();

    }
}
