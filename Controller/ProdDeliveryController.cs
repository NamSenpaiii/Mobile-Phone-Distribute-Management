using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Model;
using System.Data.SqlClient;
using static System.Collections.Specialized.BitVector32;
using System.Net.NetworkInformation;

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

        public bool updateProdDeliveryAction()
        {
            Connection.connect();
            using (SqlTransaction transaction = Connection.getConnection().BeginTransaction())
            {
                try
                {
                    if(pd.getDelivery() == 2)
                    {
                        updateProductQuantity(1);
                    }
                    pd.updateQuery();
                    transaction.Commit();
                    return true;
                }
                catch (Exception)
                {
                    transaction.Rollback();
                    return false;
                }
            }
        }

        public bool addProdDeliveryAction()
        {
            Connection.connect();
            using (SqlTransaction transaction = Connection.getConnection().BeginTransaction())
            {
                try
                {
                    if (pd.getDelivery() == 2)
                    {
                        updateProductQuantity(0);
                    }
                    pd.addQuery();
                    transaction.Commit();
                    return true;
                }
                catch (Exception)
                {
                    transaction.Rollback();
                    return false;
                }
            }
        }

        public bool deleteProdDeliveryAction()
        {
            Connection.connect();
            using (SqlTransaction transaction = Connection.getConnection().BeginTransaction())
            {
                try
                {
                    if (pd.getDelivery() == 2)
                    {
                        updateProductQuantity(2);
                    }
                    pd.deleteQuery();
                    transaction.Commit();
                    return true;
                }
                catch (Exception)
                {
                    transaction.Rollback();
                    return false;
                }
            }
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

        public bool updateProductQuantity(int action)
        {
            try
            {
                Products p = new Products();
                SO_Details sod = new SO_Details();
                DataTable tmpSOD = new DataTable();
                sod.setOrderID(pd.getOrderID());
                tmpSOD = sod.orderIDSelectQuery();
                p.setProductID(Convert.ToInt32(tmpSOD.Rows[0]["ProductID"]));
                if (tmpSOD.Rows.Count > 0)
                {
                    //get current quantity
                    int currQuantity = Convert.ToInt32(p.selectQuery().Rows[0]["Quantity"]);
                    //action = 0 -> add ,action = 1 -> update , action = 2 -> delete
                    if (action == 0)
                    {
                        p.setQuantity(currQuantity - pd.getQuantity());
                        p.updateQuantity();
                        return true;
                    }
                    if (action == 1)
                    {
                        int oldQuantity = Convert.ToInt32(pd.idSelectQuery().Rows[0]["Quantity"]);
                        int quantityChange = pd.getQuantity() - oldQuantity;

                        //invalid quantity change
                        if(currQuantity - quantityChange < 0)
                        {
                            return false;
                        }

                        //quantityChange = 0 -> user update delivery status
                        if(quantityChange == 0)
                        {
                            p.setQuantity(currQuantity - pd.getQuantity());
                        }
                        else
                        {
                            p.setQuantity(currQuantity - quantityChange);
                        }
                        p.updateQuantity();
                        return true;
                    }
                    if (action == 2)
                    {
                        p.setQuantity(currQuantity + pd.getQuantity());
                        p.updateQuantity();
                        return true;
                    }
                    return false;
                }
                else
                {
                    return false;
                }
            }catch(Exception)
            {
                return false;
            }
        }

    }
}
