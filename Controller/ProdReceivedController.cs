using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Model;

namespace Controller
{
    public class ProdReceivedController
    {
        Products_Received pr;
        public ProdReceivedController(int ReceivedID, int OrderID, int Quantity, DateTime ReceivedDate) 
        {
            pr = new Products_Received(ReceivedID, OrderID, Quantity, ReceivedDate);
        }

        public ProdReceivedController()
        {
            pr = new Products_Received();
        }

        public void addQuery()
        {
            pr.addQuery();
        }

        public void updateQuery()
        {
            pr.updateQuery();
        }

        public void deleteQuery()
        {
            pr.deleteQuery();
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
