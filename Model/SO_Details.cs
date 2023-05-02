using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class SO_Details
    {
        private int OrderDetailID;
        private int OrderID;
        private int ProductID;
        private int Quantity;
        private decimal Price;

        public SO_Details(int OrderDetailID, int OrderID, int ProductID, int Quantity, decimal Price)
        {
            this.OrderDetailID = OrderDetailID;
            this.OrderID = OrderID;
            this.ProductID = ProductID;
            this.Quantity = Quantity;
            this.Price = Price;
        }

        public SO_Details() { }

        public void addQuery()
        {
            string sql = "INSERT INTO SO_Details VALUES(@OrderDetailID,@OrderID,@ProductID,@Quantity,@Price)";
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
            string sql = "UPDATE SO_Details SET OrderID = @OrderID, ProductID = @ProductID, Quantity = @Quantity, Price = @Price WHERE OrderDetailID = @OrderDetailID";
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
            string sql = "DELETE FROM SO_Details WHERE OrderDetailID = @OrderDetailID";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@OrderDetailID", OrderDetailID)
            };
            Connection.actionQuery(sql, parameters);
        }

        public DataTable selectQuery()
        {
            string sql = "SELECT * FROM SO_Details WHERE OrderDetailID = @OrderDetailID";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@OrderDetailID", OrderDetailID)
            };
            return Connection.selectQuery(sql, parameters);
        }
        public DataTable idSelectQuery()
        {
            string sql = "SELECT * FROM SO_Details WHERE OrderID = @OrderID";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@OrderID", OrderID)
            };
            return Connection.selectQuery(sql, parameters);
        }
        public DataTable orderIDSelectQuery()
        {
            string sql = "SELECT * FROM SO_Details WHERE OrderID = @OrderID";
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
