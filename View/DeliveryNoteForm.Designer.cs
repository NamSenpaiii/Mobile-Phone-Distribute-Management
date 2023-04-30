namespace View
{
    partial class DeliveryNoteForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.grbAction = new System.Windows.Forms.GroupBox();
            this.bCancel = new System.Windows.Forms.Button();
            this.bSave = new System.Windows.Forms.Button();
            this.bEdit = new System.Windows.Forms.Button();
            this.bDelete = new System.Windows.Forms.Button();
            this.bNew = new System.Windows.Forms.Button();
            this.grbList = new System.Windows.Forms.GroupBox();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.grbInformation = new System.Windows.Forms.GroupBox();
            this.cbPayment = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbDelivery = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dtDeliveryDate = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.tbQuantity = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbOrderID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grbAction.SuspendLayout();
            this.grbList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.grbInformation.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbAction
            // 
            this.grbAction.Controls.Add(this.bCancel);
            this.grbAction.Controls.Add(this.bSave);
            this.grbAction.Controls.Add(this.bEdit);
            this.grbAction.Controls.Add(this.bDelete);
            this.grbAction.Controls.Add(this.bNew);
            this.grbAction.Location = new System.Drawing.Point(16, 133);
            this.grbAction.Name = "grbAction";
            this.grbAction.Size = new System.Drawing.Size(749, 79);
            this.grbAction.TabIndex = 6;
            this.grbAction.TabStop = false;
            this.grbAction.Text = "Action";
            // 
            // bCancel
            // 
            this.bCancel.Location = new System.Drawing.Point(633, 25);
            this.bCancel.Name = "bCancel";
            this.bCancel.Size = new System.Drawing.Size(107, 39);
            this.bCancel.TabIndex = 4;
            this.bCancel.Text = "Cancel";
            this.bCancel.UseVisualStyleBackColor = true;
            this.bCancel.Click += new System.EventHandler(this.bCancel_Click);
            // 
            // bSave
            // 
            this.bSave.Location = new System.Drawing.Point(479, 25);
            this.bSave.Name = "bSave";
            this.bSave.Size = new System.Drawing.Size(107, 39);
            this.bSave.TabIndex = 3;
            this.bSave.Text = "Save";
            this.bSave.UseVisualStyleBackColor = true;
            this.bSave.Click += new System.EventHandler(this.bSave_Click);
            // 
            // bEdit
            // 
            this.bEdit.Location = new System.Drawing.Point(322, 25);
            this.bEdit.Name = "bEdit";
            this.bEdit.Size = new System.Drawing.Size(107, 39);
            this.bEdit.TabIndex = 2;
            this.bEdit.Text = "Edit";
            this.bEdit.UseVisualStyleBackColor = true;
            this.bEdit.Click += new System.EventHandler(this.bEdit_Click);
            // 
            // bDelete
            // 
            this.bDelete.Location = new System.Drawing.Point(165, 25);
            this.bDelete.Name = "bDelete";
            this.bDelete.Size = new System.Drawing.Size(107, 39);
            this.bDelete.TabIndex = 1;
            this.bDelete.Text = "Delete";
            this.bDelete.UseVisualStyleBackColor = true;
            this.bDelete.Click += new System.EventHandler(this.bDelete_Click);
            // 
            // bNew
            // 
            this.bNew.Location = new System.Drawing.Point(21, 25);
            this.bNew.Name = "bNew";
            this.bNew.Size = new System.Drawing.Size(107, 39);
            this.bNew.TabIndex = 0;
            this.bNew.Text = "New";
            this.bNew.UseVisualStyleBackColor = true;
            this.bNew.Click += new System.EventHandler(this.bNew_Click);
            // 
            // grbList
            // 
            this.grbList.Controls.Add(this.dataGridView);
            this.grbList.Location = new System.Drawing.Point(16, 218);
            this.grbList.Name = "grbList";
            this.grbList.Size = new System.Drawing.Size(751, 342);
            this.grbList.TabIndex = 5;
            this.grbList.TabStop = false;
            this.grbList.Text = "Delivery Note List";
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToOrderColumns = true;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(12, 25);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 62;
            this.dataGridView.RowTemplate.Height = 28;
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.Size = new System.Drawing.Size(728, 296);
            this.dataGridView.TabIndex = 0;
            this.dataGridView.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView_CellMouseClick);
            // 
            // grbInformation
            // 
            this.grbInformation.Controls.Add(this.cbPayment);
            this.grbInformation.Controls.Add(this.label6);
            this.grbInformation.Controls.Add(this.cbDelivery);
            this.grbInformation.Controls.Add(this.label5);
            this.grbInformation.Controls.Add(this.dtDeliveryDate);
            this.grbInformation.Controls.Add(this.label4);
            this.grbInformation.Controls.Add(this.tbQuantity);
            this.grbInformation.Controls.Add(this.label3);
            this.grbInformation.Controls.Add(this.tbOrderID);
            this.grbInformation.Controls.Add(this.label2);
            this.grbInformation.Controls.Add(this.tbID);
            this.grbInformation.Controls.Add(this.label1);
            this.grbInformation.Location = new System.Drawing.Point(16, 12);
            this.grbInformation.Name = "grbInformation";
            this.grbInformation.Size = new System.Drawing.Size(751, 115);
            this.grbInformation.TabIndex = 4;
            this.grbInformation.TabStop = false;
            this.grbInformation.Text = "Information";
            // 
            // cbPayment
            // 
            this.cbPayment.FormattingEnabled = true;
            this.cbPayment.Location = new System.Drawing.Point(593, 66);
            this.cbPayment.Name = "cbPayment";
            this.cbPayment.Size = new System.Drawing.Size(138, 28);
            this.cbPayment.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(511, 69);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Payment";
            // 
            // cbDelivery
            // 
            this.cbDelivery.FormattingEnabled = true;
            this.cbDelivery.Location = new System.Drawing.Point(312, 71);
            this.cbDelivery.Name = "cbDelivery";
            this.cbDelivery.Size = new System.Drawing.Size(138, 28);
            this.cbDelivery.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(230, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Delivery";
            // 
            // dtDeliveryDate
            // 
            this.dtDeliveryDate.Location = new System.Drawing.Point(593, 20);
            this.dtDeliveryDate.Name = "dtDeliveryDate";
            this.dtDeliveryDate.Size = new System.Drawing.Size(138, 26);
            this.dtDeliveryDate.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(473, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Delivery Date";
            // 
            // tbQuantity
            // 
            this.tbQuantity.Location = new System.Drawing.Point(312, 22);
            this.tbQuantity.Name = "tbQuantity";
            this.tbQuantity.Size = new System.Drawing.Size(138, 26);
            this.tbQuantity.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(226, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Quantity";
            // 
            // tbOrderID
            // 
            this.tbOrderID.Location = new System.Drawing.Point(93, 71);
            this.tbOrderID.Name = "tbOrderID";
            this.tbOrderID.Size = new System.Drawing.Size(100, 26);
            this.tbOrderID.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Order ID";
            // 
            // tbID
            // 
            this.tbID.Location = new System.Drawing.Point(93, 22);
            this.tbID.Name = "tbID";
            this.tbID.Size = new System.Drawing.Size(100, 26);
            this.tbID.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // DeliveryNoteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 569);
            this.Controls.Add(this.grbAction);
            this.Controls.Add(this.grbList);
            this.Controls.Add(this.grbInformation);
            this.Name = "DeliveryNoteForm";
            this.Text = "DeliveryNoteForm";
            this.Load += new System.EventHandler(this.DeliveryNoteForm_Load);
            this.grbAction.ResumeLayout(false);
            this.grbList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.grbInformation.ResumeLayout(false);
            this.grbInformation.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox grbAction;
        private System.Windows.Forms.Button bCancel;
        private System.Windows.Forms.Button bSave;
        private System.Windows.Forms.Button bEdit;
        private System.Windows.Forms.Button bDelete;
        private System.Windows.Forms.Button bNew;
        private System.Windows.Forms.GroupBox grbList;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.GroupBox grbInformation;
        private System.Windows.Forms.ComboBox cbPayment;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbDelivery;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtDeliveryDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbQuantity;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbOrderID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.Label label1;
    }
}