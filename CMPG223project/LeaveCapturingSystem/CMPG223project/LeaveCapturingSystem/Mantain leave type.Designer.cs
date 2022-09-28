namespace LeaveCapturingSystem
{
    partial class frmMantain_leave_type
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
            this.btnAddNew = new System.Windows.Forms.Button();
            this.txtAddNumDays = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtAddDisc = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtUpdateNumDay = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbUpdtLeaveTyp = new System.Windows.Forms.ComboBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbLeaveType = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtUpdateDescription = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAddNew
            // 
            this.btnAddNew.Location = new System.Drawing.Point(119, 205);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(146, 23);
            this.btnAddNew.TabIndex = 4;
            this.btnAddNew.Text = "Add leave type";
            this.btnAddNew.UseVisualStyleBackColor = true;
            this.btnAddNew.Click += new System.EventHandler(this.button3_Click);
            // 
            // txtAddNumDays
            // 
            this.txtAddNumDays.Location = new System.Drawing.Point(119, 97);
            this.txtAddNumDays.Name = "txtAddNumDays";
            this.txtAddNumDays.Size = new System.Drawing.Size(234, 20);
            this.txtAddNumDays.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 104);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Number of days";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(17, 49);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Description";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnAddNew);
            this.groupBox4.Controls.Add(this.txtAddDisc);
            this.groupBox4.Controls.Add(this.txtAddNumDays);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Location = new System.Drawing.Point(403, 158);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(374, 252);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Add leave type";
            // 
            // txtAddDisc
            // 
            this.txtAddDisc.Location = new System.Drawing.Point(119, 41);
            this.txtAddDisc.Name = "txtAddDisc";
            this.txtAddDisc.Size = new System.Drawing.Size(234, 20);
            this.txtAddDisc.TabIndex = 3;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(114, 205);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(136, 23);
            this.btnUpdate.TabIndex = 4;
            this.btnUpdate.Text = "Update leave type";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtUpdateNumDay
            // 
            this.txtUpdateNumDay.Location = new System.Drawing.Point(114, 148);
            this.txtUpdateNumDay.Name = "txtUpdateNumDay";
            this.txtUpdateNumDay.Size = new System.Drawing.Size(234, 20);
            this.txtUpdateNumDay.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Number of days";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Descroption";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Select leave type";
            // 
            // cmbUpdtLeaveTyp
            // 
            this.cmbUpdtLeaveTyp.FormattingEnabled = true;
            this.cmbUpdtLeaveTyp.Location = new System.Drawing.Point(114, 41);
            this.cmbUpdtLeaveTyp.Name = "cmbUpdtLeaveTyp";
            this.cmbUpdtLeaveTyp.Size = new System.Drawing.Size(234, 21);
            this.cmbUpdtLeaveTyp.TabIndex = 0;
            this.cmbUpdtLeaveTyp.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(114, 70);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(162, 23);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Delete leave type";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select leave type";
            // 
            // cmbLeaveType
            // 
            this.cmbLeaveType.FormattingEnabled = true;
            this.cmbLeaveType.Location = new System.Drawing.Point(114, 27);
            this.cmbLeaveType.Name = "cmbLeaveType";
            this.cmbLeaveType.Size = new System.Drawing.Size(272, 21);
            this.cmbLeaveType.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnUpdate);
            this.groupBox3.Controls.Add(this.txtUpdateNumDay);
            this.groupBox3.Controls.Add(this.txtUpdateDescription);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.cmbUpdtLeaveTyp);
            this.groupBox3.Location = new System.Drawing.Point(43, 158);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(354, 258);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Update leave type";
            // 
            // txtUpdateDescription
            // 
            this.txtUpdateDescription.Location = new System.Drawing.Point(114, 97);
            this.txtUpdateDescription.Name = "txtUpdateDescription";
            this.txtUpdateDescription.Size = new System.Drawing.Size(234, 20);
            this.txtUpdateDescription.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cmbLeaveType);
            this.groupBox1.Location = new System.Drawing.Point(43, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(582, 109);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Delete leave type";
            // 
            // frmMantain_leave_type
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmMantain_leave_type";
            this.Text = "Mantain_leave_type";
            this.Load += new System.EventHandler(this.Mantain_leave_type_Load);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.TextBox txtAddNumDays;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox txtUpdateNumDay;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbUpdtLeaveTyp;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbLeaveType;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtUpdateDescription;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtAddDisc;
    }
}