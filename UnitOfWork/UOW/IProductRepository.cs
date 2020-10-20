using System.Collections.Generic;
using UnitOfWork.Models;

namespace UnitOfWork.UOW
{
    public interface IProductRepository
    {
        void AddProduct(Product product);
        Product GetProduct(long id);
        IEnumerable<Product> GetProducts();
        bool DeleteProduct(long productId);
    }
}