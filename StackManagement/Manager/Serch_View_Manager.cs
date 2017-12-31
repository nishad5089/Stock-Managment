using StackManagement.Gateway;
using StackManagement.Model;
using System.Collections.Generic;

namespace StackManagement.Manager
{
    internal class Serch_View_Manager
    {
        private Serch_View_Gateway serchViewGateway = new Serch_View_Gateway();

        public List<Serch_View> GetAllRelatedItem()
        {
            return serchViewGateway.GetAllRelatedItem();
        }

        public List<Serch_View> GetWithCompany(Serch_View serchView)
        {
            return serchViewGateway.GetWithCompany(serchView);
        }

        public List<Serch_View> GetWithCategory(Serch_View serchView)
        {
            return serchViewGateway.GetWithCategory(serchView);
        }

        public List<Serch_View> GeWithCatandCom(Serch_View serchView)
        {
            return serchViewGateway.GetWithCompandCat(serchView);
        }
    }
}