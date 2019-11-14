using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment2.Models
{
    public class OrderDetails
    {
		public OrderDetails() { }
		public OrderDetails(int OrderDetailId, Orders OrderId, 
		Products ProductDetails, int OrderNumber, decimal Price, int Quantity,
			String Color, Boolean Fulfilled, DateTime ShipDate, DateTime BillDate)
		{
			this.OrderDetailId = OrderDetailId;
			this.OrderDate = OrderDate;
			this.ProductDetails = ProductDetails;
			this.OrderNumber = OrderNumber;
			this.Price = Price;
			this.Quantity = Quantity;
			this.Color = Color;
			this.Fulfilled = Fulfilled;
			this.ShipDate = ShipDate;
			this.BillDate = BillDate;
		}


		[Key]
        public virtual int OrderDetailId { get; set; } //Primary Key

		[ForeignKey("OrderId")]
		[Display(Name = "Order Name")]
        public virtual Orders OrderDate { get; set; }

		[ForeignKey("ProductId")]
		[Display(Name = "Product Name")]
        public virtual Products ProductDetails { get; set; }

        public virtual int OrderNumber { get; set; }

        [DataType(DataType.Currency)]
        public virtual decimal Price { get; set; }
        public virtual int Quantity { get; set; }
        public virtual int IDSKU { get; set; }
        public virtual decimal Size { get; set; }
        public virtual String Color { get; set; }
        public virtual Boolean Fulfilled { get; set; }
        public virtual DateTime ShipDate { get; set; }
        public virtual DateTime BillDate { get; set; }

    }
}
