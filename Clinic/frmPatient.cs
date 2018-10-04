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
        public static String patient_id = "";
        public frmPatient()
        {
            InitializeComponent();
        }

        private void frmPatient_Load(object sender, EventArgs e)
        {
            conn.Open();
            String sql = "SELECT patient_id,lastname,firstname,middlename,phone,contact FROM patient";
            MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvPatient.DataSource = dt;
            conn.Close();
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
            }
        }

       
        private void txtSearch_KeyUp(object sender, KeyEventArgs e)
        {
            conn.Open();
            String sql = "SELECT patient_id,lastname,firstname,middlename,phone,contact FROM patient WHERE lastname LIKE '%"+convertQuotes(txtSearch.Text)+"%'";
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

        

        private void label14_Click(object sender, EventArgs e)
        {
             conn.Close();
            conn.Open();
            String last = convertQuotes(txtLast.Text);
            String first = convertQuotes(txtFirst.Text);
            String middle = convertQuotes(txtMiddle.Text);
            String phone = convertQuotes(txtPhone.Text);
            String contact = convertQuotes(txtContact.Text);
           

            if (txtLast.Text == "" || txtFirst.Text == "" || txtMiddle.Text == "")
            {
                MessageBox.Show("Please fill up all forms first", "Register Failed", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            else
            {
                String sql = "INSERT INTO patient (lastname,firstname,middlename,phone,contact) VALUES ('" + last + "','" + first + "','" + middle + "','" + phone + "','" + contact + "')";
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

        private void rectangleShape1_Click(object sender, EventArgs e)
        {
            conn.Close();
            conn.Open();
            String last = convertQuotes(txtLast.Text);
            String first = convertQuotes(txtFirst.Text);
            String middle = convertQuotes(txtMiddle.Text);
            String phone = convertQuotes(txtPhone.Text);
            String contact = convertQuotes(txtContact.Text);
            

            if (txtLast.Text == "" || txtFirst.Text == "" || txtMiddle.Text == "")
            {
                MessageBox.Show("Please fill up all forms first", "Register Failed", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            else
            {
                String sql = "INSERT INTO patient (lastname,firstname,middlename,phone,contact) VALUES ('" + last + "','" + first + "','" + middle + "','" + phone + "','" + contact + "')";
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

        private void rectangleShape2_Click(object sender, EventArgs e)
        {
            txtLast.Clear();
            txtFirst.Clear();
            txtMiddle.Clear();
            txtContact.Clear();
            txtPhone.Clear();

        }

        private void rectangleShape3_Click(object sender, EventArgs e)
        {
            conn.Close();
            conn.Open();
            String last = convertQuotes(txtLast.Text);
            String first = convertQuotes(txtFirst.Text);
            String middle = convertQuotes(txtMiddle.Text);
            String phone = convertQuotes(txtPhone.Text);
            String contact = convertQuotes(txtContact.Text);

            if (txtLast.Text == "" || txtFirst.Text == "" || txtMiddle.Text == "")
            {
                MessageBox.Show("Please fill up all forms first", "Register Failed", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            else
            {
                String sql = "UPDATE patient SET lastname='" + last + "', firstname='" + first + "', middlename='" + middle + "', phone='" + phone + "', contact='" + contact + "' WHERE patient_id = " + patient_id + "";
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

        private void label16_Click(object sender, EventArgs e)
        {
            conn.Close();
            conn.Open();
            String last = convertQuotes(txtLast.Text);
            String first = convertQuotes(txtFirst.Text);
            String middle = convertQuotes(txtMiddle.Text);
            String phone = convertQuotes(txtPhone.Text);
            String contact = convertQuotes(txtContact.Text);
          
            if (txtLast.Text == "" || txtFirst.Text == "" || txtMiddle.Text == "")
            {
                MessageBox.Show("Please fill up all forms first", "Register Failed", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            else
            {
                String sql = "UPDATE patient SET lastname='" + last + "', firstname='" + first + "', middlename='" + middle + "', phone='" + phone + "', contact='" + contact +"' WHERE patient_id = " + patient_id + "";
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

        private void label15_Click(object sender, EventArgs e)
        {
            txtLast.Clear();
            txtFirst.Clear();
            txtMiddle.Clear();
            txtContact.Clear();
            txtPhone.Clear();
        }

        private void txtFirst_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (patient_id == ""){
                MessageBox.Show("Please select Patient");
            }else{
                frmPatientHistory Form = new frmPatientHistory();
                Form.Show();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (patient_id == "")
            {
                MessageBox.Show("Please select Patient");
            }
            else
            {
                frmDocu Form = new frmDocu();
                Form.Show();
            }
            
        }

       

     

        
    }
    
}
