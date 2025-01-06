using RiraTask.Enums;
using RiraTask.Models;

namespace RiraTask.Fixtures
{
    public static class ProductList
    {
        private static readonly List<Product> _productList = new()
        {
            new Product { Id = 1, Name = "Product A", Category = Categories.Category1, Price = 100 },
            new Product { Id = 2, Name = "Product B", Category = Categories.Category1, Price = 150 },
            new Product { Id = 3, Name = "Product C", Category = Categories.Category2, Price = 120 },
            new Product { Id = 4, Name = "Product D", Category = Categories.Category3, Price = 200 },
            new Product { Id = 5, Name = "Product E", Category = Categories.Category1, Price = 80 }
        };

        public static List<Product> GetProducts()
        {
            return _productList;
        }
    }
}
