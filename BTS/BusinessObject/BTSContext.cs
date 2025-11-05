using System;
using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.Extensions.Configuration;
#nullable disable

namespace BusinessObject
{
    public partial class BTSContext : DbContext
    {
        public BTSContext()
        {
        }

        public BTSContext(DbContextOptions<BTSContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Admin> Admins { get; set; }
        public virtual DbSet<Bird> Birds { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Carrier> Carriers { get; set; }
        public virtual DbSet<Delivery> Deliveries { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<OrderDetail> OrderDetails { get; set; }
        public virtual DbSet<Transport> Transports { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                //#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                //                optionsBuilder.UseSqlServer("Server=LAPTOP-HP6ERQBA\\SQLEXPRESS; Database=BTS; Uid=sa; Pwd=12345");
                optionsBuilder.UseSqlServer(GetConnectionString());
            }
        }

        string GetConnectionString()
        {
            IConfiguration builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", true, true).Build();
            return builder["ConnectionStrings:DefaultConnectionString"];
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Admin>(entity =>
            {
                entity.HasKey(e => e.AdminName)
                    .HasName("PK__Admin__D6316B69DC9753D7");

                entity.ToTable("Admin");

                entity.Property(e => e.AdminName)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Role)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Bird>(entity =>
            {
                entity.ToTable("Bird");

                entity.Property(e => e.BirdId).HasColumnName("BirdID");

                entity.Property(e => e.BirdName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Origin)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Picture)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Customer>(entity =>
            {
                entity.ToTable("Customer");

                entity.Property(e => e.CustomerId).HasColumnName("CustomerID");

                entity.Property(e => e.Address).HasMaxLength(100);

                entity.Property(e => e.CustomerName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Phone)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Role)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Carrier>(entity =>
            {
                entity.HasKey(e => e.Carrier1)
                    .HasName("PK__Carrier__1232CBA818CC82FB");

                entity.ToTable("Carrier");

                entity.Property(e => e.Carrier1)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Carrier");

                entity.Property(e => e.CarrierPass)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.Role).HasMaxLength(10);
            });

            modelBuilder.Entity<Delivery>(entity =>
            {
                //entity.HasNoKey();

                entity.ToTable("Delivery");

                entity.Property(e => e.DeliveryId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("DeliveryID");

                entity.Property(e => e.DeliveryName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OrderIdetail).HasColumnName("OrderIDetail");

                entity.HasOne(d => d.OrderIdetailNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.OrderIdetail)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Delivery__OrderI__03F0984C");
            });

            modelBuilder.Entity<Order>(entity =>
            {
                entity.ToTable("Order");

                entity.Property(e => e.OrderId).HasColumnName("OrderID");

                entity.Property(e => e.BirdId).HasColumnName("BirdID");

                entity.Property(e => e.CustomerId).HasColumnName("CustomerID");

                entity.Property(e => e.OrderDate).HasColumnType("date");

                entity.Property(e => e.Status).HasMaxLength(30);

                entity.HasOne(d => d.Bird)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.BirdId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Order__BirdID__2A4B4B5E");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.CustomerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Order__CustomerI__2B3F6F97");
            });

            modelBuilder.Entity<OrderDetail>(entity =>
            {
                entity.HasKey(e => e.OrderIdetail)
                    .HasName("PK__OrderDet__819BB1F91E33262C");

                entity.ToTable("OrderDetail");

                entity.Property(e => e.OrderIdetail).HasColumnName("OrderIDetail");

                entity.Property(e => e.AddressFrom).HasMaxLength(100);

                entity.Property(e => e.AddressShip)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.OrderId).HasColumnName("OrderID");

                entity.Property(e => e.Pay)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Phone)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.TransportId).HasColumnName("TransportID");

                entity.HasOne(d => d.Order)
                    .WithMany(p => p.OrderDetails)
                    .HasForeignKey(d => d.OrderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__OrderDeta__Order__76969D2E");

                entity.HasOne(d => d.Transport)
                    .WithMany(p => p.OrderDetails)
                    .HasForeignKey(d => d.TransportId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__OrderDeta__Trans__778AC167");
            });

            modelBuilder.Entity<Transport>(entity =>
            {
                entity.ToTable("Transport");

                entity.Property(e => e.TransportId).HasColumnName("TransportID");

                entity.Property(e => e.Backpack)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MethodShip)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Vehicel)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
