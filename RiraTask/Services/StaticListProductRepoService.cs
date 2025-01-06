using System.Collections.Generic;
using System.Linq;
using RiraTask.Enums;
using RiraTask.Models;

namespace RiraTask.Services
{
    public class StaticListProductRepoService: ProductRepoService
    {
        private readonly List<Product> _productList;

        public StaticListProductRepoService(List<Product> productList)
        {
            _productList = productList;
        }

        public override List<Product> GetProductsByCategory(Categories category)
        {
            return _productList.Where(p => p.Category == category).ToList();
        }

        public override Product GetHighestPriceProduct()
        {
            int maxPrice = _productList.Max(p => p.Price);
            return _productList.First(p => p.Price == maxPrice);
        }

        public override double GetProductsTotalPrice()
        {
            return _productList.Sum(p => p.Price);
        }

        public override Dictionary<Categories, List<Product>> GetAllCategoriesProducts()
        {
            var result = new Dictionary<Categories, List<Product>>();
            var groups = _productList.GroupBy(p => p.Category)
                .Select(g => new
                {
                    category = g.Key,
                    products = g.ToList()
                }).ToList();
            foreach (var group in groups)
            {
                result[group.category] = group.products;
            }
            return result;
        }

        public override double GetProductsAveragePrice()
        {
            return _productList.Average(p => p.Price);
        }
    }
}
