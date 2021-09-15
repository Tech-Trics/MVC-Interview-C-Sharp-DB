using System;

namespace MVC_Interview_C_Sharp.SOLID.ISP
{
    interface IDiscount
    {
        double getDiscount(double TotalSales);
    }


    interface IDatabase
    {
        void Add(); // old client are happy with these.

        //Now let’s say some new clients come up with a demand saying that we also want a method which will help us to “Read” customer data.
        //So developers who are highly enthusiastic would like to change the “IDatabase” interfaceas shown below.
        void Read(); // Added for new clients.
    }

    class Enquiry : IDiscount
    {
        public double getDiscount(double TotalSales)
        {
            return TotalSales - 5;
        }
    }   
}



