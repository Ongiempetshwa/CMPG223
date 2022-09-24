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
    public partial class Mantain_leave_type : Form
    {
        public Mantain_leave_type()
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
            cnn.Open();
            cnn.Close();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
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

        private void button3_Click(object sender, EventArgs e)
        {
            connString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\user\Desktop\CMPG223project\LeaveCapturingSystem\LeaveCaptureSystem.mdf;Integrated Security=True";
            cnn.Close();

            string discription;
            int numDays;

            discription = txtDisc.Text;
            numDays = Convert.ToInt32(txtNumDays.Text);


            string insert_query = "INSERT INTO Employee VALUES(@Employee_ID, @Discription, @NO_of_days)";
            SqlDataAdapter adapter = new SqlDataAdapter();
            SqlConnection con = new SqlConnection(connString);
            SqlCommand cmd = new SqlCommand(insert_query, con);

            cmd.Parameters.AddWithValue("@ID", discription);
            cmd.Parameters.AddWithValue("@fname", numDays);
    
            cmd.ExecuteNonQuery();
            cnn.Close();
        }
    }
}
