using System;
using Core.entities;
using Core.Specification;

namespace Core.Specifications;

public class BrandListSpecification : BaseSpecification<Product, string>
{
    public BrandListSpecification()
    {
       AddSelect(x => x.Brand);
       ApplyDistinct();
    }
}