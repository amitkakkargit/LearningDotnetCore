using System.Collections.Generic;
using System.Linq;
using UnitOfWork.Models;

namespace UnitOfWork.UOW
{
    public class ProductRepository : IProductRepository
    {
        private readonly AppDbContext context;
        public ProductRepository(AppDbContext dbContext)
        {
            this.context = dbContext;
        }
        public void AddProduct(Product product)
        {
            context.Product.Add(product);
        }
        public bool DeleteProduct(long productId)
        {
            var removed = false;
            Product product = GetProduct(productId);
            if (product != null)
            {
                removed = true;
                context.Product.Remove(product);
            }
            return removed;
        }
        public Product GetProduct(long id)
        {
            return context.Product.Where(p => p.ProductId == id).FirstOrDefault();
        }
        public IEnumerable<Product> GetProducts()
        {
            return context.Product;
        }
    }
}