
using ApiCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Products.Service
{
    public class ProductServise : IProductSevise
    {
        private readonly TestingContext _testingcontext;
        public ProductServise(TestingContext testingcontext)
        {
            _testingcontext = testingcontext;
        }
        public Product AddProduct(Product product)
        {
            product.ProductCode = GetNewCode();
            product.DateCreated = DateTime.Now;
            product.IsActive = true;
            _testingcontext.Products.Add(product);
            _testingcontext.SaveChanges();
            return product;
        }
        
        public List<Product> GetAllProduct()
        {
                return _testingcontext.Products.Where(x => x.IsActive == true).ToList();
        }
        public List<Product> GetCategoryProduct(int categoryID)
        {
            return _testingcontext.Products.Where(x=> x.FkCategoryId == categoryID && x.IsActive == true).ToList();
        }
        public void UpdateProduct(Product product)
        {
             product.DateCreated = DateTime.Now;
            product.IsActive = true;
            _testingcontext.Products.Update(product);
            _testingcontext.SaveChanges();
        }
        public Boolean DeleteProduct(int productID)
        {
            var objproduct = _testingcontext.Products.FirstOrDefault(x => x.ProductId == productID);
            if (objproduct != null)
            {
                objproduct.IsActive = false;
                objproduct.DateCreated = DateTime.Now;
                _testingcontext.SaveChanges();
                return true;
            }
            return false;
        }
        public Product GetProductById(int productID)
        {
           return _testingcontext.Products.FirstOrDefault(x => x.ProductId == productID);
            
        }
        public string GetNewCode()
        {
            string code;
            int count = 0;
            DateTime dt = DateTime.Now;
            String currectDate = dt.ToShortDateString();
            var countList = _testingcontext.Products.Where(x => x.DateCreated.Date == dt.Date).ToList();
            if(countList.Count > 0)
                count = countList.Count;
            code = currectDate.ToString().Replace("/", "") + "-00"  + count.ToString();

            return code;
        }
    }
}
