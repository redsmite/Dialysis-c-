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
        String total_payment = "";
        double billing_total = 0;
        public frmPayment()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String method = cboMethod.SelectedValue.ToString();
            String amount = txtAmount.Text;
            String discount = txtDiscount.Text;
            double payment = 0;
            if (amount != "")
            {
            conn.Open();
            String sql = "INSERT INTO payment (bill_id, mode_id, amount, discount, total, date) VALUES ('" + bill_id + "','" + method + "','" + amount + "', '" + discount + "', '" +amount+ "-" +discount+"',NOW())";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Add Successful!");
            txtAmount.Clear();
            txtDiscount.Clear();
            lblTotal.Text = "None";
            groupBox2.Enabled = false;
            groupBox3.Enabled = false;
            groupBox4.Enabled = false;
            groupBox5.Enabled = false;
            groupBox6.Enabled = false;

            String sql5 = "SELECT SUM(total) AS payment FROM payment WHERE bill_id = '" + bill_id + "' GROUP BY bill_id";
            conn.Open();
            MySqlCommand cmd2 = new MySqlCommand(sql5, conn);
            MySqlDataReader dr = cmd2.ExecuteReader();
            while (dr.Read())
            {
                total_payment = dr.GetString("payment");
                payment = Convert.ToDouble(total_payment);
                
            }
            double due = billing_total - payment;
            conn.Close();
            conn.Open();
            if (due <= 0)
            {
                String sql3 = "UPDATE billing SET status = 1 WHERE bill_id = '" + bill_id + "'";
                MySqlCommand cmd3 = new MySqlCommand(sql3, conn);
                cmd3.ExecuteNonQuery();
            }
            conn.Close();
            }else{
                MessageBox.Show("Please enter amount!");
            }
        }

        private void frmPayment_Load(object sender, EventArgs e)
        {
            conn.Open();
            String sql = "SELECT schedule_id, CONCAT(lastname,', ',firstname,' ',middlename) AS name, date_schedule, time_start, time_end, session_no, is_attended FROM scheduling AS t1 LEFT JOIN patient AS t2 ON t1.patient_id = t2.patient_id LEFT JOIN billing AS t3 ON t1.schedule_id = t3.sched_id WHERE t3.status = 0 AND is_attended = 1 GROUP BY schedule_id ORDER BY schedule_id DESC";
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

        private void dgvSchedule_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            if (e.RowIndex > -1)
            {
                DataGridViewRow row = dgvSchedule.Rows[i];
                sched_id = row.Cells[0].Value.ToString();
                conn.Open();
                String sql = "SELECT bill_id,total FROM billing WHERE sched_id = " + sched_id + " AND status = 0";
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

        private void dgvBilling_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            if (e.RowIndex > -1)
            {
                DataGridViewRow row = dgvBilling.Rows[i];
                bill_id = row.Cells[0].Value.ToString();
                lblTotal.Text = row.Cells[1].Value.ToString();
                lblDue.Text = row.Cells[1].Value.ToString();
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

                String sql5 = "SELECT SUM(total) AS payment FROM payment WHERE bill_id = '" + bill_id + "' GROUP BY bill_id";
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(sql5, conn);
                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    double payment2 = 0;
                    total_payment = dr.GetString("payment");
                    double total = Convert.ToDouble(lblTotal.Text);
                    billing_total = total;
                    if (dr.HasRows)
                    {
                        payment2 = Convert.ToDouble(total_payment);
                    }
                    else
                    {
                        payment2 = 0;
                    }

                    double due = total - payment2;
                    String amounts_due = Convert.ToString(due);
                    lblDue.Text = amounts_due;
                }
                conn.Close();
            }
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            conn.Open();
            String sql = "SELECT schedule_id, CONCAT(lastname,', ',firstname,' ',middlename) AS name, date_schedule, time_start, time_end, session_no,is_attended FROM scheduling AS t1 LEFT JOIN patient AS t2 ON t1.patient_id = t2.patient_id LEFT JOIN billing AS t3 ON t1.schedule_id = t3.sched_id WHERE t3.status = 0 AND lastname like '%" + txtSearch.Text + "%' AND is_attended = 1 GROUP BY schedule_id ORDER BY schedule_id DESC";
            MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvSchedule.DataSource = dt;
            conn.Close();
        }
    }
}
