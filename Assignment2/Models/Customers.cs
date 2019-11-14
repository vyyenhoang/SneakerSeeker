using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment2.Models
{
	public class Customers
	{
		public Customers() { }
		public Customers(int CustomerId, String FirstName, String LastName, String Address,
String City, String State, String PostalCode, String Phone, String Email,
DateTime DateEntered)
		{
			this.CustomerId = CustomerId;
			this.FirstName = FirstName;
			this.LastName = LastName;
			this.Address = Address;
			this.City = City;
			this.State = State;
			this.PostalCode = PostalCode;
			this.Phone = Phone;
			this.Email = Email;
			this.DateEntered = DateEntered;

		}


		[Key]
		public virtual int CustomerId { get; set; } //Primary Key
		public virtual String FirstName { get; set; }
		public virtual String LastName { get; set; }
		public virtual String Address { get; set; }
		public virtual String City { get; set; }
		public virtual String State { get; set; }
		public virtual String PostalCode { get; set; }
		public virtual String Phone { get; set; }
		public virtual String Email { get; set; }
		public virtual DateTime DateEntered { get; set; }


        public virtual List<Orders> Orders { get; set; }


    }

}

