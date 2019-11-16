using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SneakerSeeker3.Models
{
    public class ItemReview
    {
        [Key]
        public int ItemReviewId { get; set; }
        public virtual String Comments { get; set; }
        public virtual int Rate { get; set; }


        
        public virtual Product Pro { get; set; }
    }
}
