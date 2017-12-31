using StackManagement.Gateway;
using StackManagement.Model;
using System.Collections.Generic;

namespace StackManagement.Manager
{
    internal class CompanyManager
    {
        private CompanyGateway companyGateway = new CompanyGateway();

        public string SaveCompany(Company company)
        {
            if (companyGateway.IsExistCompanyName(company.name))
            {
                return "Category all ready exist";
            }
            if (companyGateway.SaveCompany(company) > 0)
            {
                return "Data Inserted";
            }
            return "Data Not Inserted";
        }

        public List<Company> CompanyList()
        {
            return companyGateway.GetAllCompanies();
        }
        public List<Company> SearchCompanyList(string companpy)
        {
            return companyGateway.SearchCompany(companpy);
        }
    }
}