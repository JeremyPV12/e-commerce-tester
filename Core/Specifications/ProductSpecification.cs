using System;
using Core.entities;
using Core.Specification;

namespace Core.Specifications;

public class ProductSpecification : BaseSpecification<Product>
{
    public ProductSpecification(string? brand, string? type, string? sort) : base ( x => 
        (string.IsNullOrWhiteSpace(brand) || x.Brand == brand ) && 
        (string.IsNullOrWhiteSpace(type) || x.Type == type )
    )
    {
        switch (sort)
        {
            case "priceAsc" :
                AddOrderBy(x => x.Price);
                break;
            case "priceDesc":
                AddOrderByDescending(x=>x.Price);
                break;
            default:
                AddOrderBy(x => x.Price);
                break;
        }
    }
}
