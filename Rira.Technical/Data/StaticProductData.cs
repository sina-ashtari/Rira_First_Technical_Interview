using Rira.Technical.Models;

namespace Rira.Technical.Data;

public static class StaticProductData
{
    /// <summary>
    /// Provided static values from technical task pdf file
    /// </summary>
    public static readonly List<Product> Products = new List<Product>
    {
        new Product (){ Id = 1, Name = "Product A", Category = Categories.Category1, Price = 100 },
        new Product (){ Id = 2, Name = "Product B", Category = Categories.Category1, Price = 150 },
        new Product (){ Id = 3, Name = "Product C", Category = Categories.Category2, Price = 120 },
        new Product (){ Id = 4, Name = "Product D", Category = Categories.Category3, Price = 200 },
        new Product (){ Id = 5, Name = "Product E", Category = Categories.Category1, Price = 80 }
    };
}