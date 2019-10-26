using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment2.Models
{
    public class Suppliers
    {
        [Key]
        public virtual int SupplierId { get; set; } //Primary Key

        //Foreign Key
        public virtual int CustomerId { get; set; }
        public virtual Customers Cust { get; set; }

        [Required]
        public virtual String CompanyName { get; set; }

        public virtual String ContactFName { get; set; }
        public virtual String ContactLName { get; set; }
        public virtual String ContactTitle { get; set; }

        public virtual String Address1 { get; set; }
        public virtual String Address2 { get; set; }

        public virtual String City { get; set; }
        public virtual String State { get; set; }
        public virtual String PostalCode { get; set; }

        public virtual String Country { get; set; }
        public virtual String Phone { get; set; }
        public virtual String Fax { get; set; }
        public virtual String Email { get; set; }
        public virtual String URL { get; set; }

        public virtual String PaymentMethods { get; set; }
        public virtual String DiscountType { get; set; }

        public virtual String TypeGoods { get; set; }
        public virtual String Notes { get; set; }
        public virtual Boolean DiscountAvailable { get; set; }
        public virtual String CurrentOrder { get; set; }
        public virtual String Logo { get; set; }

        public virtual String SizeURL { get; set; }
    }
}
