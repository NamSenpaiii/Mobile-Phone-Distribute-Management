using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Model
{
    public class Products_Delivery
    {
        public int DeliveryID;
        public int OrderID;
        public int Quantity;
        public int Delivery;
        public int Payment;
        public DateTime DeliveryDate;

        public Products_Delivery(int DeliveryID, int OrderID, int Quantity, int Delivery, int Payment, DateTime DeliveryDate)
        {
            this.DeliveryID = DeliveryID;
            this.OrderID = OrderID;
            this.Quantity = Quantity;
            this.Delivery = Delivery;
            this.Payment = Payment;
            this.DeliveryDate = DeliveryDate;
        }

        public Products_Delivery() { }

        public void addQuery()
        {
            string sql = "INSERT INTO Products_Delivery VALUES(" + DeliveryID + "," + OrderID + "," + Quantity + "," + Delivery + "," + Payment + ",'" + DeliveryDate + "')";
            Connection.actionQuery(sql);
        }

        public void updateQuery()
        {
            string sql = "UPDATE Products_Delivery SET OrderID = " + OrderID + ", Quantity = " + Quantity + ", Delivery = " + Delivery + ", Payment = " + Payment + ", DeliveryDate = '" + DeliveryDate + "' WHERE DeliveryID = " + DeliveryID;
            Connection.actionQuery(sql);
        }

        public void deleteQuery()
        {
            string sql = "DELETE FROM Products_Delivery WHERE DeliveryID = " + DeliveryID;
            Connection.actionQuery(sql);
        }

        public DataTable selectQuery()
        {
            string sql = "SELECT * FROM Products_Delivery";
            return Connection.selectQuery(sql);
        }

        public int generateID()
        {
            string sql = "SELECT MAX(DeliveryID) FROM Products_Delivery";
            if (selectQuery().Rows.Count > 0)
            {
                return Connection.selectQuery(sql).Rows[0].Field<int>(0) + 1;
            }
            return 1;
        }

        public int getDeliveryID()
        {
            return DeliveryID;
        }

        public int getOrderID()
        {
            return OrderID;
        }

        public int getQuantity()
        {
            return Quantity;
        }

        public int getDelivery()
        {
            return Delivery;
        }

        public int getPayment()
        {
            return Payment;
        }

        public DateTime getDeliveryDate()
        {
            return DeliveryDate;
        }

        public void setDeliveryID(int DeliveryID)
        {
            this.DeliveryID = DeliveryID;
        }

        public void setOrderID(int OrderID)
        {
            this.OrderID = OrderID;
        }

        public void setQuantity(int Quantity)
        {
            this.Quantity = Quantity;
        }

        public void setDelivery(int Delivery)
        {
            this.Delivery = Delivery;
        }

        public void setPayment(int Payment)
        {
            this.Payment = Payment;
        }

        public void setDeliveryDate(DateTime DeliveryDate)
        {
            this.DeliveryDate = DeliveryDate;
        }
    }
}
