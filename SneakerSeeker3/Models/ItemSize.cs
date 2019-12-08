using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SneakerSeeker3.Models
{
    public class ItemSize
    {
        [Key]
        public virtual int ItemSizeId { get; set; }

        [Required(ErrorMessage = "Please enter Size")]
        [Display(Name = "Size")]
        //[StringLength(3, ErrorMessage = "Size could not have more than 2 numbers")]
        public virtual String Size { get; set; }

        public virtual List<Product> Products { get; set; }

    }
}
