using System;

namespace MVC_Interview_C_Sharp.SOLID.DI
{
    class Customer : IDiscount, IDatabase
    {
        private FileLogger obj = new FileLogger();

        public virtual double getDiscount(double TotalSales)
        {
            return TotalSales;
        }

        public virtual void Add()
        {
            try
            {
                // Database code goes here
            }
            catch (Exception ex)
            {
                obj.Handle(ex.ToString());
                //if (Exhandle == 1)
                //{
                //    obj = new MyException();
                //}
                //else
                //{
                //    obj = new EmailException();
                //}
                obj.Handle(ex.Message.ToString());
            }
        }
    }

    interface ILogger
    {
        void Handle(string error);
    }

    class FileLogger : ILogger
    {
        public void Handle(string error)
        {
            System.IO.File.WriteAllText(@"c:\Error.txt", error);
        }
    }

    class EverViewerLogger : ILogger
    {
        public void Handle(string error)
        {
            // log errors to event viewer
        }
    }

    class EmailLogger : ILogger
    {
        public void Handle(string error)
        {
            // send errors in email
        }
    }

    interface IDiscount
    {
        double getDiscount(double TotalSales);
    }

    interface IDatabase
    {
        void Add();
    }
}




