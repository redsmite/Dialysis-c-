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
    public partial class Form1 : Form
    {
        MySqlConnection conn = new MySqlConnection("server = localhost; uid = root; pwd=;database= db_clinic");
        String item_id = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            conn.Open();
            String sql = "SELECT item_id,name,brand,description,packaging,sell_price,original_price,quantity FROM item_info";
            MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvItem.DataSource = dt;
            conn.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            conn.Open();
            String name = convertQuotes(txtName.Text);
            String brand = convertQuotes(txtBrand.Text);
            String desc = convertQuotes(txtDesc.Text);
            String packaging = convertQuotes(cboPackaging.Text);
            String s_price = txtSPrice.Text;
            String o_price = txtOPrice.Text;
            String quantity = txtQuantity.Text;
            String sql = "INSERT INTO item_info (name,brand,description,packaging,sell_price,original_price,quantity) VALUES ('" + name + "','" + brand + "','" + desc + "','" + packaging + "','" + s_price + "','" + o_price + "','" + quantity + "')";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Add Successful!");
            dgvItem.Refresh();
            Form1_Load(sender, e);
            txtName.Clear();
            txtBrand.Clear();
            txtDesc.Clear();
            txtSPrice.Clear();
            txtOPrice.Clear();
            txtQuantity.Clear();
        }

        private void dgvItem_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            if (e.RowIndex > -1) {
                DataGridViewRow row = dgvItem.Rows[i];
                item_id = row.Cells[0].Value.ToString();
                txtName.Text = row.Cells[1].Value.ToString();
                txtBrand.Text = row.Cells[2].Value.ToString();
                txtDesc.Text = row.Cells[3].Value.ToString();
                cboPackaging.Text = row.Cells[4].Value.ToString();
                txtSPrice.Text = row.Cells[5].Value.ToString();
                txtOPrice.Text = row.Cells[6].Value.ToString();
                txtQuantity.Text = row.Cells[7].Value.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            conn.Open();
            String name = convertQuotes(txtName.Text);
            String brand = convertQuotes(txtBrand.Text);
            String desc = convertQuotes(txtDesc.Text);
            String packaging = convertQuotes(cboPackaging.Text);
            String s_price = txtSPrice.Text;
            String o_price = txtOPrice.Text;
            String quantity = txtQuantity.Text;
            String sql = "UPDATE item_info SET name = '"+ name +"', brand = '"+ brand +"', description = '"+ desc +"', packaging = '"+ packaging +"', sell_price ='"+ s_price +"', original_price = '"+ o_price +"', quantity = '"+ quantity +"' WHERE item_id = '"+ item_id +"'";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Update Successful!");
            dgvItem.Refresh();
            Form1_Load(sender, e);
            txtName.Clear();
            txtBrand.Clear();
            txtDesc.Clear();
            txtSPrice.Clear();
            txtOPrice.Clear();
            txtQuantity.Clear();
        }

        private void txtSearch_KeyUp(object sender, KeyEventArgs e)
        {
            conn.Open();
            String sql = "SELECT item_id,name,brand,description,packaging,sell_price,original_price,quantity FROM item_info WHERE name LIKE '%"+convertQuotes(txtSearch.Text)+"%'";
            MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvItem.DataSource = dt;
            conn.Close();
        }

        private void txtSPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void txtOPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void txtQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }
        public string convertQuotes(string str)
        {

            return str.Replace("'", "''");

        }
    }
}
