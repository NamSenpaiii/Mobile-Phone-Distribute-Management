using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Model
{
    public class PO_Details
    {
        private int OrderDetailID;
        private int OrderID;
        private int ProductID;
        private int Quantity;
        private decimal Price;

        public PO_Details(int OrderDetailID, int OrderID, int ProductID, int Quantity, decimal Price)
        {
            this.OrderDetailID = OrderDetailID;
            this.OrderID = OrderID;
            this.ProductID = ProductID;
            this.Quantity = Quantity;
            this.Price = Price;
        }

        public PO_Details() { }

        public void addQuery()
        {
            string sql = "INSERT INTO PO_Details VALUES(@OrderDetailID,@OrderID,@ProductID,@Quantity,@Price)";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@OrderDetailID", OrderDetailID),
                new SqlParameter("@OrderID", OrderID),
                new SqlParameter("@ProductID", ProductID),
                new SqlParameter("@Quantity", Quantity),
                new SqlParameter("@Price", Price)
            };
            Connection.actionQuery(sql, parameters);
        }

        public void updateQuery()
        {
            string sql = "UPDATE PO_Details SET OrderID = @OrderID, ProductID = @ProductID, Quantity = @Quantity, Price = @Price WHERE OrderDetailID = @OrderDetailID";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@OrderDetailID", OrderDetailID),
                new SqlParameter("@OrderID", OrderID),
                new SqlParameter("@ProductID", ProductID),
                new SqlParameter("@Quantity", Quantity),
                new SqlParameter("@Price", Price)
            };
            Connection.actionQuery(sql, parameters);
        }

        public void deleteQuery()
        {
            string sql = "DELETE FROM PO_Details WHERE OrderDetailID = @OrderDetailID";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@OrderDetailID", OrderDetailID)
            };
            Connection.actionQuery(sql, parameters);
        }

        public DataTable selectQuery()
        {
            string sql = "SELECT * FROM PO_Details";
            SqlParameter[] parameters = new SqlParameter[0];
            return Connection.selectQuery(sql, parameters);
        }

        public DataTable orderIDSelectQuery()
        {
            string sql = "SELECT * FROM PO_Details WHERE OrderID = @OrderID";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@OrderID", OrderID)
            };
            return Connection.selectQuery(sql, parameters);
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
