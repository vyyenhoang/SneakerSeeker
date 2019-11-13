using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment2.Models
{
    public class OrderDetails
    {
        [Key]
        public virtual int OrderDetailId { get; set; } //Primary Key

        //Foreign Key
        public virtual int OrderId { get; set; }
        public virtual Orders Ord { get; set; }

        //Foreign Key
        public virtual int ProductId { get; set; }
        public virtual Products ProductDetails { get; set; }

        public virtual int OrderNumber { get; set; }

        [DataType(DataType.Currency)]
        public virtual int Price { get; set; }

        public virtual int Quantity { get; set; }

        [DataType(DataType.Currency)]
        public virtual int Discount { get; set; }

        public virtual int IDSKU { get; set; }
        public virtual int Size { get; set; }
        public virtual int Color { get; set; }
        public virtual Boolean Fulfilled { get; set; }
        public virtual String ShipDate { get; set; }
        public virtual String BillDate { get; set; }

    }
}
