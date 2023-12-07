﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace RatingWeb.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20231207073836_db")]
    partial class db
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.14")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("RatingWeb.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Music"
                        },
                        new
                        {
                            Id = 2,
                            Name = "SciFi"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Era"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Action"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Modern"
                        },
                        new
                        {
                            Id = 6,
                            Name = "Digital"
                        },
                        new
                        {
                            Id = 7,
                            Name = "Cartoon"
                        },
                        new
                        {
                            Id = 8,
                            Name = "CdS"
                        },
                        new
                        {
                            Id = 9,
                            Name = "Anime"
                        });
                });

            modelBuilder.Entity("RatingWeb.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<int>("Rating")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 1,
                            Name = "NFT1",
                            Price = 100.0,
                            Rating = 1
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 2,
                            Name = "NFT2",
                            Price = 3000.0,
                            Rating = 4
                        },
                        new
                        {
                            Id = 3,
                            CategoryId = 3,
                            Name = "NFT3",
                            Price = 890.0,
                            Rating = 5
                        },
                        new
                        {
                            Id = 4,
                            CategoryId = 5,
                            Name = "NFT4",
                            Price = 100.0,
                            Rating = 5
                        },
                        new
                        {
                            Id = 5,
                            CategoryId = 6,
                            Name = "NFT5",
                            Price = 3000.0,
                            Rating = 4
                        },
                        new
                        {
                            Id = 6,
                            CategoryId = 8,
                            Name = "NFT6",
                            Price = 890.0,
                            Rating = 5
                        });
                });

            modelBuilder.Entity("RatingWeb.Models.Rating", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("Stars")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.ToTable("Ratings");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ProductId = 1,
                            Stars = 3
                        },
                        new
                        {
                            Id = 2,
                            ProductId = 2,
                            Stars = 5
                        },
                        new
                        {
                            Id = 3,
                            ProductId = 3,
                            Stars = 3
                        },
                        new
                        {
                            Id = 4,
                            ProductId = 4,
                            Stars = 3
                        },
                        new
                        {
                            Id = 5,
                            ProductId = 5,
                            Stars = 5
                        },
                        new
                        {
                            Id = 6,
                            ProductId = 6,
                            Stars = 4
                        });
                });

            modelBuilder.Entity("RatingWeb.Models.Product", b =>
                {
                    b.HasOne("RatingWeb.Models.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("RatingWeb.Models.Rating", b =>
                {
                    b.HasOne("RatingWeb.Models.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");
                });
#pragma warning restore 612, 618
        }
    }
}