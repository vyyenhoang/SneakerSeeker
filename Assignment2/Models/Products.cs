using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment2.Models
{
    public class Products
    {
        public Products() { }
        public Products(int ProductId, String SKU, String ProductName, String ProductDescription, int QuantityPerUnit, Decimal UnitPrice, Decimal Size, String Color, int UnitsInStock, int UnitsOnOrder, int ReorderLevel, string ProductURL)
        {

            this.ProductId = ProductId;
            this.SKU = SKU;
            this.ProductName = ProductName;
            this.ProductDescription = ProductDescription;
            this.QuantityPerUnit = QuantityPerUnit;
            this.UnitPrice = UnitPrice;
            this.Size = Size;
            this.Color = Color;
            this.UnitsInStock = UnitsInStock;
            this.UnitsOnOrder = UnitsOnOrder;
            this.ReorderLevel = ReorderLevel;
            this.ProductURL = ProductURL;

        }





        [Key]
        public virtual int ProductId { get; set; } //Primary Key


        [ForeignKey("SuplierId")]
        [Display(Name = "Brand Name")]
        public virtual Suppliers CompanyName { get; set; }


        [ForeignKey("CategoryId")]
        [Display(Name = "Category Name")]
        public virtual Category CategoryName { get; set; }


        public virtual String SKU { get; set; }


        [Required]
        public virtual String ProductName { get; set; }

        public virtual String ProductDescription { get; set; }

        public virtual int QuantityPerUnit { get; set; }

        [DataType(DataType.Currency)]
        public virtual Decimal UnitPrice { get; set; }
        public virtual Decimal Size { get; set; }
        public virtual String Color { get; set; }
        public virtual int UnitsInStock { get; set; }
        public virtual int UnitsOnOrder { get; set; }
        public virtual int ReorderLevel { get; set; }



        [Required(ErrorMessage = "Please select an Image to upload")]
        [Display(Name = "Image")]
        public string ProductURL { get; set; }



    }
}
