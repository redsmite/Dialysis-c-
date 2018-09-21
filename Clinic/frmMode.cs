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
    public partial class frmMode : Form
    {
        MySqlConnection conn = new MySqlConnection("server = localhost; uid = root; pwd=;database= db_clinic");
        String mode_id = "";
        public frmMode()
        {
            InitializeComponent();
        }

        private void frmMode_Load(object sender, EventArgs e)
        {
            conn.Open();
            String sql = "SELECT mode_id,mode_of_payment,description FROM mode_of_payment";
            MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvMode.DataSource = dt;
            conn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            conn.Open();
            String name = convertQuotes(txtName.Text);
            String desc = convertQuotes(txtDesc.Text);
            String sql = "INSERT INTO mode_of_payment (mode_of_payment, description) VALUES ('" + name + "','" + desc + "')";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Add Successful!");
            dgvMode.Refresh();
            frmMode_Load(sender, e);
            txtName.Clear();
            txtDesc.Clear();
        }

        private void itemInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
            this.Hide();
        }

        private void itemGroupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmItemGroup frm = new frmItemGroup();
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

        private void billingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBilling frm = new frmBilling();
            frm.Show();
            this.Hide();
        }

        private void paymentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSchedule frm = new frmSchedule();
            frm.Show();
            this.Hide();
        }

        private void txtSearch_KeyUp(object sender, KeyEventArgs e)
        {
            conn.Open();
            String sql = "SELECT mode_of_payment,description FROM mode_of_payment WHERE mode_of_payment LIKE '%"+convertQuotes(txtSearch.Text)+"%'";
            MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvMode.DataSource = dt;
            conn.Close();
        }
        public string convertQuotes(string str)
        {

            return str.Replace("'", "''");

        }

        private void dgvMode_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            if (e.RowIndex > -1)
            {
                DataGridViewRow row = dgvMode.Rows[i];
                mode_id = row.Cells[0].Value.ToString();
                txtName.Text = row.Cells[1].Value.ToString();
                txtDesc.Text = row.Cells[2].Value.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            conn.Open();
            String name = convertQuotes(txtName.Text);
            String desc = convertQuotes(txtDesc.Text);
            String sql = "UPDATE mode_of_payment SET mode_of_payment = '"+name+"',description = '"+desc+"' WHERE mode_id = '"+mode_id+"'";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Update Successful!");
            dgvMode.Refresh();
            frmMode_Load(sender, e);
            txtName.Clear();
            txtDesc.Clear();
        }
    }
}
