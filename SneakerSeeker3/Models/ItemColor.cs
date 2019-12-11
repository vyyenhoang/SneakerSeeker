using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SneakerSeeker3.Models
{
    public class ItemColor
    {
        [Key]
        public virtual int ItemColorId { get; set; }

        [Required(ErrorMessage = "Please enter Color")]
        [Display(Name = "Color")]
        //[StringLength(25, ErrorMessage = "Color could not be greater than 25 characters")]
        public virtual String Color { get; set; }

        public virtual List<Product> Products { get; set; }

    }
}
