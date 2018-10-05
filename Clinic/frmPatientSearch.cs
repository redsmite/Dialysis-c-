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
    public partial class frmPatientSearch : Form
    {
        MySqlConnection conn = new MySqlConnection("server = localhost; uid = root; pwd=;database= db_clinic");
        public static String patient_id = "";
        public static String patient_name = "";
        public frmPatientSearch()
        {
            InitializeComponent();
        }

        private void frmPatientSearch_Load(object sender, EventArgs e)
        {
            conn.Open();
            String sql = "SELECT patient_id, CONCAT(lastname,', ',firstname,' ',middlename) AS name FROM patient WHERE lastname like '%"+convertQuotes(frmSchedule.patient)+"%' AND is_complete = 1";
            MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvPatientSearch.DataSource = dt;
            conn.Close();
        }

        private void dgvPatientSearch_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            if (e.RowIndex > -1)
            {
                DataGridViewRow row = dgvPatientSearch.Rows[i];
                patient_id = row.Cells[0].Value.ToString();
                patient_name = row.Cells[1].Value.ToString();
                this.Hide();
            }
        }

        private void dgvPatientSearch_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public string convertQuotes(string str)
        {

            return str.Replace("'", "''");

        }
    }
}
