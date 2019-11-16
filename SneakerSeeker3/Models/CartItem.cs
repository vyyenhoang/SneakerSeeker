using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SneakerSeeker3.Models
{
    public class CartItem
    {
        
            [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
            [Key]
            public virtual int Id { get; set; }

            public virtual int CartId { get; set; }
            public virtual Cart cart { get; set; }

            public virtual int ProductId { get; set; }
            public virtual Product Pro { get; set; }

            public virtual int Qty { get; set; }
        }
    }
