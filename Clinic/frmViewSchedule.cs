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
        public frmViewSchedule()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            conn.Open();
            DateTime datepick = dtpSchedule.Value.Date;
            String date = datepick.ToString("yyyy-MM-dd");
            String sql = "SELECT CONCAT(lastname,', ',firstname,' ',middlename) AS name, date_schedule, time_start, time_end, session_no FROM scheduling AS t1 LEFT JOIN patient AS t2 ON t1.patient_id = t2.patient_id WHERE date_schedule = '" + date + "'";
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
            String sql = "SELECT CONCAT(lastname,', ',firstname,' ',middlename) AS name, date_schedule, time_start, time_end, session_no FROM scheduling AS t1 LEFT JOIN patient AS t2 ON t1.patient_id = t2.patient_id WHERE date_schedule = '"+date+"'";
            MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvSchedule.DataSource = dt;
            conn.Close();
        }
    }
}
