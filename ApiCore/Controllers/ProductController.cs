using ApiCore.Models;
using ApiCore.Response;
using Microsoft.AspNetCore.Mvc;
using Products.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Products.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductSevise _iproducsevise;
        public ProductController(IProductSevise iproducsevise)
        {
            _iproducsevise = iproducsevise;
        }
        /// <summary>
        /// Get list of Product by category id
        /// </summary>
        /// <returns></returns>
        [HttpGet("/GetCategoryProduct")]
        public List<Product> GetCategoryProduct(int categoryID)
        {
            return _iproducsevise.GetCategoryProduct(categoryID);
        }
        /// <summary>
        /// Get list of Product by category id
        /// </summary>
        /// <returns></returns>
        [HttpGet("/GetAllProduct")]
        public List<Product> GetAllProduct()
        {
            return _iproducsevise.GetAllProduct();
        }
        /// <summary>
        /// add new product details
        /// </summary>
        /// <param name="product"></param>
        /// <returns></returns>
        [HttpPost("/AddProduct")]
        public IActionResult AddProduct(Product product)
        {
            _iproducsevise.AddProduct(product);
            return Ok();
        }
        /// <summary>
        /// update product details
        /// </summary>
        /// <param name="product"></param>
        /// <returns></returns>
        [HttpPut("/UpdateProduct")]
        public IActionResult UpdateProduct(Product product)
        {
            _iproducsevise.UpdateProduct(product);
            return Ok();
        }
        /// <summary>
        /// delete product details by product id
        /// </summary>
        /// <param name="product"></param>
        /// <returns></returns>
        [HttpDelete("/DeleteProduct")]
        public ApiResponse DeleteProduct(int productID)
        {
            var apiResp = new ApiResponse { ResponseType = false };
            apiResp.ResponseType = _iproducsevise.DeleteProduct(productID);           
            return apiResp;
        }
        /// <summary>
        /// get product details by product id
        /// </summary>
        /// <param name="productID"></param>
        /// <returns></returns>
        [HttpGet("/GetProductById")]
        public Product GetProductById(int productID)
        {
          return  _iproducsevise.GetProductById(productID);
        }
    }
}
