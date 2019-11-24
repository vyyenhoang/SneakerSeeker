using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SneakerSeeker3.Models
{
    public class Payment
    {

        public Payment() { }
        public Payment(int SupplierId, String CompanyName, String URL, String Logo)
        {
            this.PaymentId = PaymentId;
            this.PaymentType = PaymentType;
            

        }

        [Key]
        public virtual int PaymentId { get; set; } //Primary Key

        [Required]
        public virtual String PaymentType { get; set; }

       
        public virtual SneakerSeekerUser Cust { get; set; }

        public virtual List<Order> Ord { get; set; }

        
    }
}
