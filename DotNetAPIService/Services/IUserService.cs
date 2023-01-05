using System;
using DotNetAPIService.Models;
namespace DotNetAPIService.Services
{
	public interface IUserService
	{
        public User[] GetUsers();
        public User GetUser(int id);
	}

}

