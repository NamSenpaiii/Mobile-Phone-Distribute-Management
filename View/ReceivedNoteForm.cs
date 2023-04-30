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
    public partial class ReceivedNoteForm : Form
    {
        private int condition = 0;
        public ReceivedNoteForm()
        {
            InitializeComponent();
        }

        private void ReceivedNoteForm_Load(object sender, EventArgs e)
        {
            load();
        }

        public void load()
        {
            disable(grbInformation);
            showGrid();
            bNew.Enabled = true;
            bDelete.Enabled = true;
            bEdit.Enabled = true;
            bSave.Enabled = false;
            bCancel.Enabled = false;
            dataGridView.Enabled = true;
        }

        public void clear()
        {
            tbID.Text = "";
            tbOrderID.Text = "";
            tbQuantity.Text = "";
            dtReceivedDate.Value = DateTime.Now;
        }
        
        public bool selected()
        {
            if (dataGridView.CurrentRow == null)
            {
                return false;
            }
            if (dataGridView.CurrentRow.Cells[0].Value.ToString() != "")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void enable(GroupBox groupBox)
        {
            groupBox.Enabled = true;
        }

        public void disable(GroupBox groupBox)
        {
            groupBox.Enabled = false;
        }

        public void showGrid()
        {
            ProdReceivedController controller = new ProdReceivedController();
            dataGridView.DataSource = controller.selectQuery();
        }

        private void bNew_Click(object sender, EventArgs e)
        {
            enable(grbInformation);
            bNew.Enabled = false;
            bDelete.Enabled = false;
            bEdit.Enabled = false;
            bSave.Enabled = true;
            bCancel.Enabled = true;
            dataGridView.Enabled = false;
            ProdReceivedController controller = new ProdReceivedController();

            tbID.Text = controller.generateID().ToString();
            condition = 1;
        }

        private void bSave_Click(object sender, EventArgs e)
        {
            if(condition == 1)
            {
                ProdReceivedController pr = new ProdReceivedController(Convert.ToInt32(tbID.Text), Convert.ToInt32(tbOrderID.Text), Convert.ToInt32(tbQuantity.Text), Convert.ToDateTime(dtReceivedDate.Value.ToShortDateString()));
                pr.addQuery();
                MessageBox.Show("Add success","Action status");
                condition = 0;
                load();
            }
            else if(condition == 2)
            {
                ProdReceivedController pr = new ProdReceivedController(Convert.ToInt32(tbID.Text), Convert.ToInt32(tbOrderID.Text), Convert.ToInt32(tbQuantity.Text), Convert.ToDateTime(dtReceivedDate.Value.ToShortDateString()));
                pr.updateQuery();
                MessageBox.Show("Update success", "Action status");
                condition = 0;
                load();
            }
            else
            {
                condition = 0;
                load();
            }
        }

        private void bDelete_Click(object sender, EventArgs e)
        {
            if (!selected())
            {
                MessageBox.Show("Please select a record to delete", "Action status");
                load();
                return;
            }
            if(MessageBox.Show("Are you sure to delete this record?","Action confirm",MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                ProdReceivedController pr = new ProdReceivedController(Convert.ToInt32(tbID.Text), Convert.ToInt32(tbOrderID.Text), Convert.ToInt32(tbQuantity.Text), Convert.ToDateTime(dtReceivedDate.Value.ToShortDateString()));
                pr.deleteQuery();
                MessageBox.Show("Delete success", "Action status");
                load();
            }else
            {
                MessageBox.Show("Delete Cancel", "Action status");
                load();
            }
        }

        private void dataGridView_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dataGridView.CurrentRow.Cells[0].Value.ToString() != "")
            {
                tbID.Text = dataGridView.CurrentRow.Cells[0].Value.ToString();
                tbOrderID.Text = dataGridView.CurrentRow.Cells[1].Value.ToString();
                tbQuantity.Text = dataGridView.CurrentRow.Cells[2].Value.ToString();
                dtReceivedDate.Value = Convert.ToDateTime(dataGridView.CurrentRow.Cells[3].Value.ToString());
            }
        }

        private void bEdit_Click(object sender, EventArgs e)
        {
            if (selected())
            {
                bNew.Enabled = false;
                bDelete.Enabled = false;
                bEdit.Enabled = false;
                bSave.Enabled = true;
                bCancel.Enabled = true;
                dataGridView.Enabled = false;
                enable(grbInformation);
                condition = 2;
            }
            else
            {
                MessageBox.Show("Please select a record to edit", "Alert");
            }

        }

        private void bCancel_Click(object sender, EventArgs e)
        {
            clear();
            load();
        }
    }
}
