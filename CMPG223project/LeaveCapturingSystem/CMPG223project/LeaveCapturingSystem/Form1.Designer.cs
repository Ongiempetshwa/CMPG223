namespace LeaveCapturingSystem
{
    partial class frmMainPage
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
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbStaff = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvEmployee = new System.Windows.Forms.DataGridView();
            this.rbtnManagement = new System.Windows.Forms.RadioButton();
            this.rbtnEmployee = new System.Windows.Forms.RadioButton();
            this.button2 = new System.Windows.Forms.Button();
            this.rbtnAdmin = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployee)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Password";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(41, 299);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 37);
            this.button1.TabIndex = 1;
            this.button1.Text = "Log in";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(175, 113);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(253, 20);
            this.txtPassword.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtnAdmin);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.rbtnEmployee);
            this.groupBox1.Controls.Add(this.rbtnManagement);
            this.groupBox1.Controls.Add(this.dgvEmployee);
            this.groupBox1.Controls.Add(this.cmbStaff);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.txtPassword);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(27, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(453, 358);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Home page log in";
            // 
            // cmbStaff
            // 
            this.cmbStaff.FormattingEnabled = true;
            this.cmbStaff.Items.AddRange(new object[] {
            "Employee",
            "Administrator"});
            this.cmbStaff.Location = new System.Drawing.Point(175, 34);
            this.cmbStaff.Name = "cmbStaff";
            this.cmbStaff.Size = new System.Drawing.Size(253, 21);
            this.cmbStaff.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "User ID";
            // 
            // dgvEmployee
            // 
            this.dgvEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployee.Location = new System.Drawing.Point(9, 146);
            this.dgvEmployee.Name = "dgvEmployee";
            this.dgvEmployee.Size = new System.Drawing.Size(419, 132);
            this.dgvEmployee.TabIndex = 5;
            // 
            // rbtnManagement
            // 
            this.rbtnManagement.AutoSize = true;
            this.rbtnManagement.Location = new System.Drawing.Point(252, 72);
            this.rbtnManagement.Name = "rbtnManagement";
            this.rbtnManagement.Size = new System.Drawing.Size(87, 17);
            this.rbtnManagement.TabIndex = 6;
            this.rbtnManagement.TabStop = true;
            this.rbtnManagement.Text = "Management";
            this.rbtnManagement.UseVisualStyleBackColor = true;
            // 
            // rbtnEmployee
            // 
            this.rbtnEmployee.AutoSize = true;
            this.rbtnEmployee.Location = new System.Drawing.Point(175, 72);
            this.rbtnEmployee.Name = "rbtnEmployee";
            this.rbtnEmployee.Size = new System.Drawing.Size(71, 17);
            this.rbtnEmployee.TabIndex = 6;
            this.rbtnEmployee.TabStop = true;
            this.rbtnEmployee.Text = "Employee";
            this.rbtnEmployee.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(246, 299);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(115, 37);
            this.button2.TabIndex = 7;
            this.button2.Text = "Exit";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // rbtnAdmin
            // 
            this.rbtnAdmin.AutoSize = true;
            this.rbtnAdmin.Location = new System.Drawing.Point(345, 72);
            this.rbtnAdmin.Name = "rbtnAdmin";
            this.rbtnAdmin.Size = new System.Drawing.Size(85, 17);
            this.rbtnAdmin.TabIndex = 8;
            this.rbtnAdmin.TabStop = true;
            this.rbtnAdmin.Text = "Administrator";
            this.rbtnAdmin.UseVisualStyleBackColor = true;
            // 
            // frmMainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 413);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmMainPage";
            this.Text = "Log in home page";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployee)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbStaff;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvEmployee;
        private System.Windows.Forms.RadioButton rbtnEmployee;
        private System.Windows.Forms.RadioButton rbtnManagement;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.RadioButton rbtnAdmin;
    }
}

