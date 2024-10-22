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
    public partial class View_Leave_Status : Form
    {
        public View_Leave_Status()
        {
            InitializeComponent();
        }

        private void View_Leave_Status_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            employee_dash_board employee_Dash_Board =new employee_dash_board();
            employee_Dash_Board.Show();
                this.Hide();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string path = "Data Source=DESKTOP-3L9M0TK\\SQLEXPRESS02;Initial Catalog=LMSDB25;Integrated Security=True;TrustServerCertificate=True;";
            string searchQuery = "SELECT * FROM statusleave5";

            SqlConnection con = new SqlConnection(path);
            DataTable dt = new DataTable();
            SqlDataAdapter ad = new SqlDataAdapter(searchQuery, con);

            con.Open();
            ad.Fill(dt);
            con.Close();

            dataGridView1.DataSource = dt;
        }
    }
}
