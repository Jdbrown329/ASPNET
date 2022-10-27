using System.Collections.Generic;
using Testing.Models;
using Dapper;

namespace Testing
{
    public interface IProductRepository
    {
        public IEnumerable<Product> GetAllProducts();
        public Product GetProduct(int id);
    }

    
}
