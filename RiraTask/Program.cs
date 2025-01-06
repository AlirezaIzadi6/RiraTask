using RiraTask.Enums;
using RiraTask.Fixtures;
using RiraTask.Models;
using RiraTask.Services;

var products = ProductList.GetProducts();
ProductRepoService productRepoService = new StaticListProductRepoService(products);

Console.WriteLine("Testing query 1:");
List<Product> category1Products = productRepoService.GetProductsByCategory(Categories.Category1);
Console.WriteLine($"  Number of category 1 products: {category1Products.Count}");

Console.WriteLine("Testing query 2:");
Product MostExpensiveProduct = productRepoService.GetHighestPriceProduct();
Console.WriteLine($"  The most expensive product is {MostExpensiveProduct.Name} with price {MostExpensiveProduct.Price}");

Console.WriteLine("Testing query 3:");
double totalPrice = productRepoService.GetProductsTotalPrice();
Console.WriteLine($"  Total price for all products is {totalPrice}");

Console.WriteLine("Testing query 4:");
Dictionary<Categories, List<Product>> myData = productRepoService.GetAllCategoriesProducts();
foreach(var category in myData.Keys)
{
    Console.WriteLine($"  Number of {category} products: {myData[category].Count}");
}

Console.WriteLine("Testing query 5:");
double averagePrice = productRepoService.GetProductsAveragePrice();
Console.WriteLine($"  Products average price is {averagePrice}");