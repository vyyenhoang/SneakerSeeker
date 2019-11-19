using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SneakerSeeker3.Models;

namespace SneakerSeeker3.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<SneakerSeeker3.Models.Product> Product { get; set; }
        public DbSet<SneakerSeeker3.Models.Category> Category { get; set; }
        public DbSet<SneakerSeeker3.Models.Supplier> Supplier { get; set; }
        public DbSet<SneakerSeeker3.Models.ItemColor> ItemColor { get; set; }
        public DbSet<SneakerSeeker3.Models.ItemSize> ItemSize { get; set; }
        public DbSet<SneakerSeeker3.Models.ItemReview> ItemReview { get; set; }
		public DbSet<SneakerSeeker3.Models.CartItem> CartItems { get; set; }
	}
}
