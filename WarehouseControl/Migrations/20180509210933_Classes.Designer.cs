﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;
using WarehouseControl.Models;

namespace WarehouseControl.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20180509210933_Classes")]
    partial class Classes
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.2-rtm-10011")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WarehouseControl.Models.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("BarCode");

                    b.Property<string>("Category");

                    b.Property<string>("Code");

                    b.Property<int>("Height");

                    b.Property<int>("Length");

                    b.Property<string>("Measure");

                    b.Property<string>("Name");

                    b.Property<int>("TradeSurcharge");

                    b.Property<int>("VAT");

                    b.Property<int>("Weight");

                    b.Property<int>("Width");

                    b.HasKey("ProductId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("WarehouseControl.Models.Purchase", b =>
                {
                    b.Property<int>("PurchaseId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Amount");

                    b.Property<string>("Contract");

                    b.Property<int?>("ProductId");

                    b.Property<int?>("ShopId");

                    b.Property<int?>("SupplierId");

                    b.Property<DateTime>("SupplyDate");

                    b.HasKey("PurchaseId");

                    b.HasIndex("ProductId");

                    b.HasIndex("ShopId");

                    b.HasIndex("SupplierId");

                    b.ToTable("Purchases");
                });

            modelBuilder.Entity("WarehouseControl.Models.Shop", b =>
                {
                    b.Property<int>("ShopId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Address");

                    b.Property<string>("Code");

                    b.Property<string>("Name");

                    b.HasKey("ShopId");

                    b.ToTable("Shops");
                });

            modelBuilder.Entity("WarehouseControl.Models.Supplier", b =>
                {
                    b.Property<int>("SupplierId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Account");

                    b.Property<string>("Address");

                    b.Property<string>("Contract");

                    b.Property<string>("Name");

                    b.Property<string>("PriceAgreement");

                    b.HasKey("SupplierId");

                    b.ToTable("Suppliers");
                });

            modelBuilder.Entity("WarehouseControl.Models.Purchase", b =>
                {
                    b.HasOne("WarehouseControl.Models.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId");

                    b.HasOne("WarehouseControl.Models.Shop", "Shop")
                        .WithMany()
                        .HasForeignKey("ShopId");

                    b.HasOne("WarehouseControl.Models.Supplier", "Supplier")
                        .WithMany()
                        .HasForeignKey("SupplierId");
                });
#pragma warning restore 612, 618
        }
    }
}
