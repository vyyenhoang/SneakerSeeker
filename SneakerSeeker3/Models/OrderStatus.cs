using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SneakerSeeker3.Models
{
    public class OrderStatus
    {

        public OrderStatus() { }
        public OrderStatus(int StatusId, String Status)
        {
            this.StatusId = StatusId;
            this.Status = Status;

        }

        [Key]
        public virtual int StatusId { get; set; } //Primary Key

        [Required(ErrorMessage = "Please enter Description for Status")]
        [Display(Name = "Status")]
        [StringLength(100, ErrorMessage = "Status could not be greater than 100 characters")]
        public virtual String Status { get; set; }

        public virtual List<Order> Ord { get; set; }

    }
}
