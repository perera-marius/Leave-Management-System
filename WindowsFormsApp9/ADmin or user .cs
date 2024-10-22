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
    public partial class ADmin_or_user : Form
    {
        public ADmin_or_user()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Admin_login admin_Login = new Admin_login();
            admin_Login.Show();
                this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Employee_login employee_Login = new Employee_login();   
            employee_Login.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Hide();
        }
    }
}
