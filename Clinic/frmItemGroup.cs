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
    public partial class frmItemGroup : Form
    {
        MySqlConnection conn = new MySqlConnection("server = localhost; uid = root; pwd=;database= db_clinic");
        String item_id = "";
        String group_id = "";
        public frmItemGroup()
        {
            InitializeComponent();
        }

        private void frmItemGroup_Load(object sender, EventArgs e)
        {
            conn.Open();
            String sql = "SELECT item_id,name,brand FROM item_info";
            MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvItem.DataSource = dt;
            conn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void dgvItem_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            if (e.RowIndex > -1)
            {
                DataGridViewRow row = dgvItem.Rows[i];
                item_id = row.Cells[0].Value.ToString();
                txtItem.Text = row.Cells[1].Value.ToString();
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            conn.Open();
            String sql = "SELECT name,brand,item_info.description FROM item_groups LEFT JOIN item_group_names ON ig_name_id = group_id LEFT JOIN item_info ON item_info.item_id = item_groups.item_id WHERE group_name LIKE '%" + convertQuotes(txtSearch.Text) + "%'";
            MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvItemGroup.DataSource = dt;

            String sql2 = "SELECT ig_name_id,group_name FROM item_group_names WHERE group_name LIKE '%" + convertQuotes(txtSearch.Text) + "%'";
            MySqlCommand cmd = new MySqlCommand(sql2, conn);
           
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                group_id = reader.GetString("ig_name_id");
                lblGroup.Text = reader.GetString("group_name");
                //break for single row or you can continue if you have multiple rows...
                break;
            }
            conn.Close();
        }

        private void itemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
            this.Hide();
        }

        private void patientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPatient frm = new frmPatient();
            frm.Show();
            this.Hide();
        }

        private void schedulingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSchedule frm = new frmSchedule();
            frm.Show();
            this.Hide();
        }

        private void laboratoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLaboratory frm = new frmLaboratory();
            frm.Show();
            this.Hide();
        }

        private void dialyzerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDialyzer frm = new frmDialyzer();
            frm.Show();
            this.Hide();
        }

        private void modeOfPaymentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMode frm = new frmMode();
            frm.Show();
            this.Hide();
        }

        private void billingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBilling frm = new frmBilling();
            frm.Show();
            this.Hide();
        }

        private void paymentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPayment frm = new frmPayment();
            frm.Show();
            this.Hide();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            conn.Open();
            String sql = "INSERT INTO item_groups (group_id, item_id) VALUES ('" + group_id + "','" + item_id + "')";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Add Successful!");
            dgvItemGroup.Refresh();
            button1_Click_1(sender, e);
        }
        public string convertQuotes(string str)
        {

            return str.Replace("'", "''");

        }
    }
}
