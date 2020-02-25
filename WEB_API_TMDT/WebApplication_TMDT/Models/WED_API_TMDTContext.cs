using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace WebApplication_TMDT.Models
{
    public partial class WED_API_TMDTContext : DbContext
    {
        public WED_API_TMDTContext()
        {
        }

        public WED_API_TMDTContext(DbContextOptions<WED_API_TMDTContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Bill> Bill { get; set; }
        public virtual DbSet<BillDetail> BillDetail { get; set; }
        public virtual DbSet<Cart> Cart { get; set; }
        public virtual DbSet<Category> Category { get; set; }
        public virtual DbSet<Product> Product { get; set; }
        public virtual DbSet<Users> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source=DESKTOP-EH88R88\\MSSQLSERVER2016;Initial Catalog=WED_API_TMDT;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Bill>(entity =>
            {
                entity.ToTable("BILL");

                entity.Property(e => e.BillId)
                    .HasColumnName("bill_ID")
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.Address)
                    .HasColumnName("address")
                    .HasMaxLength(100);

                entity.Property(e => e.Date)
                    .HasColumnName("date")
                    .HasColumnType("datetime");

                entity.Property(e => e.Payment)
                    .HasColumnName("payment")
                    .HasMaxLength(50);

                entity.Property(e => e.Total)
                    .HasColumnName("total")
                    .HasColumnType("money");

                entity.Property(e => e.UserId)
                    .HasColumnName("user_ID")
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Bill)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_BILL_USERS");
            });

            modelBuilder.Entity<BillDetail>(entity =>
            {
                entity.ToTable("bill_detail");

                entity.Property(e => e.BillDetailId)
                    .HasColumnName("bill_detail_ID")
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.BillId)
                    .HasColumnName("bill_ID")
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.Price)
                    .HasColumnName("price")
                    .HasColumnType("money");

                entity.Property(e => e.ProductId)
                    .HasColumnName("product_ID")
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.Quantity).HasColumnName("quantity");

                entity.HasOne(d => d.Bill)
                    .WithMany(p => p.BillDetail)
                    .HasForeignKey(d => d.BillId)
                    .HasConstraintName("FK_bill_detail_BILL");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.BillDetail)
                    .HasForeignKey(d => d.ProductId)
                    .HasConstraintName("FK_bill_detail_product");
            });

            modelBuilder.Entity<Cart>(entity =>
            {
                entity.ToTable("cart");

                entity.Property(e => e.CartId)
                    .HasColumnName("cart_ID")
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.ProductDescription)
                    .HasColumnName("productDescription")
                    .HasMaxLength(255);

                entity.Property(e => e.ProductId)
                    .HasColumnName("product_ID")
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.ProductImage)
                    .HasColumnName("productImage")
                    .HasMaxLength(255);

                entity.Property(e => e.ProductName)
                    .HasColumnName("productName")
                    .HasMaxLength(50);

                entity.Property(e => e.ProductPrice)
                    .HasColumnName("productPrice")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Quantity).HasColumnName("quantity");

                entity.Property(e => e.Total)
                    .HasColumnName("total")
                    .HasColumnType("decimal(18, 0)");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.Cart)
                    .HasForeignKey(d => d.ProductId)
                    .HasConstraintName("FK_cart_product");
            });

            modelBuilder.Entity<Category>(entity =>
            {
                entity.ToTable("category");

                entity.Property(e => e.CategoryId)
                    .HasColumnName("category_ID")
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.CategoryName)
                    .HasColumnName("categoryName")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.ToTable("product");

                entity.Property(e => e.ProductId)
                    .HasColumnName("product_ID")
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.CategoryId)
                    .HasColumnName("category_ID")
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.ProductDescription)
                    .HasColumnName("productDescription")
                    .HasMaxLength(255);

                entity.Property(e => e.ProductImage)
                    .HasColumnName("productImage")
                    .HasMaxLength(255);

                entity.Property(e => e.ProductName)
                    .HasColumnName("productName")
                    .HasMaxLength(255);

                entity.Property(e => e.ProductPrice)
                    .HasColumnName("productPrice")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.ProductType)
                    .HasColumnName("productType")
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.Product)
                    .HasForeignKey(d => d.CategoryId)
                    .HasConstraintName("FK_product_category");
            });

            modelBuilder.Entity<Users>(entity =>
            {
                entity.HasKey(e => e.UserId);

                entity.ToTable("USERS");

                entity.Property(e => e.UserId)
                    .HasColumnName("user_ID")
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.UserEmail)
                    .HasColumnName("userEmail")
                    .HasMaxLength(50);

                entity.Property(e => e.UserPass)
                    .HasColumnName("userPass")
                    .HasMaxLength(50);

                entity.Property(e => e.UserRole)
                    .HasColumnName("userRole")
                    .HasMaxLength(10)
                    .IsFixedLength();
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
