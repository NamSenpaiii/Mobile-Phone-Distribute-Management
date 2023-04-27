using System;
using System.Collections.Generic;
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
