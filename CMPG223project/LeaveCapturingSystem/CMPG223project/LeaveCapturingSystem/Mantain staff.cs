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
    public partial class frmMantain_staff : Form
    {
        public frmMantain_staff ()
        {
            InitializeComponent();
        }
        String connString;
        SqlConnection cnn;

        string sql;
        SqlCommand command;

        private void Mantain_staff_Load(object sender, EventArgs e)
        {
            connString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\user\Desktop\CMPG223project\LeaveCapturingSystem\LeaveCaptureSystem.mdf;Integrated Security=True";
            cnn = new SqlConnection(connString);

            cnn.Open();
            cnn.Close();

            cnn.Open();

            SqlDataAdapter adapter = new SqlDataAdapter();
            sql = @"Select * FROM Employee";
            command = new SqlCommand(sql, cnn);
            DataSet ds = new DataSet();
            adapter.SelectCommand = command;
            adapter.Fill(ds, "Employee"); 
            dgvDltEmployee.DataSource = ds; 
            dgvDltEmployee.DataMember = "Employee";

            cnn.Close();

            cnn.Open();
            sql = @"Select Employee_ID FROM Employee";
            command = new SqlCommand(sql, cnn);
            adapter.SelectCommand = command;
            adapter.Fill(ds, "Employee");
            cmbEmplDlt.DisplayMember = "Employee_ID"; //Field to be displayed
            cmbEmplDlt.ValueMember = "Employee_ID"; //Value to be returned
            cmbEmplDlt.DataSource = ds.Tables["Employee"];//Table in the dataset to use
            cnn.Close();

            cnn.Open();
            sql = @"Select Employee_ID FROM Employee";//Only select the EmployeeID
            command = new SqlCommand(sql, cnn);
            adapter.SelectCommand = command;
            adapter.Fill(ds, "Employee");
            cmbEmployee.DisplayMember = "Employee_ID"; //Field to be displayed
            cmbEmployee.ValueMember = "Employee_ID"; //Value to be returned
            cmbEmployee.DataSource = ds.Tables["Employee"];//Table in the dataset to use
            cnn.Close();

        }

        private void cBoxEmployeeDlt_SelectedIndexChanged(object sender, EventArgs e)
        {
            cnn.Open();
            SqlDataAdapter adapter = new SqlDataAdapter();
            sql = @"Select Employee_ID FROM Employee";//Only select the EmployeeID
            command = new SqlCommand(sql, cnn);
            DataSet ds = new DataSet();
            adapter.SelectCommand = command;
            adapter.Fill(ds, "Employee");
            cmbEmployee.DisplayMember = "Employee_ID"; //Field to be displayed
            cmbEmployee.ValueMember = "Employee_ID"; //Value to be returned
            cmbEmployee.DataSource = ds.Tables["Employee"];//Table in the dataset to use
            cnn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cnn.Open();
            SqlCommand command;
            string sql;
            SqlDataAdapter adapter = new SqlDataAdapter();
            sql = @" DELETE FROM Employee WHERE Employee_ID ='" + cmbEmplDlt.SelectedItem + "'";
            command = new SqlCommand(sql, cnn);
            DataSet ds = new DataSet();
            adapter.DeleteCommand = command;
            adapter.DeleteCommand.ExecuteNonQuery(); //Deletes from database, Adapter makes changes
            cnn.Close();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {

            connString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\user\Desktop\CMPG223project\LeaveCapturingSystem\LeaveCaptureSystem.mdf;Integrated Security=True";
            cnn.Close();

            string fname, lname,cellNum, password;
                    
            fname = txtNewF_name.Text;
            lname = txtNewL_name.Text;
            cellNum = txtNewCell_number.Text;
            password = txtNewCell_number.Text;

            string insert_query = "INSERT INTO Employee VALUES(@Employee_ID, @F_name, @L_anme, @Cell_number, @Password)";
            SqlDataAdapter adapter = new SqlDataAdapter();
            SqlConnection con = new SqlConnection(connString);
            SqlCommand cmd = new SqlCommand(insert_query, con);
            
            cmd.Parameters.AddWithValue("@ID", fname);
            cmd.Parameters.AddWithValue("@fname", lname);
            cmd.Parameters.AddWithValue("@lanme", cellNum);
            cmd.Parameters.AddWithValue("@age", password);
            cmd.ExecuteNonQuery();
            cnn.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string fName = txtUpdateF_name.Text;
            string lName = txtUpdateLname.Text;
            string cNum =  txtUpdNumber.Text;

            SqlCommand command;
            SqlDataAdapter adapter = new SqlDataAdapter();
            string sql;
            cnn.Open();
            
            sql = @" UPDATE Employee SET F_name = 'fName', L_name = 'lName', Cell_number = 'cNum' WHERE Employee_ID = '" + cmbEmployee.SelectedItem + "'";
            command = new SqlCommand(sql, cnn);
            adapter.UpdateCommand = new SqlCommand(sql, cnn);
            adapter.UpdateCommand.ExecuteNonQuery();
        }
    }
}
