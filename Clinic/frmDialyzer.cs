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
    public partial class frmDialyzer : Form
    {
        MySqlConnection conn = new MySqlConnection("server = localhost; uid = root; pwd=;database= db_clinic");
        String dialyzer_id = "";
        public frmDialyzer()
        {
            InitializeComponent();
        }

        private void frmDialyzer_Load(object sender, EventArgs e)
        {
            conn.Open();
            String sql = "SELECT dialyzer_id, dialyzer_name, description FROM dialyzers";
            MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvDialyzer.DataSource = dt;
            conn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String name = convertQuotes(txtName.Text);
            String desc = convertQuotes(txtDesc.Text);
            if (name != "" && desc != "")
            {
            conn.Open();
            String sql = "INSERT INTO dialyzers (dialyzer_name, description) VALUES ('" + name + "','" + desc + "')";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Add Successful!");
            dgvDialyzer.Refresh();
            frmDialyzer_Load(sender, e);
            txtName.Clear();
            txtDesc.Clear();
            }else{
                MessageBox.Show("Please enter name and description");
            }
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

        private void button2_Click(object sender, EventArgs e)
        {
            String name = convertQuotes(txtName.Text);
            String desc = convertQuotes(txtDesc.Text);
            if (name != "" && desc != "")
            {
            conn.Open();
            String sql = "UPDATE dialyzers SET dialyzer_name = '" + name + "', description = '" + desc + "' WHERE dialyzer_id = '" + dialyzer_id + "'";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Update Successful!");
            dgvDialyzer.Refresh();
            frmDialyzer_Load(sender, e);
            txtName.Clear();
            txtDesc.Clear();
            }else{
                MessageBox.Show("Please enter name and description!");
            }
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            conn.Open();
            String sql = "SELECT dialyzer_id, dialyzer_name, description FROM dialyzers WHERE dialyzer_name LIKE '%"+convertQuotes(txtSearch.Text)+"%'";
            MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvDialyzer.DataSource = dt;
            conn.Close();
        }
        public string convertQuotes(string str)
        {

            return str.Replace("'", "''");

        }

        private void dgvDialyzer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            if (e.RowIndex > -1)
            {
                DataGridViewRow row = dgvDialyzer.Rows[i];
                dialyzer_id = row.Cells[0].Value.ToString();
                txtName.Text = row.Cells[1].Value.ToString();
                txtDesc.Text = row.Cells[2].Value.ToString();
            }
        }
    }
}
