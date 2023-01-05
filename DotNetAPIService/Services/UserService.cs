using System;
using DotNetAPIService.Models;

namespace DotNetAPIService.Services
{
	public class UserService: IUserService
	{
        private readonly User[] _users =
        {
            new User(1, "Jhon", "New York"),
            new User(2, "Kiran", "Chennai"),
            new User(3, "David", "Ooty")
        };

        public User[] GetUsers()
        {
            return this._users;
        }

        public User GetUser(int id)
        {
            foreach(User user in this._users){
                if (user.Id == id)
                    return user;
            }
            return null;
        }

    }
}

