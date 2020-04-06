using ProductCategory.Business.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductCategory.Business.Services
{
    public interface IProductService
    {
        List<Product> All();
        Product GetProductById(int productId);
        bool Add(Product product);
        bool Update(Product product);
        bool Delete(int productId);
        ProductModel GetProducts(int currentPage);
    }
}
