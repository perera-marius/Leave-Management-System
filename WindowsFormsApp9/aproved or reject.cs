using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Lifetime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp9
{
    public partial class aproved_or_reject : Form
    {
        public aproved_or_reject()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int colId = Convert.ToInt32(textBox1.Text);
            string EmployeeID = textBox1.Text;
            string LeaveStatus = textBox2.Text;

            string updateQuery = "UPDATE statusleave5 SET EmployeeID = '" + EmployeeID + "',LeaveStatus = '" + LeaveStatus + "' WHERE statusleaveid = '" + colId + "'";
            string path = "Data Source=DESKTOP-3L9M0TK\\SQLEXPRESS02;Initial Catalog=LMSDB25;Integrated Security=True;TrustServerCertificate=True;";
            SqlConnection conn = new SqlConnection(path);

            SqlCommand cmd = new SqlCommand(updateQuery, conn);
            conn.Open();
            cmd.ExecuteNonQuery();
        }

        private void aproved_or_reject_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Manage_Leave_Applications_Form manage_Leave_Applications_Form = new Manage_Leave_Applications_Form();
            manage_Leave_Applications_Form.Show();
            this.Hide();

        }
    }
}
