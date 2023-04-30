using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Model;

namespace Controller
{
    public class ProdDeliveryController
    {
        Products_Delivery pd;
        public ProdDeliveryController(int DeliveryID, int OrderID, int Quantity, int Delivery, int Payment, DateTime DeliveryDate)
        {
            pd = new Products_Delivery(DeliveryID, OrderID, Quantity, Delivery, Payment, DeliveryDate);
        }

        public ProdDeliveryController()
        {
            pd = new Products_Delivery();
        }

        public void addQuery()
        {
            pd.addQuery();
        }

        public void updateQuery()
        {
            pd.updateQuery();
        }

        public void deleteQuery()
        {
            pd.deleteQuery();
        }

        public DataTable selectQuery()
        {
            return pd.selectQuery();
        }

        public int generateID()
        {
            return pd.generateID();
        }
        public DataTable ReadFileFromResources(string fileName)
        {
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("DisplayMember", typeof(string));
            dataTable.Columns.Add("ValueMember", typeof(string));

            string fileContents = Properties.Resources.ResourceManager.GetString(fileName);
            string[] lines = fileContents.Split(new[] { Environment.NewLine }, StringSplitOptions.None);
            foreach (string line in lines)
            {
                string[] data = line.Split(',');
                DataRow row = dataTable.NewRow();
                row["DisplayMember"] = data[0];
                row["ValueMember"] = data[1];
                dataTable.Rows.Add(row);
            }

            return dataTable;
        }

    }
}
