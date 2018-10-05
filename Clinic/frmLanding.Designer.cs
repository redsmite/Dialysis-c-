namespace Clinic
{
    partial class frmLanding
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.patientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.patientInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.schedulingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addScheduleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewScheduleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inventoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.itemInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.itemGroupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.itemGroupNameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dialyzerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.laboratoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.billingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addBillingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.paymentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addPaymentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modeOfPaymentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salesSummaryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dailySalesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.accountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adminAccountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.patientToolStripMenuItem,
            this.schedulingToolStripMenuItem,
            this.inventoryToolStripMenuItem,
            this.billingToolStripMenuItem,
            this.paymentToolStripMenuItem,
            this.salesToolStripMenuItem,
            this.accountToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1262, 36);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logoutToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(54, 32);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(147, 32);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(147, 32);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // patientToolStripMenuItem
            // 
            this.patientToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.patientInfoToolStripMenuItem});
            this.patientToolStripMenuItem.Name = "patientToolStripMenuItem";
            this.patientToolStripMenuItem.Size = new System.Drawing.Size(85, 32);
            this.patientToolStripMenuItem.Text = "Patient";
            // 
            // patientInfoToolStripMenuItem
            // 
            this.patientInfoToolStripMenuItem.Name = "patientInfoToolStripMenuItem";
            this.patientInfoToolStripMenuItem.Size = new System.Drawing.Size(184, 32);
            this.patientInfoToolStripMenuItem.Text = "Patient Info";
            this.patientInfoToolStripMenuItem.Click += new System.EventHandler(this.patientInfoToolStripMenuItem_Click);
            // 
            // schedulingToolStripMenuItem
            // 
            this.schedulingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addScheduleToolStripMenuItem,
            this.viewScheduleToolStripMenuItem});
            this.schedulingToolStripMenuItem.Name = "schedulingToolStripMenuItem";
            this.schedulingToolStripMenuItem.Size = new System.Drawing.Size(121, 32);
            this.schedulingToolStripMenuItem.Text = "Scheduling";
            // 
            // addScheduleToolStripMenuItem
            // 
            this.addScheduleToolStripMenuItem.Name = "addScheduleToolStripMenuItem";
            this.addScheduleToolStripMenuItem.Size = new System.Drawing.Size(209, 32);
            this.addScheduleToolStripMenuItem.Text = "Add Schedule";
            this.addScheduleToolStripMenuItem.Click += new System.EventHandler(this.addScheduleToolStripMenuItem_Click);
            // 
            // viewScheduleToolStripMenuItem
            // 
            this.viewScheduleToolStripMenuItem.Name = "viewScheduleToolStripMenuItem";
            this.viewScheduleToolStripMenuItem.Size = new System.Drawing.Size(209, 32);
            this.viewScheduleToolStripMenuItem.Text = "View Schedule";
            this.viewScheduleToolStripMenuItem.Click += new System.EventHandler(this.viewScheduleToolStripMenuItem_Click);
            // 
            // inventoryToolStripMenuItem
            // 
            this.inventoryToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemInfoToolStripMenuItem,
            this.itemGroupToolStripMenuItem,
            this.itemGroupNameToolStripMenuItem,
            this.dialyzerToolStripMenuItem,
            this.laboratoryToolStripMenuItem});
            this.inventoryToolStripMenuItem.Name = "inventoryToolStripMenuItem";
            this.inventoryToolStripMenuItem.Size = new System.Drawing.Size(107, 32);
            this.inventoryToolStripMenuItem.Text = "Inventory";
            // 
            // itemInfoToolStripMenuItem
            // 
            this.itemInfoToolStripMenuItem.Name = "itemInfoToolStripMenuItem";
            this.itemInfoToolStripMenuItem.Size = new System.Drawing.Size(216, 32);
            this.itemInfoToolStripMenuItem.Text = "Item Info";
            this.itemInfoToolStripMenuItem.Click += new System.EventHandler(this.itemInfoToolStripMenuItem_Click);
            // 
            // itemGroupToolStripMenuItem
            // 
            this.itemGroupToolStripMenuItem.Name = "itemGroupToolStripMenuItem";
            this.itemGroupToolStripMenuItem.Size = new System.Drawing.Size(216, 32);
            this.itemGroupToolStripMenuItem.Text = "Item Group";
            this.itemGroupToolStripMenuItem.Click += new System.EventHandler(this.itemGroupToolStripMenuItem_Click);
            // 
            // itemGroupNameToolStripMenuItem
            // 
            this.itemGroupNameToolStripMenuItem.Name = "itemGroupNameToolStripMenuItem";
            this.itemGroupNameToolStripMenuItem.Size = new System.Drawing.Size(216, 32);
            this.itemGroupNameToolStripMenuItem.Text = "Manage Group";
            this.itemGroupNameToolStripMenuItem.Click += new System.EventHandler(this.itemGroupNameToolStripMenuItem_Click);
            // 
            // dialyzerToolStripMenuItem
            // 
            this.dialyzerToolStripMenuItem.Name = "dialyzerToolStripMenuItem";
            this.dialyzerToolStripMenuItem.Size = new System.Drawing.Size(216, 32);
            this.dialyzerToolStripMenuItem.Text = "Dialyzer";
            this.dialyzerToolStripMenuItem.Click += new System.EventHandler(this.dialyzerToolStripMenuItem_Click);
            // 
            // laboratoryToolStripMenuItem
            // 
            this.laboratoryToolStripMenuItem.Name = "laboratoryToolStripMenuItem";
            this.laboratoryToolStripMenuItem.Size = new System.Drawing.Size(216, 32);
            this.laboratoryToolStripMenuItem.Text = "Laboratory";
            this.laboratoryToolStripMenuItem.Click += new System.EventHandler(this.laboratoryToolStripMenuItem_Click);
            // 
            // billingToolStripMenuItem
            // 
            this.billingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addBillingToolStripMenuItem});
            this.billingToolStripMenuItem.Name = "billingToolStripMenuItem";
            this.billingToolStripMenuItem.Size = new System.Drawing.Size(78, 32);
            this.billingToolStripMenuItem.Text = "Billing";
            // 
            // addBillingToolStripMenuItem
            // 
            this.addBillingToolStripMenuItem.Name = "addBillingToolStripMenuItem";
            this.addBillingToolStripMenuItem.Size = new System.Drawing.Size(180, 32);
            this.addBillingToolStripMenuItem.Text = "Add Billing";
            this.addBillingToolStripMenuItem.Click += new System.EventHandler(this.addBillingToolStripMenuItem_Click);
            // 
            // paymentToolStripMenuItem
            // 
            this.paymentToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addPaymentToolStripMenuItem,
            this.modeOfPaymentToolStripMenuItem});
            this.paymentToolStripMenuItem.Name = "paymentToolStripMenuItem";
            this.paymentToolStripMenuItem.Size = new System.Drawing.Size(100, 32);
            this.paymentToolStripMenuItem.Text = "Payment";
            // 
            // addPaymentToolStripMenuItem
            // 
            this.addPaymentToolStripMenuItem.Name = "addPaymentToolStripMenuItem";
            this.addPaymentToolStripMenuItem.Size = new System.Drawing.Size(240, 32);
            this.addPaymentToolStripMenuItem.Text = "Add Payment";
            this.addPaymentToolStripMenuItem.Click += new System.EventHandler(this.addPaymentToolStripMenuItem_Click);
            // 
            // modeOfPaymentToolStripMenuItem
            // 
            this.modeOfPaymentToolStripMenuItem.Name = "modeOfPaymentToolStripMenuItem";
            this.modeOfPaymentToolStripMenuItem.Size = new System.Drawing.Size(240, 32);
            this.modeOfPaymentToolStripMenuItem.Text = "Mode of Payment";
            this.modeOfPaymentToolStripMenuItem.Click += new System.EventHandler(this.modeOfPaymentToolStripMenuItem_Click);
            // 
            // salesToolStripMenuItem
            // 
            this.salesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salesSummaryToolStripMenuItem,
            this.dailySalesToolStripMenuItem});
            this.salesToolStripMenuItem.Name = "salesToolStripMenuItem";
            this.salesToolStripMenuItem.Size = new System.Drawing.Size(68, 32);
            this.salesToolStripMenuItem.Text = "Sales";
            // 
            // salesSummaryToolStripMenuItem
            // 
            this.salesSummaryToolStripMenuItem.Name = "salesSummaryToolStripMenuItem";
            this.salesSummaryToolStripMenuItem.Size = new System.Drawing.Size(216, 32);
            this.salesSummaryToolStripMenuItem.Text = "Sales Summary";
            this.salesSummaryToolStripMenuItem.Click += new System.EventHandler(this.salesSummaryToolStripMenuItem_Click);
            // 
            // dailySalesToolStripMenuItem
            // 
            this.dailySalesToolStripMenuItem.Name = "dailySalesToolStripMenuItem";
            this.dailySalesToolStripMenuItem.Size = new System.Drawing.Size(216, 32);
            this.dailySalesToolStripMenuItem.Text = "Daily Sales";
            this.dailySalesToolStripMenuItem.Click += new System.EventHandler(this.dailySalesToolStripMenuItem_Click);
            // 
            // accountToolStripMenuItem
            // 
            this.accountToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adminAccountToolStripMenuItem});
            this.accountToolStripMenuItem.Name = "accountToolStripMenuItem";
            this.accountToolStripMenuItem.Size = new System.Drawing.Size(96, 32);
            this.accountToolStripMenuItem.Text = "Account";
            // 
            // adminAccountToolStripMenuItem
            // 
            this.adminAccountToolStripMenuItem.Name = "adminAccountToolStripMenuItem";
            this.adminAccountToolStripMenuItem.Size = new System.Drawing.Size(276, 32);
            this.adminAccountToolStripMenuItem.Text = "Manage User Account";
            this.adminAccountToolStripMenuItem.Click += new System.EventHandler(this.adminAccountToolStripMenuItem_Click);
            // 
            // frmLanding
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(1262, 733);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmLanding";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Eastern Marikina Dialysis Center";
            this.Load += new System.EventHandler(this.frmLanding_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem patientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem patientInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem schedulingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addScheduleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inventoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem itemInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem itemGroupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem billingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addBillingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem paymentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addPaymentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem accountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salesSummaryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dialyzerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem laboratoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modeOfPaymentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewScheduleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adminAccountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem itemGroupNameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dailySalesToolStripMenuItem;
    }
}