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
        public static String bill_id = "";
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
            btnSummary.Enabled = true;
        }

        private void frmBilling_Load(object sender, EventArgs e)
        {
            conn.Open();
            String sql = "SELECT schedule_id, CONCAT(lastname,', ',firstname,' ',middlename) AS name, date_schedule, time_start, time_end, session_no,is_attended FROM scheduling AS t1 LEFT JOIN patient AS t2 ON t1.patient_id = t2.patient_id WHERE is_attended = 1 ORDER BY schedule_id DESC";
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

        private void button2_Click_1(object sender, EventArgs e)
        {
            String amount = txtItemAmt.Text;
            String quantity = txtQuantity.Text;
            String item = txtItem.Text;

            if (txtItem.Text != "" && quantity != "")
            {
                conn.Open();
                String sql = "INSERT INTO item_used (item_id, bill_id, amount, quantity,datecommit) VALUES ('" + item_id + "','" + bill_id + "','" + amount + "', '" + quantity + "',NOW())";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                String sql2 = "UPDATE billing SET total = total+(" + amount + "*" + quantity + ") WHERE bill_id = " + bill_id + "";
                MySqlCommand cmd2 = new MySqlCommand(sql2, conn);
                cmd2.ExecuteNonQuery();
                String sql3 = "INSERT INTO summary (summary, quantity, amount) VALUES ('"+item+"','"+quantity+"',"+quantity+"*"+amount+")";
                MySqlCommand cmd3 = new MySqlCommand(sql3, conn);
                cmd3.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Add Successful!");
                dgvItem.Refresh();
                txtSearch.Clear();
                txtItem.Clear();
                txtItemAmt.Clear();
                txtQuantity.Clear();
            }
            else {
                MessageBox.Show("Please select item and enter amount!");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            String dialyzer = cboDialyzer.SelectedValue.ToString();
            String amount = txtDialyzerAmt.Text;
            String details = cboDialyzer.Text;
            if (amount != "")
            {
            conn.Open();
            String sql = "INSERT INTO dialyzer_used (dialyzer_id, amount, bill_id, datecommit) VALUES ('" + dialyzer + "','" + amount + "','" + bill_id + "',NOW())";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            String sql2 = "UPDATE billing SET total = total+" + amount + " WHERE bill_id = " + bill_id + "";
            MySqlCommand cmd2 = new MySqlCommand(sql2, conn);
            cmd2.ExecuteNonQuery();
            String sql3 = "INSERT INTO summary (summary, quantity, amount) VALUES ('" + details + "',1,"+ amount + ")";
            MySqlCommand cmd3 = new MySqlCommand(sql3, conn);
            cmd3.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Add Successful!");
            txtDialyzerAmt.Clear();
            }else{
                MessageBox.Show("Please enter amount!");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            String lab = cboLab.SelectedValue.ToString();
            String amount = txtLabAmt.Text;
            String details = cboLab.Text;
            if (amount != "")
            {
            conn.Open();
            String sql = "INSERT INTO laboratory_used (lab_id, amount, bill_id,datecommit) VALUES ('" + lab+ "','" + amount + "','" + bill_id + "',NOW())";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            String sql2 = "UPDATE billing SET total = total+" + amount + " WHERE bill_id = " + bill_id + "";
            MySqlCommand cmd2 = new MySqlCommand(sql2, conn);
            cmd2.ExecuteNonQuery();
            String sql3 = "INSERT INTO summary (summary, quantity, amount) VALUES ('" + details + "',1," + amount + ")";
            MySqlCommand cmd3 = new MySqlCommand(sql3, conn);
            cmd3.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Add Successful!");
            txtLabAmt.Clear();
            }else{
                MessageBox.Show("Please enter amount!");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            String desc = convertQuotes(txtOther.Text);
            String amount = txtOtherAmt.Text;
            if (desc != "" && amount != "")
            {
            conn.Open();
            String sql = "INSERT INTO other_expenses (description, amount, bill_id, datecommit) VALUES ('" + desc + "','" + amount + "','" + bill_id + "',NOW())";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            String sql2 = "UPDATE billing SET total = total+" + amount + " WHERE bill_id = " + bill_id + "";
            MySqlCommand cmd2 = new MySqlCommand(sql2, conn);
            cmd2.ExecuteNonQuery();
            String sql3 = "INSERT INTO summary (summary, quantity, amount) VALUES ('" + desc + "',1," + amount + ")";
            MySqlCommand cmd3 = new MySqlCommand(sql3, conn);
            cmd3.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Add Successful!");
            txtOther.Clear();
            txtOtherAmt.Clear();
            }else{
                MessageBox.Show("Please enter amount and description!");
            }
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
            btnSummary.Enabled = false;
            conn.Open();
            String sql3 = "truncate summary";
            MySqlCommand cmd3 = new MySqlCommand(sql3, conn);
            cmd3.ExecuteNonQuery();
            conn.Close();
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

        private void dgvSchedule_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            if (e.RowIndex > -1)
            {
                DataGridViewRow row = dgvSchedule.Rows[i];
                lblSchedule.Text = row.Cells[0].Value.ToString();
            }
            btnNew.Enabled = true;
        }

        private void dgvItem_CellClick(object sender, DataGridViewCellEventArgs e)
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

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            conn.Open();
            String sql = "SELECT schedule_id, CONCAT(lastname,', ',firstname,' ',middlename) AS name, date_schedule, time_start, time_end, session_no FROM scheduling AS t1 LEFT JOIN patient AS t2 ON t1.patient_id = t2.patient_id WHERE lastname like '%" + convertQuotes(txtSearchSched.Text) + "%' ORDER BY schedule_id DESC";
            MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvSchedule.DataSource = dt;
            conn.Close();
        }

        private void txtSearchItem_KeyUp(object sender, KeyEventArgs e)
        {
            conn.Open();
            String sql = "SELECT item_id, name, brand, sell_price FROM item_info WHERE name LIKE '%" + convertQuotes(txtSearchItem.Text) + "%'";
            MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvItem.DataSource = dt;
            conn.Close();
        }

        private void txtQuantity_KeyUp(object sender, KeyEventArgs e)
        {
            double sub = 0;
            double amount = 0;
            double qty = 0;

            if (txtQuantity.Text != "" && txtItemAmt.Text != "" && txtQuantity.Text != "")
            {
                amount = Convert.ToDouble(txtItemAmt.Text);
                qty = Convert.ToDouble(txtQuantity.Text);
                sub = amount * qty;
                txtSubtotal.Text = Convert.ToString(sub);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            frmSummary frm = new frmSummary();
            frm.Show();
        }
    }
}
