using DependenceInjectionTest.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DependenceInjectionTest.Service
{
    interface IUserService
    {
        Task<List<User>> GetAllUsers();
        Task<string> AddUser(User user);
        Task<User> GetUserData(string id);
        Task<User> GetUserByUserName(string username);
        bool IsExistUser(string username);
    }
}
