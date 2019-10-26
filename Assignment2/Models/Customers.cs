using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment2.Models
{
    public class Customers
    {
        [Key]
        public virtual int CustomerId { get; set; } //Primary Key

        public virtual String FirstName { get; set; }
        public virtual String LastName { get; set; }
        public virtual String Class { get; set; }
        public virtual String Room { get; set; }
        public virtual String Building { get; set; }
        public virtual String Address1 { get; set; }
        public virtual String Address2 { get; set; }
        public virtual String City { get; set; }
        public virtual String State { get; set; }
        public virtual String PostalCode { get; set; }
        public virtual String Phone { get; set; }
        public virtual String Email { get; set; }
        public virtual String VoiceMail { get; set; }
        public virtual String Password { get; set; }
        public virtual String CreditCard { get; set; }
        public virtual String CreditCardTypeId { get; set; }
        public virtual String CardExpMo { get; set; }
        public virtual String CardExpYr { get; set; }
        public virtual String BillingAddress { get; set; }
        public virtual String BillingCity { get; set; }
        public virtual String BillingRegion { get; set; }
        public virtual String BillingPostalCode { get; set; }
        public virtual String BillingCountry { get; set; }
        public virtual String ShipAddress { get; set; }
        public virtual String ShipCity { get; set; }
        public virtual String ShipRegion { get; set; }
        public virtual String ShipPostalCode { get; set; }
        public virtual String ShipCountry { get; set; }
        public virtual String DateEntered { get; set; }
    }
}
