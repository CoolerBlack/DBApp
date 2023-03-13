namespace DBApp
{
    partial class NewCustomer
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
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtCustomerName = new TextBox();
            txtCustomerID = new TextBox();
            btnCreateAccount = new Button();
            btnPlaceOrder = new Button();
            btnAddAnotherAccount = new Button();
            btnAddFinish = new Button();
            numOrderAmount = new NumericUpDown();
            dtpOrderDate = new DateTimePicker();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numOrderAmount).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtCustomerID);
            groupBox1.Controls.Add(txtCustomerName);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(47, 44);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(274, 99);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Dodaj konto";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dtpOrderDate);
            groupBox2.Controls.Add(numOrderAmount);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label3);
            groupBox2.Location = new Point(47, 204);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(274, 99);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Utwórz zamówienie";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 31);
            label1.Name = "label1";
            label1.Size = new Size(81, 15);
            label1.TabIndex = 0;
            label1.Text = "Nazwa Klienta";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 72);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 1;
            label2.Text = "ID Klienta";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(23, 32);
            label3.Name = "label3";
            label3.Size = new Size(97, 15);
            label3.TabIndex = 0;
            label3.Text = "Ilość zamówienia";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(23, 63);
            label4.Name = "label4";
            label4.Size = new Size(97, 15);
            label4.TabIndex = 1;
            label4.Text = "Data zamówienia";
            // 
            // txtCustomerName
            // 
            txtCustomerName.Location = new Point(122, 31);
            txtCustomerName.Name = "txtCustomerName";
            txtCustomerName.Size = new Size(123, 23);
            txtCustomerName.TabIndex = 2;
            // 
            // txtCustomerID
            // 
            txtCustomerID.Location = new Point(140, 64);
            txtCustomerID.Name = "txtCustomerID";
            txtCustomerID.ReadOnly = true;
            txtCustomerID.Size = new Size(105, 23);
            txtCustomerID.TabIndex = 3;
            // 
            // btnCreateAccount
            // 
            btnCreateAccount.Location = new Point(327, 120);
            btnCreateAccount.Name = "btnCreateAccount";
            btnCreateAccount.Size = new Size(95, 23);
            btnCreateAccount.TabIndex = 2;
            btnCreateAccount.Text = "Utwórz konto";
            btnCreateAccount.UseVisualStyleBackColor = true;
            // 
            // btnPlaceOrder
            // 
            btnPlaceOrder.Location = new Point(327, 280);
            btnPlaceOrder.Name = "btnPlaceOrder";
            btnPlaceOrder.Size = new Size(109, 23);
            btnPlaceOrder.TabIndex = 3;
            btnPlaceOrder.Text = "Złóż zamówienie";
            btnPlaceOrder.UseVisualStyleBackColor = true;
            // 
            // btnAddAnotherAccount
            // 
            btnAddAnotherAccount.Location = new Point(274, 364);
            btnAddAnotherAccount.Name = "btnAddAnotherAccount";
            btnAddAnotherAccount.Size = new Size(162, 23);
            btnAddAnotherAccount.TabIndex = 4;
            btnAddAnotherAccount.Text = "Dodaj kolejne konto";
            btnAddAnotherAccount.UseVisualStyleBackColor = true;
            // 
            // btnAddFinish
            // 
            btnAddFinish.Location = new Point(47, 364);
            btnAddFinish.Name = "btnAddFinish";
            btnAddFinish.Size = new Size(75, 23);
            btnAddFinish.TabIndex = 5;
            btnAddFinish.Text = "Koniec";
            btnAddFinish.UseVisualStyleBackColor = true;
            // 
            // numOrderAmount
            // 
            numOrderAmount.Location = new Point(140, 24);
            numOrderAmount.Maximum = new decimal(new int[] { 5000, 0, 0, 0 });
            numOrderAmount.Name = "numOrderAmount";
            numOrderAmount.Size = new Size(105, 23);
            numOrderAmount.TabIndex = 2;
            // 
            // dtpOrderDate
            // 
            dtpOrderDate.Format = DateTimePickerFormat.Short;
            dtpOrderDate.Location = new Point(140, 55);
            dtpOrderDate.Name = "dtpOrderDate";
            dtpOrderDate.Size = new Size(105, 23);
            dtpOrderDate.TabIndex = 3;
            // 
            // NewCustomer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(485, 446);
            Controls.Add(btnAddFinish);
            Controls.Add(btnAddAnotherAccount);
            Controls.Add(btnPlaceOrder);
            Controls.Add(btnCreateAccount);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "NewCustomer";
            Text = "Nowy Klient i zamówienie";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numOrderAmount).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private TextBox txtCustomerID;
        private TextBox txtCustomerName;
        private Label label2;
        private Label label1;
        private Label label4;
        private Label label3;
        private DateTimePicker dtpOrderDate;
        private NumericUpDown numOrderAmount;
        private Button btnCreateAccount;
        private Button btnPlaceOrder;
        private Button btnAddAnotherAccount;
        private Button btnAddFinish;
    }
}