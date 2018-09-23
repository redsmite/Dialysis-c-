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
    public partial class frmBilling : Form
    {
        MySqlConnection conn = new MySqlConnection("server = localhost; uid = root; pwd=;database= db_clinic");
        String bill_id = "";
        String group_id = "";
        String item_id = "";
        public frmBilling()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = true;
            groupBox2.Enabled = true;
            groupBox3.Enabled = true;
            groupBox4.Enabled = true;
            conn.Open();
            String schedule = lblSchedule.Text;
            String sql = "INSERT INTO billing (sched_id,datecreated,status) VALUES ('" + schedule + "',NOW(),0)";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.ExecuteNonQuery();

            String sql2 = "SELECT COALESCE(MAX(bill_id),0) AS bill_id FROM billing";
            MySqlCommand cmd2 = new MySqlCommand(sql2, conn);

            MySqlDataReader dr = cmd2.ExecuteReader();
            while (dr.Read())
            {
                bill_id = dr.GetValue(0).ToString();
                lblBilling.Text = dr.GetValue(0).ToString();
            }
            conn.Close();
            MessageBox.Show("Initializing new billing account");
            btnNew.Enabled = false;
            btnSelect.Enabled = true;
            dgvSchedule.Enabled = false;

        }

        private void frmBilling_Load(object sender, EventArgs e)
        {
            conn.Open();
            String sql = "SELECT schedule_id, CONCAT(lastname,', ',firstname,' ',middlename) AS name, date_schedule, time_start, time_end, session_no FROM scheduling AS t1 LEFT JOIN patient AS t2 ON t1.patient_id = t2.patient_id";
            MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvSchedule.DataSource = dt;

            String sql2 = "SELECT dialyzer_id, dialyzer_name FROM dialyzers ORDER BY dialyzer_name";
            MySqlCommand cmd = new MySqlCommand(sql2, conn);
            MySqlDataReader dr = cmd.ExecuteReader();
            DataTable table = new DataTable();
            table.Load(dr);
            cboDialyzer.DataSource = table;
            cboDialyzer.DisplayMember = "dialyzer_name";
            cboDialyzer.ValueMember = "dialyzer_id";

            String sql3 = "SELECT COALESCE(MAX(bill_id),0) AS bill_id FROM billing";
            MySqlCommand cmd2 = new MySqlCommand(sql3, conn);

            MySqlDataReader dr2 = cmd2.ExecuteReader();
            while (dr2.Read())
            {
                bill_id = dr2.GetValue(0).ToString();
                lblBilling.Text = dr2.GetValue(0).ToString();
            }

            conn.Close();
            conn.Open();
            String sql4 = "SELECT lab_id, lab_name FROM laboratories ORDER BY lab_name";
            MySqlCommand cmd3 = new MySqlCommand(sql4, conn);
            MySqlDataReader dr3 = cmd3.ExecuteReader();
            DataTable table2 = new DataTable();
            table2.Load(dr3);
            cboLab.DataSource = table2;
            cboLab.DisplayMember = "lab_name";
            cboLab.ValueMember = "lab_id";

            conn.Close();
        }

        private void dgvSchedule_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            if (e.RowIndex > -1)
            {
                DataGridViewRow row = dgvSchedule.Rows[i];
                lblSchedule.Text = row.Cells[0].Value.ToString();
            }
            btnNew.Enabled = true;
        }

        private void txtSearch_KeyUp(object sender, KeyEventArgs e)
        {
            conn.Open();
            String sql = "SELECT item_groups.item_id, name, brand, sell_price FROM item_groups LEFT JOIN item_group_names ON ig_name_id = group_id LEFT JOIN item_info ON item_info.item_id = item_groups.item_id WHERE group_name LIKE '%" + convertQuotes(txtSearch.Text) + "%'";
            MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvItem.DataSource = dt;

            String sql2 = "SELECT ig_name_id,group_name FROM item_group_names WHERE group_name LIKE '%" + txtSearch.Text + "%'";
            MySqlCommand cmd = new MySqlCommand(sql2, conn);

            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                group_id = reader[0] as string;
                lblGroup.Text = reader[1] as string;
                //break for single row or you can continue if you have multiple rows...
                break;
            }
            conn.Close();
        }

        private void dgvItem_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            if (e.RowIndex > -1)
            {
                DataGridViewRow row = dgvItem.Rows[i];
                item_id = row.Cells[0].Value.ToString();
                txtItem.Text = row.Cells[1].Value.ToString(); 
                txtItemAmt.Text = row.Cells[3].Value.ToString();
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            conn.Open();
            String amount = txtItemAmt.Text;
            String quantity = txtQuantity.Text;
            String sql = "INSERT INTO item_used (item_id, bill_id, amount, quantity,datecommit) VALUES ('" + item_id + "','" + bill_id + "','" + amount + "', '" + quantity + "',NOW())";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            String sql2 = "UPDATE billing SET total = total+("+amount+"*"+quantity+") WHERE bill_id = "+bill_id+"";
            MySqlCommand cmd2 = new MySqlCommand(sql2, conn);
            cmd2.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Add Successful!");
            dgvItem.Refresh();
            txtSearch.Clear();
            txtItem.Clear();
            txtItemAmt.Clear();
            txtQuantity.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            conn.Open();
            String dialyzer = cboDialyzer.SelectedValue.ToString();
            String amount = txtDialyzerAmt.Text;
            String sql = "INSERT INTO dialyzer_used (dialyzer_id, amount, bill_id, datecommit) VALUES ('" + dialyzer + "','" + amount + "','" + bill_id + "',NOW())";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            String sql2 = "UPDATE billing SET total = total+" + amount + " WHERE bill_id = " + bill_id + "";
            MySqlCommand cmd2 = new MySqlCommand(sql2, conn);
            cmd2.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Add Successful!");
            txtDialyzerAmt.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            conn.Open();
            String lab = cboLab.SelectedValue.ToString();
            String amount = txtLabAmt.Text;
            String sql = "INSERT INTO laboratory_used (lab_id, amount, bill_id,datecommit) VALUES ('" + lab+ "','" + amount + "','" + bill_id + "',NOW())";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            String sql2 = "UPDATE billing SET total = total+" + amount + " WHERE bill_id = " + bill_id + "";
            MySqlCommand cmd2 = new MySqlCommand(sql2, conn);
            cmd2.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Add Successful!");
            txtLabAmt.Clear();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            conn.Open();
            String desc = convertQuotes(txtOther.Text);
            String amount = txtOtherAmt.Text;
            String sql = "INSERT INTO other_expenses (description, amount, bill_id, datecommit) VALUES ('" + desc + "','" + amount + "','" + bill_id + "',NOW())";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            String sql2 = "UPDATE billing SET total = total+" + amount + " WHERE bill_id = " + bill_id + "";
            MySqlCommand cmd2 = new MySqlCommand(sql2, conn);
            cmd2.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Add Successful!");
            txtOther.Clear();
            txtOtherAmt.Clear();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            dgvSchedule.Enabled = true;
            btnSelect.Enabled = false;
            MessageBox.Show("Your billing account has been finalized");
            groupBox1.Enabled = false;
            groupBox2.Enabled = false;
            groupBox3.Enabled = false;
            groupBox4.Enabled = false;
        }

        private void txtQuantity_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void txtItemAmt_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void txtDialyzerAmt_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void txtLabAmt_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void txtOtherAmt_KeyPress(object sender, KeyPressEventArgs e)
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
