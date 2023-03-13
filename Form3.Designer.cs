namespace DBApp
{
    partial class FillOrCancel
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
            label1 = new Label();
            txtOrderID = new TextBox();
            btnFindByOrderID = new Button();
            label2 = new Label();
            dtpFillDate = new DateTimePicker();
            dgvCustomerOrders = new DataGridView();
            btnCancelOrder = new Button();
            btnFillOrder = new Button();
            btnFinishUpdates = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvCustomerOrders).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(50, 39);
            label1.Name = "label1";
            label1.Size = new Size(84, 15);
            label1.TabIndex = 0;
            label1.Text = "ID zamówienia";
            // 
            // txtOrderID
            // 
            txtOrderID.Location = new Point(140, 36);
            txtOrderID.Name = "txtOrderID";
            txtOrderID.Size = new Size(134, 23);
            txtOrderID.TabIndex = 1;
            // 
            // btnFindByOrderID
            // 
            btnFindByOrderID.Location = new Point(299, 36);
            btnFindByOrderID.Name = "btnFindByOrderID";
            btnFindByOrderID.Size = new Size(154, 23);
            btnFindByOrderID.TabIndex = 2;
            btnFindByOrderID.Text = "Znajdź zamówienie";
            btnFindByOrderID.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 124);
            label2.Name = "label2";
            label2.Size = new Size(259, 15);
            label2.TabIndex = 3;
            label2.Text = "Jeżeli wypełniasz zamówienie proszę podaj datę:";
            // 
            // dtpFillDate
            // 
            dtpFillDate.Format = DateTimePickerFormat.Short;
            dtpFillDate.Location = new Point(299, 118);
            dtpFillDate.Name = "dtpFillDate";
            dtpFillDate.Size = new Size(154, 23);
            dtpFillDate.TabIndex = 4;
            // 
            // dgvCustomerOrders
            // 
            dgvCustomerOrders.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCustomerOrders.Location = new Point(15, 164);
            dgvCustomerOrders.Name = "dgvCustomerOrders";
            dgvCustomerOrders.ReadOnly = true;
            dgvCustomerOrders.RowHeadersVisible = false;
            dgvCustomerOrders.RowTemplate.Height = 25;
            dgvCustomerOrders.Size = new Size(438, 146);
            dgvCustomerOrders.TabIndex = 5;
            // 
            // btnCancelOrder
            // 
            btnCancelOrder.Location = new Point(16, 334);
            btnCancelOrder.Name = "btnCancelOrder";
            btnCancelOrder.Size = new Size(118, 44);
            btnCancelOrder.TabIndex = 6;
            btnCancelOrder.Text = "Anuluj zamówienie";
            btnCancelOrder.UseVisualStyleBackColor = true;
            // 
            // btnFillOrder
            // 
            btnFillOrder.Location = new Point(140, 334);
            btnFillOrder.Name = "btnFillOrder";
            btnFillOrder.Size = new Size(118, 44);
            btnFillOrder.TabIndex = 7;
            btnFillOrder.Text = "Wypełnij zamówienie";
            btnFillOrder.UseVisualStyleBackColor = true;
            // 
            // btnFinishUpdates
            // 
            btnFinishUpdates.Location = new Point(352, 345);
            btnFinishUpdates.Name = "btnFinishUpdates";
            btnFinishUpdates.Size = new Size(101, 34);
            btnFinishUpdates.TabIndex = 8;
            btnFinishUpdates.Text = "Zakończ";
            btnFinishUpdates.UseVisualStyleBackColor = true;
            // 
            // FillOrCancel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(502, 425);
            Controls.Add(btnFinishUpdates);
            Controls.Add(btnFillOrder);
            Controls.Add(btnCancelOrder);
            Controls.Add(dgvCustomerOrders);
            Controls.Add(dtpFillDate);
            Controls.Add(label2);
            Controls.Add(btnFindByOrderID);
            Controls.Add(txtOrderID);
            Controls.Add(label1);
            Name = "FillOrCancel";
            Text = "Wypełnij albo anuluj";
            ((System.ComponentModel.ISupportInitialize)dgvCustomerOrders).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtOrderID;
        private Button btnFindByOrderID;
        private Label label2;
        private DateTimePicker dtpFillDate;
        private DataGridView dgvCustomerOrders;
        private Button btnCancelOrder;
        private Button btnFillOrder;
        private Button btnFinishUpdates;
    }
}