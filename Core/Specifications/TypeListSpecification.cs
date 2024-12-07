using System;
using Core.entities;
using Core.Specification;

namespace Core.Specifications;

public class TypeListSpecification : BaseSpecification<Product, string>
{
    public TypeListSpecification()
    {
        AddSelect(x => x.Type);
       ApplyDistinct();   
    }
}
