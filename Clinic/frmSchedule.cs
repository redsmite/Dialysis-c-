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
    public partial class frmSchedule : Form
    {
        MySqlConnection conn = new MySqlConnection("server = localhost; uid = root; pwd=;database= db_clinic");
        public frmSchedule()
        {
            InitializeComponent();
        }

        private void frmSchedule_Load(object sender, EventArgs e)
        {
            conn.Open();
            String sql = "SELECT schedule_id, CONCAT(lastname,', ',firstname,' ',middlename) AS name, date_schedule, time_start, time_end, session_no FROM scheduling AS t1 LEFT JOIN patient AS t2 ON t1.patient_id = t2.patient_id";
            MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvSchedule.DataSource = dt;
            conn.Close();
            
            String sql2 = "SELECT patient_id, CONCAT(lastname,', ',firstname,' ',middlename) AS name FROM patient ORDER BY lastname";
            MySqlCommand cmd = new MySqlCommand(sql2, conn);
            conn.Open();
            MySqlDataReader dr = cmd.ExecuteReader();
            DataTable table = new DataTable();
            table.Load(dr);
            cboPatient.DataSource = table;
            cboPatient.DisplayMember = "name";
            cboPatient.ValueMember = "patient_id";
            conn.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            conn.Open();
            String patient = cboPatient.SelectedValue.ToString();
            String schedule = dtpDate.Value.Date.ToString("yyyy-MM-dd");
            String time_start = timeStart.Text;
            String time_end = timeEnd.Text;
            String session_num = DateTime.Now.ToString("yyyyMMddHHmmss");

            String sql = "INSERT INTO scheduling (patient_id, date_schedule, time_start, time_end, session_no) VALUES ('" + patient + "','" + schedule + "','" + time_start + "','" + time_end + "','" + session_num + "')";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Add Successful!");
            dgvSchedule.Refresh();
            frmSchedule_Load(sender, e);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cboSession_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

    }
}
