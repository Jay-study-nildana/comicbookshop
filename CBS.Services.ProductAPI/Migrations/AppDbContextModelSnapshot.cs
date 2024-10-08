﻿// <auto-generated />
using CBS.Services.ProductAPI.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CBS.Services.ProductAPI.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("CBS.Services.ProductAPI.Models.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProductId"));

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageLocalPath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.HasKey("ProductId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            ProductId = 1,
                            CategoryName = "BatmanComics",
                            Description = "Gotham City is infected by a crime epidemic and all of Batman's enemies have emerged to throw his life into utter chaos. But little do they know, they're all pawns of the villainous Hush in an elaborate game of revenge against Bruce Wayne. Pushed past his breaking point, Batman will need to use more than the world's greatest detective skills to uncover the true identity of this mysterious mastermind before it's too late.",
                            ImageUrl = "https://m.media-amazon.com/images/I/91TffnqrdeL._SL1500_.jpg",
                            Name = "Batman:Hush",
                            Price = 15.0
                        },
                        new
                        {
                            ProductId = 2,
                            CategoryName = "BatmanComics",
                            Description = "Working with District Attorney Harvey Dent and Lieutenant James Gordon, Batman races against the calendar as he tries to discover who Holiday is before he claims his next victim each month. A mystery that has the reader continually guessing the identity of the killer, this story also ties into the events that transform Harvey Dent into Batman's deadly enemy, Two-Face.",
                            ImageUrl = "https://m.media-amazon.com/images/I/81oxI3fwvlL._SL1500_.jpg",
                            Name = "Batman: The Long Halloween",
                            Price = 13.99
                        },
                        new
                        {
                            ProductId = 3,
                            CategoryName = "SupermanComics",
                            Description = "ADVENTURES OF SUPERMAN! Topsy-turvy madness on the backwards Bizarro planet. A bottled city that proves you can never go home again. A living sun hell-bent on destroying humanity. A world without the Man of Steel. Twelve impossible labors and mere moments to save the Earth.",
                            ImageUrl = "https://m.media-amazon.com/images/I/81IlLHwDXuL._SL1500_.jpg",
                            Name = "All-Star Superman",
                            Price = 10.99
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
