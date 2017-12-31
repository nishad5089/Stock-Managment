using StackManagement.Gateway;
using StackManagement.Model;
using System.Collections.Generic;

namespace StackManagement.Manager
{
    internal class SaleManager
    {
        private SaleViewGateway saleViewGateway = new SaleViewGateway();

        public List<SaleView> GetAllSaledItem(string fromDate, string toDate)
        {
            return saleViewGateway.GetAllSaledItems(fromDate, toDate);
        }
    }
}