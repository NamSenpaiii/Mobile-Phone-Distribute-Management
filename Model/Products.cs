using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Model
{
    public class Products
    {
        private int ProductID;
        private string Name;
        private string Description;
        private decimal Price;
        private int Quantity;
        private string Provider;

        public Products(int ProductID, string Name, string Description, decimal Price, int Quantity, string Provider)
        {
            this.ProductID = ProductID;
            this.Name = Name;
            this.Description = Description;
            this.Price = Price;
            this.Quantity = Quantity;
            this.Provider = Provider;
        }
        public Products() { }

        public void addQuery()
        {
            string sql = "INSERT INTO Products VALUES(@ProductID,@Name,@Description,@Price,@Quantity,@Provider)";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@ProductID", ProductID),
                new SqlParameter("@Name", Name),
                new SqlParameter("@Description", Description),
                new SqlParameter("@Price", Price),
                new SqlParameter("@Quantity", Quantity),
                new SqlParameter("@Provider", Provider)
            };
            Connection.actionQuery(sql, parameters);
        }

        public void updateQuery()
        {
            string sql = "UPDATE Products SET Name = @Name, Description = @Description, Price = @Price, Quantity = @Quantity, Provider = @Provider WHERE ProductID = @ProductID";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@ProductID", ProductID),
                new SqlParameter("@Name", Name),
                new SqlParameter("@Description", Description),
                new SqlParameter("@Price", Price),
                new SqlParameter("@Quantity", Quantity),
                new SqlParameter("@Provider", Provider)
            };
            Connection.actionQuery(sql, parameters);
        }

        public void updateQuantity()
        {
            string sql = "UPDATE Products SET Quantity = @Quantity WHERE ProductID = @ProductID";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@ProductID", ProductID),
                new SqlParameter("@Quantity", Quantity)
            };
            Connection.actionQuery(sql, parameters);
        }

        public void deleteQuery()
        {
            string sql = "DELETE FROM Products WHERE ProductID = @ProductID";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@ProductID", ProductID)
            };
            Connection.actionQuery(sql, parameters);
        }

        public DataTable selectQuery()
        {
            string sql = "SELECT * FROM Products";
            SqlParameter[] parameters = new SqlParameter[0];
            return Connection.selectQuery(sql, parameters);
        }

        public int getProductID()
        {
            return ProductID;
        }
        public string getName()
        {
            return Name;
        }
        public string getDescription()
        {
            return Description;
        }

        public int getQuantity()
        {
            return Quantity;
        }
        public decimal getPrice()
        {
            return Price;
        }

        public void setPrice(decimal Price) { this.Price = Price; }

        public void setName(string Name) { this.Name = Name; }

        public void setDescription(string Description) { this.Description = Description; }

        public void setProductID(int ProductID) { this.ProductID = ProductID; }

        public void setQuantity(int Quantity) { this.Quantity = Quantity; }
    }
}
