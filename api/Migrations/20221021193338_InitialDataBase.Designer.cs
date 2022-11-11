﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using api;

#nullable disable

namespace api.Migrations
{
    [DbContext(typeof(ContextDb))]
    [Migration("20221021193338_InitialDataBase")]
    partial class InitialDataBase
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("api.Customer", b =>
                {
                    b.Property<int>("CustomerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CustomerId"), 1L, 1);

                    b.Property<string>("CustomerName")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("CustomerId");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("api.OrderDetail", b =>
                {
                    b.Property<int>("OrderDEtailId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("OrderDEtailId"), 1L, 1);

                    b.Property<int>("OrderMasterId")
                        .HasColumnType("int");

                    b.Property<int>("ProductItemID")
                        .HasColumnType("int");

                    b.Property<decimal>("ProductItemPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("OrderDEtailId");

                    b.HasIndex("OrderMasterId");

                    b.HasIndex("ProductItemID");

                    b.ToTable("OrderDetails");
                });

            modelBuilder.Entity("api.OrderMaster", b =>
                {
                    b.Property<int>("OrderMasterId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("OrderMasterId"), 1L, 1);

                    b.Property<int>("CustomerId")
                        .HasColumnType("int");

                    b.Property<decimal>("GTotal")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("OrderNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(75)");

                    b.Property<string>("PMethod")
                        .IsRequired()
                        .HasColumnType("nvarchar(75)");

                    b.HasKey("OrderMasterId");

                    b.HasIndex("CustomerId");

                    b.ToTable("OrderMasters");
                });

            modelBuilder.Entity("api.ProductItem", b =>
                {
                    b.Property<int>("ProductItemId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProductItemId"), 1L, 1);

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(10,2)");

                    b.Property<string>("ProductItemName")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("ProductItemId");

                    b.ToTable("ProductItems");
                });

            modelBuilder.Entity("api.OrderDetail", b =>
                {
                    b.HasOne("api.OrderMaster", "OrderMaster")
                        .WithMany("OrderDetails")
                        .HasForeignKey("OrderMasterId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("api.ProductItem", "ProductItem")
                        .WithMany()
                        .HasForeignKey("ProductItemID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("OrderMaster");

                    b.Navigation("ProductItem");
                });

            modelBuilder.Entity("api.OrderMaster", b =>
                {
                    b.HasOne("api.Customer", "Customer")
                        .WithMany()
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");
                });

            modelBuilder.Entity("api.OrderMaster", b =>
                {
                    b.Navigation("OrderDetails");
                });
#pragma warning restore 612, 618
        }
    }
}
