
using ApiCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Products.Service
{
    public interface IProductSevise
    {
        Product AddProduct(Product product);
        List<Product> GetCategoryProduct(int categoryID);
        List<Product> GetAllProduct();
        void UpdateProduct(Product product);
        Boolean DeleteProduct(int productID);
        Product GetProductById(int productID);
    }
}
