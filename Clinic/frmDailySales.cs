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
    public partial class frmDailySales : Form
    {
        MySqlConnection conn = new MySqlConnection("server = localhost; uid = root; pwd=;database= db_clinic");
        public frmDailySales()
        {
            InitializeComponent();
        }

        private void frmDailySales_Load(object sender, EventArgs e)
        {
            conn.Open();
            String sql = "SELECT name, sum(amount * t1.quantity) AS total_sales, SUM(t1.quantity) AS total_quantity FROM item_used AS t1 LEFT JOIN item_info AS t2 ON t1.item_id = t2.item_id WHERE datecommit = '" + DateTime.Today.ToString("yyyy-MM-dd") + "' GROUP BY t1.item_id";
            MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvSales.DataSource = dt;
            conn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            conn.Open();
            String sql = "SELECT name, sum(amount * t1.quantity) AS total_sales, SUM(t1.quantity) AS total_quantity FROM item_used AS t1 LEFT JOIN item_info AS t2 ON t1.item_id = t2.item_id WHERE datecommit = '" + dtpDate.Value.ToString("yyyy-MM-dd") + "' GROUP BY t1.item_id";
            MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvSales.DataSource = dt;
            conn.Close();     
        }

        private void button2_Click(object sender, EventArgs e)
        {
            conn.Open();
            String sql2 = "SELECT dialyzer_name, SUM(amount) AS total_sales, COUNT(dialyzer_used_id) AS total_quantity FROM dialyzer_used AS t1 LEFT JOIN dialyzers AS t2 ON t1.dialyzer_id = t2.dialyzer_id WHERE datecommit = '" + dtpDate.Value.ToString("yyyy-MM-dd") + "' GROUP BY t1.dialyzer_id";
            MySqlDataAdapter da2 = new MySqlDataAdapter(sql2, conn);
            DataTable dt2 = new DataTable();
            da2.Fill(dt2);
            dgvSales.DataSource = dt2;
            conn.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            conn.Open();
            String sql3 = "SELECT lab_name, SUM(amount) AS total_sales, COUNT(lab_used_id) AS total_quantity FROM laboratory_used AS t1 LEFT JOIN laboratories AS t2 ON t1.lab_id = t2.lab_id WHERE datecommit = '" + dtpDate.Value.ToString("yyyy-MM-dd") + "' GROUP BY t1.lab_id";
            MySqlDataAdapter da3 = new MySqlDataAdapter(sql3, conn);
            DataTable dt3 = new DataTable();
            da3.Fill(dt3);
            dgvSales.DataSource = dt3;
            conn.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            conn.Open();
            String sql4 = "SELECT description, SUM(amount) AS total_sales, COUNT(expense_id) AS total_quantity FROM other_expenses WHERE datecommit = '" + dtpDate.Value.ToString("yyyy-MM-dd") + "' GROUP BY description";
            MySqlDataAdapter da4 = new MySqlDataAdapter(sql4, conn);
            DataTable dt4 = new DataTable();
            da4.Fill(dt4);
            dgvSales.DataSource = dt4;
            conn.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            conn.Open();
            String sql4 = "SELECT mode_of_payment, SUM(amount)AS total_amount, SUM(discount) AS total_discount FROM payment AS t1 LEFT JOIN mode_of_payment AS t2 ON t1.mode_id = t2.mode_id WHERE date = '" + dtpDate.Value.ToString("yyyy-MM-dd") + "' GROUP BY description";
            MySqlDataAdapter da4 = new MySqlDataAdapter(sql4, conn);
            DataTable dt4 = new DataTable();
            da4.Fill(dt4);
            dgvSales.DataSource = dt4;
            conn.Close();
        }
    }
}
