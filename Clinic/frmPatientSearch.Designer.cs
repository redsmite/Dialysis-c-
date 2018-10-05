namespace Clinic
{
    partial class frmPatientSearch
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
            this.dgvPatientSearch = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPatientSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPatientSearch
            // 
            this.dgvPatientSearch.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvPatientSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPatientSearch.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvPatientSearch.Location = new System.Drawing.Point(12, 12);
            this.dgvPatientSearch.Name = "dgvPatientSearch";
            this.dgvPatientSearch.RowTemplate.Height = 24;
            this.dgvPatientSearch.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPatientSearch.Size = new System.Drawing.Size(332, 354);
            this.dgvPatientSearch.TabIndex = 0;
            this.dgvPatientSearch.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPatientSearch_CellClick);
            this.dgvPatientSearch.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPatientSearch_CellContentClick);
            // 
            // frmPatientSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 378);
            this.Controls.Add(this.dgvPatientSearch);
            this.Name = "frmPatientSearch";
            this.Text = "Search Patient";
            this.Load += new System.EventHandler(this.frmPatientSearch_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPatientSearch)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPatientSearch;
    }
}