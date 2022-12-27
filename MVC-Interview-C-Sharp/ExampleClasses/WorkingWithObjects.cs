using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MVC_Interview_C_Sharp.Models.DataModels;

namespace MVC_Interview_C_Sharp.ExampleClasses
{
    public interface ICollectionExample
    {
        public int SumOfCustomersByCompanName(string companyName, List<Customer> customers);

        public List<Customer> CustomersWithMiddleNames(List<Customer> customers);

        public string GetCustomerNamesAndRemoveDuplicateLetters(char letterToRemove);

        public string GetCustomerNamesAndCountOccuranceOfLetter(char letterToCount);

        public List<Customer> SortListByCustomerName(List<Customer> customers);

        /// <summary>
        /// Use linq and see if you can come up with at least two more ways.
        /// </summary>
        /// <param name="customers"></param>
        /// <returns></returns>
        public List<string> DistinctListOfCustomerNames(List<Customer> customers);

        public List<Customer> ReverseCustomerNames(List<Customer> customers);


        /// <summary>
        /// Use FName and LName
        /// </summary>
        /// <param name="customers"></param>
        /// <returns></returns>
        public List<Customer> GetUniqueCustomers(List<Customer> customers);
    }

    //Implement Interface Here

}
