using Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace View
{
    public partial class DeliveryNoteForm : Form
    {
        private int condition = 0;
        public DeliveryNoteForm()
        {
            InitializeComponent();
        }

        private void DeliveryNoteForm_Load(object sender, EventArgs e)
        {
            load();
            ProdDeliveryController controller = new ProdDeliveryController();
            importDataToComboBox(cbDelivery, controller.ReadFileFromResources("DeliveryCB"));
            importDataToComboBox(cbPayment, controller.ReadFileFromResources("PaymentCB"));
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
            dtDeliveryDate.Value = DateTime.Now;
            cbDelivery.SelectedIndex = 0;
            cbPayment.SelectedIndex = 0;
        }

        public bool selected()
        {
            DataGridViewCell cell = dataGridView.CurrentRow.Cells[0];
            if (dataGridView.CurrentRow.Cells[0].Value == null)
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
            ProdDeliveryController controller = new ProdDeliveryController();
            dataGridView.DataSource = controller.selectQuery();
        }

        private void importDataToComboBox(ComboBox comboBox, DataTable dataTable)
        {
            comboBox.DataSource = dataTable;
            comboBox.DisplayMember = "DisplayMember";
            comboBox.ValueMember = "ValueMember";
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

            ProdDeliveryController controller = new ProdDeliveryController();
            tbID.Text = controller.generateID().ToString();
            condition = 1;
        }

        private void bSave_Click(object sender, EventArgs e)
        {
            if (condition == 1)
            {
                ProdDeliveryController pd = new ProdDeliveryController(Convert.ToInt32(tbID.Text), Convert.ToInt32(tbOrderID.Text), Convert.ToInt32(tbQuantity.Text), Convert.ToInt32(cbDelivery.SelectedIndex), Convert.ToInt32(cbPayment.SelectedIndex), Convert.ToDateTime(dtDeliveryDate.Value.ToShortDateString()));
                if(pd.addProdDeliveryAction())
                {
                    MessageBox.Show("Add success", "Action status");
                }
                else
                {
                    MessageBox.Show("Add failed", "Action status");
                }
                condition = 0;
                clear();
                load();
            }
            else if (condition == 2)
            {
                ProdDeliveryController pd = new ProdDeliveryController(Convert.ToInt32(tbID.Text), Convert.ToInt32(tbOrderID.Text), Convert.ToInt32(tbQuantity.Text), Convert.ToInt32(cbDelivery.SelectedIndex), Convert.ToInt32(cbPayment.SelectedIndex), Convert.ToDateTime(dtDeliveryDate.Value.ToShortDateString()));
                if(pd.updateProdDeliveryAction())
                {
                    MessageBox.Show("Update success", "Action status");
                }
                else
                {
                    MessageBox.Show("Update failed", "Action status");
                }
                condition = 0;
                clear();
                load();
            }
            else
            {
                condition = 0;
                clear();
                load();
            }
        }

        private void bEdit_Click(object sender, EventArgs e)
        {
            if (selected())
            {
                enable(grbInformation);
                bNew.Enabled = false;
                bDelete.Enabled = false;
                bEdit.Enabled = false;
                bSave.Enabled = true;
                bCancel.Enabled = true;
                dataGridView.Enabled = false;
                condition = 2;
            }
            else
            {
                MessageBox.Show("Please select a record to edit", "Alert");
            }
        }

        private void dataGridView_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (selected())
            {
                tbID.Text = dataGridView.CurrentRow.Cells[0].Value.ToString();
                tbOrderID.Text = dataGridView.CurrentRow.Cells[1].Value.ToString();
                tbQuantity.Text = dataGridView.CurrentRow.Cells[2].Value.ToString();
                cbDelivery.SelectedIndex = Convert.ToInt32(dataGridView.CurrentRow.Cells[3].Value.ToString());
                cbPayment.SelectedIndex = Convert.ToInt32(dataGridView.CurrentRow.Cells[4].Value.ToString());
                dtDeliveryDate.Value = Convert.ToDateTime(dataGridView.CurrentRow.Cells[5].Value.ToString());
            }
        }

        private void bCancel_Click(object sender, EventArgs e)
        {
            clear();
            load();
        }

        private void bDelete_Click(object sender, EventArgs e)
        {
            if (!selected())
            {
                MessageBox.Show("Please select a record to delete", "Action status");
                load();
                return;
            }
            if (MessageBox.Show("Are you sure to delete this record?", "Action confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                ProdDeliveryController pd = new ProdDeliveryController(Convert.ToInt32(tbID.Text), Convert.ToInt32(tbOrderID.Text), Convert.ToInt32(tbQuantity.Text), Convert.ToInt32(cbDelivery.SelectedIndex), Convert.ToInt32(cbPayment.SelectedIndex), Convert.ToDateTime(dtDeliveryDate.Value.ToShortDateString()));
                if(pd.deleteProdDeliveryAction())
                {
                    MessageBox.Show("Delete success", "Action status");
                }
                else
                {
                    MessageBox.Show("Delete failed", "Action status");
                }
                clear();
                load();
            }
            else
            {
                MessageBox.Show("Delete Cancel", "Action status");
                load();
            }
        }
    }
}
