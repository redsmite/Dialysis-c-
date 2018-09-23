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
    public partial class frmPatient : Form
    {
        MySqlConnection conn = new MySqlConnection("server = localhost; uid = root; pwd=;database= db_clinic");
        String patient_id = "";
        public frmPatient()
        {
            InitializeComponent();
        }

        private void frmPatient_Load(object sender, EventArgs e)
        {
            conn.Open();
            String sql = "SELECT patient_id,lastname,firstname,middlename,phone,contact,clinic_abstract,hemoglobin_order,latest_lab,latest_chest_xray,hepatitis_profile,dialysis_logsheet,storage_code FROM patient";
            MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvPatient.DataSource = dt;
            conn.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            conn.Close();
            conn.Open();
            String last = convertQuotes(txtLast.Text);
            String first = convertQuotes(txtFirst.Text);
            String middle = convertQuotes(txtMiddle.Text);
            String phone = convertQuotes(txtPhone.Text);
            String contact = convertQuotes(txtContact.Text);
            String storage = convertQuotes(txtStorage.Text);
            int clinic = 0;
            int hemo = 0;
            int lab = 0;
            int xray = 0;
            int hepa = 0;
            int dialysis = 0;

            if (rdoClinicYes.Checked == true)
            {
                clinic = 1;
            }
            else if (rdoClinicNo.Checked == true)
            {
                clinic = 0;
            }

            if (rdoHemoglobinYes.Checked == true)
            {
                hemo = 1;
            }
            else if (rdoHemoglobinNo.Checked == true)
            {
                hemo = 0;
            }

            if (rdoLatestlabYes.Checked == true)
            {
                lab = 1;
            }
            else if (rdoLatestlabNo.Checked == true)
            {
                lab = 0;
            }

            if (rdoLatestxrayYes.Checked == true)
            {
                xray = 1;
            }
            else if (rdoLatestXrayNo.Checked == true)
            {
                xray = 0;
            }

            if (rdoHepatitisYes.Checked == true)
            {
                hepa = 1;
            }
            else if (rdoHepatitisNo.Checked == true)
            {
                hepa = 0;
            }       

            if (rdoDialysisYes.Checked == true)
            {
                dialysis = 1;
            }
            else if (rdoDialysisNo.Checked == true)
            {
                dialysis = 0;
            }

            if (txtLast.Text == "" || txtFirst.Text == "" || txtMiddle.Text == "" || txtStorage.Text == "")
            {
                MessageBox.Show("Please fill up all forms first", "Register Failed", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            else
            {
                String sql = "INSERT INTO patient (lastname,firstname,middlename,phone,contact,clinic_abstract,hemoglobin_order,latest_lab,latest_chest_xray,hepatitis_profile,dialysis_logsheet,storage_code) VALUES ('" + last + "','" + first + "','" + middle + "','" + phone + "','" + contact + "','" + clinic + "','" + hemo + "','" + lab + "','" + xray + "','" + hepa + "','" + dialysis + "','" + storage + "')";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Add Successful!");
                dgvPatient.Refresh();
                frmPatient_Load(sender, e);
                txtLast.Clear();
                txtFirst.Clear();
                txtMiddle.Clear();
                txtPhone.Clear();
                txtContact.Clear();
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void dgvPatient_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            if (e.RowIndex > -1)
            {
                DataGridViewRow row = dgvPatient.Rows[i];
                patient_id = row.Cells[0].Value.ToString();
                txtLast.Text = row.Cells[1].Value.ToString();
                txtFirst.Text = row.Cells[2].Value.ToString();
                txtMiddle.Text = row.Cells[3].Value.ToString();
                txtPhone.Text = row.Cells[4].Value.ToString();
                txtContact.Text = row.Cells[5].Value.ToString();
                if (row.Cells[6].Value.ToString() == "True")
                {
                    rdoClinicYes.Checked = true;
                }
                else
                {
                    rdoClinicNo.Checked = true;
                }
                
                if (row.Cells[7].Value.ToString() == "True")
                {
                    rdoHemoglobinYes.Checked = true;
                }
                else
                {
                    rdoHemoglobinNo.Checked = true;
                }

                if (row.Cells[8].Value.ToString() == "True")
                {
                    rdoLatestlabYes.Checked = true;
                }
                else
                {
                    rdoLatestlabNo.Checked = true;
                }

                if (row.Cells[9].Value.ToString() == "True")
                {
                    rdoLatestxrayYes.Checked = true;
                }
                else
                {
                    rdoLatestXrayNo.Checked = true;
                }

                if (row.Cells[10].Value.ToString() == "True")
                {
                    rdoHepatitisYes.Checked = true;
                }
                else
                {
                    rdoHepatitisNo.Checked = true;
                }

                if (row.Cells[11].Value.ToString() == "True")
                {
                    rdoDialysisYes.Checked = true;
                }
                else
                {
                    rdoDialysisNo.Checked = true;
                }
                txtStorage.Text = row.Cells[12].Value.ToString();
                
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            conn.Close();
            conn.Open();
            String last = convertQuotes(txtLast.Text);
            String first = convertQuotes(txtFirst.Text);
            String middle = convertQuotes(txtMiddle.Text);
            String phone = convertQuotes(txtPhone.Text);
            String contact = convertQuotes(txtContact.Text);
            String storage = convertQuotes(txtStorage.Text);
            int clinic = 0;
            int hemo = 0;
            int lab = 0;
            int xray = 0;
            int hepa = 0;
            int dialysis = 0;

            if (rdoClinicYes.Checked == true)
            {
                clinic = 1;
            }
            else if (rdoClinicNo.Checked == true)
            {
                clinic = 0;
            }

            if (rdoHemoglobinYes.Checked == true)
            {
                hemo = 1;
            }
            else if (rdoHemoglobinNo.Checked == true)
            {
                hemo = 0;
            }

            if (rdoLatestlabYes.Checked == true)
            {
                lab = 1;
            }
            else if (rdoLatestlabNo.Checked == true)
            {
                lab = 0;
            }

            if (rdoLatestxrayYes.Checked == true)
            {
                xray = 1;
            }
            else if (rdoLatestXrayNo.Checked == true)
            {
                xray = 0;
            }

            if (rdoHepatitisYes.Checked == true)
            {
                hepa = 1;
            }
            else if (rdoHepatitisNo.Checked == true)
            {
                hepa = 0;
            }

            if (rdoDialysisYes.Checked == true)
            {
                dialysis = 1;
            }
            else if (rdoDialysisNo.Checked == true)
            {
                dialysis = 0;
            }

            if (txtLast.Text == "" || txtFirst.Text == "" || txtMiddle.Text == "" || txtStorage.Text == "")
            {
                MessageBox.Show("Please fill up all forms first", "Register Failed", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            else
            {
                String sql = "UPDATE patient SET lastname='"+last+"', firstname='"+first+"', middlename='"+middle+"', phone='"+phone+"', contact='"+contact+"', clinic_abstract='"+clinic+"', hemoglobin_order='"+hemo+"', latest_lab='"+lab+"', latest_chest_xray='"+xray+"', hepatitis_profile='"+hepa+"', dialysis_logsheet='"+dialysis+"',storage_code='"+storage+"' WHERE patient_id = "+patient_id+"";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Update Successful!");
                dgvPatient.Refresh();
                frmPatient_Load(sender, e);
                txtLast.Clear();
                txtFirst.Clear();
                txtMiddle.Clear();
                txtPhone.Clear();
                txtContact.Clear();
            }
        }

        private void txtSearch_KeyUp(object sender, KeyEventArgs e)
        {
            conn.Open();
            String sql = "SELECT patient_id,lastname,firstname,middlename,phone,contact,clinic_abstract,hemoglobin_order,latest_lab,latest_chest_xray,hepatitis_profile,dialysis_logsheet,storage_code FROM patient WHERE lastname LIKE '%"+convertQuotes(txtSearch.Text)+"%'";
            MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvPatient.DataSource = dt;
            conn.Close();
        }
        public string convertQuotes(string str)
        {

            return str.Replace("'", "''");

        }
    }
    
}
