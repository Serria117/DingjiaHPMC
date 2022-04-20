using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using DingjiaHpmc.Models.Entities;

namespace DingjiaHpmc.Data
{
    public partial class dingjiaContext : DbContext
    {
        public dingjiaContext()
        {
        }

        public dingjiaContext(DbContextOptions<dingjiaContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Category> Categories { get; set; } = null!;
        public virtual DbSet<Content> Contents { get; set; } = null!;
        public virtual DbSet<Feedback> Feedbacks { get; set; } = null!;
        public virtual DbSet<Gallery> Galleries { get; set; } = null!;
        public virtual DbSet<GalleryType> GalleryTypes { get; set; } = null!;
        public virtual DbSet<Product> Products { get; set; } = null!;
        public virtual DbSet<ProductImage> ProductImages { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>(entity =>
            {
                entity.ToTable("category");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Code)
                    .HasMaxLength(100)
                    .HasColumnName("code");

                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<Content>(entity =>
            {
                entity.ToTable("contents");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Detail)
                    .HasColumnType("ntext")
                    .IsUnicode(true)
                    .HasColumnName("detail");

                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .IsUnicode(true)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<Feedback>(entity =>
            {
                entity.ToTable("feedback");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ClientName)
                    .HasColumnType("nvarchar")
                    .HasMaxLength(255)
                    .IsUnicode(true)
                    .HasColumnName("client_name");

                entity.Property(e => e.DateCreate)
                    .HasColumnType("datetime")
                    .HasColumnName("date_create");

                entity.Property(e => e.DateUpdate)
                    .HasColumnType("datetime")
                    .HasColumnName("date_update");

                entity.Property(e => e.Email)
                    .HasMaxLength(100)
                    .IsUnicode(true)
                    .HasColumnName("email");

                entity.Property(e => e.IsAnswered).HasColumnName("is_answered");

                entity.Property(e => e.Message)
                    .HasColumnType("ntext")
                    .IsUnicode(true)
                    .HasColumnName("message");

                entity.Property(e => e.Phone)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("phone");
            });

            modelBuilder.Entity<Gallery>(entity =>
            {
                entity.ToTable("gallery");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Type).HasColumnName("type");

                entity.Property(e => e.Url)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("url");

                entity.HasOne(d => d.TypeNavigation)
                    .WithMany(p => p.Galleries)
                    .HasForeignKey(d => d.Type)
                    .HasConstraintName("gallery_FK");
            });

            modelBuilder.Entity<GalleryType>(entity =>
            {
                entity.ToTable("gallery_type");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .IsUnicode(true)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.ToTable("product");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Category).HasColumnName("category");

                entity.Property(e => e.Code)
                    .HasMaxLength(100)
                    .HasColumnName("code");

                entity.Property(e => e.DateUpdate)
                    .HasColumnType("datetime")
                    .HasColumnName("Date_update");

                entity.Property(e => e.Info)
                    .HasColumnType("ntext")
                    .HasColumnName("info");

                entity.Property(e => e.IsDeleted).HasColumnName("is_deleted");

                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .HasColumnName("name");

                entity.Property(e => e.Price)
                    .HasColumnType("decimal(38, 0)")
                    .HasColumnName("price");

                entity.Property(e => e.TechDetail)
                    .HasColumnType("ntext")
                    .HasColumnName("tech_detail");

                entity.HasOne(d => d.CategoryNavigation)
                    .WithMany(p => p.Products)
                    .HasForeignKey(d => d.Category)
                    .HasConstraintName("product_FK");
            });

            modelBuilder.Entity<ProductImage>(entity =>
            {
                entity.ToTable("product_images");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Product).HasColumnName("product");

                entity.Property(e => e.Url)
                    .HasMaxLength(100)
                    .IsUnicode(true)
                    .HasColumnName("url");

                entity.HasOne(d => d.ProductNavigation)
                    .WithMany(p => p.ProductImages)
                    .HasForeignKey(d => d.Product)
                    .HasConstraintName("product_images_FK");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
