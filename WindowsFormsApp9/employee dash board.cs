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
    public partial class employee_dash_board : Form
    {
        public employee_dash_board()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            empolyee_leave_formcs k = new empolyee_leave_formcs();
            k.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            View_Leave_Status status = new View_Leave_Status();
            status.Show();
            this.Hide();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Delete_leave delete_Leave = new Delete_leave();
            delete_Leave.Show();
            this.Hide();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Leave_histroy_cs leave_Histroy_Cs = new Leave_histroy_cs();
            leave_Histroy_Cs.Show();
            this.Hide();
            

        }

      

        private void button4_Click(object sender, EventArgs e)
        {
            ADmin_or_user aDmin_Or_User = new ADmin_or_user();
            aDmin_Or_User.Show();
            this.Hide();
        }
    }
}
