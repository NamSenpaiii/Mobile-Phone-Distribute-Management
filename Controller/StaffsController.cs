using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using Model;
using System.Data;

namespace Controller
{
    public class StaffsController
    {
        Staffs s;
        
        public StaffsController(int staffID, string username, string firstName, string lastName, string email, string password)
        {
            s = new Staffs(staffID, username, firstName, lastName, email, password);
        }

        public StaffsController(string username, string password)
        {
            s = new Staffs(username, password);
        }

        public bool checkLogin()
        {
            if(s.getUsername().Contains("-") || s.getPassword().Contains("-") ||
               s.getUsername().Contains("'") || s.getPassword().Contains("'"))
            {
                return false;
            }
            DataTable dt = s.selectQuery();
            if (dt.Rows.Count > 0)
            {
                return true;
            }
            return false;
        }

        public void addQuery()
        {
            s.addQuery();
        }

        public void updateQuery()
        {
            s.updateQuery();
        }

        public void deleteQuery()
        {
            s.deleteQuery();
        }

        public DataTable selectQuery()
        {
            return s.selectQuery();
        }
        
    }
}
