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
    [Migration("20230718171408_ProductConfiguration")]
    partial class ProductConfiguration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ptj_server.Models.CategoryProduct", b =>
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

                    b.Property<int?>("ParentId")
                        .HasColumnType("int")
                        .HasColumnName("PARENT_ID");

                    b.HasKey("Id")
                        .HasName("PK_CATEGORY_PRODUCT");

                    b.HasIndex("ParentId");

                    b.ToTable("CATEGORY_PRODUCTS", (string)null);
                });

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

            modelBuilder.Entity("ptj_server.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("Active")
                        .HasColumnType("bit")
                        .HasColumnName("ACTIVE");

                    b.Property<bool>("BestSeller")
                        .HasColumnType("bit")
                        .HasColumnName("BEST_SELLER");

                    b.Property<int?>("CatId")
                        .HasColumnType("int")
                        .HasColumnName("CAT_ID");

                    b.Property<string>("Color")
                        .HasMaxLength(12)
                        .HasColumnType("nvarchar(12)")
                        .HasColumnName("COLOR");

                    b.Property<int?>("GeomancyId")
                        .HasColumnType("int")
                        .HasColumnName("GEOMANCY_ID");

                    b.Property<bool>("HomeFlag")
                        .HasColumnType("bit")
                        .HasColumnName("HOME_FLAG");

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("IMAGE");

                    b.Property<int?>("MainStoneId")
                        .HasColumnType("int")
                        .HasColumnName("MAIN_STONE_ID");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("NAME");

                    b.Property<string>("Note")
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)")
                        .HasColumnName("NOTE");

                    b.Property<int?>("SubStoneId")
                        .HasColumnType("int")
                        .HasColumnName("SUB_STONE_ID");

                    b.HasKey("Id")
                        .HasName("PK_PRODUCT");

                    b.HasIndex("CatId");

                    b.HasIndex("GeomancyId");

                    b.HasIndex("MainStoneId");

                    b.HasIndex("SubStoneId");

                    b.ToTable("PRODUCTS", (string)null);
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

            modelBuilder.Entity("ptj_server.Models.CategoryProduct", b =>
                {
                    b.HasOne("ptj_server.Models.CategoryProduct", "Parent")
                        .WithMany("InverseParent")
                        .HasForeignKey("ParentId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired()
                        .HasConstraintName("FK_CATEGORY_PRODUCT");

                    b.Navigation("Parent");
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

            modelBuilder.Entity("ptj_server.Models.Product", b =>
                {
                    b.HasOne("ptj_server.Models.CategoryProduct", "Cat")
                        .WithMany("Products")
                        .HasForeignKey("CatId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired()
                        .HasConstraintName("FK_PRODUCTS_CATEGORY_PRODUCTS");

                    b.HasOne("ptj_server.Models.Geomancy", "Geomancy")
                        .WithMany("Products")
                        .HasForeignKey("GeomancyId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired()
                        .HasConstraintName("FK_PRODUCTS_GEOMANCIES");

                    b.HasOne("ptj_server.Models.StoneType", "MainStone")
                        .WithMany("ProductMainStones")
                        .HasForeignKey("MainStoneId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired()
                        .HasConstraintName("FK__PRODUCTS__MAIN_S__3C34F16F");

                    b.HasOne("ptj_server.Models.StoneType", "SubStone")
                        .WithMany("ProductSubStones")
                        .HasForeignKey("SubStoneId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired()
                        .HasConstraintName("FK__PRODUCTS__SUB_ST__3D2915A8");

                    b.Navigation("Cat");

                    b.Navigation("Geomancy");

                    b.Navigation("MainStone");

                    b.Navigation("SubStone");
                });

            modelBuilder.Entity("ptj_server.Models.User", b =>
                {
                    b.HasOne("ptj_server.Models.Role", "Role")
                        .WithMany("Users")
                        .HasForeignKey("IdRole")
                        .HasConstraintName("FK_USERS_ROLE");

                    b.Navigation("Role");
                });

            modelBuilder.Entity("ptj_server.Models.CategoryProduct", b =>
                {
                    b.Navigation("InverseParent");

                    b.Navigation("Products");
                });

            modelBuilder.Entity("ptj_server.Models.CustomerType", b =>
                {
                    b.Navigation("Customers");
                });

            modelBuilder.Entity("ptj_server.Models.Geomancy", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("ptj_server.Models.Role", b =>
                {
                    b.Navigation("Users");
                });

            modelBuilder.Entity("ptj_server.Models.StoneType", b =>
                {
                    b.Navigation("ProductMainStones");

                    b.Navigation("ProductSubStones");
                });
#pragma warning restore 612, 618
        }
    }
}
