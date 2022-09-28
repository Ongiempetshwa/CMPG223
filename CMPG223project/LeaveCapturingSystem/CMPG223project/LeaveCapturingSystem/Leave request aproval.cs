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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Security.Cryptography;

namespace LeaveCapturingSystem
{
    public partial class frmLeave_request_aproval : Form
    {
        public frmLeave_request_aproval()
        {
            InitializeComponent();
        }

        private void Leave_request_aproval_Load(object sender, EventArgs e)
        {
            String connString;
            SqlConnection cnn;
            connString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\user\Desktop\CMPG223project\LeaveCapturingSystem\LeaveCaptureSystem.mdf;Integrated Security=True";
            cnn = new SqlConnection(connString);

            //filling data grid view
            cnn.Open();
            SqlCommand command;
            string sql;
            SqlDataAdapter adapter = new SqlDataAdapter();
            sql = @"Select * FROM Leave_application";
            command = new SqlCommand(sql, cnn);
            DataSet ds = new DataSet();
            adapter.SelectCommand = command;
            adapter.Fill(ds, "Leave_application");
            dgvApplicants.DataSource = ds;
            dgvApplicants.DataMember = "Leave_application";
            cnn.Close();

            // filling combo box
            cnn.Open();
            
            sql = @"Select LV_app_ID FROM Leave_application";//Only select the ID
            command = new SqlCommand(sql, cnn);
            adapter.SelectCommand = command;
            adapter.Fill(ds, "Leave_application");
            cmbLV_Employee_ID.DisplayMember = "LV_app_ID";
            cmbLV_Employee_ID.ValueMember = "LV_app_ID";
            cmbLV_Employee_ID.DataSource = ds.Tables["Leave_application"];

            cnn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            String connString;
            SqlConnection cnn;
            connString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\user\Desktop\CMPG223project\LeaveCapturingSystem\LeaveCaptureSystem.mdf;Integrated Security=True";
            cnn = new SqlConnection(connString);

            int employee_ID, manager_ID;
            DateTime dateResponse;
            string status;


            //insert to table

            manager_ID = Convert.ToInt32(lblManager_ID.Text);
            dateResponse = DateTime.Today;
            employee_ID = Convert.ToInt32(cmbLV_Employee_ID.SelectedItem);
            if (rbApproved.Checked)
                status = "Approved";
            else
                status = "Rejected";
            cnn.Open();

            string insert_query = "INSERT INTO Report VALUES(@Employee_ID, @Date, @Manager_ID, Leave_status)";
            SqlDataAdapter adapter = new SqlDataAdapter();
            SqlCommand cmd = new SqlCommand(insert_query, cnn);
      
            cmd.Parameters.AddWithValue("@Employee_ID", employee_ID);
            cmd.Parameters.AddWithValue("@Date", dateResponse);
            cmd.Parameters.AddWithValue("@Manager_ID", manager_ID);
            cmd.Parameters.AddWithValue("@Leave_status", status);
            
            cmd.ExecuteNonQuery();
            cnn.Close();

            MessageBox.Show("Application processe");

            //remove lrave from leave records
            cnn.Open();
            SqlCommand command;
            string sql;
            sql = @" DELETE FROM Leave_application WHERE LV_app_ID ='" + cmbLV_Employee_ID.SelectedItem + "'";
            command = new SqlCommand(sql, cnn);
            DataSet ds = new DataSet();
            adapter.DeleteCommand = command;
            adapter.DeleteCommand.ExecuteNonQuery(); 

            cnn.Close();

        }

        private void cmbLV_Employee_ID_SelectedIndexChanged(object sender, EventArgs e)
        {
            String connString;
            SqlConnection cnn;
            connString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\user\Desktop\CMPG223project\LeaveCapturingSystem\LeaveCaptureSystem.mdf;Integrated Security=True";
            cnn = new SqlConnection(connString);

            cnn.Open();
            SqlCommand command;
            string sql;
            SqlDataAdapter adapter = new SqlDataAdapter();
            sql = @"Select * FROM Leave_application Where LV_app_ID ='"
            + cmbLV_Employee_ID.SelectedValue + "'";
            command = new SqlCommand(sql, cnn);
            DataSet ds = new DataSet();
            adapter.SelectCommand = command;
            adapter.Fill(ds, "Leave_application");
            dgvApplicants.DataSource = ds;
            dgvApplicants.DataMember = "Leave_application";
            cnn.Close();
        }

        frmReport report = new frmReport();

        private void btnReports_Click(object sender, EventArgs e)
        {
            //report.lbl_ID.Text = (cmbStaff.SelectedItem).ToString();
            report.Show();
        }
    }
}
