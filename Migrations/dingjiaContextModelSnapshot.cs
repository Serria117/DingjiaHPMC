﻿// <auto-generated />
using System;
using DingjiaHpmc.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DingjiaHpmc.Migrations
{
    [DbContext(typeof(dingjiaContext))]
    partial class dingjiaContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("DingjiaHpmc.Models.Entities.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Code")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("code");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("name");

                    b.HasKey("Id");

                    b.ToTable("category", (string)null);
                });

            modelBuilder.Entity("DingjiaHpmc.Models.Entities.Content", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Detail")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("detail");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)")
                        .HasColumnName("name");

                    b.HasKey("Id");

                    b.ToTable("contents", (string)null);
                });

            modelBuilder.Entity("DingjiaHpmc.Models.Entities.Feedback", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClientName")
                        .IsRequired()
                        .HasMaxLength(255)
                        .IsUnicode(false)
                        .HasColumnType("varchar(255)")
                        .HasColumnName("client_name");

                    b.Property<DateTime?>("DateCreate")
                        .HasColumnType("datetime")
                        .HasColumnName("date_create");

                    b.Property<DateTime?>("DateUpdate")
                        .HasColumnType("datetime")
                        .HasColumnName("date_update");

                    b.Property<string>("Email")
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)")
                        .HasColumnName("email");

                    b.Property<bool?>("IsAnswered")
                        .HasColumnType("bit")
                        .HasColumnName("is_answered");

                    b.Property<string>("Message")
                        .HasColumnType("text")
                        .HasColumnName("message");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasMaxLength(20)
                        .IsUnicode(false)
                        .HasColumnType("varchar(20)")
                        .HasColumnName("phone");

                    b.HasKey("Id");

                    b.ToTable("feedback", (string)null);
                });

            modelBuilder.Entity("DingjiaHpmc.Models.Entities.Gallery", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("Type")
                        .HasColumnType("int")
                        .HasColumnName("type");

                    b.Property<string>("Url")
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)")
                        .HasColumnName("url");

                    b.HasKey("Id");

                    b.HasIndex("Type");

                    b.ToTable("gallery", (string)null);
                });

            modelBuilder.Entity("DingjiaHpmc.Models.Entities.GalleryType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)")
                        .HasColumnName("name");

                    b.HasKey("Id");

                    b.ToTable("gallery_type", (string)null);
                });

            modelBuilder.Entity("DingjiaHpmc.Models.Entities.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("Category")
                        .HasColumnType("int")
                        .HasColumnName("category");

                    b.Property<string>("Code")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("code");

                    b.Property<DateTime>("Date_update")
                        .HasColumnType("datetime2");

                    b.Property<string>("Info")
                        .HasColumnType("ntext")
                        .HasColumnName("info");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit")
                        .HasColumnName("is_deleted");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("name");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(38,0)")
                        .HasColumnName("price");

                    b.Property<string>("TechDetail")
                        .HasColumnType("ntext")
                        .HasColumnName("tech_detail");

                    b.HasKey("Id");

                    b.HasIndex("Category");

                    b.ToTable("product", (string)null);
                });

            modelBuilder.Entity("DingjiaHpmc.Models.Entities.ProductImage", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("Product")
                        .HasColumnType("int")
                        .HasColumnName("product");

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)")
                        .HasColumnName("url");

                    b.HasKey("Id");

                    b.HasIndex("Product");

                    b.ToTable("product_images", (string)null);
                });

            modelBuilder.Entity("DingjiaHpmc.Models.Entities.Gallery", b =>
                {
                    b.HasOne("DingjiaHpmc.Models.Entities.GalleryType", "TypeNavigation")
                        .WithMany("Galleries")
                        .HasForeignKey("Type")
                        .HasConstraintName("gallery_FK");

                    b.Navigation("TypeNavigation");
                });

            modelBuilder.Entity("DingjiaHpmc.Models.Entities.Product", b =>
                {
                    b.HasOne("DingjiaHpmc.Models.Entities.Category", "CategoryNavigation")
                        .WithMany("Products")
                        .HasForeignKey("Category")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("product_FK");

                    b.Navigation("CategoryNavigation");
                });

            modelBuilder.Entity("DingjiaHpmc.Models.Entities.ProductImage", b =>
                {
                    b.HasOne("DingjiaHpmc.Models.Entities.Product", "ProductNavigation")
                        .WithMany("ProductImages")
                        .HasForeignKey("Product")
                        .HasConstraintName("product_images_FK");

                    b.Navigation("ProductNavigation");
                });

            modelBuilder.Entity("DingjiaHpmc.Models.Entities.Category", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("DingjiaHpmc.Models.Entities.GalleryType", b =>
                {
                    b.Navigation("Galleries");
                });

            modelBuilder.Entity("DingjiaHpmc.Models.Entities.Product", b =>
                {
                    b.Navigation("ProductImages");
                });
#pragma warning restore 612, 618
        }
    }
}
