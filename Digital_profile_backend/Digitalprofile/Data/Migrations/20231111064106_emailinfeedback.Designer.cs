﻿// <auto-generated />
using Digitalprofile.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Digitalprofile.Data.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20231111064106_emailinfeedback")]
    partial class emailinfeedback
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.13");

            modelBuilder.Entity("Digitalprofile.Data.Feedback", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Email")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<string>("comment")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("UserFeedback");
                });
#pragma warning restore 612, 618
        }
    }
}
