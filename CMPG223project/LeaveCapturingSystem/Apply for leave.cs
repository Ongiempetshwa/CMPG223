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
    public partial class Apply_for_leave : Form
    {
        public Apply_for_leave()
        {
            InitializeComponent();
        }
        String connString;
        SqlConnection cnn;

        string sql;
        SqlCommand command;
        
        private void Apply_for_leave_Load(object sender, EventArgs e)
        {
            
            connString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\user\Desktop\CMPG223project\LeaveCapturingSystem\LeaveCaptureSystem.mdf;Integrated Security=True";
            cnn = new SqlConnection(connString);
            cnn.Open();
            cnn.Close();
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            cnn.Open();
            SqlDataAdapter adapter = new SqlDataAdapter();
            sql = @"Select LV_descreption FROM Leave_type";//Only select the surnames
            command = new SqlCommand(sql, cnn);
            DataSet ds = new DataSet();
            adapter.SelectCommand = command;
            adapter.Fill(ds, "Leave_type");
            cboxLeave_type.DisplayMember = "Surnames"; //Field to be displayed
            cboxLeave_type.ValueMember = "Surnames"; //Value to be returned
            cboxLeave_type.DataSource = ds.Tables["TableInformation"];//Table in the dataset to use
            cnn.Close();
        }

        private void cboxManager_SelectedIndexChanged(object sender, EventArgs e)
        {
            cnn.Open();
            SqlDataAdapter adapter = new SqlDataAdapter();
            sql = @"Select LV_descreption FROM Leave_type";//Only select the surnames
            command = new SqlCommand(sql, cnn);
            DataSet ds = new DataSet();
            adapter.SelectCommand = command;
            adapter.Fill(ds, "Leave_type");
            cboxLeave_type.DisplayMember = "Surnames"; //Field to be displayed
            cboxLeave_type.ValueMember = "Surnames"; //Value to be returned
            cboxLeave_type.DataSource = ds.Tables["TableInformation"];//Table in the dataset to use
            cnn.Close();
        }
    }
}
