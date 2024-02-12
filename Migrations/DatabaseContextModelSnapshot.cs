﻿// <auto-generated />
using System;
using Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace MadPlanner.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    partial class DatabaseContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.1");

            modelBuilder.Entity("Models.Ingrediens", b =>
                {
                    b.Property<int>("RetId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("ProduktId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Grams")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Id")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Note")
                        .HasColumnType("TEXT");

                    b.HasKey("RetId", "ProduktId");

                    b.HasIndex("ProduktId");

                    b.ToTable("Ingredienser");
                });

            modelBuilder.Entity("Models.Produkt", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("Butik")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("Calories")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("Grams")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Note")
                        .HasColumnType("TEXT");

                    b.Property<int>("PackingType")
                        .HasColumnType("INTEGER");

                    b.Property<double>("Price")
                        .HasColumnType("REAL");

                    b.HasKey("Id");

                    b.ToTable("Produkter");
                });

            modelBuilder.Entity("Models.Ret", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Category")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<bool>("Leftovers")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<bool>("PorkBased")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("Takeway")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("Vegetarian")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Retter");
                });

            modelBuilder.Entity("Models.Ingrediens", b =>
                {
                    b.HasOne("Models.Produkt", "Produkt")
                        .WithMany("Ingredienser")
                        .HasForeignKey("ProduktId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Models.Ret", "Ret")
                        .WithMany("Ingredienser")
                        .HasForeignKey("RetId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Produkt");

                    b.Navigation("Ret");
                });

            modelBuilder.Entity("Models.Produkt", b =>
                {
                    b.Navigation("Ingredienser");
                });

            modelBuilder.Entity("Models.Ret", b =>
                {
                    b.Navigation("Ingredienser");
                });
#pragma warning restore 612, 618
        }
    }
}
