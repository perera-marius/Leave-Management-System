using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp9
{
    public partial class Leave_histroy_cs : Form
    {
        public Leave_histroy_cs()
        {
            InitializeComponent();
            tableload();
            

        }

        public void tableload()
        {
            string path = "Data Source=DESKTOP-3L9M0TK\\SQLEXPRESS02;Initial Catalog=LMSDB25;Integrated Security=True;TrustServerCertificate=True;";
            string searchQuery = "SELECT * FROM Employee1 WHERE EmployeeID = '" + textBox1.Text+"'";


            SqlConnection con = new SqlConnection(path);
            DataTable dt = new DataTable();
            SqlDataAdapter ad = new SqlDataAdapter(searchQuery, con);

            con.Open();
            ad.Fill(dt);
            con.Close();


            // return dt;
            dataGridView3.DataSource = dt;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            employee_dash_board employee_Dash_Board = new employee_dash_board();
            employee_Dash_Board.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string path = "Data Source=DESKTOP-3L9M0TK\\SQLEXPRESS02;Initial Catalog=LMSDB25;Integrated Security=True;TrustServerCertificate=True;";
            string searchQuery = "SELECT * FROM Employee1";


            SqlConnection con = new SqlConnection(path);
            DataTable dt = new DataTable();
            SqlDataAdapter ad = new SqlDataAdapter(searchQuery, con);

            con.Open();
            ad.Fill(dt);
            con.Close();

            dataGridView3.DataSource = dt;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string path = "Data Source=DESKTOP-3L9M0TK\\SQLEXPRESS02;Initial Catalog=LMSDB25;Integrated Security=True;TrustServerCertificate=True;";
            string searchQuery = "SELECT * FROM Employee1 WHERE EmployeeID = '" + textBox1.Text + "'";


            SqlConnection con = new SqlConnection(path);
            DataTable dt = new DataTable();
            SqlDataAdapter ad = new SqlDataAdapter(searchQuery, con);

            con.Open();
            ad.Fill(dt);
            con.Close();


            // return dt;
            dataGridView3.DataSource = dt;
        }
    }
}
