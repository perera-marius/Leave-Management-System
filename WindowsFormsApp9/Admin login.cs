using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp9
{
    public partial class Admin_login : Form
    {
        public Admin_login()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textAdmin.Text == "admin" && textadmin1.Text == "1234")
            {
                Admin_dash_borad mb = new Admin_dash_borad();
                mb.Show();
                this.Hide();
                MessageBox.Show("login successfully", "Alert Box !!!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            }
            else
            {
                MessageBox.Show("incorrect Username or Password", "Alert Box !!!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);


            }
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
