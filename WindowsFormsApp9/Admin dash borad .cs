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
    public partial class Admin_dash_borad : Form
    {
        public Admin_dash_borad()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            a_Register_New_Employee_Form ar =new a_Register_New_Employee_Form();
            ar.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ADmin_or_user aDmin_Or_User = new ADmin_or_user();
            aDmin_Or_User.Show(); this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Manage_Leave_Applications_Form ml = new Manage_Leave_Applications_Form();
            ml.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            View_Leave_Reports_Form view_Leave_Reports_Form = new View_Leave_Reports_Form();
            view_Leave_Reports_Form.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            employee_leave_balance employee_Leave_Balance = new employee_leave_balance();
            employee_Leave_Balance.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Admin_register admin_Register = new Admin_register();
            admin_Register.Show();
            this.Hide();
        }
    }
}
