using StackManagement.Gateway;
using StackManagement.Model;
using System.Collections.Generic;

namespace StackManagement.Manager
{
    internal class StockManager
    {
        private StockInGateway stockInGateway = new StockInGateway();

        public string SaveStock(StockIn stockIn)
        {
            if (stockInGateway.SaveStock(stockIn) > 0)
            {
                return "Data Inserted";
            }
            return "Data Not Inserted";
        }

        public List<Item> GetAllItemwithCompId(int cmpId)
        {
            return stockInGateway.GetItemWithCompany(cmpId);
        }

        public StockIn GetStockIn(int stockId)
        {
            return stockInGateway.GetSignleStock(stockId);
        }

        public string ExistItem(StockIn stockIn)
        {
            if (stockInGateway.IsExistItem(stockIn))
            {
                return "Exist";
            }
            return "NotExist";
        }

        public string UpdateQuentity(StockIn stockIn)
        {
            if (stockInGateway.UpdateQuentity(stockIn) > 0)
            {
                return "Updated";
            }

            return "Not Updated";
        }
    }
}