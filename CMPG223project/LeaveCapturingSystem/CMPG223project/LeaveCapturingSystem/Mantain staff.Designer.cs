namespace LeaveCapturingSystem
{
    partial class frmMantain_staff
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbEmplDlt = new System.Windows.Forms.ComboBox();
            this.dgvDltEmployee = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtUpdNumber = new System.Windows.Forms.TextBox();
            this.txtUpdateLname = new System.Windows.Forms.TextBox();
            this.txtUpdateF_name = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbEmployee = new System.Windows.Forms.ComboBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnAddEmployee = new System.Windows.Forms.Button();
            this.txtNewNumber = new System.Windows.Forms.TextBox();
            this.txtNewCell_number = new System.Windows.Forms.TextBox();
            this.txtNewL_name = new System.Windows.Forms.TextBox();
            this.txtNewF_name = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblAdmin = new System.Windows.Forms.Label();
            this.lblAdmin_ID = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDltEmployee)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cmbEmplDlt);
            this.groupBox1.Controls.Add(this.dgvDltEmployee);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(35, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(590, 212);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Delete employee";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 188);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Select employee to delet";
            // 
            // cmbEmplDlt
            // 
            this.cmbEmplDlt.FormattingEnabled = true;
            this.cmbEmplDlt.Location = new System.Drawing.Point(154, 185);
            this.cmbEmplDlt.Name = "cmbEmplDlt";
            this.cmbEmplDlt.Size = new System.Drawing.Size(298, 21);
            this.cmbEmplDlt.TabIndex = 4;
            // 
            // dgvDltEmployee
            // 
            this.dgvDltEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDltEmployee.Location = new System.Drawing.Point(0, 20);
            this.dgvDltEmployee.Name = "dgvDltEmployee";
            this.dgvDltEmployee.Size = new System.Drawing.Size(576, 150);
            this.dgvDltEmployee.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(458, 183);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Delete";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnUpdate);
            this.groupBox3.Controls.Add(this.txtUpdNumber);
            this.groupBox3.Controls.Add(this.txtUpdateLname);
            this.groupBox3.Controls.Add(this.txtUpdateF_name);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.cmbEmployee);
            this.groupBox3.Location = new System.Drawing.Point(35, 251);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(354, 258);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Update mployee";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(114, 218);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(136, 23);
            this.btnUpdate.TabIndex = 4;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtUpdNumber
            // 
            this.txtUpdNumber.Location = new System.Drawing.Point(114, 165);
            this.txtUpdNumber.Name = "txtUpdNumber";
            this.txtUpdNumber.Size = new System.Drawing.Size(234, 20);
            this.txtUpdNumber.TabIndex = 3;
            // 
            // txtUpdateLname
            // 
            this.txtUpdateLname.Location = new System.Drawing.Point(114, 119);
            this.txtUpdateLname.Name = "txtUpdateLname";
            this.txtUpdateLname.Size = new System.Drawing.Size(234, 20);
            this.txtUpdateLname.TabIndex = 3;
            // 
            // txtUpdateF_name
            // 
            this.txtUpdateF_name.Location = new System.Drawing.Point(114, 75);
            this.txtUpdateF_name.Name = "txtUpdateF_name";
            this.txtUpdateF_name.Size = new System.Drawing.Size(234, 20);
            this.txtUpdateF_name.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 172);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Cell number";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Surname:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Name: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Select lemployee";
            // 
            // cmbEmployee
            // 
            this.cmbEmployee.FormattingEnabled = true;
            this.cmbEmployee.Location = new System.Drawing.Point(114, 30);
            this.cmbEmployee.Name = "cmbEmployee";
            this.cmbEmployee.Size = new System.Drawing.Size(234, 21);
            this.cmbEmployee.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnAddEmployee);
            this.groupBox4.Controls.Add(this.txtNewNumber);
            this.groupBox4.Controls.Add(this.txtNewCell_number);
            this.groupBox4.Controls.Add(this.txtNewL_name);
            this.groupBox4.Controls.Add(this.txtNewF_name);
            this.groupBox4.Controls.Add(this.Password);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Location = new System.Drawing.Point(395, 240);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(354, 252);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Add mployee";
            // 
            // btnAddEmployee
            // 
            this.btnAddEmployee.Location = new System.Drawing.Point(114, 223);
            this.btnAddEmployee.Name = "btnAddEmployee";
            this.btnAddEmployee.Size = new System.Drawing.Size(146, 23);
            this.btnAddEmployee.TabIndex = 4;
            this.btnAddEmployee.Text = "Add employee";
            this.btnAddEmployee.UseVisualStyleBackColor = true;
            this.btnAddEmployee.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // txtNewNumber
            // 
            this.txtNewNumber.Location = new System.Drawing.Point(114, 182);
            this.txtNewNumber.Name = "txtNewNumber";
            this.txtNewNumber.Size = new System.Drawing.Size(234, 20);
            this.txtNewNumber.TabIndex = 3;
            // 
            // txtNewCell_number
            // 
            this.txtNewCell_number.Location = new System.Drawing.Point(114, 136);
            this.txtNewCell_number.Name = "txtNewCell_number";
            this.txtNewCell_number.Size = new System.Drawing.Size(234, 20);
            this.txtNewCell_number.TabIndex = 3;
            // 
            // txtNewL_name
            // 
            this.txtNewL_name.Location = new System.Drawing.Point(114, 86);
            this.txtNewL_name.Name = "txtNewL_name";
            this.txtNewL_name.Size = new System.Drawing.Size(234, 20);
            this.txtNewL_name.TabIndex = 3;
            // 
            // txtNewF_name
            // 
            this.txtNewF_name.Location = new System.Drawing.Point(114, 42);
            this.txtNewF_name.Name = "txtNewF_name";
            this.txtNewF_name.Size = new System.Drawing.Size(234, 20);
            this.txtNewF_name.TabIndex = 3;
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.Location = new System.Drawing.Point(17, 182);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(53, 13);
            this.Password.TabIndex = 2;
            this.Password.Text = "Password";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 139);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Cell number";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 93);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Surname:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(17, 49);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Name: ";
            // 
            // lblAdmin
            // 
            this.lblAdmin.AutoSize = true;
            this.lblAdmin.Location = new System.Drawing.Point(671, 51);
            this.lblAdmin.Name = "lblAdmin";
            this.lblAdmin.Size = new System.Drawing.Size(81, 13);
            this.lblAdmin.TabIndex = 5;
            this.lblAdmin.Text = "Administrator ID";
            // 
            // lblAdmin_ID
            // 
            this.lblAdmin_ID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblAdmin_ID.Location = new System.Drawing.Point(665, 92);
            this.lblAdmin_ID.Name = "lblAdmin_ID";
            this.lblAdmin_ID.Size = new System.Drawing.Size(100, 23);
            this.lblAdmin_ID.TabIndex = 6;
            this.lblAdmin_ID.Text = "label1";
            // 
            // frmMantain_staff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 504);
            this.Controls.Add(this.lblAdmin_ID);
            this.Controls.Add(this.lblAdmin);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmMantain_staff";
            this.Text = "Mantain_staff";
            this.Load += new System.EventHandler(this.Mantain_staff_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDltEmployee)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cmbEmployee;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox txtUpdNumber;
        private System.Windows.Forms.TextBox txtUpdateLname;
        private System.Windows.Forms.TextBox txtUpdateF_name;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnAddEmployee;
        private System.Windows.Forms.TextBox txtNewCell_number;
        private System.Windows.Forms.TextBox txtNewL_name;
        private System.Windows.Forms.TextBox txtNewF_name;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dgvDltEmployee;
        private System.Windows.Forms.TextBox txtNewNumber;
        private System.Windows.Forms.Label Password;
        private System.Windows.Forms.Label lblAdmin;
        public System.Windows.Forms.Label lblAdmin_ID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbEmplDlt;
    }
}