namespace Clinic
{
    partial class frmSales
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dgvItem = new System.Windows.Forms.DataGridView();
            this.dgvDialyzer = new System.Windows.Forms.DataGridView();
            this.dgvLab = new System.Windows.Forms.DataGridView();
            this.dgvOther = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDialyzer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLab)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOther)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvItem);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(354, 271);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Item Sales Summary";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvDialyzer);
            this.groupBox2.Location = new System.Drawing.Point(372, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(354, 271);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dialyzer Sales Summary";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgvLab);
            this.groupBox3.Location = new System.Drawing.Point(12, 290);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(354, 271);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Laboratory Sales Summary";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dgvOther);
            this.groupBox4.Location = new System.Drawing.Point(374, 290);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(354, 271);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Other Sales Summary";
            // 
            // dgvItem
            // 
            this.dgvItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItem.Location = new System.Drawing.Point(6, 21);
            this.dgvItem.Name = "dgvItem";
            this.dgvItem.RowTemplate.Height = 24;
            this.dgvItem.Size = new System.Drawing.Size(342, 244);
            this.dgvItem.TabIndex = 0;
            // 
            // dgvDialyzer
            // 
            this.dgvDialyzer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDialyzer.Location = new System.Drawing.Point(6, 21);
            this.dgvDialyzer.Name = "dgvDialyzer";
            this.dgvDialyzer.RowTemplate.Height = 24;
            this.dgvDialyzer.Size = new System.Drawing.Size(342, 244);
            this.dgvDialyzer.TabIndex = 1;
            // 
            // dgvLab
            // 
            this.dgvLab.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLab.Location = new System.Drawing.Point(6, 21);
            this.dgvLab.Name = "dgvLab";
            this.dgvLab.RowTemplate.Height = 24;
            this.dgvLab.Size = new System.Drawing.Size(342, 244);
            this.dgvLab.TabIndex = 2;
            // 
            // dgvOther
            // 
            this.dgvOther.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOther.Location = new System.Drawing.Point(6, 21);
            this.dgvOther.Name = "dgvOther";
            this.dgvOther.RowTemplate.Height = 24;
            this.dgvOther.Size = new System.Drawing.Size(342, 244);
            this.dgvOther.TabIndex = 3;
            // 
            // frmSales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 573);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmSales";
            this.Text = "Sales Summary";
            this.Load += new System.EventHandler(this.frmSales_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDialyzer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLab)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOther)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dgvItem;
        private System.Windows.Forms.DataGridView dgvDialyzer;
        private System.Windows.Forms.DataGridView dgvLab;
        private System.Windows.Forms.DataGridView dgvOther;

    }
}