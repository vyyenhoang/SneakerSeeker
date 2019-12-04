using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
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

		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public virtual int Id { get; set; }


        public virtual SneakerSeekerUser User { get; set; }
        public virtual List<CartItem> CartItems { get; set; }

		
	}
}
