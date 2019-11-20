using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SneakerSeeker3.Models
{
    public class Product
    {
        public Product() { }
        public Product(int ProductId, String SKU, String ProductName, String ProductDescription, Decimal UnitPrice, String ProductURL)
        {

            this.ProductId = ProductId;
            this.SKU = SKU;
            this.ProductName = ProductName;
            this.ProductDescription = ProductDescription;
            this.UnitPrice = UnitPrice;
            this.ProductURL = ProductURL;

        }





        [Key]
        public virtual int ProductId { get; set; } //Primary Key

        
        public virtual String SKU { get; set; }


        [Required]
        public virtual String ProductName { get; set; }

        public virtual String ProductDescription { get; set; }
        

        [DataType(DataType.Currency)]
        public virtual Decimal UnitPrice { get; set; }
        
        [Display(Name = "Image")]
        public string ProductURL { get; set; }

        
        public virtual int CategoryId { get; set; }
        public virtual Category Cat { get; set; }

        public virtual int SupplierId { get; set; }
        public virtual Supplier Sup { get; set; }

        public virtual ItemSize size { get; set; }


        public virtual int ItemColorId { get; set; }
        public virtual ItemColor color { get; set; }

        public virtual List<ItemReview> ItemReviews { get; set; }



    }
}
