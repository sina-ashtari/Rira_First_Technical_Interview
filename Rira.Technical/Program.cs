using Rira.Technical.Data;using Rira.Technical.Models;
using Rira.Technical.Services;


IProductService productService = new ProductService(StaticProductData.Products);

var category1Products = productService.GetProductsByCategory(Categories.Category1);
var mostExpensive = productService.GetMostExpensiveProduct();
var totalPrice = productService.GetTotalPrice();
var grouped = productService.GroupByCategory();
var avgPrice = productService.GetAveragePrice();

Console.WriteLine("Category 1 Products: ");
foreach (var product in category1Products)
{
    Console.WriteLine("Name: " + product.Name + " with id: " + product.Id + ", category: " + product.Category + ", price: " + product.Price);
}

Console.WriteLine("Most expensive product is: " +  mostExpensive.Name + " with id: " + mostExpensive.Id + ", category: " + mostExpensive.Category + ", price: " + mostExpensive.Price);
Console.WriteLine("Total price is: " + totalPrice);

foreach (var category in grouped)
{
    Console.WriteLine($"{category.Key}: ");
    foreach (var product in category.Value)
    {
        Console.WriteLine("Name: " + product.Name + " with id: " + product.Id + ", category: " + product.Category + ", price: " + product.Price);
    }
}

Console.WriteLine("Average price: " + avgPrice);
