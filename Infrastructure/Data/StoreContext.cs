using System;
using Core.entities;
using Infrastructure.Config;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data;

/* provide the constructor
    We are instance the store context */
    /* Primary constructor */
public class StoreContext(DbContextOptions options) : DbContext(options)
{
    /* The name use inside our database */
    public required DbSet<Product> Products { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.ApplyConfigurationsFromAssembly(typeof(ProductConfiguration).Assembly);
    }
}
