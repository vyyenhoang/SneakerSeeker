using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SneakerSeeker3.Models
{
    public class Supplier
    {

        public Supplier() { }
        public Supplier(int SupplierId, String CompanyName, String URL)
        {
            this.SupplierId = SupplierId;
            this.CompanyName = CompanyName;
            this.URL = URL;

        }




        [Key]
        public virtual int SupplierId { get; set; } //Primary Key
        [Required(ErrorMessage = "Please enter Company Name")]
        [Display(Name = "Company Name")]
        //[StringLength(50, ErrorMessage = "Color could not be greater than 50 characters")]
        public virtual String CompanyName { get; set; }
        [Required(ErrorMessage = "Please enter Image URL")]
        public virtual String URL { get; set; }

        public virtual List<Product> Products { get; set; }

    }
}
