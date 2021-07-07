using ApiCore.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Products.Service
{
    public class CategoryService :ICategoryService
    {
        private readonly TestingContext _testingcontext;
        public CategoryService(TestingContext testingcontext)
        {
            _testingcontext = testingcontext;
        }
        public Category AddCategory(Category category)
        {
            _testingcontext.Categories.Add(category);
            _testingcontext.SaveChanges();
            return category;
        }
        public  List<Category> GetCategory()
        {
            return  _testingcontext.Categories.ToList();
        }
        public void UpdateCategory(Category category)
        {
            category.IsActive = true;
            _testingcontext.Categories.Update(category);
            _testingcontext.SaveChanges();
        }
        public Category GetCategoryByID(int categoryId)
        {
          return  _testingcontext.Categories.Where(x=> x.CategoryId == categoryId).FirstOrDefault();
        }
        public Boolean GetCategoryByCode(string categoryCode)
        {
            return _testingcontext.Categories.Any(x => x.CategoryCode == categoryCode);
        }
    }
}
