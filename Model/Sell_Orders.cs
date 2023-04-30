using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Sell_Orders
    {
        private int OrderID;
        private int CustomerID;
        private DateTime OrderDate;

        public Sell_Orders(int OrderID, int CustomerID, DateTime OrderDate)
        {
            this.OrderID = OrderID;
            this.CustomerID = CustomerID;
            this.OrderDate = OrderDate;
        }

        public void addQuery()
        {
            string sql = "INSERT INTO Sell_Orders VALUES(" + OrderID + ", " + CustomerID + ", '" + OrderDate + "')";
            Connection.actionQuery(sql);
        }

        public void updateQuery()
        {
            string sql = "UPDATE Sell_Orders SET CustomerID = " + CustomerID + ", OrderDate = '" + OrderDate + "' WHERE OrderID = " + OrderID;
            Connection.actionQuery(sql);
        }

        public void deleteQuery()
        {
            string sql = "DELETE FROM Sell_Orders WHERE OrderID = " + OrderID;
            Connection.actionQuery(sql);
        }

        public int getOrderID()
        {
            return OrderID;
        }

        public int getCustomerID()
        {
            return CustomerID;
        }

        public DateTime getOrderDate()
        {
            return OrderDate;
        }

        public void setOrderID(int OrderID)
        {
            this.OrderID = OrderID;
        }

        public void setCustomerID(int CustomerID)
        {
            this.CustomerID = CustomerID;
        }

        public void setOrderDate(DateTime OrderDate)
        {
            this.OrderDate = OrderDate;
        }
    }
}
