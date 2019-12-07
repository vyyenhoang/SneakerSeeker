using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SneakerSeeker3.Models
{
    public class Category
    {
        public Category() { }
    public Category(int CategoryId, String CategoryName, String Description, Boolean Active)
    {
        this.CategoryId = CategoryId;
        this.CategoryName = CategoryName;
        this.Description = Description;
        this.Active = Active;

    }

    [Key]
    public virtual int CategoryId { get; set; } //Primary Key




    [Required(ErrorMessage = "Please enter Category Name")]
    [Display(Name = "Category Name")]
    [StringLength(100, ErrorMessage = "Category Name could not be greater than 100 characters")]
    public virtual String CategoryName { get; set; }

    [Required(ErrorMessage = "Please enter Description for Category")]
    [Display(Name = "Description")]
    [StringLength(100, ErrorMessage = "Description could not be greater than 100 characters")]
    public virtual String Description { get; set; }

    public virtual String ImageURL { get; set; }

    public virtual Boolean Active { get; set; }

    public virtual List<Product> Products { get; set; }
}
}
