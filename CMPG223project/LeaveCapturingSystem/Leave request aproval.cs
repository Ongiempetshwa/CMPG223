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
    public partial class Leave_request_aproval : Form
    {
        public Leave_request_aproval()
        {
            InitializeComponent();
        }

        private void Leave_request_aproval_Load(object sender, EventArgs e)
        {
            String connString;
            SqlConnection cnn;
            connString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\user\Desktop\CMPG223project\LeaveCapturingSystem\LeaveCaptureSystem.mdf;Integrated Security=True";
            cnn = new SqlConnection(connString);
            cnn.Open();
            cnn.Close();
        }
    }
}
