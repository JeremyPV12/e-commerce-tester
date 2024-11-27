using System;
using System.Text.Json;
using System.Text.Json.Nodes;
using Core.entities;

namespace Infrastructure.Data;

public class StoreContextSeed
{
    /* what meaning static ? :  We can use this method without needing to create a new instance of the store context */
    public static async Task SeedAsync(StoreContext context)
    {
        if (!context.Products.Any())
        {
            var productsData = await File.ReadAllTextAsync("../Infrastructure/Data/SeedData/products.json");
            var products = JsonSerializer.Deserialize<List<Product>>(productsData);
            if (products == null) return ;
            context.Products.AddRange(products);
            await context.SaveChangesAsync();
        }
    }
}
