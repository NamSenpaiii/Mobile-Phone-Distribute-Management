using System;
using System.Collections.Generic;
using System.Data;
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

        public Products(int ProductID, string Name, string Description, decimal Price)
        {
            this.ProductID = ProductID;
            this.Name = Name;
            this.Description = Description;
            this.Price = Price;
        }

        public void addQuery()
        {
            string sql = "INSERT INTO Products VALUES(" + ProductID + ",'" + Name + "','" + Description + "'," + Price + ")";
            Connection.actionQuery(sql);
        }

        public void updateQuery()
        {
            string sql = "UPDATE Products SET Name = '" + Name + "', Description = '" + Description + "', Price = " + Price + " WHERE ProductID = " + ProductID;
            Connection.actionQuery(sql);
        }

        public void deleteQuery()
        {
            string sql = "DELETE FROM Products WHERE ProductID = " + ProductID;
            Connection.actionQuery(sql);
        }

        public DataTable selectQuery()
        {
            string sql = "SELECT * FROM Products";
            return Connection.selectQuery(sql);
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
        public decimal getPrice()
        {
            return Price;
        }

        public void setPrice(decimal Price) { this.Price = Price; }

        public void setName(string Name) { this.Name = Name; }

        public void setDescription(string Description) { this.Description = Description; }

        public void setProductID(int ProductID) { this.ProductID = ProductID; }

    }
}
