namespace Clinic
{
    partial class frmPatient
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
            this.button1 = new System.Windows.Forms.Button();
            this.txtContact = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMiddle = new System.Windows.Forms.TextBox();
            this.txtFirst = new System.Windows.Forms.TextBox();
            this.txtLast = new System.Windows.Forms.TextBox();
            this.dgvPatient = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.txtStorage = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.rdoDialysisYes = new System.Windows.Forms.RadioButton();
            this.rdoDialysisNo = new System.Windows.Forms.RadioButton();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.rdoLatestxrayYes = new System.Windows.Forms.RadioButton();
            this.rdoLatestXrayNo = new System.Windows.Forms.RadioButton();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.rdoHepatitisYes = new System.Windows.Forms.RadioButton();
            this.rdoHepatitisNo = new System.Windows.Forms.RadioButton();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.rdoLatestlabYes = new System.Windows.Forms.RadioButton();
            this.rdoLatestlabNo = new System.Windows.Forms.RadioButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.rdoHemoglobinYes = new System.Windows.Forms.RadioButton();
            this.rdoHemoglobinNo = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.rdoClinicYes = new System.Windows.Forms.RadioButton();
            this.rdoClinicNo = new System.Windows.Forms.RadioButton();
            this.itemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.patientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sessionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.schedulingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.label13 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPatient)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.txtContact);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtPhone);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtMiddle);
            this.groupBox1.Controls.Add(this.txtFirst);
            this.groupBox1.Controls.Add(this.txtLast);
            this.groupBox1.Controls.Add(this.dgvPatient);
            this.groupBox1.Location = new System.Drawing.Point(9, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(642, 571);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Patient";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(493, 389);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 35);
            this.button1.TabIndex = 14;
            this.button1.Text = "Update";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtContact
            // 
            this.txtContact.Location = new System.Drawing.Point(121, 458);
            this.txtContact.Name = "txtContact";
            this.txtContact.Size = new System.Drawing.Size(223, 22);
            this.txtContact.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 467);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "Contact:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 435);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Phone:";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(121, 430);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(223, 22);
            this.txtPhone.TabIndex = 10;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(493, 345);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 35);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 407);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Middle Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 379);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "First Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 351);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Last Name:";
            // 
            // txtMiddle
            // 
            this.txtMiddle.Location = new System.Drawing.Point(121, 402);
            this.txtMiddle.Name = "txtMiddle";
            this.txtMiddle.Size = new System.Drawing.Size(223, 22);
            this.txtMiddle.TabIndex = 3;
            // 
            // txtFirst
            // 
            this.txtFirst.Location = new System.Drawing.Point(121, 374);
            this.txtFirst.Name = "txtFirst";
            this.txtFirst.Size = new System.Drawing.Size(223, 22);
            this.txtFirst.TabIndex = 2;
            // 
            // txtLast
            // 
            this.txtLast.Location = new System.Drawing.Point(121, 346);
            this.txtLast.Name = "txtLast";
            this.txtLast.Size = new System.Drawing.Size(223, 22);
            this.txtLast.TabIndex = 1;
            // 
            // dgvPatient
            // 
            this.dgvPatient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPatient.Location = new System.Drawing.Point(6, 21);
            this.dgvPatient.Name = "dgvPatient";
            this.dgvPatient.RowTemplate.Height = 24;
            this.dgvPatient.Size = new System.Drawing.Size(616, 296);
            this.dgvPatient.TabIndex = 0;
            this.dgvPatient.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPatient_CellContentClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox9);
            this.groupBox2.Controls.Add(this.groupBox7);
            this.groupBox2.Controls.Add(this.groupBox6);
            this.groupBox2.Controls.Add(this.groupBox8);
            this.groupBox2.Controls.Add(this.groupBox5);
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Location = new System.Drawing.Point(657, 33);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(437, 571);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.txtStorage);
            this.groupBox9.Controls.Add(this.label12);
            this.groupBox9.Location = new System.Drawing.Point(6, 486);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(425, 70);
            this.groupBox9.TabIndex = 25;
            this.groupBox9.TabStop = false;
            // 
            // txtStorage
            // 
            this.txtStorage.Location = new System.Drawing.Point(240, 25);
            this.txtStorage.Name = "txtStorage";
            this.txtStorage.Size = new System.Drawing.Size(166, 22);
            this.txtStorage.TabIndex = 14;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(3, 18);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(169, 29);
            this.label12.TabIndex = 6;
            this.label12.Text = "Storage Code:";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.label11);
            this.groupBox7.Controls.Add(this.rdoDialysisYes);
            this.groupBox7.Controls.Add(this.rdoDialysisNo);
            this.groupBox7.Location = new System.Drawing.Point(6, 410);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(425, 70);
            this.groupBox7.TabIndex = 24;
            this.groupBox7.TabStop = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(3, 13);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(208, 29);
            this.label11.TabIndex = 5;
            this.label11.Text = "Dialysis Logsheet:";
            // 
            // rdoDialysisYes
            // 
            this.rdoDialysisYes.AutoSize = true;
            this.rdoDialysisYes.Checked = true;
            this.rdoDialysisYes.Location = new System.Drawing.Point(260, 21);
            this.rdoDialysisYes.Name = "rdoDialysisYes";
            this.rdoDialysisYes.Size = new System.Drawing.Size(53, 21);
            this.rdoDialysisYes.TabIndex = 19;
            this.rdoDialysisYes.TabStop = true;
            this.rdoDialysisYes.Text = "Yes";
            this.rdoDialysisYes.UseVisualStyleBackColor = true;
            // 
            // rdoDialysisNo
            // 
            this.rdoDialysisNo.AutoSize = true;
            this.rdoDialysisNo.Location = new System.Drawing.Point(344, 21);
            this.rdoDialysisNo.Name = "rdoDialysisNo";
            this.rdoDialysisNo.Size = new System.Drawing.Size(47, 21);
            this.rdoDialysisNo.TabIndex = 20;
            this.rdoDialysisNo.Text = "No";
            this.rdoDialysisNo.UseVisualStyleBackColor = true;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.label8);
            this.groupBox6.Controls.Add(this.rdoLatestxrayYes);
            this.groupBox6.Controls.Add(this.rdoLatestXrayNo);
            this.groupBox6.Location = new System.Drawing.Point(6, 250);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(425, 70);
            this.groupBox6.TabIndex = 24;
            this.groupBox6.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(3, 18);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(214, 29);
            this.label8.TabIndex = 2;
            this.label8.Text = "Latest Chest X-ray:";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // rdoLatestxrayYes
            // 
            this.rdoLatestxrayYes.AutoSize = true;
            this.rdoLatestxrayYes.Checked = true;
            this.rdoLatestxrayYes.Location = new System.Drawing.Point(260, 18);
            this.rdoLatestxrayYes.Name = "rdoLatestxrayYes";
            this.rdoLatestxrayYes.Size = new System.Drawing.Size(53, 21);
            this.rdoLatestxrayYes.TabIndex = 15;
            this.rdoLatestxrayYes.TabStop = true;
            this.rdoLatestxrayYes.Text = "Yes";
            this.rdoLatestxrayYes.UseVisualStyleBackColor = true;
            this.rdoLatestxrayYes.CheckedChanged += new System.EventHandler(this.radioButton8_CheckedChanged);
            // 
            // rdoLatestXrayNo
            // 
            this.rdoLatestXrayNo.AutoSize = true;
            this.rdoLatestXrayNo.Location = new System.Drawing.Point(344, 18);
            this.rdoLatestXrayNo.Name = "rdoLatestXrayNo";
            this.rdoLatestXrayNo.Size = new System.Drawing.Size(47, 21);
            this.rdoLatestXrayNo.TabIndex = 16;
            this.rdoLatestXrayNo.Text = "No";
            this.rdoLatestXrayNo.UseVisualStyleBackColor = true;
            this.rdoLatestXrayNo.CheckedChanged += new System.EventHandler(this.radioButton7_CheckedChanged);
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.label10);
            this.groupBox8.Controls.Add(this.rdoHepatitisYes);
            this.groupBox8.Controls.Add(this.rdoHepatitisNo);
            this.groupBox8.Location = new System.Drawing.Point(6, 326);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(431, 70);
            this.groupBox8.TabIndex = 24;
            this.groupBox8.TabStop = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(3, 25);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(195, 29);
            this.label10.TabIndex = 4;
            this.label10.Text = " Hepatitis Profile:";
            // 
            // rdoHepatitisYes
            // 
            this.rdoHepatitisYes.AutoSize = true;
            this.rdoHepatitisYes.Checked = true;
            this.rdoHepatitisYes.Location = new System.Drawing.Point(266, 19);
            this.rdoHepatitisYes.Name = "rdoHepatitisYes";
            this.rdoHepatitisYes.Size = new System.Drawing.Size(53, 21);
            this.rdoHepatitisYes.TabIndex = 17;
            this.rdoHepatitisYes.TabStop = true;
            this.rdoHepatitisYes.Text = "Yes";
            this.rdoHepatitisYes.UseVisualStyleBackColor = true;
            // 
            // rdoHepatitisNo
            // 
            this.rdoHepatitisNo.AutoSize = true;
            this.rdoHepatitisNo.Location = new System.Drawing.Point(350, 19);
            this.rdoHepatitisNo.Name = "rdoHepatitisNo";
            this.rdoHepatitisNo.Size = new System.Drawing.Size(47, 21);
            this.rdoHepatitisNo.TabIndex = 18;
            this.rdoHepatitisNo.Text = "No";
            this.rdoHepatitisNo.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label9);
            this.groupBox5.Controls.Add(this.rdoLatestlabYes);
            this.groupBox5.Controls.Add(this.rdoLatestlabNo);
            this.groupBox5.Location = new System.Drawing.Point(6, 173);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(431, 70);
            this.groupBox5.TabIndex = 24;
            this.groupBox5.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(3, 21);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(129, 29);
            this.label9.TabIndex = 3;
            this.label9.Text = "Latest Lab:";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // rdoLatestlabYes
            // 
            this.rdoLatestlabYes.AutoSize = true;
            this.rdoLatestlabYes.Checked = true;
            this.rdoLatestlabYes.Location = new System.Drawing.Point(266, 21);
            this.rdoLatestlabYes.Name = "rdoLatestlabYes";
            this.rdoLatestlabYes.Size = new System.Drawing.Size(53, 21);
            this.rdoLatestlabYes.TabIndex = 11;
            this.rdoLatestlabYes.TabStop = true;
            this.rdoLatestlabYes.Text = "Yes";
            this.rdoLatestlabYes.UseVisualStyleBackColor = true;
            // 
            // rdoLatestlabNo
            // 
            this.rdoLatestlabNo.AutoSize = true;
            this.rdoLatestlabNo.Location = new System.Drawing.Point(350, 21);
            this.rdoLatestlabNo.Name = "rdoLatestlabNo";
            this.rdoLatestlabNo.Size = new System.Drawing.Size(47, 21);
            this.rdoLatestlabNo.TabIndex = 12;
            this.rdoLatestlabNo.Text = "No";
            this.rdoLatestlabNo.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.rdoHemoglobinYes);
            this.groupBox4.Controls.Add(this.rdoHemoglobinNo);
            this.groupBox4.Location = new System.Drawing.Point(6, 97);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(425, 70);
            this.groupBox4.TabIndex = 24;
            this.groupBox4.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(9, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(225, 29);
            this.label7.TabIndex = 1;
            this.label7.Text = "Hemoglobin Orden:";
            // 
            // rdoHemoglobinYes
            // 
            this.rdoHemoglobinYes.AutoSize = true;
            this.rdoHemoglobinYes.Checked = true;
            this.rdoHemoglobinYes.Location = new System.Drawing.Point(266, 18);
            this.rdoHemoglobinYes.Name = "rdoHemoglobinYes";
            this.rdoHemoglobinYes.Size = new System.Drawing.Size(53, 21);
            this.rdoHemoglobinYes.TabIndex = 13;
            this.rdoHemoglobinYes.TabStop = true;
            this.rdoHemoglobinYes.Text = "Yes";
            this.rdoHemoglobinYes.UseVisualStyleBackColor = true;
            // 
            // rdoHemoglobinNo
            // 
            this.rdoHemoglobinNo.AutoSize = true;
            this.rdoHemoglobinNo.Location = new System.Drawing.Point(350, 18);
            this.rdoHemoglobinNo.Name = "rdoHemoglobinNo";
            this.rdoHemoglobinNo.Size = new System.Drawing.Size(47, 21);
            this.rdoHemoglobinNo.TabIndex = 14;
            this.rdoHemoglobinNo.Text = "No";
            this.rdoHemoglobinNo.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.rdoClinicYes);
            this.groupBox3.Controls.Add(this.rdoClinicNo);
            this.groupBox3.Location = new System.Drawing.Point(6, 21);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(425, 70);
            this.groupBox3.TabIndex = 23;
            this.groupBox3.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(9, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(171, 29);
            this.label6.TabIndex = 0;
            this.label6.Text = "Clinic Abstract:";
            // 
            // rdoClinicYes
            // 
            this.rdoClinicYes.AutoSize = true;
            this.rdoClinicYes.Checked = true;
            this.rdoClinicYes.Location = new System.Drawing.Point(266, 27);
            this.rdoClinicYes.Name = "rdoClinicYes";
            this.rdoClinicYes.Size = new System.Drawing.Size(53, 21);
            this.rdoClinicYes.TabIndex = 7;
            this.rdoClinicYes.TabStop = true;
            this.rdoClinicYes.Text = "Yes";
            this.rdoClinicYes.UseVisualStyleBackColor = true;
            this.rdoClinicYes.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // rdoClinicNo
            // 
            this.rdoClinicNo.AutoSize = true;
            this.rdoClinicNo.Location = new System.Drawing.Point(350, 27);
            this.rdoClinicNo.Name = "rdoClinicNo";
            this.rdoClinicNo.Size = new System.Drawing.Size(47, 21);
            this.rdoClinicNo.TabIndex = 8;
            this.rdoClinicNo.Text = "No";
            this.rdoClinicNo.UseVisualStyleBackColor = true;
            this.rdoClinicNo.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // itemToolStripMenuItem
            // 
            this.itemToolStripMenuItem.Name = "itemToolStripMenuItem";
            this.itemToolStripMenuItem.Size = new System.Drawing.Size(151, 24);
            this.itemToolStripMenuItem.Text = "Item";
            // 
            // patientToolStripMenuItem
            // 
            this.patientToolStripMenuItem.Name = "patientToolStripMenuItem";
            this.patientToolStripMenuItem.Size = new System.Drawing.Size(151, 24);
            this.patientToolStripMenuItem.Text = "Patient";
            // 
            // sessionToolStripMenuItem
            // 
            this.sessionToolStripMenuItem.Name = "sessionToolStripMenuItem";
            this.sessionToolStripMenuItem.Size = new System.Drawing.Size(151, 24);
            this.sessionToolStripMenuItem.Text = "Session";
            // 
            // schedulingToolStripMenuItem
            // 
            this.schedulingToolStripMenuItem.Name = "schedulingToolStripMenuItem";
            this.schedulingToolStripMenuItem.Size = new System.Drawing.Size(151, 24);
            this.schedulingToolStripMenuItem.Text = "Scheduling";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(151, 24);
            this.toolStripMenuItem1.Text = "Item";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(151, 24);
            this.toolStripMenuItem2.Text = "Patient";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(151, 24);
            this.toolStripMenuItem3.Text = "Session";
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(151, 24);
            this.toolStripMenuItem4.Text = "Scheduling";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(12, 9);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(152, 17);
            this.label13.TabIndex = 8;
            this.label13.Text = "Search (by Lastname):";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(181, 6);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(217, 22);
            this.txtSearch.TabIndex = 9;
            this.txtSearch.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtSearch_KeyUp);
            // 
            // frmPatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1130, 586);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmPatient";
            this.Text = "Patient";
            this.Load += new System.EventHandler(this.frmPatient_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPatient)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMiddle;
        private System.Windows.Forms.TextBox txtFirst;
        private System.Windows.Forms.TextBox txtLast;
        private System.Windows.Forms.DataGridView dgvPatient;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtContact;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton rdoClinicNo;
        private System.Windows.Forms.RadioButton rdoClinicYes;
        private System.Windows.Forms.RadioButton rdoDialysisNo;
        private System.Windows.Forms.RadioButton rdoDialysisYes;
        private System.Windows.Forms.RadioButton rdoHepatitisNo;
        private System.Windows.Forms.RadioButton rdoHepatitisYes;
        private System.Windows.Forms.RadioButton rdoLatestXrayNo;
        private System.Windows.Forms.RadioButton rdoLatestxrayYes;
        private System.Windows.Forms.RadioButton rdoHemoglobinNo;
        private System.Windows.Forms.RadioButton rdoHemoglobinYes;
        private System.Windows.Forms.RadioButton rdoLatestlabNo;
        private System.Windows.Forms.RadioButton rdoLatestlabYes;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.ToolStripMenuItem itemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem patientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sessionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem schedulingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.TextBox txtStorage;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtSearch;

    }
}