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

namespace BankProject
{
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
        }
       

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLogIn_Click_1(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\90535\source\repos\HelloWorld\BankProject\Database1.mdf;Integrated Security=True");
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("select count(*) from LogInTable where UserName = '" + txtUserName.Text + "' and Password = '" + txtPassword.Text + "'", connection);
            DataSet dataSet = new DataSet();

            connection.Open();
            sqlDataAdapter.Fill(dataSet, "LogIn");
            connection.Close();

            if (dataSet.Tables[0].Rows[0][0].ToString() != "0")
            {
                Form1 f = new Form1(this);
                f.Visible = true;
                this.Visible = false;
                txtUserName.Text = "";
                txtPassword.Text = "";
            }
            else
            {
                txtUserName.Text = "";
                txtPassword.Text = "";
                MessageBox.Show("User name or password is invalid!", "Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
