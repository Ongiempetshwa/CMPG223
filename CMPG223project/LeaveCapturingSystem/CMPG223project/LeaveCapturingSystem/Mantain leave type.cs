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
    public partial class frmMantain_leave_type : Form
    {
        public frmMantain_leave_type()
        {
            InitializeComponent();
        }
        String connString;
        SqlConnection cnn;

        string sql;
        SqlCommand command;

        private void Mantain_leave_type_Load(object sender, EventArgs e)
        {
            
            connString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\user\Desktop\CMPG223project\LeaveCapturingSystem\LeaveCaptureSystem.mdf;Integrated Security=True";
            cnn = new SqlConnection(connString);
            
            //fill combo box with leave discriptions
            cnn.Open();
            SqlCommand command;
            string sql;
            SqlDataAdapter adapter = new SqlDataAdapter();

            sql = @"Select Leave_descreption FROM Leave_type";
            command = new SqlCommand(sql, cnn);
            DataSet ds = new DataSet();
            adapter.SelectCommand = command;
            adapter.Fill(ds, "Leave_type");
            cmbLeaveType.DisplayMember = "Leave_descreption";
            cmbLeaveType.ValueMember = "Leave_descreption";
            cmbLeaveType.DataSource = ds.Tables["Leave_type"];
            cnn.Close();

            //fill combo box with leave discriptions
            cnn.Open();
            sql = @"Select Leave_descreption FROM Leave_type";
            command = new SqlCommand(sql, cnn);
            adapter.SelectCommand = command;
            adapter.Fill(ds, "Leave_type");
            cmbLeaveType.DisplayMember = "Leave_descreption";
            cmbLeaveType.ValueMember = "Leave_descreption";
            cmbLeaveType.DataSource = ds.Tables["Leave_type"];
            cnn.Close();

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            cnn.Open();
            cnn.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string description;
            int numDays;

            connString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\user\Desktop\CMPG223project\LeaveCapturingSystem\LeaveCaptureSystem.mdf;Integrated Security=True";
            cnn.Close();

            description = txtAddDisc.Text ;
            numDays = Convert.ToInt32(txtAddNumDays.Text);
            
            string insert_query = "INSERT INTO Leave_type VALUES(@Leave_description, @NO_of_days)";
            SqlDataAdapter adapter = new SqlDataAdapter();
            SqlConnection con = new SqlConnection(connString);
            SqlCommand cmd = new SqlCommand(insert_query, con);

            cmd.Parameters.AddWithValue("@Leave_description", description);
            cmd.Parameters.AddWithValue("@NO_of_days", numDays);
            cmd.ExecuteNonQuery();
            cnn.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string leaveD = txtUpdateDescription .Text;
            string numDays = txtUpdateNumDay.Text;
            
            SqlCommand command;
            SqlDataAdapter adapter = new SqlDataAdapter();
            string sql;
            cnn.Open();

            sql = @" UPDATE Leave_type SET Leave_descreption = 'leaveD', NO_of_days = 'numDays' WHERE Leave_descreption = '" + cmbUpdtLeaveTyp.SelectedItem + "'";
            command = new SqlCommand(sql, cnn);
            adapter.UpdateCommand = new SqlCommand(sql, cnn);
            adapter.UpdateCommand.ExecuteNonQuery();
        }
    }
}
