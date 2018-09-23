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
    public partial class frmPatientHistory : Form
    {
        MySqlConnection conn = new MySqlConnection("server = localhost; uid = root; pwd=;database= db_clinic");
        String patient_id = "";
        String schedule_id = "";
        String bill_id = "";
        public frmPatientHistory()
        {
            InitializeComponent();
        }

        private void frmPatientHistory_Load(object sender, EventArgs e)
        {
            conn.Open();
            String sql = "SELECT patient_id, CONCAT(lastname,', ',firstname,' ',middlename) AS name, phone, contact FROM patient";
            MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvPatient.DataSource = dt;
            conn.Close();
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            conn.Open();
            String sql = "SELECT patient_id, CONCAT(lastname,', ',firstname,' ',middlename) AS name, phone, contact FROM patient WHERE lastname LIKE '%" + convertQuotes(txtSearch.Text) + "%'";
            MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvPatient.DataSource = dt;
            conn.Close();
        }
        public string convertQuotes(string str)
        {

            return str.Replace("'", "''");

        }

        private void dgvPatient_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            if (e.RowIndex > -1)
            {
                DataGridViewRow row = dgvPatient.Rows[i];
                patient_id = row.Cells[0].Value.ToString();
                conn.Open();
                String sql = "SELECT schedule_id, date_schedule, time_start, time_end FROM scheduling WHERE patient_id = '"+patient_id+"'";
                MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvSchedule.DataSource = dt;
                conn.Close();
                groupBox4.Enabled = false;
            }

        }

        private void dgvSchedule_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            if (e.RowIndex > -1)
            {
                DataGridViewRow row = dgvSchedule.Rows[i];
                schedule_id = row.Cells[0].Value.ToString();
                conn.Open();
                String sql = "SELECT bill_id FROM billing WHERE sched_id = '" + schedule_id + "'";
                MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvBilling.DataSource = dt;
                conn.Close();
                groupBox4.Enabled = false;
            }
        }

        private void dgvBilling_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            if (e.RowIndex > -1)
            {
                DataGridViewRow row = dgvBilling.Rows[i];
                bill_id = row.Cells[0].Value.ToString();
                groupBox4.Enabled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            conn.Open();
            String sql = "SELECT name, SUM(amount) AS total_sales, SUM(t1.quantity) AS total_quantity FROM item_used AS t1 LEFT JOIN item_info AS t2 ON t1.item_id = t2.item_id WHERE bill_id = '" + bill_id + "' GROUP BY t1.item_id";
            MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvUsed.DataSource = dt;
            conn.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            conn.Open();
            String sql2 = "SELECT dialyzer_name, SUM(amount) AS total_sales, COUNT(dialyzer_used_id) AS total_quantity FROM dialyzer_used AS t1 LEFT JOIN dialyzers AS t2 ON t1.dialyzer_id = t2.dialyzer_id WHERE bill_id = '" + bill_id + "' GROUP BY t1.dialyzer_id";
            MySqlDataAdapter da2 = new MySqlDataAdapter(sql2, conn);
            DataTable dt2 = new DataTable();
            da2.Fill(dt2);
            dgvUsed.DataSource = dt2;
            conn.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            conn.Open();
            String sql3 = "SELECT lab_name, SUM(amount) AS total_sales, COUNT(lab_used_id) AS total_quantity FROM laboratory_used AS t1 LEFT JOIN laboratories AS t2 ON t1.lab_id = t2.lab_id WHERE bill_id = '" + bill_id + "' GROUP BY t1.lab_id";
            MySqlDataAdapter da3 = new MySqlDataAdapter(sql3, conn);
            DataTable dt3 = new DataTable();
            da3.Fill(dt3);
            dgvUsed.DataSource = dt3;
            conn.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            conn.Open();
            String sql4 = "SELECT description, SUM(amount) AS total_sales, COUNT(expense_id) AS total_quantity FROM other_expenses WHERE bill_id = '" + bill_id + "' GROUP BY description";
            MySqlDataAdapter da4 = new MySqlDataAdapter(sql4, conn);
            DataTable dt4 = new DataTable();
            da4.Fill(dt4);
            dgvUsed.DataSource = dt4;
            conn.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            conn.Open();
            String sql4 = "SELECT mode_of_payment, SUM(amount)AS total_amount, SUM(discount) AS total_discount FROM payment AS t1 LEFT JOIN mode_of_payment AS t2 ON t1.mode_id = t2.mode_id WHERE bill_id = '" + bill_id + "' GROUP BY description";
            MySqlDataAdapter da4 = new MySqlDataAdapter(sql4, conn);
            DataTable dt4 = new DataTable();
            da4.Fill(dt4);
            dgvUsed.DataSource = dt4;
            conn.Close();
        }
    }
}
