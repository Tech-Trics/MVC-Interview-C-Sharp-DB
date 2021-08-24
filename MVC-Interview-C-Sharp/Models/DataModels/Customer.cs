using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_Interview_C_Sharp.Models.DataModels
{
    public class Customer
    {
        public int CustomerID { get; set; }

        public string NameStyle { get; set; }

        public string Title { get; set; }

        public string FirstName { get; set; }

        public string MiddleName { get; set; }

        public string LastName { get; set; }

        public string Suffix { get; set; }

        public string CompanyName { get; set; }

        public string SalesPerson { get; set; }

        [EmailAddress]
        public string EmailAddress { get; set; }

        [Phone]
        public string Phone { get; set; }

        public string PasswordHash { get; set; }

        public string PasswordSalt { get; set; }

        public string rowguid { get; set; }

        public DateTime ModifiedDate { get; set; }
    }
}
