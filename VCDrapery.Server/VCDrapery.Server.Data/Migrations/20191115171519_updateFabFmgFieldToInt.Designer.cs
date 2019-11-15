﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using VCDrapery.Server.Data;

namespace VCDrapery.Server.Data.Migrations
{
    [DbContext(typeof(DraperyContext))]
    [Migration("20191115171519_updateFabFmgFieldToInt")]
    partial class updateFabFmgFieldToInt
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("VCDrapery.Server.Data.Models.Customers", b =>
                {
                    b.Property<int>("CustomerId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address");

                    b.Property<string>("City");

                    b.Property<DateTime>("DateAdded");

                    b.Property<DateTime>("DateUpdated");

                    b.Property<string>("Name");

                    b.Property<string>("State");

                    b.Property<int>("Zip");

                    b.HasKey("CustomerId");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("VCDrapery.Server.Data.Models.Quote", b =>
                {
                    b.Property<int>("QuoteId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CustomerId");

                    b.Property<DateTime>("DateAdded");

                    b.Property<decimal?>("DiscountDollarAmount");

                    b.Property<decimal?>("DiscountPercentAmount");

                    b.Property<decimal>("QuotePrice");

                    b.HasKey("QuoteId");

                    b.HasIndex("CustomerId");

                    b.ToTable("Quotes");
                });

            modelBuilder.Entity("VCDrapery.Server.Data.Models.QuoteLineItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Comments");

                    b.Property<DateTime>("DateAdded");

                    b.Property<string>("FabricColor");

                    b.Property<string>("FabricCurtainType");

                    b.Property<int>("FabricFabFmg");

                    b.Property<int>("FabricFullness");

                    b.Property<int>("FabricLength");

                    b.Property<decimal>("FabricPrice");

                    b.Property<string>("FabricType");

                    b.Property<decimal>("LaborPrice");

                    b.Property<decimal>("Price");

                    b.Property<decimal>("PriceBeforeTax");

                    b.Property<int>("QuoteId");

                    b.Property<int>("Return");

                    b.Property<decimal>("RodPrice");

                    b.Property<int>("RodSize");

                    b.Property<string>("RodType");

                    b.Property<string>("Room");

                    b.Property<decimal>("Tax");

                    b.Property<int>("Widths");

                    b.Property<int>("WidthsLab");

                    b.Property<int>("Yards");

                    b.HasKey("Id");

                    b.HasIndex("QuoteId");

                    b.ToTable("QuoteLineItems");
                });

            modelBuilder.Entity("VCDrapery.Server.Data.Models.Quote", b =>
                {
                    b.HasOne("VCDrapery.Server.Data.Models.Customers", "Customer")
                        .WithMany("Quotes")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("VCDrapery.Server.Data.Models.QuoteLineItem", b =>
                {
                    b.HasOne("VCDrapery.Server.Data.Models.Quote", "Quote")
                        .WithMany("LineItems")
                        .HasForeignKey("QuoteId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
