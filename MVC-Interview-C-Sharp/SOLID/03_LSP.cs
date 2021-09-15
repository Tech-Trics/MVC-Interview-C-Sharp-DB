using System;

namespace MVC_Interview_C_Sharp.SOLID.LSP
{
    public class Customer
    {
        public virtual double getDiscount(double TotalSales)
        {
            return TotalSales;
        }

        public virtual void Add()
        {
            //Add Customer
        }
    }

    public class SilverCustomer : Customer
    {
        public override double getDiscount(double TotalSales)
        {
            return base.getDiscount(TotalSales) - 50;
        }

        public override void Add()
        {
            //Add Silver Customer
        }
    }

    public class GoldCustomer : Customer
    {
        public override double getDiscount(double TotalSales)
        {
            return base.getDiscount(TotalSales) - 100;
        }

        public override void Add()
        {
            //Add Gold Customer
        }
    }

    public class Enquiry : Customer
    {
        public override double getDiscount(double TotalSales)
        {
            return base.getDiscount(TotalSales) - 5;
        }

        public override void Add()
        {
            throw new Exception("Not allowed");
        }
    }

    /*
    List<Customer> Customers = new List<Customer>();
    Customers.Add(new SilverCustomer());
    Customers.Add(new goldCustomer());
    Customers.Add(new Enquiry());

     foreach (Customer o in Customers)
    {
        o.Add();
    }
    */

}



