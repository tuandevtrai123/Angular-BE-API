﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ptj_server.DatabaseContext;

#nullable disable

namespace ptj_server.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20230718164021_ProductPriceConfiguration")]
    partial class ProductPriceConfiguration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ptj_server.Models.Customer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .HasMaxLength(80)
                        .HasColumnType("nvarchar(80)")
                        .HasColumnName("ADDRESS");

                    b.Property<string>("Avatar")
                        .HasMaxLength(12)
                        .IsUnicode(false)
                        .HasColumnType("char(12)")
                        .HasColumnName("AVATAR")
                        .IsFixedLength();

                    b.Property<int?>("CustomerTypeId")
                        .HasColumnType("int")
                        .HasColumnName("CUSTOMER_TYPE_ID");

                    b.Property<DateTime?>("Dob")
                        .HasColumnType("date")
                        .HasColumnName("DOB");

                    b.Property<string>("Fullname")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("FULLNAME");

                    b.Property<string>("IdCard")
                        .HasMaxLength(12)
                        .IsUnicode(false)
                        .HasColumnType("char(12)")
                        .HasColumnName("ID_CARD")
                        .IsFixedLength();

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(255)
                        .IsUnicode(false)
                        .HasColumnType("varchar(255)")
                        .HasColumnName("PASSWORD");

                    b.Property<string>("Phone")
                        .HasMaxLength(12)
                        .IsUnicode(false)
                        .HasColumnType("char(12)")
                        .HasColumnName("PHONE")
                        .IsFixedLength();

                    b.Property<int?>("ScorePay")
                        .HasColumnType("int")
                        .HasColumnName("SCORE_PAY");

                    b.Property<string>("Username")
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)")
                        .HasColumnName("USERNAME");

                    b.HasKey("Id")
                        .HasName("PK_CUSTOMER");

                    b.HasIndex("CustomerTypeId");

                    b.ToTable("CUSTOMERS", (string)null);
                });

            modelBuilder.Entity("ptj_server.Models.CustomerType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CustomerTypeName")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)")
                        .HasColumnName("CUSTOMER_TYPE_NAME");

                    b.Property<string>("DiscountUnit")
                        .IsRequired()
                        .HasMaxLength(5)
                        .IsUnicode(false)
                        .HasColumnType("char(5)")
                        .HasColumnName("DISCOUNT_UNIT")
                        .IsFixedLength();

                    b.Property<int?>("DiscountValue")
                        .HasColumnType("int")
                        .HasColumnName("DISCOUNT_VALUE");

                    b.HasKey("Id")
                        .HasName("PK_CUSTOMER_TYPE");

                    b.ToTable("CUSTOMER_TYPES", (string)null);
                });

            modelBuilder.Entity("ptj_server.Models.Geomancy", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("DESCRIPTION");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)")
                        .HasColumnName("NAME");

                    b.HasKey("Id")
                        .HasName("PK_GEOMANCY");

                    b.ToTable("GEOMANCIES", (string)null);
                });

            modelBuilder.Entity("ptj_server.Models.ProductPrice", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("BasePrice")
                        .HasColumnType("int")
                        .HasColumnName("BASE_PRICE");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("date")
                        .HasColumnName("CREATED_DATE");

                    b.Property<bool?>("InActive")
                        .HasColumnType("bit")
                        .HasColumnName("IN_ACTIVE");

                    b.Property<int>("SalePrice")
                        .HasColumnType("int")
                        .HasColumnName("SALE_PRICE");

                    b.HasKey("Id")
                        .HasName("PK_PRODUCT_PRICE");

                    b.ToTable("PRODUCT_PRICES", (string)null);
                });

            modelBuilder.Entity("ptj_server.Models.Role", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)")
                        .HasColumnName("NAME");

                    b.HasKey("Id")
                        .HasName("PK_ROLE");

                    b.ToTable("ROLES", (string)null);
                });

            modelBuilder.Entity("ptj_server.Models.StoneType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)")
                        .HasColumnName("NAME");

                    b.HasKey("Id")
                        .HasName("PK_STONE_TYPE");

                    b.ToTable("STONE_TYPES", (string)null);
                });

            modelBuilder.Entity("ptj_server.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("Dob")
                        .HasColumnType("date")
                        .HasColumnName("DOB");

                    b.Property<string>("Fullname")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("FULLNAME");

                    b.Property<string>("IdCard")
                        .HasMaxLength(12)
                        .IsUnicode(false)
                        .HasColumnType("char(12)")
                        .HasColumnName("ID_CARD")
                        .IsFixedLength();

                    b.Property<int?>("IdRole")
                        .HasColumnType("int");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(255)
                        .IsUnicode(false)
                        .HasColumnType("varchar(255)")
                        .HasColumnName("PASSWORD");

                    b.Property<string>("Phone")
                        .HasMaxLength(12)
                        .IsUnicode(false)
                        .HasColumnType("varchar(12)")
                        .HasColumnName("PHONE");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)")
                        .HasColumnName("USERNAME");

                    b.HasKey("Id")
                        .HasName("PK_USER");

                    b.HasIndex("IdRole");

                    b.ToTable("USERS", (string)null);
                });

            modelBuilder.Entity("ptj_server.Models.Customer", b =>
                {
                    b.HasOne("ptj_server.Models.CustomerType", "CustomerType")
                        .WithMany("Customers")
                        .HasForeignKey("CustomerTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK_CUSTOMER_TYPE");

                    b.Navigation("CustomerType");
                });

            modelBuilder.Entity("ptj_server.Models.User", b =>
                {
                    b.HasOne("ptj_server.Models.Role", "Role")
                        .WithMany("Users")
                        .HasForeignKey("IdRole")
                        .HasConstraintName("FK_USERS_ROLE");

                    b.Navigation("Role");
                });

            modelBuilder.Entity("ptj_server.Models.CustomerType", b =>
                {
                    b.Navigation("Customers");
                });

            modelBuilder.Entity("ptj_server.Models.Role", b =>
                {
                    b.Navigation("Users");
                });
#pragma warning restore 612, 618
        }
    }
}
