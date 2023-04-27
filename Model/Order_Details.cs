using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Order_Details
    {
        private int OrderDetailID;
        private int OrderID;
        private int ProductID;
        private int Quantity;
        private decimal Price;

        public Order_Details(int OrderDetailID, int OrderID, int ProductID, int Quantity, decimal Price)
        {
            this.OrderDetailID = OrderDetailID;
            this.OrderID = OrderID;
            this.ProductID = ProductID;
            this.Quantity = Quantity;
            this.Price = Price;
        }

        public int getOrderDetailID()
        {
            return OrderDetailID;
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

        public decimal getPrice()
        {
            return Price;
        }

        public void setOrderDetailID(int OrderDetailID)
        {
            this.OrderDetailID = OrderDetailID;
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

        public void setPrice(decimal Price)
        {
            this.Price = Price;
        }
    }
}
