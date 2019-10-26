using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment2.Models
{
    public class Products
    {
        [Key]
        public virtual int ProductId { get; set; } //Primary Key

        //Foreign Key
        public virtual int SupplierId { get; set; }
        public virtual Suppliers Supp { get; set; }
        //Foreign Key
        public virtual int CategoryId { get; set; }
        public virtual Category ProductCategory { get; set; }

        public virtual int SKU { get; set; }
        public virtual int IDSKU { get; set; }

        [Required]
        public virtual String ProductName { get; set; }
        
        public virtual String ProductDescription { get; set; }

        public virtual int QuantityPerUnit { get; set; }

        [DataType(DataType.Currency)]
        public virtual Decimal UnitPrice { get; set; }

        [DataType(DataType.Currency)]
        public virtual Decimal MSRP { get; set; }

        public virtual int AvailableSize { get; set; }
        public virtual String AvailableColor { get; set; }

        public virtual float Size { get; set; }
        public virtual  String Color { get; set; }
        public virtual int Discount { get; set; }

        public virtual int UnitWeight { get; set; }
        public virtual int UnitsInStock { get; set; }
        public virtual int UnitsOnOrder { get; set; }

        public virtual int ReorderLevel { get; set; }

        public virtual Boolean ProductAvailable { get; set; }
        public virtual Boolean DiscountAvailable { get; set; }

        public virtual int CurrentOrder { get; set; }
        public virtual String Picture { get; set; }
        public virtual int Ranking { get; set; }
        public virtual String Note { get; set; }
    }
}
