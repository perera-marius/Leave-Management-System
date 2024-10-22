using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp9
{
    public partial class Employee_login : Form
    {
        public Employee_login()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textuser1.Text == "employee" && textppssword.Text == "1234")
            {
                employee_dash_board mb = new employee_dash_board();
                mb.Show();
                this.Hide();
                MessageBox.Show("login successfully", "Alert Box !!!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            }
            else
            {
                MessageBox.Show("incorrect Username or Password", "Alert Box !!!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);


            }
        }

        private void Employee_login_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
        
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ADmin_or_user aDmin_Or_User = new ADmin_or_user();
            aDmin_Or_User.Show();
            this.Hide();
        }
    }
}
