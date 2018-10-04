using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Clinic
{
    public partial class frmLanding : Form
    {
        public frmLanding()
        {
            InitializeComponent();
        }

        private void patientInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;
            frmPatient Form = new frmPatient();
            Form.MdiParent = this;
            Form.Show();
        }

        private void addScheduleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;
            frmSchedule Form = new frmSchedule();
            Form.MdiParent = this;
            Form.Show();
        }

        private void itemInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;
            Form1 Form = new Form1();
            Form.MdiParent = this;
            Form.Show();
        }

        private void itemGroupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;
            frmItemGroup Form = new frmItemGroup();
            Form.MdiParent = this;
            Form.Show();
        }

        private void addBillingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;
            frmBilling Form = new frmBilling();
            Form.MdiParent = this;
            Form.Show();
        }

        private void addPaymentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;
            frmPayment Form = new frmPayment();
            Form.MdiParent = this;
            Form.Show();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLogin.user_id = "";
            frmLogin frm = new frmLogin();
            frm.Show();
            this.Hide();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void salesSummaryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;
            frmSales Form = new frmSales();
            Form.MdiParent = this;
            Form.Show();
        }

        private void dialyzerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;
            frmDialyzer Form = new frmDialyzer();
            Form.MdiParent = this;
            Form.Show();
        }

        private void laboratoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;
            frmLaboratory Form = new frmLaboratory();
            Form.MdiParent = this;
            Form.Show();
        }

        private void modeOfPaymentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;
            frmMode Form = new frmMode();
            Form.MdiParent = this;
            Form.Show();
        }

        private void adminAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;
            frmSetting Form = new frmSetting();
            Form.MdiParent = this;
            Form.Show();
        }

        private void viewScheduleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;
            frmViewSchedule Form = new frmViewSchedule();
            Form.MdiParent = this;
            Form.Show();
        }

        private void itemGroupNameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;
            frmItemGroupName Form = new frmItemGroupName();
            Form.MdiParent = this;
            Form.Show();
        }

        private void frmLanding_Load(object sender, EventArgs e)
        {

        }

        private void dailySalesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;
            frmDailySales Form = new frmDailySales();
            Form.MdiParent = this;
            Form.Show();
        }

        
    }
}
