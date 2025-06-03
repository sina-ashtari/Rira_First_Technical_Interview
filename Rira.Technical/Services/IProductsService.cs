using Rira.Technical.Models;

namespace Rira.Technical.Services;

public interface IProductsService
{
    IEnumerable<Product> GetProductsByCategory(Categories category);
    Product GetMostExpensiveProduct();
    decimal GetTotalPrice();
    Dictionary<Categories, List<Product>> GroupByCategory();
    decimal GetAveragePrice();
}