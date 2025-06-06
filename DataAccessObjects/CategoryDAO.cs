using BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessObjects
{
    public class CategoryDAO
    {
        private static List<Category> CategoryList;

        public CategoryDAO()
        {
            if (CategoryList == null)
            {
                CategoryList = new List<Category>();
                Category beverages = new Category(1, "Beverages");
                Category condiments = new Category(2, "Condiments");
                Category confections = new Category(3, "Confections");
                Category dairy = new Category(4, "Dairy Products");
                Category grains = new Category(5, "Grains/Cereals");
                Category meat = new Category(6, "Meat/Poultry");
                Category produce = new Category(7, "Produce");
                Category seafood = new Category(8, "Seafood");

                try
                {
                    CategoryList.Add(beverages);
                    CategoryList.Add(condiments);
                    CategoryList.Add(confections);
                    CategoryList.Add(dairy);
                    CategoryList.Add(grains);
                    CategoryList.Add(meat);
                    CategoryList.Add(produce);
                    CategoryList.Add(seafood);
                }
                catch (Exception e)
                {
                    throw new Exception(e.Message);
                }
            }
        }

        public List<Category> GetCategories()
        {
            return CategoryList;
        }

        public void SaveCategory(Category c)
        {
            CategoryList.Add(c);
        }

        public void UpdateCategory(Category category)
        {
            foreach (Category c in CategoryList.ToList())
            {
                if (c.CategoryId == category.CategoryId)
                {
                    c.CategoryId = category.CategoryId;
                    c.CategoryName = category.CategoryName;
                }
            }
        }

        public void DeleteCategory(Category category)
        {
            foreach (Category c in CategoryList.ToList())
            {
                if (c.CategoryId == category.CategoryId)
                {
                    CategoryList.Remove(c);
                }
            }
        }

        public Category GetCategoryById(int id)
        {
            foreach (Category c in CategoryList.ToList())
            {
                if (c.CategoryId == id)
                {
                    return c;
                }
            }
            return null;
        }
    }
}