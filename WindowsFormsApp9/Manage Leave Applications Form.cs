﻿using System;
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
    public partial class Manage_Leave_Applications_Form : Form
    {
        public Manage_Leave_Applications_Form()
        {
            InitializeComponent();
        }

        private void Manage_Leave_Applications_Form_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Admin_dash_borad admin_Dash_Borad = new Admin_dash_borad(); 
            admin_Dash_Borad.Show();
            this.Hide();    
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string path = "Data Source=DESKTOP-3L9M0TK\\SQLEXPRESS02;Initial Catalog=LMSDB25;Integrated Security=True;TrustServerCertificate=True;";
            string searchQuery = "SELECT * FROM LeaveApplication12";


            SqlConnection con = new SqlConnection(path);
            DataTable dt = new DataTable();
            SqlDataAdapter ad = new SqlDataAdapter(searchQuery, con);

            con.Open();
            ad.Fill(dt);
            con.Close();

            dataGridView4.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            aproved_or_reject aproved_Or_Reject = new aproved_or_reject();
            aproved_Or_Reject.Show();
            this.Hide();
        }
    }
}