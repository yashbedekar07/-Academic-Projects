using System;
using System.Collections.Generic;
using CustomerApi.Models.Domains;
using Microsoft.EntityFrameworkCore;

namespace CustomerApi.Models.Data;

public partial class CrudDbContext : DbContext
{
    //public CrudDbContext()
    //{
    //}

    public CrudDbContext(DbContextOptions<CrudDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Customer> Customers { get; set; }

    //public virtual DbSet<Product> Products { get; set; }

//    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
//        => optionsBuilder.UseSqlServer("Server=.;;Database=CRUD_DB;Integrated Security=True;Trusted_Connection=True;TrustServerCertificate=True;");

   // protected override void OnModelCreating(ModelBuilder modelBuilder)
    //{
    //    modelBuilder.Entity<Customer>(entity =>
    //    {
    //        entity.HasKey(e => e.CustomerId).HasName("PK__Customer__A4AE64D81DAF71FB");

    //        entity.Property(e => e.Address)
    //            .HasMaxLength(255)
    //            .IsUnicode(false);
    //        entity.Property(e => e.Age)
    //            .HasMaxLength(2)
    //            .IsUnicode(false);
    //        entity.Property(e => e.City)
    //            .HasMaxLength(100)
    //            .IsUnicode(false);
    //        entity.Property(e => e.CustomerName)
    //            .HasMaxLength(100)
    //            .IsUnicode(false);
    //        entity.Property(e => e.DateOfBirth)
    //            .HasDefaultValueSql("(getdate())")
    //            .HasColumnType("datetime");
    //        entity.Property(e => e.Email)
    //            .HasMaxLength(255)
    //            .IsUnicode(false);
    //        entity.Property(e => e.Phone)
    //            .HasMaxLength(20)
    //            .IsUnicode(false);
    //        entity.Property(e => e.State)
    //            .HasMaxLength(50)
    //            .IsUnicode(false);
    //    });

    //    OnModelCreatingPartial(modelBuilder);
   // }

    //partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
