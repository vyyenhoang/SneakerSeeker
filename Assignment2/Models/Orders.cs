﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment2.Models
{
    public class Orders

    {



        public Orders() { }
        public Orders(DateTime OrderDate)
        {
            this.OrderDate = OrderDate;


        }



        [Key]
        public virtual int OrderId { get; set; } //Primary Key

        [ForeignKey("CustmerId")]
        [Display(Name = "Customer Name")]
        public virtual Customers FirstName { get; set; }


        [ForeignKey("PaymentId")]
        [Display(Name = "Payment Type")]
        public virtual Payment PaymentType { get; set; }



        [ForeignKey("StatusId")]
        [Display(Name = "Order Status")]
        public virtual OrderStatus Status { get; set; }


        public virtual DateTime OrderDate { get; set; }




        public virtual List<Payment> Payments { get; set; }


        public virtual List<OrderStatus> OrderStatuses { get; set; }

    }
}
