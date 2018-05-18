using System;
using Realms;

namespace APIExperiment.Models
{
	public class UserModel : RealmObject
    {
        public UserModel()
        {
        }
        
		[PrimaryKey]
		public int ID { get; set; }
		public string Name { get; set; }
		public string Email { get; set; }
		public string Password { get; set; }
		public int Level { get; set; }
        
    }
}
