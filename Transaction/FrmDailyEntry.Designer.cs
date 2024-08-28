namespace SMKCContractor.Transaction
{
    partial class FrmDailyEntry
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDailyEntry));
            this.btnclose = new System.Windows.Forms.Button();
            this.lblcompanyname = new System.Windows.Forms.Label();
            this.lblfinyear = new System.Windows.Forms.Label();
            this.lblloginid = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lblentryid = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtnetamt = new System.Windows.Forms.TextBox();
            this.btnsubmit = new System.Windows.Forms.Button();
            this.btnadd = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtremark = new System.Windows.Forms.TextBox();
            this.dtexpense = new System.Windows.Forms.DataGridView();
            this.cmbmode = new System.Windows.Forms.ComboBox();
            this.cmbitem = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbledge = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtdate = new System.Windows.Forms.DateTimePicker();
            this.txtledid = new System.Windows.Forms.TextBox();
            this.txtamt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lbltotrecamt = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.dtincome = new System.Windows.Forms.DataGridView();
            this.btnsubmit1 = new System.Windows.Forms.Button();
            this.cmbmode1 = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtremark1 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtnetamt1 = new System.Windows.Forms.TextBox();
            this.cmbledge1 = new System.Windows.Forms.ComboBox();
            this.txtdate1 = new System.Windows.Forms.DateTimePicker();
            this.lblledid1 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lbltransmode = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtexpense)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtincome)).BeginInit();
            this.SuspendLayout();
            // 
            // btnclose
            // 
            this.btnclose.Location = new System.Drawing.Point(1373, 12);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(51, 38);
            this.btnclose.TabIndex = 8;
            this.btnclose.Text = "X";
            this.btnclose.UseVisualStyleBackColor = true;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // lblcompanyname
            // 
            this.lblcompanyname.AutoSize = true;
            this.lblcompanyname.Location = new System.Drawing.Point(715, 24);
            this.lblcompanyname.Name = "lblcompanyname";
            this.lblcompanyname.Size = new System.Drawing.Size(24, 26);
            this.lblcompanyname.TabIndex = 7;
            this.lblcompanyname.Text = "..";
            // 
            // lblfinyear
            // 
            this.lblfinyear.AutoSize = true;
            this.lblfinyear.Location = new System.Drawing.Point(1117, 9);
            this.lblfinyear.Name = "lblfinyear";
            this.lblfinyear.Size = new System.Drawing.Size(24, 26);
            this.lblfinyear.TabIndex = 6;
            this.lblfinyear.Text = "..";
            // 
            // lblloginid
            // 
            this.lblloginid.AutoSize = true;
            this.lblloginid.Location = new System.Drawing.Point(25, 12);
            this.lblloginid.Name = "lblloginid";
            this.lblloginid.Size = new System.Drawing.Size(24, 26);
            this.lblloginid.TabIndex = 5;
            this.lblloginid.Text = "..";
            this.lblloginid.Visible = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 66);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1414, 575);
            this.tabControl1.TabIndex = 14;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lblentryid);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.txtnetamt);
            this.tabPage1.Controls.Add(this.btnsubmit);
            this.tabPage1.Controls.Add(this.btnadd);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.txtremark);
            this.tabPage1.Controls.Add(this.dtexpense);
            this.tabPage1.Controls.Add(this.cmbmode);
            this.tabPage1.Controls.Add(this.cmbitem);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.cmbledge);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.txtdate);
            this.tabPage1.Controls.Add(this.txtledid);
            this.tabPage1.Controls.Add(this.txtamt);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 35);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1406, 536);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Expenses / Names";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // lblentryid
            // 
            this.lblentryid.AutoSize = true;
            this.lblentryid.Location = new System.Drawing.Point(39, 146);
            this.lblentryid.Name = "lblentryid";
            this.lblentryid.Size = new System.Drawing.Size(24, 26);
            this.lblentryid.TabIndex = 28;
            this.lblentryid.Text = "..";
            this.lblentryid.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(87, 437);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 26);
            this.label8.TabIndex = 27;
            this.label8.Text = "Total Rs.";
            // 
            // txtnetamt
            // 
            this.txtnetamt.Enabled = false;
            this.txtnetamt.Location = new System.Drawing.Point(191, 437);
            this.txtnetamt.Name = "txtnetamt";
            this.txtnetamt.Size = new System.Drawing.Size(132, 32);
            this.txtnetamt.TabIndex = 7;
            // 
            // btnsubmit
            // 
            this.btnsubmit.Location = new System.Drawing.Point(1020, 450);
            this.btnsubmit.Name = "btnsubmit";
            this.btnsubmit.Size = new System.Drawing.Size(87, 39);
            this.btnsubmit.TabIndex = 9;
            this.btnsubmit.Text = "Saved";
            this.btnsubmit.UseVisualStyleBackColor = true;
            this.btnsubmit.Click += new System.EventHandler(this.btnsubmit_Click);
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(1020, 86);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(87, 39);
            this.btnadd.TabIndex = 6;
            this.btnadd.Text = "Fill out";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(349, 437);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 26);
            this.label7.TabIndex = 23;
            this.label7.Text = "Details";
            // 
            // txtremark
            // 
            this.txtremark.Location = new System.Drawing.Point(434, 434);
            this.txtremark.Multiline = true;
            this.txtremark.Name = "txtremark";
            this.txtremark.Size = new System.Drawing.Size(344, 67);
            this.txtremark.TabIndex = 8;
            this.txtremark.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtremark_KeyDown);
            // 
            // dtexpense
            // 
            this.dtexpense.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtexpense.Location = new System.Drawing.Point(88, 146);
            this.dtexpense.Name = "dtexpense";
            this.dtexpense.RowTemplate.Height = 24;
            this.dtexpense.Size = new System.Drawing.Size(1019, 270);
            this.dtexpense.TabIndex = 22;
            this.dtexpense.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtexpense_CellClick);
            // 
            // cmbmode
            // 
            this.cmbmode.FormattingEnabled = true;
            this.cmbmode.Items.AddRange(new object[] {
            "Cash",
            "Check",
            "NEFT",
            "RTGS"});
            this.cmbmode.Location = new System.Drawing.Point(865, 88);
            this.cmbmode.Name = "cmbmode";
            this.cmbmode.Size = new System.Drawing.Size(149, 34);
            this.cmbmode.TabIndex = 5;
            this.cmbmode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbmode_KeyDown);
            // 
            // cmbitem
            // 
            this.cmbitem.FormattingEnabled = true;
            this.cmbitem.Location = new System.Drawing.Point(202, 88);
            this.cmbitem.Name = "cmbitem";
            this.cmbitem.Size = new System.Drawing.Size(285, 34);
            this.cmbitem.TabIndex = 3;
            this.cmbitem.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbitem_KeyDown);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(725, 91);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(138, 26);
            this.label6.TabIndex = 21;
            this.label6.Text = "Cash / check";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(493, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 26);
            this.label4.TabIndex = 21;
            this.label4.Text = "Amount";
            // 
            // cmbledge
            // 
            this.cmbledge.FormattingEnabled = true;
            this.cmbledge.Location = new System.Drawing.Point(591, 27);
            this.cmbledge.Name = "cmbledge";
            this.cmbledge.Size = new System.Drawing.Size(516, 34);
            this.cmbledge.TabIndex = 2;
            this.cmbledge.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbledge_KeyDown);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(190, 26);
            this.label5.TabIndex = 14;
            this.label5.Text = "Head of Expenses";
            // 
            // txtdate
            // 
            this.txtdate.Location = new System.Drawing.Point(246, 27);
            this.txtdate.Name = "txtdate";
            this.txtdate.Size = new System.Drawing.Size(217, 32);
            this.txtdate.TabIndex = 1;
            this.txtdate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtdate_KeyDown);
            // 
            // txtledid
            // 
            this.txtledid.Location = new System.Drawing.Point(88, 27);
            this.txtledid.Name = "txtledid";
            this.txtledid.Size = new System.Drawing.Size(73, 32);
            this.txtledid.TabIndex = 0;
            this.txtledid.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtledid_KeyDown);
            // 
            // txtamt
            // 
            this.txtamt.Location = new System.Drawing.Point(587, 88);
            this.txtamt.Name = "txtamt";
            this.txtamt.Size = new System.Drawing.Size(132, 32);
            this.txtamt.TabIndex = 4;
            this.txtamt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtamt_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(472, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 26);
            this.label3.TabIndex = 14;
            this.label3.Text = "Laser head";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(180, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 26);
            this.label2.TabIndex = 15;
            this.label2.Text = "Date";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 26);
            this.label1.TabIndex = 16;
            this.label1.Text = "No.";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.lbltotrecamt);
            this.tabPage2.Controls.Add(this.label15);
            this.tabPage2.Controls.Add(this.dtincome);
            this.tabPage2.Controls.Add(this.btnsubmit1);
            this.tabPage2.Controls.Add(this.cmbmode1);
            this.tabPage2.Controls.Add(this.label14);
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Controls.Add(this.txtremark1);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.txtnetamt1);
            this.tabPage2.Controls.Add(this.cmbledge1);
            this.tabPage2.Controls.Add(this.txtdate1);
            this.tabPage2.Controls.Add(this.lblledid1);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Location = new System.Drawing.Point(4, 35);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1406, 536);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Deposit / Generate";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lbltotrecamt
            // 
            this.lbltotrecamt.AutoSize = true;
            this.lbltotrecamt.Location = new System.Drawing.Point(279, 316);
            this.lbltotrecamt.Name = "lbltotrecamt";
            this.lbltotrecamt.Size = new System.Drawing.Size(24, 26);
            this.lbltotrecamt.TabIndex = 31;
            this.lbltotrecamt.Text = "..";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(110, 316);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(178, 26);
            this.label15.TabIndex = 31;
            this.label15.Text = "Total Deposit Rs.";
            // 
            // dtincome
            // 
            this.dtincome.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtincome.Location = new System.Drawing.Point(691, 27);
            this.dtincome.Name = "dtincome";
            this.dtincome.RowTemplate.Height = 24;
            this.dtincome.Size = new System.Drawing.Size(696, 488);
            this.dtincome.TabIndex = 30;
            this.dtincome.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtincome_CellClick);
            // 
            // btnsubmit1
            // 
            this.btnsubmit1.Location = new System.Drawing.Point(584, 234);
            this.btnsubmit1.Name = "btnsubmit1";
            this.btnsubmit1.Size = new System.Drawing.Size(87, 39);
            this.btnsubmit1.TabIndex = 29;
            this.btnsubmit1.Text = "Saved";
            this.btnsubmit1.UseVisualStyleBackColor = true;
            this.btnsubmit1.Click += new System.EventHandler(this.btnsubmit1_Click);
            // 
            // cmbmode1
            // 
            this.cmbmode1.FormattingEnabled = true;
            this.cmbmode1.Items.AddRange(new object[] {
            "Cash",
            "Check",
            "NEFT",
            "RTGS"});
            this.cmbmode1.Location = new System.Drawing.Point(547, 107);
            this.cmbmode1.Name = "cmbmode1";
            this.cmbmode1.Size = new System.Drawing.Size(124, 34);
            this.cmbmode1.TabIndex = 27;
            this.cmbmode1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbmode1_KeyDown);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(413, 110);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(138, 26);
            this.label14.TabIndex = 28;
            this.label14.Text = "Cash / check";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(43, 150);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(79, 26);
            this.label13.TabIndex = 26;
            this.label13.Text = "Details";
            // 
            // txtremark1
            // 
            this.txtremark1.Location = new System.Drawing.Point(128, 150);
            this.txtremark1.Multiline = true;
            this.txtremark1.Name = "txtremark1";
            this.txtremark1.Size = new System.Drawing.Size(543, 67);
            this.txtremark1.TabIndex = 25;
            this.txtremark1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtremark1_KeyDown);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(34, 115);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(88, 26);
            this.label12.TabIndex = 24;
            this.label12.Text = "Amount";
            // 
            // txtnetamt1
            // 
            this.txtnetamt1.Location = new System.Drawing.Point(128, 107);
            this.txtnetamt1.Name = "txtnetamt1";
            this.txtnetamt1.Size = new System.Drawing.Size(279, 32);
            this.txtnetamt1.TabIndex = 23;
            this.txtnetamt1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtnetamt1_KeyDown);
            // 
            // cmbledge1
            // 
            this.cmbledge1.FormattingEnabled = true;
            this.cmbledge1.Location = new System.Drawing.Point(128, 67);
            this.cmbledge1.Name = "cmbledge1";
            this.cmbledge1.Size = new System.Drawing.Size(543, 34);
            this.cmbledge1.TabIndex = 19;
            this.cmbledge1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbledge1_KeyDown);
            // 
            // txtdate1
            // 
            this.txtdate1.Location = new System.Drawing.Point(455, 27);
            this.txtdate1.Name = "txtdate1";
            this.txtdate1.Size = new System.Drawing.Size(217, 32);
            this.txtdate1.TabIndex = 18;
            this.txtdate1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtdate1_KeyDown);
            // 
            // lblledid1
            // 
            this.lblledid1.Enabled = false;
            this.lblledid1.Location = new System.Drawing.Point(128, 27);
            this.lblledid1.Name = "lblledid1";
            this.lblledid1.Size = new System.Drawing.Size(73, 32);
            this.lblledid1.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 75);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(120, 26);
            this.label9.TabIndex = 20;
            this.label9.Text = "Laser head";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(378, 27);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 26);
            this.label10.TabIndex = 21;
            this.label10.Text = "Date";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(76, 33);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(46, 26);
            this.label11.TabIndex = 22;
            this.label11.Text = "No.";
            // 
            // lbltransmode
            // 
            this.lbltransmode.AutoSize = true;
            this.lbltransmode.Location = new System.Drawing.Point(244, 682);
            this.lbltransmode.Name = "lbltransmode";
            this.lbltransmode.Size = new System.Drawing.Size(24, 26);
            this.lbltransmode.TabIndex = 15;
            this.lbltransmode.Text = "..";
            this.lbltransmode.Visible = false;
            // 
            // FrmDailyEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1438, 755);
            this.Controls.Add(this.lbltransmode);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.lblcompanyname);
            this.Controls.Add(this.lblfinyear);
            this.Controls.Add(this.lblloginid);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FrmDailyEntry";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Daily Entry";
            this.Load += new System.EventHandler(this.FrmDailyEntry_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtexpense)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtincome)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.Label lblcompanyname;
        private System.Windows.Forms.Label lblfinyear;
        private System.Windows.Forms.Label lblloginid;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbledge;
        private System.Windows.Forms.DateTimePicker txtdate;
        private System.Windows.Forms.TextBox txtamt;
        private System.Windows.Forms.TextBox txtledid;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ComboBox cmbitem;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbmode;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtnetamt;
        private System.Windows.Forms.Button btnsubmit;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtremark;
        private System.Windows.Forms.DataGridView dtexpense;
        private System.Windows.Forms.Label lblentryid;
        private System.Windows.Forms.ComboBox cmbledge1;
        private System.Windows.Forms.DateTimePicker txtdate1;
        private System.Windows.Forms.TextBox lblledid1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lbltransmode;
        private System.Windows.Forms.ComboBox cmbmode1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtremark1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtnetamt1;
        private System.Windows.Forms.Button btnsubmit1;
        private System.Windows.Forms.Label lbltotrecamt;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DataGridView dtincome;
    }
}