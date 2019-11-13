using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment2.Models
{
    public class Suppliers
    {

        public Suppliers() { }
        public Suppliers(int SupplierId, String CompanyName, String URL, String Logo)
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
        public virtual List<Products> Products { get; set; }

    }
}
