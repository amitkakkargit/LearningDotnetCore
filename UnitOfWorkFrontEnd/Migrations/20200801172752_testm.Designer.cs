﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using UnitOfWork.UOW;

namespace UnitOfWorkFrontEnd.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20200801172752_testm")]
    partial class testm
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("UnitOfWork.Models.Product", b =>
                {
                    b.Property<long>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ProductName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("UserId")
                        .HasColumnType("int");

                    b.HasKey("ProductId");

                    b.HasIndex("UserId");

                    b.ToTable("Product");
                });

            modelBuilder.Entity("UnitOfWork.Models.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId");

                    b.ToTable("User");
                });

            modelBuilder.Entity("UnitOfWork.Models.Product", b =>
                {
                    b.HasOne("UnitOfWork.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId");
                });
#pragma warning restore 612, 618
        }
    }
}
