using StackManagement.Gateway;
using StackManagement.Model;
using System.Collections.Generic;

namespace StackManagement.Manager
{
    internal class ItemManager
    {
        private CategoryGateway categoryGateway = new CategoryGateway();
        private CompanyGateway companyGateway = new CompanyGateway();
        private ItemGateway itemGateway = new ItemGateway();

        public List<Category> GetAllCategory()
        {
            return categoryGateway.GetAllCategories();
        }

        public List<Company> GetAllCompany()
        {
            return companyGateway.GetAllCompanies();
        }

        public string SaveItem(Item item)
        {
            if (itemGateway.IsExistItem(item))
            {
                return "Item Already Exist";
            }
            if (itemGateway.SaveItem(item) > 0)
            {
                return "Inseted";
            }
            return "Not Inserted";
        }

        public List<Item> GetAllItem()
        {
            return itemGateway.GetAllItems();
        }
    }
}