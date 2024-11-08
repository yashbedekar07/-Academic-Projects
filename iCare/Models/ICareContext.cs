using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace iCare.Models;

public partial class ICareContext : DbContext
{
    public ICareContext()
    {
    }

    public ICareContext(DbContextOptions<ICareContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Casepaper> Casepapers { get; set; }

    public virtual DbSet<Frame> Frames { get; set; }

    public virtual DbSet<FrameType> FrameTypes { get; set; }

    public virtual DbSet<Glass> Glass { get; set; }

    public virtual DbSet<GlassType> GlassTypes { get; set; }

    public virtual DbSet<Patient> Patients { get; set; }

    public virtual DbSet<User> Users { get; set; }

//    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
//        => optionsBuilder.UseSqlServer("Server=.;Database=iCare;Integrated Security=True;Trusted_Connection=True;TrustServerCertificate=True");

//    protected override void OnModelCreating(ModelBuilder modelBuilder)
//    {
//        modelBuilder.Entity<Casepaper>(entity =>
//        {
//            entity.HasKey(e => e.CasepaperId).HasName("PK__Casepape__502393428AB142B4");

//            entity.Property(e => e.CasepaperId).HasColumnName("CasepaperID");
//            entity.Property(e => e.Amount).HasColumnType("decimal(10, 2)");
//            entity.Property(e => e.CreatedDate)
//                .HasDefaultValueSql("(getdate())")
//                .HasColumnType("datetime");
//            entity.Property(e => e.FrameId).HasColumnName("FrameID");
//            entity.Property(e => e.FrameTypesId).HasColumnName("FrameTypesID");
//            entity.Property(e => e.GlassId).HasColumnName("GlassID");
//            entity.Property(e => e.GlassTypesId).HasColumnName("GlassTypesID");
//            entity.Property(e => e.LeftEyeAxisdv)
//                .HasMaxLength(20)
//                .IsUnicode(false)
//                .HasColumnName("LeftEyeAXISDV");
//            entity.Property(e => e.LeftEyeAxisnv)
//                .HasMaxLength(20)
//                .IsUnicode(false)
//                .HasColumnName("LeftEyeAXISNV");
//            entity.Property(e => e.LeftEyeCyldv)
//                .HasMaxLength(20)
//                .IsUnicode(false)
//                .HasColumnName("LeftEyeCYLDV");
//            entity.Property(e => e.LeftEyeCylnv)
//                .HasMaxLength(20)
//                .IsUnicode(false)
//                .HasColumnName("LeftEyeCYLNV");
//            entity.Property(e => e.LeftEyeSphdv)
//                .HasMaxLength(20)
//                .IsUnicode(false)
//                .HasColumnName("LeftEyeSPHDV");
//            entity.Property(e => e.LeftEyeSphnv)
//                .HasMaxLength(20)
//                .IsUnicode(false)
//                .HasColumnName("LeftEyeSPHNV");
//            entity.Property(e => e.MobileNumber)
//                .HasMaxLength(15)
//                .IsUnicode(false);
//            entity.Property(e => e.PatientId).HasColumnName("PatientID");
//            entity.Property(e => e.Remarks).HasMaxLength(255);
//            entity.Property(e => e.RightEyeAxisdv)
//                .HasMaxLength(20)
//                .IsUnicode(false)
//                .HasColumnName("RightEyeAXISDV");
//            entity.Property(e => e.RightEyeAxisnv)
//                .HasMaxLength(20)
//                .IsUnicode(false)
//                .HasColumnName("RightEyeAXISNV");
//            entity.Property(e => e.RightEyeCyldv)
//                .HasMaxLength(20)
//                .IsUnicode(false)
//                .HasColumnName("RightEyeCYLDV");
//            entity.Property(e => e.RightEyeCylnv)
//                .HasMaxLength(20)
//                .IsUnicode(false)
//                .HasColumnName("RightEyeCYLNV");
//            entity.Property(e => e.RightEyeSphdv)
//                .HasMaxLength(20)
//                .IsUnicode(false)
//                .HasColumnName("RightEyeSPHDV");
//            entity.Property(e => e.RightEyeSphnv)
//                .HasMaxLength(20)
//                .IsUnicode(false)
//                .HasColumnName("RightEyeSPHNV");

//            entity.HasOne(d => d.Frame).WithMany(p => p.Casepapers)
//                .HasForeignKey(d => d.FrameId)
//                .HasConstraintName("FK__Casepaper__Frame__49C3F6B7");

//            entity.HasOne(d => d.FrameTypes).WithMany(p => p.Casepapers)
//                .HasForeignKey(d => d.FrameTypesId)
//                .HasConstraintName("FK__Casepaper__Frame__4BAC3F29");

//            entity.HasOne(d => d.Glass).WithMany(p => p.Casepapers)
//                .HasForeignKey(d => d.GlassId)
//                .HasConstraintName("FK__Casepaper__Glass__4AB81AF0");

//            entity.HasOne(d => d.GlassTypes).WithMany(p => p.Casepapers)
//                .HasForeignKey(d => d.GlassTypesId)
//                .HasConstraintName("FK__Casepaper__Glass__4CA06362");

//            entity.HasOne(d => d.Patient).WithMany(p => p.Casepapers)
//                .HasForeignKey(d => d.PatientId)
//                .HasConstraintName("FK__Casepaper__Patie__48CFD27E");
//        });

//        modelBuilder.Entity<Frame>(entity =>
//        {
//            entity.HasKey(e => e.FrameId).HasName("PK__Frames__563E43C066554551");

//            entity.Property(e => e.FrameId).HasColumnName("FrameID");
//            entity.Property(e => e.Description).HasMaxLength(255);
//            entity.Property(e => e.FrameType).HasMaxLength(50);
//        });

//        modelBuilder.Entity<FrameType>(entity =>
//        {
//            entity.HasKey(e => e.FrameTypesId).HasName("PK__FrameTyp__515EAA93680D4E29");

//            entity.Property(e => e.FrameTypesId).HasColumnName("FrameTypesID");
//            entity.Property(e => e.Description).HasMaxLength(255);
//            entity.Property(e => e.FrameTypeName).HasMaxLength(50);
//        });

//        modelBuilder.Entity<Glass>(entity =>
//        {
//            entity.HasKey(e => e.GlassId).HasName("PK__Glass__46AF7735AD91D77C");

//            entity.ToTable("Glass");

//            entity.Property(e => e.GlassId).HasColumnName("GlassID");
//            entity.Property(e => e.Description).HasMaxLength(255);
//            entity.Property(e => e.GlassType).HasMaxLength(50);
//        });

//        modelBuilder.Entity<GlassType>(entity =>
//        {
//            entity.HasKey(e => e.GlassTypesId).HasName("PK__GlassTyp__CAA99361A0A1F344");

//            entity.Property(e => e.GlassTypesId).HasColumnName("GlassTypesID");
//            entity.Property(e => e.Description).HasMaxLength(255);
//            entity.Property(e => e.GlassTypeName).HasMaxLength(50);
//        });

//        modelBuilder.Entity<Patient>(entity =>
//        {
//            entity.HasKey(e => e.PatientId).HasName("PK__Patients__970EC3468251482D");

//            entity.Property(e => e.PatientId).HasColumnName("PatientID");
//            entity.Property(e => e.Address).HasMaxLength(255);
//            entity.Property(e => e.ContactNumber).HasMaxLength(15);
//            entity.Property(e => e.Dob).HasColumnName("DOB");
//            entity.Property(e => e.Email).HasMaxLength(50);
//            entity.Property(e => e.Gender).HasMaxLength(10);
//            entity.Property(e => e.PatientName)
//                .HasMaxLength(50)
//                .IsUnicode(false);
//        });

//        modelBuilder.Entity<User>(entity =>
//        {
//            entity.HasKey(e => e.Id).HasName("PK__Users__3214EC27B4ADFC2F");

//            entity.HasIndex(e => e.Username, "UQ__Users__536C85E4F8050A50").IsUnique();

//            entity.Property(e => e.Id).HasColumnName("ID");
//            entity.Property(e => e.Password).HasMaxLength(50);
//            entity.Property(e => e.Role).HasMaxLength(20);
//            entity.Property(e => e.Username).HasMaxLength(50);
//        });

//        OnModelCreatingPartial(modelBuilder);
//    }

//    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
