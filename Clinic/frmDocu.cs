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
    public partial class frmDocu : Form
    {
        MySqlConnection conn = new MySqlConnection("server = localhost; uid = root; pwd=;database= db_clinic");
        String patient_id = frmPatient.patient_id;
        bool clinic = false;
        bool hemo = false;
        bool lab = false;
        bool xray = false;
        bool hepa = false;
        bool dia = false;
        String storage = "";
        public frmDocu()
        {
            InitializeComponent();
        }

        private void frmDocu_Load(object sender, EventArgs e)
        {
            conn.Open();

            String sql = "SELECT clinic_abstract, hemoglobin_order, latest_lab, latest_chest_xray, hepatitis_profile, dialysis_logsheet, storage_code FROM patient WHERE patient_id = '"+patient_id+"'";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                clinic = reader.GetBoolean("clinic_abstract");
                hemo = reader.GetBoolean("hemoglobin_order");
                lab = reader.GetBoolean("latest_lab");
                xray = reader.GetBoolean("latest_chest_xray");
                hepa = reader.GetBoolean("hepatitis_profile");
                dia = reader.GetBoolean("dialysis_logsheet");
                storage = reader.GetString("storage_code");
                break;
            }
            if (clinic == true)
            {
                rdoClinicYes.Checked = true;
                rdoClinicNo.Enabled = false;
            }
            else {
                rdoClinicYes.Checked = false;
                rdoClinicNo.Checked = true;
            }

            if (hemo == true)
            {
                rdoHemoYes.Checked = true;
                rdoHemoNo.Enabled = false;
            }
            else
            {
                rdoHemoYes.Checked = false;
                rdoHemoNo.Checked = true;
            }

            if (lab == true)
            {
                rdoLatestYes.Checked = true;
                rdoLatestNo.Enabled = false;
            }
            else
            {
                rdoLatestYes.Checked = false;
                rdoLatestNo.Checked = true;
            }

            if (xray == true)
            {
                rdoXrayYes.Checked = true;
                rdoXrayNo.Enabled = false;
            }
            else
            {
                rdoXrayYes.Checked = false;
                rdoXrayNo.Checked = true;
            }

            if (hepa == true)
            {
                rdoHepaYes.Checked = true;
                rdoHepaNo.Enabled = false;
            }
            else
            {
                rdoHepaYes.Checked = false;
                rdoHepaNo.Checked = true;
            }

            if (dia == true)
            {
                rdoDialysisYes.Checked = true;
                rdoDialysisNo.Enabled = false;
            }
            else
            {
                rdoDialysisYes.Checked = false;
                rdoDialysisNo.Checked = true;
            }
            txtStorage.Text = storage;

            conn.Close();  
        }
        public string convertQuotes(string str)
        {

            return str.Replace("'", "''");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (rdoClinicYes.Checked == true)
            {
                clinic = true;
            }
            else if(rdoClinicYes.Checked == false){
                clinic = false;
            }

            if (rdoHemoYes.Checked == true){
                hemo = true;
            }
            else if (rdoHemoYes.Checked == false){
                hemo = false;
            }

            if(rdoLatestYes.Checked == true){
                lab = true;
            }
            else if (rdoLatestYes.Checked == false){
                lab = false;
            }

            if(rdoXrayYes.Checked == true){
                xray = true;
            }
            else if(rdoXrayYes.Checked == false){
                xray = false;
            }

            if (rdoHepaYes.Checked == true) {
                hepa = true;
            }
            else if (rdoHepaYes.Checked == false) {
                hepa = false;
            }

            if(rdoDialysisYes.Checked == true){
                dia = true;
            }
            else if (rdoDialysisYes.Checked == false) {
                dia = false;
            }

            storage = txtStorage.Text;
            conn.Open();
            String sql = "UPDATE patient SET clinic_abstract = "+clinic+", hemoglobin_order = "+hemo+", latest_lab = "+lab+", latest_chest_xray = "+xray+", hepatitis_profile = "+hepa+", dialysis_logsheet = "+dia+", storage_code = '"+storage+"' WHERE patient_id = '"+patient_id+"'";
            MessageBox.Show(sql);
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Update Successful!");
            this.Hide();
        }
    }
}
