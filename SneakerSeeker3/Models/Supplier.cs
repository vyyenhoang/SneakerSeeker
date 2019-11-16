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
        [Required]
        public virtual String CompanyName { get; set; }
        public virtual String URL { get; set; }

        public virtual List<Product> Products { get; set; }

    }
}
