using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment2.Models
{
    public class Orders
    {
        [Key]
        public virtual int OrderId { get; set; } //Primary Key

        //Foreign Key
        public virtual int CustomerId { get; set; }
        public virtual Customers Cust { get; set; }
        //Foreign Key
        //public virtual int ProductId { get; set; }
        //public virtual Products Prod { get; set; } 

        public virtual int OrderNumber { get; set; }
        public virtual int OrderDate { get; set; }
        public virtual String ShipDate { get; set; }
        public virtual String RequiredDate { get; set; }

        public virtual String Freight { get; set; }

        [DataType(DataType.Currency)]
        public virtual int SalesTax { get; set; }

        public virtual String Timestamp { get; set; }
        public virtual String TransactStatus { get; set; }
        public virtual String ErrLock { get; set; }
        public virtual String ErrMsg { get; set; }

        public virtual Boolean Fulfilled { get; set; }
        public virtual Boolean Deleted { get; set; }
        public virtual Boolean Paid { get; set; }
        public virtual String PaymentDate { get; set; }

    }
}
