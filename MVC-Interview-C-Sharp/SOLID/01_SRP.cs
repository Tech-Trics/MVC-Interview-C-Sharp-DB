using System;

namespace MVC_Interview_C_Sharp.SOLID.SRP
{

    #region SRP
    public class Customer
    {
        public void Add()
        {
            try
            {
                // Database code goes here
            }
            catch (Exception ex)
            {
                System.IO.File.WriteAllText(@"c:\Error.txt", ex.ToString());
            }
        }
    }

    #endregion
}

