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
    public partial class frmItemGroupName : Form
    {
        MySqlConnection conn = new MySqlConnection("server = localhost; uid = root; pwd=;database= db_clinic");
        String group_id = "";
        public frmItemGroupName()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String group = convertQuotes(txtGroup.Text);
            String desc = convertQuotes(txtDesc.Text);
            if (group != "" && desc != "")
            {
            conn.Open();
            String sql = "INSERT INTO item_group_names (group_name, description) VALUES ('" + group + "','" + desc + "')";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Add Successful!");
            dgvGroup.Refresh();
            frmItemGroupName_Load(sender, e);
            txtGroup.Clear();
            txtDesc.Clear();
            }else{
                MessageBox.Show("Please enter name and description!");
            }
        }
        public string convertQuotes(string str)
        {

            return str.Replace("'", "''");

        }

        private void frmItemGroupName_Load(object sender, EventArgs e)
        {
            conn.Open();
            String sql = "SELECT ig_name_id,group_name,description FROM item_group_names";
            MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvGroup.DataSource = dt;
            conn.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            conn.Open();
            String group = convertQuotes(txtGroup.Text);
            String desc = convertQuotes(txtDesc.Text);
            if(group != "" && desc != ""){
            String sql = "UPDATE item_group_names SET group_name = '"+group+"', description = '"+desc+"' WHERE ig_name_id = '"+group_id+"'";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Update Successful!");
            dgvGroup.Refresh();
            frmItemGroupName_Load(sender, e);
            txtGroup.Clear();
            txtDesc.Clear();
            }else{
                MessageBox.Show("Please enter name and description!");
            }
        }

        private void dgvGroup_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dgvGroup_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            if (e.RowIndex > -1)
            {
                DataGridViewRow row = dgvGroup.Rows[i];
                group_id = row.Cells[0].Value.ToString();
                txtGroup.Text = row.Cells[1].Value.ToString();
                txtDesc.Text = row.Cells[2].Value.ToString();
            }
        }
    }
}
