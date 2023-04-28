using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controller;

namespace View
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void bLogin_Click(object sender, EventArgs e)
        {

            StaffsController s = new StaffsController(tbUsername.Text,tbPassword.Text); 
            if(s.selectQuery().Rows.Count > 0)
            {
                MainForm mainForm = new MainForm();
                mainForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Login fail");
            }
        }

        private void bCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
