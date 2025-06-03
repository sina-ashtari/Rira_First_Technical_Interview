using Rira.Technical.Models;

namespace Rira.Technical.Services;

public class ProductsService : IProductsService
{
    private readonly List<Product> _products;
    
    public ProductsService(List<Product> products)
    {
        _products = products;
    }

    /// <summary>
    /// Filters and returns products that belong to the specified category.
    /// </summary>
    /// <param name="category">The product category to filter by.</param>
    /// <returns>A collection of products that match the given category.</returns>
    public IEnumerable<Product> GetProductsByCategory(Categories category)
    {
        return _products.Where(product => product.Category == category);
    }
    
    /// <summary>
    /// Retrieves the product with the highest price from the list.
    /// </summary>
    /// <returns>The most expensive product.</returns>
    public Product GetMostExpensiveProduct()
    {
        return _products.OrderByDescending(product => product.Price).First();
    }
    /// <summary>
    /// Calculates the total price of all products in the list.
    /// </summary>
    /// <returns>The total sum of all product prices.</returns>
    public decimal GetTotalPrice()
    {
        return _products.Sum(product => product.Price);
    }
    /// <summary>
    /// Groups all products by their category.
    /// </summary>
    /// <returns>
    /// A dictionary where the key is the product category and the value is a list of products in that category.
    /// </returns>
    public Dictionary<Categories, List<Product>> GroupByCategory()
    {
        return _products.GroupBy(product => product.Category).ToDictionary(g => g.Key, g => g.ToList());
    }
    /// <summary>
    /// Calculates the average price of all products.
    /// </summary>
    /// <returns>The average price of the products.</returns>
    public decimal GetAveragePrice()
    {
        return _products.Average(product => product.Price);
    }
}