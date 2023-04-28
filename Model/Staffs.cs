using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Staffs
    {
        private int StaffID;
        private string Username, FirstName, LastName, Email, Password;

        public Staffs(int staffID, string username, string firstName, string lastName, string email, string password)
        {
            this.StaffID = staffID;
            this.Username = username;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Email = email;
            this.Password = password;
        }

        public Staffs(string username,string password)
        {
            this.Username = username;
            this.Password = password;
        }

        public void addQuery()
        {
            string sql = "INSERT INTO Staffs VALUES(" + StaffID + ",'" + Username + "','" + FirstName + "','" + LastName + "','" + Email + "','" + Password + "')";
            Connection.actionQuery(sql);
        }

        public void updateQuery()
        {
            string sql = "UPDATE Staffs SET Username = '" + Username + "', FirstName = '" + FirstName + "', LastName = '" + LastName + "', Email = '" + Email + "', Password = '" + Password + "' WHERE StaffID = " + StaffID;
            Connection.actionQuery(sql);
        }

        public void deleteQuery()
        {
            string sql = "DELETE FROM Staffs WHERE StaffID = " + StaffID;
            Connection.actionQuery(sql);
        }

        public DataTable selectQuery()
        {
            string sql = "SELECT * FROM Staffs WHERE Username = '" + Username + "' AND Password = '" + Password + "'";
            return Connection.selectQuery(sql);
        }

        public int getStaffID()
        {
            return StaffID;
        }

        public string getUsername()
        {
            return Username;
        }

        public string getFirstName()
        {
            return FirstName;
        }

        public string getLastName()
        {
            return LastName;
        }

        public string getEmail()
        {
            return Email;
        }

        public string getPassword()
        {
            return Password;
        }

        public void setStaffID(int staffID)
        {
            this.StaffID = staffID;
        }

        public void setUsername(string username)
        {
            this.Username = username;
        }

        public void setFirstName(string firstName)
        {
            this.FirstName = firstName;
        }

        public void setLastName(string lastName)
        {
            this.LastName = lastName;
        }

        public void setEmail(string email)
        {
            this.Email = email;
        }

        public void setPassword(string password)
        {
            this.Password = password;
        }
    }
}
