using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SneakerSeeker3.Models
{
    public class SneakerSeekerUser : IdentityUser
    {
        public SneakerSeekerUser() : base() { }
        public SneakerSeekerUser(String FirstName, String LastName)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
        }
        public virtual String FirstName { get; set; }
        public virtual String LastName { get; set; }
        public virtual List<Order> Orders { get; set; }
        public virtual List<Payment> Payment { get; set; }

    }

}

