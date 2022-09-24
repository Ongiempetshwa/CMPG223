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
    public partial class Mantain_staff : Form
    {
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
            adapter.Fill(ds, "Info"); 
            dgvDltEmployee.DataSource = ds; 
            dgvDltEmployee.DataMember = "Info";


            cnn.Close();
        }

        private void cboxEmployee_SelectedIndexChanged(object sender, EventArgs e)
        {
            cnn.Open();
            SqlDataAdapter adapter = new SqlDataAdapter();
            sql = @"Select Employee_ID FROM Employee";//Only select the EmployeeID
            command = new SqlCommand(sql, cnn);
            DataSet ds = new DataSet();
            adapter.SelectCommand = command;
            adapter.Fill(ds, "Employee");
            cboxEmployee.DisplayMember = "Employee_ID"; //Field to be displayed
            cboxEmployee.ValueMember = "Employee_ID"; //Value to be returned
            cboxEmployee.DataSource = ds.Tables["Employee"];//Table in the dataset to use
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
            cboxEmployee.DisplayMember = "Employee_ID"; //Field to be displayed
            cboxEmployee.ValueMember = "Employee_ID"; //Value to be returned
            cboxEmployee.DataSource = ds.Tables["Employee"];//Table in the dataset to use
            cnn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cnn.Open();
            SqlCommand command;
            string sql;
            SqlDataAdapter adapter = new SqlDataAdapter();
            sql = @" DELETE FROM Employee WHERE Employee_ID ='" + cboxEmployee.SelectedIndex + "'";
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
                    
            fname = newF_name.Text;
            lname = newL_name.Text;
            cellNum = newCell_number.Text;
            password = newCell_number.Text;

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
    }
}
