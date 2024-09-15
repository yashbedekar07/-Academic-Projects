using System;
using System.Collections.Generic;
using InventoryManagementSystem.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace InventoryManagementSystem.Models.Data;

public partial class InventoryContext : DbContext
{
    public InventoryContext(DbContextOptions<InventoryContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Customer> Customers { get; set; }

    public virtual DbSet<Product> Products { get; set; }

    public virtual DbSet<Supplier> Suppliers { get; set; }

    public virtual DbSet<User> Users { get; set; }



}
