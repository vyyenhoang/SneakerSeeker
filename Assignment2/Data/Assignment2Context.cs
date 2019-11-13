using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Assignment2.Models;

namespace Assignment2.Models
{
    public class Assignment2Context : DbContext
    {
        public Assignment2Context (DbContextOptions<Assignment2Context> options)
            : base(options)
        {
        }

        public DbSet<Assignment2.Models.Products> Products { get; set; }

        public DbSet<Assignment2.Models.Suppliers> Suppliers { get; set; }

        public DbSet<Assignment2.Models.Category> Category { get; set; }

        public DbSet<Assignment2.Models.OrderDetails> OrderDetails { get; set; }

        public DbSet<Assignment2.Models.Orders> Orders { get; set; }

        public DbSet<Assignment2.Models.Customers> Customers { get; set; }

        public DbSet<Assignment2.Models.Payment> Payment { get; set; }
    }
}
