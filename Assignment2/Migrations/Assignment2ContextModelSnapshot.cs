﻿// <auto-generated />
using Assignment2.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Assignment2.Migrations
{
    [DbContext(typeof(Assignment2Context))]
    partial class Assignment2ContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.11-servicing-32099")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Assignment2.Models.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Active");

                    b.Property<string>("Description")
                        .IsRequired();

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<string>("Picture");

                    b.HasKey("CategoryId");

                    b.ToTable("Category");
                });

            modelBuilder.Entity("Assignment2.Models.Customers", b =>
                {
                    b.Property<int>("CustomerId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address1");

                    b.Property<string>("Address2");

                    b.Property<string>("BillingAddress");

                    b.Property<string>("BillingCity");

                    b.Property<string>("BillingCountry");

                    b.Property<string>("BillingPostalCode");

                    b.Property<string>("BillingRegion");

                    b.Property<string>("Building");

                    b.Property<string>("CardExpMo");

                    b.Property<string>("CardExpYr");

                    b.Property<string>("City");

                    b.Property<string>("Class");

                    b.Property<string>("CreditCard");

                    b.Property<string>("CreditCardTypeId");

                    b.Property<string>("DateEntered");

                    b.Property<string>("Email");

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.Property<string>("Password");

                    b.Property<string>("Phone");

                    b.Property<string>("PostalCode");

                    b.Property<string>("Room");

                    b.Property<string>("ShipAddress");

                    b.Property<string>("ShipCity");

                    b.Property<string>("ShipCountry");

                    b.Property<string>("ShipPostalCode");

                    b.Property<string>("ShipRegion");

                    b.Property<string>("State");

                    b.Property<string>("VoiceMail");

                    b.HasKey("CustomerId");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("Assignment2.Models.OrderDetails", b =>
                {
                    b.Property<int>("OrderDetailId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BillDate");

                    b.Property<int>("Color");

                    b.Property<int>("Discount");

                    b.Property<bool>("Fulfilled");

                    b.Property<int>("IDSKU");

                    b.Property<int>("OrderId");

                    b.Property<int>("OrderNumber");

                    b.Property<int>("Price");

                    b.Property<int>("ProductId");

                    b.Property<int>("Quantity");

                    b.Property<string>("ShipDate");

                    b.Property<int>("Size");

                    b.HasKey("OrderDetailId");

                    b.HasIndex("OrderId");

                    b.HasIndex("ProductId");

                    b.ToTable("OrderDetails");
                });

            modelBuilder.Entity("Assignment2.Models.Orders", b =>
                {
                    b.Property<int>("OrderId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CustomerId");

                    b.Property<bool>("Deleted");

                    b.Property<string>("ErrLock");

                    b.Property<string>("ErrMsg");

                    b.Property<string>("Freight");

                    b.Property<bool>("Fulfilled");

                    b.Property<int>("OrderDate");

                    b.Property<int>("OrderNumber");

                    b.Property<bool>("Paid");

                    b.Property<string>("PaymentDate");

                    b.Property<string>("RequiredDate");

                    b.Property<int>("SalesTax");

                    b.Property<string>("ShipDate");

                    b.Property<string>("Timestamp");

                    b.Property<string>("TransactStatus");

                    b.HasKey("OrderId");

                    b.HasIndex("CustomerId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("Assignment2.Models.Products", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AvailableColor");

                    b.Property<int>("AvailableSize");

                    b.Property<int>("CategoryId");

                    b.Property<string>("Color");

                    b.Property<int>("CurrentOrder");

                    b.Property<int>("Discount");

                    b.Property<bool>("DiscountAvailable");

                    b.Property<int>("IDSKU");

                    b.Property<decimal>("MSRP");

                    b.Property<string>("Note");

                    b.Property<string>("Picture");

                    b.Property<bool>("ProductAvailable");

                    b.Property<string>("ProductDescription");

                    b.Property<string>("ProductName")
                        .IsRequired();

                    b.Property<int>("QuantityPerUnit");

                    b.Property<int>("Ranking");

                    b.Property<int>("ReorderLevel");

                    b.Property<int>("SKU");

                    b.Property<float>("Size");

                    b.Property<int>("SupplierId");

                    b.Property<decimal>("UnitPrice");

                    b.Property<int>("UnitWeight");

                    b.Property<int>("UnitsInStock");

                    b.Property<int>("UnitsOnOrder");

                    b.HasKey("ProductId");

                    b.HasIndex("CategoryId");

                    b.HasIndex("SupplierId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("Assignment2.Models.Suppliers", b =>
                {
                    b.Property<int>("SupplierId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address1");

                    b.Property<string>("Address2");

                    b.Property<string>("City");

                    b.Property<string>("CompanyName")
                        .IsRequired();

                    b.Property<string>("ContactFName");

                    b.Property<string>("ContactLName");

                    b.Property<string>("ContactTitle");

                    b.Property<string>("Country");

                    b.Property<string>("CurrentOrder");

                    b.Property<int>("CustomerId");

                    b.Property<bool>("DiscountAvailable");

                    b.Property<string>("DiscountType");

                    b.Property<string>("Email");

                    b.Property<string>("Fax");

                    b.Property<string>("Logo");

                    b.Property<string>("Notes");

                    b.Property<string>("PaymentMethods");

                    b.Property<string>("Phone");

                    b.Property<string>("PostalCode");

                    b.Property<string>("SizeURL");

                    b.Property<string>("State");

                    b.Property<string>("TypeGoods");

                    b.Property<string>("URL");

                    b.HasKey("SupplierId");

                    b.HasIndex("CustomerId");

                    b.ToTable("Suppliers");
                });

            modelBuilder.Entity("Assignment2.Models.OrderDetails", b =>
                {
                    b.HasOne("Assignment2.Models.Orders", "Ord")
                        .WithMany()
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Assignment2.Models.Products", "ProductDetails")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Assignment2.Models.Orders", b =>
                {
                    b.HasOne("Assignment2.Models.Customers", "Cust")
                        .WithMany()
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Assignment2.Models.Products", b =>
                {
                    b.HasOne("Assignment2.Models.Category", "ProductCategory")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Assignment2.Models.Suppliers", "Supp")
                        .WithMany()
                        .HasForeignKey("SupplierId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Assignment2.Models.Suppliers", b =>
                {
                    b.HasOne("Assignment2.Models.Customers", "Cust")
                        .WithMany()
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
