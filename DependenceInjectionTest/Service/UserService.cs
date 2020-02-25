using DependenceInjectionTest.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DependenceInjectionTest.Service
{
    public class UserService : BaseService, IUserService, ISuperUserService
    {
        public List<User> ListUser { get; set; }
        public UserService()
        {
            ListUser = new List<User>
            {
                new User { UserId = "userId1", UserName = "user1" },
                new User { UserId = "userId2", UserName = "user2" },
                new User { UserId = "userId3", UserName = "user3" },
            };
        }

        public async Task<List<User>> GetAllUsers()
        {
            if (ListUser != null)
                return ListUser;
            else
                return new List<User>();
        }
        public async Task<string> AddUser(User user)
        {
            if (user == null)
            {
                return string.Empty;
            }
            
            //do add User
            return user.UserId;
        }
        public async Task<DateTime> UpdateUser(User user)
        {
            if (user == null)
            {
                return DateTime.MinValue;
            }

            //do update User
            return DateTime.Now;
        }
        public async Task<User> GetUserData(string id)
        {
            if (!string.IsNullOrWhiteSpace(id))
            {
                return null;
            }

            //find User in database
            return new User();
        }

        public async Task<User> GetUserByUserName(string username)
        {
            if (!string.IsNullOrWhiteSpace(username))
            {
                return null;
            }

            //find User in database
            return new User();
        }

        public async Task<DateTime> DeleteUser(string id)
        {
            if (!string.IsNullOrWhiteSpace(id))
            {
                return DateTime.MinValue;
            }

            //do delete User
            return DateTime.Now;
        }

        public async Task<DateTime> DeleteUser(User user)
        {
            return await DeleteUser(user.UserId);
        }

        public bool IsExistUser(string userName)
        {
            var user = GetUserByUserName(userName)?.Result;
            return user != null;
        }

        public void Test()
        {
            throw new NotImplementedException();
        }
    }
}
