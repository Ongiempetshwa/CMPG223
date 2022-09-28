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

namespace LeaveCapturingSystem
{
    public partial class frmMainPage : Form
    {
        public frmMainPage()
        {
            InitializeComponent();
        }
        SqlConnection cnn =  new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\user\Desktop\CMPG223project\LeaveCapturingSystem\LeaveCaptureSystem.mdf;Integrated Security=True");
       
        private void Form1_Load(object sender, EventArgs e)
        {
           
            // filling combo box
            cnn.Open();
                        
            SqlCommand command;
            string sql;
            SqlDataAdapter adapter = new SqlDataAdapter();

            sql = @"Select Employee_ID FROM Employee";//Only select the ID
            command = new SqlCommand(sql, cnn);
            DataSet ds = new DataSet();
            adapter.SelectCommand = command;
            adapter.Fill(ds, "Employee");
            cmbStaff.DisplayMember = "Employee_ID";
            cmbStaff.ValueMember = "Employee_ID"; 
            cmbStaff.DataSource = ds.Tables["Employee"];
            cnn.Close();

            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand command;
            string sql;
            SqlDataAdapter adapter = new SqlDataAdapter();

            string password = txtPassword.Text;

            String connString;
            SqlConnection cnn;
            connString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\user\Desktop\CMPG223project\LeaveCapturingSystem\LeaveCaptureSystem.mdf;Integrated Security=True";
            cnn = new SqlConnection(connString);

            //filling data grid view
            cnn.Open();
            sql = @"Select * FROM Employee Where Password ='" + password + "'";
            command = new SqlCommand(sql, cnn);
            DataSet ds = new DataSet();
            adapter.SelectCommand = command;
            adapter.Fill(ds, "Employee");
            dgvEmployee.DataSource = ds;
            dgvEmployee.DataMember = "Employee";
            cnn.Close();

            frmApply_for_leave apply = new frmApply_for_leave();
            frmLeave_request_aproval approve = new frmLeave_request_aproval();
            frmMantain_staff staffMaintain = new frmMantain_staff();
            if (rbtnEmployee.Checked)
            {
                apply.lbl_ID.Text = (cmbStaff.SelectedItem).ToString();
                apply.ShowDialog();
            }
            else if(rbtnManagement.Checked)
            {
                approve.lblManager_ID.Text = (cmbStaff.SelectedItem).ToString();
                approve.ShowDialog();
            }
            else if (rbtnAdmin.Checked)
            {
                //staffMaintain.lblAdmin_ID.Text = (cmbStaff.SelectedItem).ToString();
                staffMaintain.ShowDialog();
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
