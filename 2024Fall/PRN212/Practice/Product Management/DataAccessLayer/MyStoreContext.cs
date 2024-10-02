using System;
using System.Collections.Generic;
using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using BusinessObjects;

namespace DataAccessLayer
{
    public partial class MyStoreContext : DbContext
    {
        public MyStoreContext()
        {
        }

        public MyStoreContext(DbContextOptions<MyStoreContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AccountMember> AccountMembers { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Product> Products { get; set; }

        // Method to retrieve connection string from appsettings.json
        private string GetConnectionString()
        {
            IConfiguration configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            return configuration["ConnectionStrings:MyStockDB"];
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                // Use the connection string from appsettings.json
                optionsBuilder.UseSqlServer(GetConnectionString());
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AccountMember>(entity =>
            {
                entity.HasKey(e => e.MemberId).HasName("PK__AccountM__0CF04B384471A8B5");

                entity.ToTable("AccountMember");

                entity.HasIndex(e => e.EmailAddress, "UQ__AccountM__49A14740A02EC065").IsUnique();

                entity.Property(e => e.MemberId)
                    .HasMaxLength(20)
                    .HasColumnName("MemberID");
                entity.Property(e => e.EmailAddress).HasMaxLength(100);
                entity.Property(e => e.FullName).HasMaxLength(80);
                entity.Property(e => e.MemberPassword).HasMaxLength(80);
            });

            modelBuilder.Entity<Category>(entity =>
            {
                entity.HasKey(e => e.CategoryId).HasName("PK__Categori__19093A2B310781C6");

                entity.Property(e => e.CategoryId).HasColumnName("CategoryID");
                entity.Property(e => e.CategoryName).HasMaxLength(15);
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.HasKey(e => e.ProductId).HasName("PK__Products__B40CC6EDC7352EA2");

                entity.Property(e => e.ProductId).HasColumnName("ProductID");
                entity.Property(e => e.CategoryId).HasColumnName("CategoryID");
                entity.Property(e => e.ProductName).HasMaxLength(40);
                entity.Property(e => e.UnitPrice).HasColumnType("money");

                entity.HasOne(d => d.Category).WithMany(p => p.Products)
                    .HasForeignKey(d => d.CategoryId)
                    .HasConstraintName("FK__Products__Catego__3C69FB99");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
