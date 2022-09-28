namespace LeaveCapturingSystem
{
    partial class frmReport
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
            this.dgvReport = new System.Windows.Forms.DataGridView();
            this.rbApproved = new System.Windows.Forms.RadioButton();
            this.rbAll_report = new System.Windows.Forms.RadioButton();
            this.rbRejected = new System.Windows.Forms.RadioButton();
            this.btnReport = new System.Windows.Forms.Button();
            this.lblDate = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReport)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvReport
            // 
            this.dgvReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReport.Location = new System.Drawing.Point(17, 125);
            this.dgvReport.Name = "dgvReport";
            this.dgvReport.Size = new System.Drawing.Size(458, 195);
            this.dgvReport.TabIndex = 0;
            // 
            // rbApproved
            // 
            this.rbApproved.AutoSize = true;
            this.rbApproved.Location = new System.Drawing.Point(17, 49);
            this.rbApproved.Name = "rbApproved";
            this.rbApproved.Size = new System.Drawing.Size(124, 17);
            this.rbApproved.TabIndex = 1;
            this.rbApproved.TabStop = true;
            this.rbApproved.Text = "Approvd applications";
            this.rbApproved.UseVisualStyleBackColor = true;
            // 
            // rbAll_report
            // 
            this.rbAll_report.AutoSize = true;
            this.rbAll_report.Location = new System.Drawing.Point(17, 20);
            this.rbAll_report.Name = "rbAll_report";
            this.rbAll_report.Size = new System.Drawing.Size(95, 17);
            this.rbAll_report.TabIndex = 1;
            this.rbAll_report.TabStop = true;
            this.rbAll_report.Text = "All applications";
            this.rbAll_report.UseVisualStyleBackColor = true;
            // 
            // rbRejected
            // 
            this.rbRejected.AutoSize = true;
            this.rbRejected.Location = new System.Drawing.Point(17, 79);
            this.rbRejected.Name = "rbRejected";
            this.rbRejected.Size = new System.Drawing.Size(127, 17);
            this.rbRejected.TabIndex = 1;
            this.rbRejected.TabStop = true;
            this.rbRejected.Text = "Rejected applications";
            this.rbRejected.UseVisualStyleBackColor = true;
            // 
            // btnReport
            // 
            this.btnReport.Location = new System.Drawing.Point(167, 344);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(183, 34);
            this.btnReport.TabIndex = 2;
            this.btnReport.Text = "Generate report";
            this.btnReport.UseVisualStyleBackColor = true;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // lblDate
            // 
            this.lblDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDate.Location = new System.Drawing.Point(322, 21);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(153, 23);
            this.lblDate.TabIndex = 3;
            this.lblDate.Text = "label1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvReport);
            this.groupBox1.Controls.Add(this.btnReport);
            this.groupBox1.Controls.Add(this.lblDate);
            this.groupBox1.Controls.Add(this.rbRejected);
            this.groupBox1.Controls.Add(this.rbApproved);
            this.groupBox1.Controls.Add(this.rbAll_report);
            this.groupBox1.Location = new System.Drawing.Point(28, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(509, 396);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // frmReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmReport";
            this.Text = "Reports ";
            this.Load += new System.EventHandler(this.Leave_balance_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReport)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvReport;
        private System.Windows.Forms.RadioButton rbApproved;
        private System.Windows.Forms.RadioButton rbAll_report;
        private System.Windows.Forms.RadioButton rbRejected;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}