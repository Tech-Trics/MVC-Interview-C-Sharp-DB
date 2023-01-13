using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MVC_Interview_C_Sharp.Models.DataModels;

namespace MVC_Interview_C_Sharp.ExampleClasses
{
    public interface ICollectionExample
    {
        /// <summary>
        /// Return the count of customers that work with the specified company
        /// </summary>
        /// <param name="companyName"></param>
        /// <param name="customers"></param>
        /// <returns></returns>
        public int SumOfCustomersByCompanName(string companyName, List<Customer> customers);

        /// <summary>
        /// Shows Customer who have a middle name populated in the system
        /// </summary>
        /// <param name="customers"></param>
        /// <returns></returns>
        public List<Customer> CustomersWithMiddleNames(List<Customer> customers);

        /// <summary>
        /// Order List by customer Last Name
        /// </summary>
        /// <param name="customers"></param>
        /// <returns></returns>
        public List<Customer> SortListByCustomerName(List<Customer> customers);

        /// <summary>
        /// Removes duplicate letters from a customers name. For example, if passing in the name Matt, then Ma is returned
        /// </summary>
        /// <param name="letterToRemove"></param>
        /// <returns></returns>
        public string GetCustomerNamesAndRemoveDuplicateLetters(char letterToRemove);

        /// <summary>
        /// Counts occurance of letter. For example, if the name Matt is passed in and we are counting the letter T we should expect 
        /// T = 2
        /// </summary>
        /// <param name="letterToCount"></param>
        /// <returns></returns>
        public int  GetCustomerNamesAndCountOccuranceOfLetter(char letterToCount, string name);

        /// <summary>
        /// Use linq and see if you can come up with at least two more ways.
        /// </summary>
        /// <param name="customers"></param>
        /// <returns></returns>
        public List<string> DistinctListOfCustomerNames(List<Customer> customers);

        /// <summary>
        /// For each customer in the list, reverse their first name. For Example, if customer[0] name is Matt we would expect to see customer[0].FirstName = ttaM
        /// </summary>
        /// <param name="customers"></param>
        /// <returns></returns>
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
