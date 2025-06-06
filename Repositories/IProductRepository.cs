using BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public interface IProductRepository
    {
        void SaveProduct(Product p);
        void DeleteProduct(int p);
        void UpdateProduct(int p);

        List<Product> GetProducts();
        Product GetProductById(int id);
    }
}
