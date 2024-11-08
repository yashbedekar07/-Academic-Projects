using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using MyFitness.Models.Domain;

namespace MyFitness.Models.Data;

public partial class MyFitnessContext : DbContext
{
    public MyFitnessContext(DbContextOptions<MyFitnessContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Attendance> Attendance { get; set; }

    public virtual DbSet<Classes> Classes { get; set; }

    public virtual DbSet<Equipment> Equipment { get; set; }

    public virtual DbSet<Member> Members { get; set; }

    public virtual DbSet<Membership> Memberships { get; set; }

    public virtual DbSet<MembershipType> MembershipTypes { get; set; }

    public virtual DbSet<Trainers> Trainers { get; set; }

}
