using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Products_Received
    {
        private int ReceivedID;
        private int OrderID;
        private int ProductID;
        private int Quantity;
        private DateTime ReceivedDate;
        private string Provider;

        public Products_Received(int ReceivedID, int OrderID, int ProductID, int Quantity, DateTime ReceivedDate, string Provider)
        {
            this.ReceivedID = ReceivedID;
            this.OrderID = OrderID;
            this.ProductID = ProductID;
            this.Quantity = Quantity;
            this.ReceivedDate = ReceivedDate;
            this.Provider = Provider;
        }

        public int getReceivedID()
        {
            return ReceivedID;
        }

        public int getOrderID()
        {
            return OrderID;
        }

        public int getProductID()
        {
            return ProductID;
        }

        public int getQuantity()
        {
            return Quantity;
        }

        public DateTime getReceivedDate()
        {
            return ReceivedDate;
        }

        public string getProvider()
        {
            return Provider;
        }

        public void setReceivedID(int ReceivedID)
        {
            this.ReceivedID = ReceivedID;
        }

        public void setOrderID(int OrderID)
        {
            this.OrderID = OrderID;
        }

        public void setProductID(int ProductID)
        {
            this.ProductID = ProductID;
        }

        public void setQuantity(int Quantity)
        {
            this.Quantity = Quantity;
        }

        public void setReceivedDate(DateTime ReceivedDate)
        {
            this.ReceivedDate = ReceivedDate;
        }
    }
}
