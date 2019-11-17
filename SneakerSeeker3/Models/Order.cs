using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SneakerSeeker3.Models
{
	public class Order

	{



		public Order() { }
		public Order(DateTime OrderDate)
		{
			this.OrderDate = OrderDate;


		}



		[Key]
		public virtual int OrderId { get; set; } //Primary Key


		public virtual DateTime OrderDate { get; set; }


		public virtual Cart cart { get; set; }

		public virtual int StatusId { get; set; }
		public virtual OrderStatus Stat { get; set; }

		public virtual int PaymentId { get; set; }
		public virtual Payment Pay { get; set; }



	}


}

