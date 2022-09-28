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
using System.Xml.Linq;

namespace LeaveCapturingSystem
{
    public partial class frmApply_for_leave : Form
    {
        public frmApply_for_leave()
        {
            InitializeComponent();
        }
        String connString;
        SqlConnection cnn;

        string sql;
        SqlCommand command;
        
        private void Apply_for_leave_Load(object sender, EventArgs e)
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
            sql = @"Select * FROM Leave_type";
            command = new SqlCommand(sql, cnn);
            DataSet ds = new DataSet();
            adapter.SelectCommand = command;
            adapter.Fill(ds, "Leave_type");
            dgvLeaveType.DataSource = ds;
            dgvLeaveType.DataMember = "Leave_type";
            cnn.Close();

            // filling combo box manager

            cnn.Open();
                
            sql = @"Select F_name FROM Manager";//Only select the manager name
            command = new SqlCommand(sql, cnn);
            adapter.SelectCommand = command;
            adapter.Fill(ds, "Manager");
            cmbManager.DisplayMember = "F_name";
            cmbManager.ValueMember = "F_name";
            cmbManager.DataSource = ds.Tables["Manager"];

            cnn.Close();

            // filling combo box Leave type

            cnn.Open();

            sql = @"Select Leave_type_ID FROM Leave_type";//Only select leave type ID
            command = new SqlCommand(sql, cnn);
            adapter.SelectCommand = command;
            adapter.Fill(ds, "Leave_type");
            cmbLeave_ID.DisplayMember = "Leave_type_ID";
            cmbLeave_ID.ValueMember = "Leave_type_ID";
            cmbLeave_ID.DataSource = ds.Tables["Leave_type"];

            cnn.Close();

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void cboxManager_SelectedIndexChanged(object sender, EventArgs e)
        {
        
        }

        private void lbl_ID_Click(object sender, EventArgs e)
        {
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String connString;
            SqlConnection cnn;
            connString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\user\Desktop\CMPG223project\LeaveCapturingSystem\LeaveCaptureSystem.mdf;Integrated Security=True";
            cnn = new SqlConnection(connString);

            //insert to table
            int employee_ID, leave_type_ID, manager_ID;
            
            employee_ID = Convert.ToInt32(lbl_ID.Text);
            leave_type_ID = Convert.ToInt32(cmbLeave_ID);
            manager_ID = Convert.ToInt32(cmbManager.SelectedItem);

            cnn.Open();

            string insert_query = "INSERT INTO Leave_application VALUES(@Employee_ID, @Leave_type_ID, @Manager_ID)";
            SqlDataAdapter adapter = new SqlDataAdapter();
            SqlCommand cmd = new SqlCommand(insert_query, cnn);
            // Here you can assign the values from the user to the placeholders after you have created the SqlCommand

            cmd.Parameters.AddWithValue("@Employee_ID", employee_ID);
            cmd.Parameters.AddWithValue("@Leave_type_ID", leave_type_ID);
            cmd.Parameters.AddWithValue("@Manager_ID", manager_ID);
            cmd.ExecuteNonQuery();
            cnn.Close();

            MessageBox.Show("Application submited");
        }
    }
}
