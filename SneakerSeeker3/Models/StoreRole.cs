using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SneakerSeeker3.Models
{
	public class StoreRole : IdentityRole
	{
		public StoreRole() : base() { }
		public StoreRole(string roleName) : base(roleName) { }
		public StoreRole(string roleName, string description, DateTime creationDate  ) : base(roleName) {
			this.Description = description;
			this.CreationDate = creationDate;
			
		}
		public string Description { get; set; }
		public DateTime CreationDate { get; set; }
	}
}

