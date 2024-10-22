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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp9
{
    public partial class Admin_register : Form
    {
        public Admin_register()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
          Admin_dash_borad admin_Dash_Borad = new Admin_dash_borad();
           admin_Dash_Borad.Show();
            this.Hide();    
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Connectionstring, commandstring;
            Connectionstring = "Data Source=DESKTOP-3L9M0TK\\SQLEXPRESS02;Initial Catalog=LMSDB25;Integrated Security=True;TrustServerCertificate=True;";
            commandstring = "INSERT INTO ADMIN123 VALUES  ('" + textBox1 .Text+ "', '"+ textBox2 .Text+ "','"+ textBox3.Text + "')";
            SqlConnection Conn = new SqlConnection(Connectionstring);
            SqlCommand Command = new SqlCommand(commandstring, Conn);
            Conn.Open();
            Command.ExecuteNonQuery();

            MessageBox.Show("register suscessfully", "Alert Box !!!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
        }
    }
}
