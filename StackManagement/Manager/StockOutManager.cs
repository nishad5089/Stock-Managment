using StackManagement.Gateway;
using StackManagement.Model;

namespace StackManagement.Manager
{
    internal class StockOutManager
    {
        private StockOutGatway stockOutGatway = new StockOutGatway();

        public string SaveStock(StockOut stockOut)
        {
            if (stockOutGatway.StockSave(stockOut) > 0)
            {
                return "Inserted";
            }

            return "Not Inserted";
        }

        public bool IsStockedOut(StockOut stockOut)
        {
            if (stockOutGatway.IsSelledOut(stockOut))
            {
                return true;
            }
            return false;
        }

        public bool IsDamageOut(StockOut stockOut)
        {
            if (stockOutGatway.IsDemagedOut(stockOut))
            {
                return true;
            }
            return false;
        }

        public bool IsLostOut(StockOut stockOut)
        {
            if (stockOutGatway.IsLostOut(stockOut))
            {
                return true;
            }
            return false;
        }

        public string UpdateTakenQuentity(StockOut stockOut)
        {
            if (stockOutGatway.UpdateTakenQuentity(stockOut) > 0)
            {
                return "Updated";
            }

            return "Not Updated";
        }

        public StockOut GetTekenQuentity(StockOut stockOut)
        {
            return stockOutGatway.GetTekenQuentity(stockOut);
        }

        public string UpdateAviableQuentity(StockOut stockOut)
        {
            if (stockOutGatway.UpdateAviableQuentity(stockOut) > 0)
            {
                return "Updated";
            }

            return "Not Updated";
        }
    }
}