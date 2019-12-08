﻿using Microsoft.AspNetCore.Authorization;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SneakerSeeker3.Models
{
	[Authorize (Roles = "role1")]
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


        [Required(ErrorMessage = "Please enter Product Name")]
        [Display(Name = "Product Name")]
        [StringLength(50, ErrorMessage = "Status could not be greater than 50 characters")]
        public virtual String ProductName { get; set; }

        [Required(ErrorMessage = "Please enter Product Description")]
        [Display(Name = "Product Description")]
        [StringLength(100, ErrorMessage = "Status could not be greater than 100 characters")]
        public virtual String ProductDescription { get; set; }

        [Required(ErrorMessage = "Please enter Unit Price for this product")]
        [Display(Name = "Price")]
        [DataType(DataType.Currency)]
        public virtual Decimal UnitPrice { get; set; }
        
        [Display(Name = "Image")]
        [Required(ErrorMessage = "Please enter Image URL")]
        public string ProductURL { get; set; }

        [Required(ErrorMessage = "Please select Category")]
        public virtual int CategoryId { get; set; }
        public virtual Category Cat { get; set; }

        [Required(ErrorMessage = "Please select Supplier")]
        public virtual int SupplierId { get; set; }
        public virtual Supplier Sup { get; set; }

        public virtual ItemSize size { get; set; }

        public virtual int ItemColorId { get; set; }
        public virtual ItemColor color { get; set; }

        public virtual List<ItemReview> ItemReviews { get; set; }

		public virtual List<CartItem> ShoppingCartItems { get; set; }

    }
}
