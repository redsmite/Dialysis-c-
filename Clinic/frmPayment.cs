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
    public partial class frmPayment : Form
    {
        MySqlConnection conn = new MySqlConnection("server = localhost; uid = root; pwd=;database= db_clinic");
        String sched_id = "";
        String bill_id = "";
        public frmPayment()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            conn.Open();
            String method = cboMethod.SelectedValue.ToString();
            String amount = txtAmount.Text;
            String discount = txtDiscount.Text;
            String sql = "INSERT INTO payment (bill_id, mode_id, amount, discount, total, date) VALUES ('" + bill_id + "','" + method + "','" + amount + "', '" + discount + "', '" +amount+ "-" +discount+"',NOW())";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Add Successful!");
            txtAmount.Clear();
            txtDiscount.Clear();
        }

        private void frmPayment_Load(object sender, EventArgs e)
        {
            conn.Open();
            String sql = "SELECT schedule_id, CONCAT(lastname,', ',firstname,' ',middlename) AS name, date_schedule, time_start, time_end, session_no FROM scheduling AS t1 LEFT JOIN patient AS t2 ON t1.patient_id = t2.patient_id";
            MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvSchedule.DataSource = dt;

            String sql2 = "SELECT mode_id, mode_of_payment FROM mode_of_payment ORDER BY mode_of_payment";
            MySqlCommand cmd = new MySqlCommand(sql2, conn);
            MySqlDataReader dr = cmd.ExecuteReader();
            DataTable table = new DataTable();
            table.Load(dr);
            cboMethod.DataSource = table;
            cboMethod.DisplayMember = "mode_of_payment";
            cboMethod.ValueMember = "mode_id";
            conn.Close();
        }

        private void dgvSchedule_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            if (e.RowIndex > -1)
            {
                DataGridViewRow row = dgvSchedule.Rows[i];
                sched_id = row.Cells[0].Value.ToString();
                conn.Open();
                String sql = "SELECT bill_id,total FROM billing WHERE sched_id = "+sched_id+"";
                MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvBilling.DataSource = dt;
                conn.Close();
                groupBox1.Enabled = true;
                dgvItem.DataSource = null;
                dgvLab.DataSource = null;
                dgvDialyzer.DataSource = null;
                dgvExpense.DataSource = null;
                groupBox6.Enabled = false;
            }
        }

        private void dgvBilling_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            if (e.RowIndex > -1)
            {
                DataGridViewRow row = dgvBilling.Rows[i];
                bill_id = row.Cells[0].Value.ToString();
                lblTotal.Text = row.Cells[1].Value.ToString();
                conn.Open();

                String sql = "SELECT name,amount FROM item_used AS t1 LEFT JOIN item_info AS t2 ON t1.item_id = t2.item_id WHERE bill_id = " + bill_id + "";
                MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvItem.DataSource = dt;

                String sql2 = "SELECT dialyzer_name,amount FROM dialyzer_used AS t1 LEFT JOIN dialyzers AS t2 ON t1.dialyzer_id = t2.dialyzer_id WHERE bill_id = " + bill_id + "";
                MySqlDataAdapter da2 = new MySqlDataAdapter(sql2, conn);
                DataTable dt2 = new DataTable();
                da2.Fill(dt2);
                dgvDialyzer.DataSource = dt2;

                String sql3 = "SELECT lab_name,amount FROM laboratory_used AS t1 LEFT JOIN laboratories AS t2 ON t1.lab_id = t2.lab_id WHERE bill_id = " + bill_id + "";
                MySqlDataAdapter da3 = new MySqlDataAdapter(sql3, conn);
                DataTable dt3 = new DataTable();
                da3.Fill(dt3);
                dgvLab.DataSource = dt3;

                String sql4 = "SELECT description,amount FROM other_expenses WHERE bill_id = " + bill_id + "";
                MySqlDataAdapter da4 = new MySqlDataAdapter(sql4, conn);
                DataTable dt4 = new DataTable();
                da4.Fill(dt4);
                dgvExpense.DataSource = dt4;

                conn.Close();
                groupBox2.Enabled = true;
                groupBox3.Enabled = true;
                groupBox4.Enabled = true;
                groupBox5.Enabled = true;
                groupBox6.Enabled = true;
            }
        }

        private void txtAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void txtDiscount_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtDiscount_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }
        public string convertQuotes(string str)
        {

            return str.Replace("'", "''");

        }
    }
}
