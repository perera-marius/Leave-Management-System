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
    public partial class a_Register_New_Employee_Form : Form
    {
        public a_Register_New_Employee_Form()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

           
            string Connectionstring, commandstring;
            Connectionstring = "Data Source=DESKTOP-3L9M0TK\\SQLEXPRESS02;Initial Catalog=LMSDB25;Integrated Security=True;TrustServerCertificate=True;";
            commandstring = "INSERT INTO Employee1 VALUES ('"+ textBox1.Text+ "', '"+ textBox2 .Text+ "', '"+ textppssword.Text+ "', '"+ textBox3.Text+ "','"+ textBox4.Text+ "', '"+ textBox5 .Text+ "', '"+ textBox6.Text+ "', '"+ textBox7.Text+ "')";
            SqlConnection Conn = new SqlConnection(Connectionstring);
            SqlCommand Command = new SqlCommand(commandstring, Conn);

            Conn.Open();
            Command.ExecuteNonQuery();

            MessageBox.Show("register suscessfully", "Alert Box !!!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
        Admin_dash_borad admin_Dash_Borad = new Admin_dash_borad(); 
            admin_Dash_Borad.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int ID = Convert.ToInt32(textBox1.Text);


            string DeleteQuery = "delete Employee1 WHERE  EmployeeID = '" + ID + "' ";
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
