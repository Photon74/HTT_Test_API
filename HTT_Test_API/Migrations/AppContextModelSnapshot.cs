﻿// <auto-generated />
using HTT_Test_API;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace HTT_Test_API.Migrations
{
    [DbContext(typeof(AppContext))]
    partial class AppContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("HTT_Test_API.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Фрукты"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Овощи"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Мясо"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Алкоголь"
                        });
                });

            modelBuilder.Entity("HTT_Test_API.Models.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProductId"));

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ProductId");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            ProductId = 1,
                            CategoryId = 1,
                            ProductName = "Клубника"
                        },
                        new
                        {
                            ProductId = 2,
                            CategoryId = 1,
                            ProductName = "Вишня"
                        },
                        new
                        {
                            ProductId = 3,
                            CategoryId = 1,
                            ProductName = "Крыжовник"
                        },
                        new
                        {
                            ProductId = 4,
                            CategoryId = 2,
                            ProductName = "Помидоры"
                        },
                        new
                        {
                            ProductId = 5,
                            CategoryId = 2,
                            ProductName = "Огурцы"
                        },
                        new
                        {
                            ProductId = 6,
                            CategoryId = 2,
                            ProductName = "Лук"
                        },
                        new
                        {
                            ProductId = 7,
                            CategoryId = 3,
                            ProductName = "Свинина"
                        },
                        new
                        {
                            ProductId = 8,
                            CategoryId = 3,
                            ProductName = "Говядина"
                        },
                        new
                        {
                            ProductId = 9,
                            CategoryId = 3,
                            ProductName = "Курица"
                        },
                        new
                        {
                            ProductId = 10,
                            CategoryId = 4,
                            ProductName = "Пиво"
                        },
                        new
                        {
                            ProductId = 11,
                            CategoryId = 4,
                            ProductName = "Водка"
                        },
                        new
                        {
                            ProductId = 12,
                            CategoryId = 4,
                            ProductName = "Коньяк"
                        });
                });

            modelBuilder.Entity("HTT_Test_API.Models.Product", b =>
                {
                    b.HasOne("HTT_Test_API.Models.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("HTT_Test_API.Models.Category", b =>
                {
                    b.Navigation("Products");
                });
#pragma warning restore 612, 618
        }
    }
}
