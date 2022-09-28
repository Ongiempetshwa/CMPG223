namespace LeaveCapturingSystem
{
    partial class frmApply_for_leave
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnApply = new System.Windows.Forms.Button();
            this.cmbManager = new System.Windows.Forms.ComboBox();
            this.lblEmployee_ID = new System.Windows.Forms.Label();
            this.lbl_ID = new System.Windows.Forms.Label();
            this.dgvLeaveType = new System.Windows.Forms.DataGridView();
            this.cmbLeave_ID = new System.Windows.Forms.ComboBox();
            this.lblLeaveType = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLeaveType)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Chose leave type";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 319);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Select manager";
            // 
            // btnApply
            // 
            this.btnApply.Location = new System.Drawing.Point(138, 369);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(141, 38);
            this.btnApply.TabIndex = 3;
            this.btnApply.Text = "Submit application";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.button1_Click);
            // 
            // cmbManager
            // 
            this.cmbManager.FormattingEnabled = true;
            this.cmbManager.Location = new System.Drawing.Point(214, 316);
            this.cmbManager.Name = "cmbManager";
            this.cmbManager.Size = new System.Drawing.Size(223, 21);
            this.cmbManager.TabIndex = 1;
            this.cmbManager.SelectedIndexChanged += new System.EventHandler(this.cboxManager_SelectedIndexChanged);
            // 
            // lblEmployee_ID
            // 
            this.lblEmployee_ID.AutoSize = true;
            this.lblEmployee_ID.Location = new System.Drawing.Point(22, 26);
            this.lblEmployee_ID.Name = "lblEmployee_ID";
            this.lblEmployee_ID.Size = new System.Drawing.Size(67, 13);
            this.lblEmployee_ID.TabIndex = 4;
            this.lblEmployee_ID.Text = "Employee ID";
            // 
            // lbl_ID
            // 
            this.lbl_ID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_ID.Location = new System.Drawing.Point(214, 26);
            this.lbl_ID.Name = "lbl_ID";
            this.lbl_ID.Size = new System.Drawing.Size(223, 27);
            this.lbl_ID.TabIndex = 5;
            this.lbl_ID.Text = "label3";
            this.lbl_ID.Click += new System.EventHandler(this.lbl_ID_Click);
            // 
            // dgvLeaveType
            // 
            this.dgvLeaveType.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLeaveType.Location = new System.Drawing.Point(25, 96);
            this.dgvLeaveType.Name = "dgvLeaveType";
            this.dgvLeaveType.Size = new System.Drawing.Size(412, 150);
            this.dgvLeaveType.TabIndex = 6;
            // 
            // cmbLeave_ID
            // 
            this.cmbLeave_ID.FormattingEnabled = true;
            this.cmbLeave_ID.Location = new System.Drawing.Point(214, 252);
            this.cmbLeave_ID.Name = "cmbLeave_ID";
            this.cmbLeave_ID.Size = new System.Drawing.Size(223, 21);
            this.cmbLeave_ID.TabIndex = 7;
            // 
            // lblLeaveType
            // 
            this.lblLeaveType.AutoSize = true;
            this.lblLeaveType.Location = new System.Drawing.Point(22, 255);
            this.lblLeaveType.Name = "lblLeaveType";
            this.lblLeaveType.Size = new System.Drawing.Size(84, 13);
            this.lblLeaveType.TabIndex = 8;
            this.lblLeaveType.Text = "Chose Leave ID";
            // 
            // frmApply_for_leave
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 413);
            this.Controls.Add(this.lblLeaveType);
            this.Controls.Add(this.cmbLeave_ID);
            this.Controls.Add(this.dgvLeaveType);
            this.Controls.Add(this.lbl_ID);
            this.Controls.Add(this.lblEmployee_ID);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbManager);
            this.Name = "frmApply_for_leave";
            this.Text = "Apply_for_leave";
            this.Load += new System.EventHandler(this.Apply_for_leave_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLeaveType)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.ComboBox cmbManager;
        private System.Windows.Forms.Label lblEmployee_ID;
        public System.Windows.Forms.Label lbl_ID;
        private System.Windows.Forms.DataGridView dgvLeaveType;
        private System.Windows.Forms.ComboBox cmbLeave_ID;
        private System.Windows.Forms.Label lblLeaveType;
    }
}