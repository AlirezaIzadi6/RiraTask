using RiraTask.Enums;
using RiraTask.Models;

namespace RiraTask.Services
{
    public abstract class ProductRepoService
    {
        public abstract List<Product> GetProductsByCategory(Categories category);
        public abstract Product GetHighestPriceProduct();
        public abstract double GetProductsTotalPrice();
        public abstract Dictionary<Categories, List<Product>> GetAllCategoriesProducts();
        public abstract double GetProductsAveragePrice();
    }
}
