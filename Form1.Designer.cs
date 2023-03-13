namespace DBApp
{
    partial class Navigation
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnGoToAdd = new Button();
            btnGoToFillOrCancel = new Button();
            btnExit = new Button();
            groupBox1 = new GroupBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btnGoToAdd
            // 
            btnGoToAdd.Location = new Point(50, 14);
            btnGoToAdd.Name = "btnGoToAdd";
            btnGoToAdd.Size = new Size(258, 23);
            btnGoToAdd.TabIndex = 0;
            btnGoToAdd.Text = "Nowe konto";
            btnGoToAdd.UseVisualStyleBackColor = true;
            btnGoToAdd.Click += button1_Click;
            // 
            // btnGoToFillOrCancel
            // 
            btnGoToFillOrCancel.Location = new Point(50, 38);
            btnGoToFillOrCancel.Name = "btnGoToFillOrCancel";
            btnGoToFillOrCancel.Size = new Size(258, 23);
            btnGoToFillOrCancel.TabIndex = 1;
            btnGoToFillOrCancel.Text = "Wypełnij albo anuluj zamówienie";
            btnGoToFillOrCancel.UseVisualStyleBackColor = true;
            btnGoToFillOrCancel.Click += btnGoToFillOrCancel_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(241, 118);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(75, 23);
            btnExit.TabIndex = 2;
            btnExit.Text = "Wyjście";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnGoToAdd);
            groupBox1.Controls.Add(btnGoToFillOrCancel);
            groupBox1.Location = new Point(96, 23);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(364, 67);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Start";
            // 
            // Navigation
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(565, 153);
            Controls.Add(groupBox1);
            Controls.Add(btnExit);
            Name = "Navigation";
            Text = "Panel Nawigacyjny";
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button btnGoToAdd;
        private Button btnGoToFillOrCancel;
        private Button btnExit;
        private GroupBox groupBox1;
    }
}