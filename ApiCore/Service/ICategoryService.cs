
using ApiCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Products.Service
{
    public interface ICategoryService
    {
        Category AddCategory(Category category);
        List<Category> GetCategory();
        void UpdateCategory(Category category);
        Category GetCategoryByID(int categoryId);
        Boolean GetCategoryByCode(string categoryCode);
    }
}
