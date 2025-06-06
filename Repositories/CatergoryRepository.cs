using BusinessObjects;
using DataAccessObjects;
using System.Collections.Generic;

namespace Repositories
{
   public class CategoryRepository : ICatergoryRepository
    {
        private readonly CategoryDAO _categoryDAO;
        public CategoryRepository()
        {
            _categoryDAO = new CategoryDAO();
        }
        public void SaveCategory(Category c) => _categoryDAO.SaveCategory(c);
        public void DeleteCategory(Category c) => _categoryDAO.DeleteCategory(c);
        public void UpdateCategory(Category c) => _categoryDAO.UpdateCategory(c);
        public List<Category> GetCategories() => _categoryDAO.GetCategories();
        public Category GetCategoryById(int id) => _categoryDAO.GetCategoryById(id);
    }
}
