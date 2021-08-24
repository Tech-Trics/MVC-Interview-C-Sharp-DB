using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using MVC_Interview_C_Sharp.Models.DataModels;

namespace MVC_Interview_C_Sharp.Data
{
    public class DataAccess
    {
        //What does CRUD stand for?

        //If you needed to implement similar methods for other tables in the DB how could you do it? 

        //Implement for SalesOrderHeader

        public DataAccess()
        {
                
        }

        public List<Customer> GetCustomers()
        {
            //If you were writing this code would you make any changes? Show how you would refactor.

            List<Customer> listOfCustomers = new List<Customer>();
            string sql = "Select * FROM [SalesLT].[Customer]";
            SqlConnection conn = new SqlConnection("Server=tcp:tech-trics-public.database.windows.net,1433;Initial Catalog=C-Sharp-Interview;Persist Security Info=False;User ID=interview;Password=SuperSecret!;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
            SqlCommand cmd = new SqlCommand(sql, conn) { CommandType = CommandType.Text };
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Customer newCustomer = new Customer();
                newCustomer.CustomerID = int.Parse(reader.GetValue("CustomerID").ToString());
                newCustomer.FirstName = reader.GetValue("FirstName").ToString();
                newCustomer.ModifiedDate = DateTime.Parse(reader.GetValue("ModifiedDate").ToString());
                listOfCustomers.Add(newCustomer);
            }
            return listOfCustomers;
        }


        //public List<Customer> GetCustomersByCompanyName(string companyName)
        //{
        //}


        //public bool SaveNewCustomer(Customer newCustomer)
        //{
        //    //implement method
        //}

        //public bool UpdateCustomer(Customer customer)
        //{
        //    //implement method
        //}

        //public bool DeleteCustomer(Customer customer)
        //{
        //    //implement method
        //}
    }
}
