namespace Rira.Technical.Models;

public class Product
{
    public required int Id {get; init;}
    public required string Name{get; init;}
    public required Categories Category{get; init;}
    public decimal Price{get; init;}
}