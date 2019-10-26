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
        public Category(int GenreId, String Name, String Description)
        {
            this.CategoryId = CategoryId;
            this.Name = Name;
            this.Description = Description;
        }

        [Key]
        public virtual int CategoryId { get; set; } //Primary Key


        [Required]
        [Display(Name = "Category Name")]
        public virtual String Name { get; set; }

        [Required]
        public virtual String Description { get; set; }

        public virtual String Picture { get; set; }

        public virtual Boolean Active { get; set; }

    }
}
