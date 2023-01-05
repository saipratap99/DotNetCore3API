using System;
namespace DotNetAPIService.Models
{
	public class User
	{
        public int Id { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public User(int id, string name, string city)
		{
			this.Id = id;
			this.Name = name;
			this.City = city;
		}
	}
}

