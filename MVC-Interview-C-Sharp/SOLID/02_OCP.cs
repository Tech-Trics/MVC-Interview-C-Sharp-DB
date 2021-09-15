namespace MVC_Interview_C_Sharp.SOLID.OCP
{
    #region OCP
    public class Customer
    {
        private int _CustType;

        public int CustType
        {
            get { return _CustType; }
            set { _CustType = value; }
        }

        public double getDiscount(double TotalSales)
        {
            if (_CustType == 1)
            {
                return TotalSales - 100;
            }
            else
            {
                return TotalSales - 50;
            }
        }
    }

    #endregion
}

