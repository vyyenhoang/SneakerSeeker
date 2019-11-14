using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Assignment2.Models;

namespace Assignment2.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Assignment2.Models.Suppliers> Suppliers { get; set; }
        public DbSet<Assignment2.Models.Products> Products { get; set; }
        public DbSet<Assignment2.Models.Payment> Payment { get; set; }
        public DbSet<Assignment2.Models.OrderStatus> OrderStatus { get; set; }
        public DbSet<Assignment2.Models.Orders> Orders { get; set; }
        public DbSet<Assignment2.Models.OrderDetails> OrderDetails { get; set; }
        public DbSet<Assignment2.Models.Customers> Customers { get; set; }
        public DbSet<Assignment2.Models.Category> Category { get; set; }
    }
}
