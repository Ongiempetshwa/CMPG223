using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace LeaveCapturingSystem
{
    public partial class frmReport : Form
    {
        public frmReport()
        {
            InitializeComponent();
        }

        private void Leave_balance_Load(object sender, EventArgs e)
        {
            String connString;
            SqlConnection cnn;
            connString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\user\Desktop\CMPG223project\LeaveCapturingSystem\LeaveCaptureSystem.mdf;Integrated Security=True";
            cnn = new SqlConnection(connString);
            cnn.Open();
            cnn.Close();
            lblDate.Text = DateTime.Today.ToString();

            //filling data grid view

            cnn.Open();
            SqlCommand command;
            string sql;
            SqlDataAdapter adapter = new SqlDataAdapter();
            
            sql = @"Select * FROM Report ";
            
            command = new SqlCommand(sql, cnn);
            DataSet ds = new DataSet();
            adapter.SelectCommand = command;
            adapter.Fill(ds, "Report");
            dgvReport.DataSource = ds;
            dgvReport.DataMember = "Report";
            cnn.Close();

        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            String connString;
            SqlConnection cnn;
            connString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\user\Desktop\CMPG223project\LeaveCapturingSystem\LeaveCaptureSystem.mdf;Integrated Security=True";
            cnn = new SqlConnection(connString);
            cnn.Open();
            cnn.Close();
            lblDate.Text = DateTime.Today.ToString();

            //filling data grid view

            cnn.Open();
            SqlCommand command;
            string sql;
            SqlDataAdapter adapter = new SqlDataAdapter();


            if (rbAll_report.Checked)
            {
                sql = @"Select * FROM Report ";
            }
            else if (rbApproved.Checked)
            {
                sql = @"Select * FROM Report Where Leave_status ='" + "Approved" + "'";
            }
            else // rejected
            {
                sql = @"Select * FROM Report Where Leave_status ='" + "Rejected" + "'";
            }

            command = new SqlCommand(sql, cnn);
            DataSet ds = new DataSet();
            adapter.SelectCommand = command;
            adapter.Fill(ds, "Report");
            dgvReport.DataSource = ds;
            dgvReport.DataMember = "Report";
            cnn.Close();
        }
    }
}
