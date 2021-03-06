﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RazorPagesCar.Models;

namespace RazorPagesCar.Migrations
{
    [DbContext(typeof(RazorPagesCarContext))]
    partial class RazorPagesCarContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062");

            modelBuilder.Entity("RazorPagesCar.Models.Car", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Cylinders");

                    b.Property<string>("Make");

                    b.Property<string>("Model");

                    b.Property<int>("NumberOfDoors");

                    b.HasKey("ID");

                    b.ToTable("Car");
                });

            modelBuilder.Entity("RazorPagesCar.Models.Review", b =>
                {
                    b.Property<int>("ReviewID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CarID");

                    b.Property<int>("CustReview");

                    b.Property<string>("CustReviewDesc");

                    b.HasKey("ReviewID");

                    b.HasIndex("CarID");

                    b.ToTable("Review");
                });

            modelBuilder.Entity("RazorPagesCar.Models.Review", b =>
                {
                    b.HasOne("RazorPagesCar.Models.Car", "Car")
                        .WithMany("Reviews")
                        .HasForeignKey("CarID")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
