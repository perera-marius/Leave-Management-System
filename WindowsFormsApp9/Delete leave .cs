using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp9
{
    public partial class Delete_leave : Form
    {
        public Delete_leave()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            employee_dash_board employee_Dash_Board=new employee_dash_board();
            employee_Dash_Board.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string path = "Data Source=DESKTOP-3L9M0TK\\SQLEXPRESS02;Initial Catalog=LMSDB25;Integrated Security=True;TrustServerCertificate=True;";
            string searchQuery = "SELECT * FROM LeaveApplication13";

            SqlConnection con = new SqlConnection(path);
            DataTable dt = new DataTable();
            SqlDataAdapter ad = new SqlDataAdapter(searchQuery, con);

            con.Open();
            ad.Fill(dt);
            con.Close();

            dataGridView2.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int ID = Convert.ToInt32(textBox1.Text);


            string DeleteQuery = "delete LeaveApplication12 WHERE  LeaveApplicationID = '" + ID + "' ";
            string path = "Data Source=DESKTOP-3L9M0TK\\SQLEXPRESS02;Initial Catalog=LMSDB25;Integrated Security=True;TrustServerCertificate=True;";
            SqlConnection conn = new SqlConnection(path);

            SqlCommand cmd = new SqlCommand(DeleteQuery, conn);
            conn.Open();
            cmd.ExecuteNonQuery();
            MessageBox.Show("Data Delete sucssfully ");
            conn.Close();
        }
    }
}
