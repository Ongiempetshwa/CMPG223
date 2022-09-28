namespace LeaveCapturingSystem
{
    partial class frmLeave_request_aproval
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
            this.btnProcess = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnReports = new System.Windows.Forms.Button();
            this.lblLeave_type_ID = new System.Windows.Forms.Label();
            this.lblEmployeeID = new System.Windows.Forms.Label();
            this.lblManager_ID = new System.Windows.Forms.Label();
            this.lblLeave_typeID = new System.Windows.Forms.Label();
            this.lblManagerID = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rbReject = new System.Windows.Forms.RadioButton();
            this.rbApproved = new System.Windows.Forms.RadioButton();
            this.dgvApplicants = new System.Windows.Forms.DataGridView();
            this.cmbLV_Employee_ID = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvApplicants)).BeginInit();
            this.SuspendLayout();
            // 
            // btnProcess
            // 
            this.btnProcess.Location = new System.Drawing.Point(231, 280);
            this.btnProcess.Name = "btnProcess";
            this.btnProcess.Size = new System.Drawing.Size(114, 23);
            this.btnProcess.TabIndex = 1;
            this.btnProcess.Text = "Process";
            this.btnProcess.UseVisualStyleBackColor = true;
            this.btnProcess.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnReports);
            this.groupBox1.Controls.Add(this.lblLeave_type_ID);
            this.groupBox1.Controls.Add(this.lblEmployeeID);
            this.groupBox1.Controls.Add(this.lblManager_ID);
            this.groupBox1.Controls.Add(this.lblLeave_typeID);
            this.groupBox1.Controls.Add(this.lblManagerID);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(409, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(205, 286);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Employee details";
            // 
            // btnReports
            // 
            this.btnReports.Location = new System.Drawing.Point(31, 245);
            this.btnReports.Name = "btnReports";
            this.btnReports.Size = new System.Drawing.Size(154, 35);
            this.btnReports.TabIndex = 2;
            this.btnReports.Text = "Generate reports";
            this.btnReports.UseVisualStyleBackColor = true;
            this.btnReports.Click += new System.EventHandler(this.btnReports_Click);
            // 
            // lblLeave_type_ID
            // 
            this.lblLeave_type_ID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblLeave_type_ID.Location = new System.Drawing.Point(114, 108);
            this.lblLeave_type_ID.Name = "lblLeave_type_ID";
            this.lblLeave_type_ID.Size = new System.Drawing.Size(85, 13);
            this.lblLeave_type_ID.TabIndex = 1;
            this.lblLeave_type_ID.Text = "label1";
            // 
            // lblEmployeeID
            // 
            this.lblEmployeeID.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblEmployeeID.Location = new System.Drawing.Point(114, 74);
            this.lblEmployeeID.Name = "lblEmployeeID";
            this.lblEmployeeID.Size = new System.Drawing.Size(85, 13);
            this.lblEmployeeID.TabIndex = 1;
            this.lblEmployeeID.Text = "label1";
            // 
            // lblManager_ID
            // 
            this.lblManager_ID.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblManager_ID.Location = new System.Drawing.Point(114, 36);
            this.lblManager_ID.Name = "lblManager_ID";
            this.lblManager_ID.Size = new System.Drawing.Size(85, 13);
            this.lblManager_ID.TabIndex = 1;
            this.lblManager_ID.Text = "label1";
            // 
            // lblLeave_typeID
            // 
            this.lblLeave_typeID.AutoSize = true;
            this.lblLeave_typeID.Location = new System.Drawing.Point(9, 108);
            this.lblLeave_typeID.Name = "lblLeave_typeID";
            this.lblLeave_typeID.Size = new System.Drawing.Size(74, 13);
            this.lblLeave_typeID.TabIndex = 0;
            this.lblLeave_typeID.Text = "Leave type ID";
            // 
            // lblManagerID
            // 
            this.lblManagerID.AutoSize = true;
            this.lblManagerID.Location = new System.Drawing.Point(9, 36);
            this.lblManagerID.Name = "lblManagerID";
            this.lblManagerID.Size = new System.Drawing.Size(63, 13);
            this.lblManagerID.TabIndex = 0;
            this.lblManagerID.Text = "Manager ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Employee ID";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.cmbLV_Employee_ID);
            this.groupBox2.Controls.Add(this.rbReject);
            this.groupBox2.Controls.Add(this.rbApproved);
            this.groupBox2.Controls.Add(this.dgvApplicants);
            this.groupBox2.Controls.Add(this.btnProcess);
            this.groupBox2.Location = new System.Drawing.Point(25, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(360, 309);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Leave requests";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Select applicant ID";
            // 
            // rbReject
            // 
            this.rbReject.AutoSize = true;
            this.rbReject.Location = new System.Drawing.Point(169, 280);
            this.rbReject.Name = "rbReject";
            this.rbReject.Size = new System.Drawing.Size(56, 17);
            this.rbReject.TabIndex = 3;
            this.rbReject.TabStop = true;
            this.rbReject.Text = "Reject";
            this.rbReject.UseVisualStyleBackColor = true;
            // 
            // rbApproved
            // 
            this.rbApproved.AutoSize = true;
            this.rbApproved.Location = new System.Drawing.Point(25, 280);
            this.rbApproved.Name = "rbApproved";
            this.rbApproved.Size = new System.Drawing.Size(65, 17);
            this.rbApproved.TabIndex = 3;
            this.rbApproved.TabStop = true;
            this.rbApproved.Text = "Approve";
            this.rbApproved.UseVisualStyleBackColor = true;
            // 
            // dgvApplicants
            // 
            this.dgvApplicants.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvApplicants.Location = new System.Drawing.Point(9, 50);
            this.dgvApplicants.Name = "dgvApplicants";
            this.dgvApplicants.Size = new System.Drawing.Size(339, 201);
            this.dgvApplicants.TabIndex = 2;
            // 
            // cmbLV_Employee_ID
            // 
            this.cmbLV_Employee_ID.FormattingEnabled = true;
            this.cmbLV_Employee_ID.Location = new System.Drawing.Point(198, 23);
            this.cmbLV_Employee_ID.Name = "cmbLV_Employee_ID";
            this.cmbLV_Employee_ID.Size = new System.Drawing.Size(150, 21);
            this.cmbLV_Employee_ID.TabIndex = 4;
            this.cmbLV_Employee_ID.SelectedIndexChanged += new System.EventHandler(this.cmbLV_Employee_ID_SelectedIndexChanged);
            // 
            // frmLeave_request_aproval
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 339);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmLeave_request_aproval";
            this.Text = "Leave_request_aproval";
            this.Load += new System.EventHandler(this.Leave_request_aproval_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvApplicants)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnProcess;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblLeave_typeID;
        private System.Windows.Forms.Label lblManagerID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvApplicants;
        public System.Windows.Forms.Label lblManager_ID;
        private System.Windows.Forms.RadioButton rbReject;
        private System.Windows.Forms.RadioButton rbApproved;
        public System.Windows.Forms.Label lblLeave_type_ID;
        public System.Windows.Forms.Label lblEmployeeID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbLV_Employee_ID;
        private System.Windows.Forms.Button btnReports;
    }
}