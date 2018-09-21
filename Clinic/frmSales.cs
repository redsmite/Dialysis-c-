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
    public partial class frmSales : Form
    {
        MySqlConnection conn = new MySqlConnection("server = localhost; uid = root; pwd=;database= db_clinic");
        public frmSales()
        {
            InitializeComponent();
        }

        private void frmSales_Load(object sender, EventArgs e)
        {
            conn.Open();
            String sql = "SELECT name, SUM(amount) AS total_sales, SUM(t1.quantity) AS total_quantity FROM item_used AS t1 LEFT JOIN item_info AS t2 ON t1.item_id = t2.item_id GROUP BY t1.item_id";
            MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvItem.DataSource = dt;

            String sql2 = "SELECT dialyzer_name, SUM(amount) AS total_sales, COUNT(dialyzer_used_id) AS total_quantity FROM dialyzer_used AS t1 LEFT JOIN dialyzers AS t2 ON t1.dialyzer_id = t2.dialyzer_id GROUP BY t1.dialyzer_id";
            MySqlDataAdapter da2 = new MySqlDataAdapter(sql2, conn);
            DataTable dt2 = new DataTable();
            da2.Fill(dt2);
            dgvDialyzer.DataSource = dt2;

            String sql3 = "SELECT lab_name, SUM(amount) AS total_sales, COUNT(lab_used_id) AS total_quantity FROM laboratory_used AS t1 LEFT JOIN laboratories AS t2 ON t1.lab_id = t2.lab_id GROUP BY t1.lab_id";
            MySqlDataAdapter da3 = new MySqlDataAdapter(sql3, conn);
            DataTable dt3 = new DataTable();
            da3.Fill(dt3);
            dgvLab.DataSource = dt3;

            String sql4 = "SELECT description, SUM(amount) AS total_sales, COUNT(expense_id) AS total_quantity FROM other_expenses GROUP BY description";
            MySqlDataAdapter da4 = new MySqlDataAdapter(sql4, conn);
            DataTable dt4 = new DataTable();
            da4.Fill(dt4);
            dgvOther.DataSource = dt4;

            conn.Close();
        }
    }
}
