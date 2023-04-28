using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Orders
    {
        private int OrderID;
        private int StaffID;
        private DateTime OrderDate;

        public Orders(int OrderID, int StaffID, DateTime OrderDate)
        {
            this.OrderID = OrderID;
            this.StaffID = StaffID;
            this.OrderDate = OrderDate;
        }

        public void addQuery()
        {
            string sql = "INSERT INTO Orders VALUES(" + OrderID + ", " + StaffID + ", '" + OrderDate + "')";
            Connection.actionQuery(sql);
        }

        public void updateQuery()
        {
            string sql = "UPDATE Orders SET StaffID = " + StaffID + ", OrderDate = '" + OrderDate + "' WHERE OrderID = " + OrderID;
            Connection.actionQuery(sql);
        }

        public void deleteQuery()
        {
            string sql = "DELETE FROM Orders WHERE OrderID = " + OrderID;
            Connection.actionQuery(sql);
        }

        public DataTable selectQuery()
        {
            string sql = "SELECT * FROM Orders";
            return Connection.selectQuery(sql);
        }
        public int getOrderID()
        {
            return OrderID;
        }

        public int getStaffID()
        {
            return StaffID;
        }

        public DateTime getOrderDate()
        {
            return OrderDate;
        }

        public void setOrderID(int OrderID)
        {
            this.OrderID = OrderID;
        }

        public void setStaffID(int StaffID)
        {
            this.StaffID = StaffID;
        }

        public void setOrderDate(DateTime OrderDate)
        {
            this.OrderDate = OrderDate;
        }
    }
}
