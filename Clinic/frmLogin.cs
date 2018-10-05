﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Clinic
{
    public partial class frmLogin : Form
    {
        public static String user_id = "";
        public static String session_name = "";
        MySqlConnection conn = new MySqlConnection("server = localhost; uid = root; pwd=;database= db_clinic");
        public frmLogin()
        {
            InitializeComponent();
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
          
            conn.Open();
            String user = convertQuotes(txtUsername.Text);
            String password = convertQuotes(txtPassword.Text);

            String sql = "SELECT user_id,username,password FROM user WHERE username ='" + user + "' AND password = md5('" + password + "')";
            
            MySqlCommand cmd = new MySqlCommand(sql,conn);
            MySqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    MessageBox.Show("Welcome " + dr.GetString(1));
                    user_id = dr.GetString(0);
                    session_name = dr.GetString(1);
                }
                conn.Close();
                conn.Open();
                String sql3 = "truncate summary";
                MySqlCommand cmd3 = new MySqlCommand(sql3, conn);
                cmd3.ExecuteNonQuery();
                conn.Close();
                frmLanding frm = new frmLanding();
                frm.Show();
                this.Hide();
            }
            else {
                MessageBox.Show("Invalid username or password");
                txtPassword.Clear();


            }
            conn.Close();
        }
        public string convertQuotes(string str)
        {

            return str.Replace("'", "''");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtUsername.Text = "";
            txtPassword.Text = "";

        }
    }
}
