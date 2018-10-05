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
    public partial class frmViewSchedule : Form
    {
        MySqlConnection conn = new MySqlConnection("server = localhost; uid = root; pwd=;database= db_clinic");
        String schedule_id = "";
        public frmViewSchedule()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            conn.Open();
            DateTime datepick = dtpSchedule.Value.Date;
            String date = datepick.ToString("yyyy-MM-dd");
            String sql = "SELECT schedule_id, CONCAT(lastname,', ',firstname,' ',middlename) AS name, date_schedule, time_start, time_end, session_no,is_attended FROM scheduling AS t1 LEFT JOIN patient AS t2 ON t1.patient_id = t2.patient_id WHERE date_schedule = '" + date + "'";
            MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvSchedule.DataSource = dt;
            conn.Close();
        }

        private void frmViewSchedule_Load(object sender, EventArgs e)
        {
            conn.Open();
            DateTime today = DateTime.Today;
            String date = today.ToString("yyyy-MM-dd");
            String sql = "SELECT schedule_id, CONCAT(lastname,', ',firstname,' ',middlename) AS name, date_schedule, time_start, time_end, session_no, is_attended FROM scheduling AS t1 LEFT JOIN patient AS t2 ON t1.patient_id = t2.patient_id WHERE date_schedule = '"+date+"'";
            MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvSchedule.DataSource = dt;
            conn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (schedule_id != "")
            {
                conn.Open();
                String sql = "UPDATE scheduling SET is_attended = 1 WHERE schedule_id = '" + schedule_id + "'";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Update successful!");
                button1.Enabled = false;
            }
            else {
                MessageBox.Show("Please select schedule");
            }
        }

        private void dgvSchedule_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            if (e.RowIndex > -1)
            {
                DataGridViewRow row = dgvSchedule.Rows[i];
                schedule_id = row.Cells[0].Value.ToString();
                 button1.Enabled = true;
             }
        }

        private void txtSearch_KeyUp(object sender, KeyEventArgs e)
        {
            conn.Open();
            DateTime datepick = dtpSchedule.Value.Date;
            String date = datepick.ToString("yyyy-MM-dd");
            String sql = "SELECT schedule_id, CONCAT(lastname,', ',firstname,' ',middlename) AS name, date_schedule, time_start, time_end, session_no,is_attended FROM scheduling AS t1 LEFT JOIN patient AS t2 ON t1.patient_id = t2.patient_id WHERE date_schedule = '" + date + "' AND lastname like '%" +convertQuotes(txtSearch.Text)+ "%'";
            MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvSchedule.DataSource = dt;
            conn.Close();
        }
        public string convertQuotes(string str)
        {

            return str.Replace("'", "''");

        }
    }
}
