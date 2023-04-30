using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace View
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void receivedNoteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReceivedNoteForm frm = new ReceivedNoteForm();
            frm.MdiParent = this;
            frm.Show();

        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void deliveryNoteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeliveryNoteForm frm = new DeliveryNoteForm();
            frm.MdiParent = this;
            frm.Show();
        }
    }
}
