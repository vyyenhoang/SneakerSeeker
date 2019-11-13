using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment2.Models
{
	public class Payment
	{
		[Key]
		public virtual int PaymentId { get; set; } //Primary Key

		[Required]
		public virtual String PaymentType { get; set; }

	}
}
