using System;
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
    public partial class frmSetting : Form
    {
        MySqlConnection conn = new MySqlConnection("server = localhost; uid = root; pwd=;database= db_clinic");
        public frmSetting()
        {
            InitializeComponent();
        }

        private void frmSetting_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            conn.Open();
            String verify = convertQuotes(txtVerify.Text);
            String sql = "SELECT password FROM user WHERE user_id ='"+frmLogin.user_id+"' AND password = md5('"+verify+"')";
            MySqlCommand cmd = new MySqlCommand(sql,conn);
            MySqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    groupBox1.Enabled = true;
                    txtVerify.Clear();
                    txtUsername.Text = frmLogin.session_name;
                }
            }
            else {
                MessageBox.Show("Your password doesn't match");
            }
            conn.Close();
        }
        public string convertQuotes(string str)
        {

            return str.Replace("'", "''");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            String user = txtUsername.Text;
            String password = txtPassword.Text;
            String confirm = txtConfirm.Text;

            if (password != confirm)
            {
                MessageBox.Show("Password doesn't match");
            }
            else if (user == "" || password == "")
            {
                MessageBox.Show("Please fill up the textboxes");
            }
            else {
                conn.Open();
                String sql = "UPDATE user SET username = '"+user+"', password = md5('"+password+"') WHERE user_id = '"+frmLogin.user_id+"'";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("You have updated your account");
                txtUsername.Clear();
                txtPassword.Clear();
                txtConfirm.Clear();
                groupBox1.Enabled = false;
                conn.Close();
            }
        }
    }
}
