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
    [ApiController]
    [Route("[controller]")]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryService _icategoryservice;
        public CategoryController(ICategoryService icategoryservice)
        {
            _icategoryservice = icategoryservice;
        }
        /// <summary>
        /// GetCategory
        /// </summary>
        /// <returns></returns>
        [HttpGet("/GetCategory")]
        public IEnumerable<object> GetCategory()
        {
            return _icategoryservice.GetCategory();
        }
        /// <summary>
        /// Get Category details by category ID
        /// </summary>
        /// <param name="CategoryId"></param>
        /// <returns></returns>
        [HttpGet("/GetCategoryByID")]
        public object GetCategoryByID(int CategoryId)
        {
            return _icategoryservice.GetCategoryByID(CategoryId);
        }
        /// <summary>
        ///check if category code exist
        /// </summary>
        /// <param name="CategoryCode"></param>
        /// <returns></returns>
        [HttpGet("/GetCategoryByCode")]
        public ApiResponse GetCategoryByCode(string CategoryCode)
        {
            var apiResp = new ApiResponse { ResponseType = false };
            apiResp.ResponseType = _icategoryservice.GetCategoryByCode(CategoryCode);
            return apiResp;
        }
        /// <summary>
        /// add new category details
        /// </summary>
        /// <param name="category"></param>
        /// <returns></returns>
        [HttpPost("/AddCategory")]
        public IActionResult AddCategory(Category category)
        {
            _icategoryservice.AddCategory(category);
            return Ok();
        }
        /// <summary>
        /// update category details 
        /// </summary>
        /// <param name="category"></param>
        /// <returns></returns>
        [HttpPut("/UpdateCategory")]
        public IActionResult UpdateCategory(Category category)
        {
            _icategoryservice.UpdateCategory(category);
            return Ok();
        }

    }
}
