using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment2.Models
{
	public class Category
	{
		public Category() { }
		public Category(int CategoryId, String CategoryName, String Description, Boolean Active)
		{
			this.CategoryId = CategoryId;
			this.CategoryName = CategoryName;
			this.Description = Description;
			this.Active = Active

		}

		[Key]
		public virtual int CategoryId { get; set; } //Primary Key


		[Required]
		[Display(Name = "Category Name")]
		public virtual String CategoryName { get; set; }

		[Required]
		public virtual String Description { get; set; }

		public virtual String ImageURL { get; set; }

		public virtual Boolean Active { get; set; }

		public virtual List<Category> CateName { get; set; }
    }
}
