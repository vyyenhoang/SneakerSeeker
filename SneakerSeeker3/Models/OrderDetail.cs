using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SneakerSeeker3.Models
{
    public class OrderDetail
    {

        public virtual int OrderDetailId { get; set; }
        public virtual int OrderId { get; set; }
        public virtual int ProductId { get; set; }
        public virtual int Quantity { get; set; }
        [Column(TypeName = "decimal(10, 2)")]
        public virtual decimal Price { get; set; }

        [ForeignKey("OrderId")]
        [InverseProperty("OrderDetail")]
        public virtual Order Order { get; set; }
        [ForeignKey("ProductId")]
        [InverseProperty("OrderDetail")]
        public virtual Product Product { get; set; }

    }
}
