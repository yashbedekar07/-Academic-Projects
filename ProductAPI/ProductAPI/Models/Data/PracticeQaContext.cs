using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using ProductAPI.Models.Domains;

namespace ProductAPI.Models.Data;

public partial class PracticeQaContext : DbContext
{
    public PracticeQaContext()
    {
    }

    public PracticeQaContext(DbContextOptions<PracticeQaContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Product> Products { get; set; }

    //    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    //#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
    //        => optionsBuilder.UseSqlServer("Server=.;Database=practice-qa;Integrated Security=True;TrustServerCertificate=true;");

    //protected override void OnModelCreating(ModelBuilder modelBuilder)
    //{
    //    modelBuilder.Entity<Product>(entity =>
    //    {
    //        entity.HasKey(e => e.Id).HasName("PK__Products__3213E83F112B80CD");

    //        entity.Property(e => e.Id).HasColumnName("id");
    //        entity.Property(e => e.Code)
    //            .HasMaxLength(50)
    //            .IsUnicode(false)
    //            .HasColumnName("code");
    //        entity.Property(e => e.Name)
    //            .HasMaxLength(5000)
    //            .IsUnicode(false);
    //    });

    //    OnModelCreatingPartial(modelBuilder);
    //}

    //partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
