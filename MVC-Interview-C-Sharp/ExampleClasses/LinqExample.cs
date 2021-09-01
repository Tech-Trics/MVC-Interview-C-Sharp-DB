using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MVC_Interview_C_Sharp.Models.DataModels;

namespace MVC_Interview_C_Sharp.ExampleClasses
{
    public interface ICollectionExample
    {
        public List<Customer> SortListByName(List<Customer> customers);

        public int SumOfCustomersByCompanName(string companyName);

        public List<Customer> CustomersWithMiddleNames(List<Customer> customers);
    }

    //Implement Interface Here

}
