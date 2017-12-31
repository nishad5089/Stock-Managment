using StackManagement.Gateway;
using StackManagement.Model;
using System.Collections.Generic;

namespace StackManagement.Manager
{
    internal class CategoriManager
    {
        private CategoryGateway categoryGateway = new CategoryGateway();

        public string SaveCategory(Category category)
        {
            if (categoryGateway.IsExistCatgory(category))
            {
                return "Category all ready exist";
            }
            if (categoryGateway.SaveCategory(category) > 0)
            {
                return "Data Inserted";
            }
            return "Data Not Inserted";
        }

        public List<Category> CategoryList()
        {
            return categoryGateway.GetAllCategories();
        }

        public string UpdateCategory(Category category)
        {
            if (categoryGateway.UpdateCategory(category) > 0)
            {
                return "Updated";
            }

            return "Not Updated";
        }

        public List<Category> GetAllCategory()
        {
            return categoryGateway.GetAllCategories();
        }

        public List<Category> SearchCat(string catgory)
        {
            return categoryGateway.SearchCategories(catgory);
        }
    }
}