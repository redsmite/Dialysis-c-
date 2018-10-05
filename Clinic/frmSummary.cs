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
    public partial class frmSummary : Form
    {
        MySqlConnection conn = new MySqlConnection("server = localhost; uid = root; pwd=;database= db_clinic");
        public frmSummary()
        {
            InitializeComponent();
        }

        private void frmSummary_Load(object sender, EventArgs e)
        {
            conn.Open();
            String sql = "SELECT summary, quantity, amount FROM summary";
            MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvSummary.DataSource = dt;


            String sql2 = "SELECT total FROM billing WHERE bill_id = '"+frmBilling.bill_id+"'";
            MySqlCommand cmd = new MySqlCommand(sql2, conn);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                lblTotal.Text = reader.GetString("total");
                //break for single row or you can continue if you have multiple rows...
                break;
            }
            conn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmSummary_Load(sender, e);
        }
    }
}
