using SneakerSeeker3.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SneakerSeeker3.Models
{
    public class Cart
    {
		//private readonly ApplicationDbContext _context;
		
		//private Cart (ApplicationDbContext context)
		//{
		//	_context = context;
		//}

		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public virtual int Id { get; set; }


        public virtual SneakerSeekerUser Cust { get; set; }
        public virtual List<CartItem> CartItems { get; set; }

		//public static Cart GetCart(IServiceProvider services)
		//{
		//	ISession session = services.GetRequiredService<IHttpContextAccessor>()?.HttpContext.Session;

		//	var context = services.Get
		//}
    }
}
