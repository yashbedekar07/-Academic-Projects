using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace RakesModules.Models;

public partial class DistributorDbContext : DbContext
{
    public DistributorDbContext()
    {
    }

    public DistributorDbContext(DbContextOptions<DistributorDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Consignor> Consignors { get; set; }

    public virtual DbSet<Dealer> Dealers { get; set; }

    public virtual DbSet<DealerType> DealerTypes { get; set; }

    public virtual DbSet<Despatch> Despatches { get; set; }

    public virtual DbSet<DespatchType> DespatchTypes { get; set; }

    public virtual DbSet<DestRateMaster> DestRateMasters { get; set; }

    public virtual DbSet<Destination> Destinations { get; set; }

    public virtual DbSet<District> Districts { get; set; }

    public virtual DbSet<Group> Groups { get; set; }

    public virtual DbSet<Product> Products { get; set; }

    public virtual DbSet<ProductStockHistory> ProductStockHistories { get; set; }

    public virtual DbSet<Rake> Rakes { get; set; }

    public virtual DbSet<Subdealer> Subdealers { get; set; }

    public virtual DbSet<Taluka> Talukas { get; set; }

    public virtual DbSet<Transport> Transports { get; set; }

    public virtual DbSet<User> Users { get; set; }

    public virtual DbSet<Wagon> Wagons { get; set; }

   }
