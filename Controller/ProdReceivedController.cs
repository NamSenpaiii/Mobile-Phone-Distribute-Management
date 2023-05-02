using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Model;
using System.Data.SqlClient;

namespace Controller
{
    public class ProdReceivedController
    {
        private Products_Received pr;
        public ProdReceivedController(int ReceivedID, int OrderID, int Quantity, DateTime ReceivedDate) 
        {
            pr = new Products_Received(ReceivedID, OrderID, Quantity, ReceivedDate);
        }

        public ProdReceivedController()
        {
            pr = new Products_Received();
        }

        public bool updateProdReceivedAction()
        {
            Connection.connect();
            using (SqlTransaction transaction = Connection.getConnection().BeginTransaction())
            {
                try
                {
                    updateProductQuantity(1);
                    pr.updateQuery();
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
        public bool addProdReceivedAction()
        {
            Connection.connect();
            using (SqlTransaction transaction = Connection.getConnection().BeginTransaction())
            {
                try
                {
                    pr.addQuery();
                    updateProductQuantity(0);
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
        public bool deleteProdReceivedAction()
        {
            Connection.connect();
            using (SqlTransaction transaction = Connection.getConnection().BeginTransaction())
            {
                try
                {
                    pr.deleteQuery();
                    updateProductQuantity(2);
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

        public bool updateProductQuantity(int action)
        {
            try
            {
                Products p = new Products();
                PO_Details pod = new PO_Details();
                DataTable tmpPOD = new DataTable();
                pod.setOrderID(pr.getOrderID());
                tmpPOD = pod.orderIDSelectQuery();

                p.setProductID(Convert.ToInt32(tmpPOD.Rows[0]["ProductID"]));

                if(tmpPOD.Rows.Count > 0)
                {
                    //get current quantity
                    int currQuantity = Convert.ToInt32(p.selectQuery().Rows[0]["Quantity"]);
                    //action = 0 -> add ,action = 1 -> update , action = 2 -> delete
                    if(action == 0)
                    {
                        p.setQuantity(currQuantity + pr.getQuantity());
                        p.updateQuantity();
                        return true;
                    }
                    if(action == 1)
                    {
                        int quantityChange = pr.getQuantity() - currQuantity;

                        //invalid update quantity
                        if(currQuantity + quantityChange < 0)
                        {
                            return false;
                        }
                        p.setQuantity(currQuantity + quantityChange);
                        p.updateQuantity();
                        return true;
                    }
                    if(action == 2)
                    {
                        p.setQuantity(currQuantity - pr.getQuantity());
                        p.updateQuantity();
                        return true;
                    }
                    return false;
                }
                else
                {
                    return false;
                }
            }catch (Exception)
            {
                return false;
            }
        }

        public bool addQuery()
        {
            try
            {
                pr.addQuery();
                return true;
            }
            catch(Exception e)
            {
                return false;
            }

        }

        public bool updateQuery()
        {
            try
            {
                pr.updateQuery();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public bool deleteQuery()
        {
            try
            {
                pr.deleteQuery();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public DataTable selectQuery()
        {
            return pr.selectQuery();
        }

        public int generateID()
        {
            return pr.generateID();
        }

    }
}
