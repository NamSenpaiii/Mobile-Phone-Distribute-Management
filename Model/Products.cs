using System;
using System.Collections.Generic;
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
