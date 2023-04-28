﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Products_Received
    {
        private int ReceivedID;
        private int OrderID;
        private int Quantity;
        private DateTime ReceivedDate;

        public Products_Received(int ReceivedID, int OrderID, int Quantity, DateTime ReceivedDate)
        {
            this.ReceivedID = ReceivedID;
            this.OrderID = OrderID;
            this.Quantity = Quantity;
            this.ReceivedDate = ReceivedDate;
        }

        public Products_Received() { }

        public void addQuery()
        {
            string sql = "INSERT INTO Products_Received VALUES(" + ReceivedID + "," + OrderID + "," + Quantity + ",'" + ReceivedDate.ToString("yyyy-MM-dd") + "')";
            Connection.actionQuery(sql);
        }

        public void updateQuery()
        {
            string sql = "UPDATE Products_Received SET OrderID = " + OrderID + ", Quantity = " + Quantity + ", ReceivedDate = '" + ReceivedDate.ToString("yyyy-MM-dd") + "' WHERE ReceivedID = " + ReceivedID;
            Connection.actionQuery(sql);
        }

        public void deleteQuery()
        {
            string sql = "DELETE FROM Products_Received WHERE ReceivedID = " + ReceivedID;
            Connection.actionQuery(sql);
        }

        public DataTable selectQuery()
        {
            string sql = "SELECT * FROM Products_Received";
            return Connection.selectQuery(sql);
        }

        public int generateID()
        {
            string sql = "SELECT MAX(ReceivedID) FROM Products_Received";
            if(selectQuery().Rows.Count > 0)
            {
                return Connection.selectQuery(sql).Rows[0].Field<int>(0) + 1;
            }
            return 1;
        }

        public int getReceivedID()
        {
            return ReceivedID;
        }

        public int getOrderID()
        {
            return OrderID;
        }


        public int getQuantity()
        {
            return Quantity;
        }

        public DateTime getReceivedDate()
        {
            return ReceivedDate;
        }


        public void setReceivedID(int ReceivedID)
        {
            this.ReceivedID = ReceivedID;
        }

        public void setOrderID(int OrderID)
        {
            this.OrderID = OrderID;
        }

        public void setQuantity(int Quantity)
        {
            this.Quantity = Quantity;
        }

        public void setReceivedDate(DateTime ReceivedDate)
        {
            this.ReceivedDate = ReceivedDate;
        }
    }
}
