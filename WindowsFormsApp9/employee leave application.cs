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
    public partial class empolyee_leave_formcs : Form
    {
        public empolyee_leave_formcs()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void empolyee_leave_formcs_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            {
                string Connectionstring, commandstring;
                Connectionstring = "Data Source=DESKTOP-3L9M0TK\\SQLEXPRESS02;Initial Catalog=LMSDB25;Integrated Security=True;TrustServerCertificate=True;";
                commandstring = "INSERT INTO LeaveApplication13 VALUES ('" + textBox6.Text + "', '" + textBox1.Text + "', '" + comboBox1.SelectedItem.ToString()+ "', '" + textdate.Text + "', '" + textBox5.Text + "','"+ textBox4.Text+ "')";
                SqlConnection Conn = new SqlConnection(Connectionstring);
                SqlCommand Command = new SqlCommand(commandstring, Conn);

                Conn.Open();
                Command.ExecuteNonQuery();

                MessageBox.Show("apply successfully", "Alert Box !!!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            employee_dash_board employee_Dash_Board = new employee_dash_board();
             employee_Dash_Board.Show();
            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            employee_dash_board em = new employee_dash_board();
            em.Show();
            this.Hide();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
