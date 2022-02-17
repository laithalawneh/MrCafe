using MrCafe.Core.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace MrCafe.Core.Repository
{
    public interface ICategoryRepository
    {
        public List<Category> GetAllCategory();
        public bool CreateCategory(Category category);
        public bool UpdateCategory(Category category);
        public bool DeleteCategory(int id);
        public List<Category> GetCategoryById(Category category);
    }
}
