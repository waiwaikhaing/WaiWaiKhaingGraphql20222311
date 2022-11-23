using DotNetCoreCRUDAssign.Shared.Models;
using Microsoft.AspNetCore.Mvc;
using System;

namespace WaiWaiKhaingGraphql20222311.Controllers
{
    public class CategoryQuery
    {
        List<CategoryModel> _categories = new List<CategoryModel>();
        public CategoryQuery()
        {
            for (int i = 0; i < 10; i++)
            {
                CategoryModel category = new CategoryModel();
                category.CategoryID = i;
                category.CategoryName = "ABC" + i.ToString();
                category.CreatedDateTime = DateTime.Now;
                category.CategoryCode = "C00" + i.ToString();
                _categories.Add(category);
            }
        }

        public List<CategoryModel> CategoryList()
        {
           return _categories;
        }
        public CategoryModel CategoryById(string id)
        {
            int _id = Convert.ToInt32(id);
            CategoryModel item = _categories.FirstOrDefault(x => x.CategoryID == _id);
            return item;
        }
    }
}
