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
    public partial class Reports : Form
    {
        public Reports()
        {
            InitializeComponent();
        }
        String connString;
        SqlConnection cnn;

        SqlCommand command;
        string sql;

        private void Reports_Load(object sender, EventArgs e)
        {
            
            connString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\user\Desktop\CMPG223project\LeaveCapturingSystem\LeaveCaptureSystem.mdf;Integrated Security=True";
            cnn = new SqlConnection(connString);
            
            cnn.Open();

            SqlDataAdapter adapter = new SqlDataAdapter();
            sql = @"Select * FROM Employee";
            command = new SqlCommand(sql, cnn);
            DataSet ds = new DataSet();
            adapter.SelectCommand = command;
            adapter.Fill(ds, "Info"); //fills the dataset with the results in the table adapter
            dgvEmployee.DataSource = ds; // Set the datasource to the dataset
            dgvEmployee.DataMember = "Info";//Point to


            cnn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            

        }

        private void dgvEmployee_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
