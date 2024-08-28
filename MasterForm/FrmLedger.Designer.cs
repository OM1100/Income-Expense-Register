namespace SMKCContractor.MasterForm
{
    partial class FrmLedger
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLedger));
            this.lblloginid = new System.Windows.Forms.Label();
            this.lblfinyear = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dtgridperson = new System.Windows.Forms.DataGridView();
            this.btndel = new System.Windows.Forms.Button();
            this.btnsubmit = new System.Windows.Forms.Button();
            this.txtledstartdate = new System.Windows.Forms.DateTimePicker();
            this.txtleddate = new System.Windows.Forms.DateTimePicker();
            this.txtledno = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtledamt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtledname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtledperson = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtledid = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dtgriditem = new System.Windows.Forms.DataGridView();
            this.btnidel = new System.Windows.Forms.Button();
            this.btnisubmit = new System.Windows.Forms.Button();
            this.txtirem = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtiamt = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtiname = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtiid = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lblcompanyname = new System.Windows.Forms.Label();
            this.btnclose = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgridperson)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgriditem)).BeginInit();
            this.SuspendLayout();
            // 
            // lblloginid
            // 
            this.lblloginid.AutoSize = true;
            this.lblloginid.Location = new System.Drawing.Point(22, 9);
            this.lblloginid.Name = "lblloginid";
            this.lblloginid.Size = new System.Drawing.Size(24, 26);
            this.lblloginid.TabIndex = 0;
            this.lblloginid.Text = "..";
            this.lblloginid.Visible = false;
            // 
            // lblfinyear
            // 
            this.lblfinyear.AutoSize = true;
            this.lblfinyear.Location = new System.Drawing.Point(875, 9);
            this.lblfinyear.Name = "lblfinyear";
            this.lblfinyear.Size = new System.Drawing.Size(24, 26);
            this.lblfinyear.TabIndex = 1;
            this.lblfinyear.Text = "..";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(2, 56);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1197, 682);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dtgridperson);
            this.tabPage1.Controls.Add(this.btndel);
            this.tabPage1.Controls.Add(this.btnsubmit);
            this.tabPage1.Controls.Add(this.txtledstartdate);
            this.tabPage1.Controls.Add(this.txtleddate);
            this.tabPage1.Controls.Add(this.txtledno);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.txtledamt);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.txtledname);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.txtledperson);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.txtledid);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 35);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1189, 643);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Deposit / Name Register";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dtgridperson
            // 
            this.dtgridperson.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgridperson.Location = new System.Drawing.Point(6, 313);
            this.dtgridperson.Name = "dtgridperson";
            this.dtgridperson.RowTemplate.Height = 24;
            this.dtgridperson.Size = new System.Drawing.Size(1180, 327);
            this.dtgridperson.TabIndex = 10;
            this.dtgridperson.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgridperson_CellClick);
            // 
            // btndel
            // 
            this.btndel.Location = new System.Drawing.Point(456, 253);
            this.btndel.Name = "btndel";
            this.btndel.Size = new System.Drawing.Size(124, 37);
            this.btndel.TabIndex = 9;
            this.btndel.Text = "Remove";
            this.btndel.UseVisualStyleBackColor = true;
            this.btndel.Click += new System.EventHandler(this.btndel_Click);
            // 
            // btnsubmit
            // 
            this.btnsubmit.Location = new System.Drawing.Point(335, 253);
            this.btnsubmit.Name = "btnsubmit";
            this.btnsubmit.Size = new System.Drawing.Size(115, 37);
            this.btnsubmit.TabIndex = 8;
            this.btnsubmit.Text = "Saved";
            this.btnsubmit.UseVisualStyleBackColor = true;
            this.btnsubmit.Click += new System.EventHandler(this.btnsubmit_Click);
            this.btnsubmit.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnsubmit_KeyDown);
            // 
            // txtledstartdate
            // 
            this.txtledstartdate.Location = new System.Drawing.Point(335, 139);
            this.txtledstartdate.Name = "txtledstartdate";
            this.txtledstartdate.Size = new System.Drawing.Size(242, 32);
            this.txtledstartdate.TabIndex = 5;
            this.txtledstartdate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtledstartdate_KeyDown);
            // 
            // txtleddate
            // 
            this.txtleddate.Location = new System.Drawing.Point(494, 102);
            this.txtleddate.Name = "txtleddate";
            this.txtleddate.Size = new System.Drawing.Size(274, 32);
            this.txtleddate.TabIndex = 4;
            this.txtleddate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtleddate_KeyDown);
            // 
            // txtledno
            // 
            this.txtledno.Location = new System.Drawing.Point(335, 102);
            this.txtledno.Name = "txtledno";
            this.txtledno.Size = new System.Drawing.Size(153, 32);
            this.txtledno.TabIndex = 3;
            this.txtledno.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtledno_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(286, 26);
            this.label3.TabIndex = 0;
            this.label3.Text = "Approved Number And Date";
            // 
            // txtledamt
            // 
            this.txtledamt.Location = new System.Drawing.Point(335, 177);
            this.txtledamt.Name = "txtledamt";
            this.txtledamt.Size = new System.Drawing.Size(245, 32);
            this.txtledamt.TabIndex = 6;
            this.txtledamt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtledamt_KeyDown);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(135, 177);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(194, 26);
            this.label6.TabIndex = 0;
            this.label6.Text = "Total Amount (Rs.)";
            // 
            // txtledname
            // 
            this.txtledname.Location = new System.Drawing.Point(335, 64);
            this.txtledname.Name = "txtledname";
            this.txtledname.Size = new System.Drawing.Size(433, 32);
            this.txtledname.TabIndex = 2;
            this.txtledname.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtledname_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(171, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 26);
            this.label2.TabIndex = 0;
            this.label2.Text = "Register Name";
            // 
            // txtledperson
            // 
            this.txtledperson.Location = new System.Drawing.Point(335, 215);
            this.txtledperson.Name = "txtledperson";
            this.txtledperson.Size = new System.Drawing.Size(245, 32);
            this.txtledperson.TabIndex = 7;
            this.txtledperson.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtledperson_KeyDown);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(144, 215);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(175, 26);
            this.label5.TabIndex = 0;
            this.label5.Text = "Name Of Person";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(213, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 26);
            this.label4.TabIndex = 0;
            this.label4.Text = "Start date";
            // 
            // txtledid
            // 
            this.txtledid.Enabled = false;
            this.txtledid.Location = new System.Drawing.Point(335, 26);
            this.txtledid.Name = "txtledid";
            this.txtledid.Size = new System.Drawing.Size(106, 32);
            this.txtledid.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(188, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Account No.";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dtgriditem);
            this.tabPage2.Controls.Add(this.btnidel);
            this.tabPage2.Controls.Add(this.btnisubmit);
            this.tabPage2.Controls.Add(this.txtirem);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.txtiamt);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.txtiname);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.txtiid);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Location = new System.Drawing.Point(4, 35);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1189, 643);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Deposit / Name Head (Item)";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dtgriditem
            // 
            this.dtgriditem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgriditem.Location = new System.Drawing.Point(5, 241);
            this.dtgriditem.Name = "dtgriditem";
            this.dtgriditem.RowTemplate.Height = 24;
            this.dtgriditem.Size = new System.Drawing.Size(1180, 396);
            this.dtgriditem.TabIndex = 14;
            this.dtgriditem.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgriditem_CellContentClick);
            // 
            // btnidel
            // 
            this.btnidel.Location = new System.Drawing.Point(352, 198);
            this.btnidel.Name = "btnidel";
            this.btnidel.Size = new System.Drawing.Size(117, 37);
            this.btnidel.TabIndex = 5;
            this.btnidel.Text = "Remove";
            this.btnidel.UseVisualStyleBackColor = true;
            this.btnidel.Click += new System.EventHandler(this.btnidel_Click);
            // 
            // btnisubmit
            // 
            this.btnisubmit.Location = new System.Drawing.Point(240, 198);
            this.btnisubmit.Name = "btnisubmit";
            this.btnisubmit.Size = new System.Drawing.Size(106, 37);
            this.btnisubmit.TabIndex = 4;
            this.btnisubmit.Text = "Saved";
            this.btnisubmit.UseVisualStyleBackColor = true;
            this.btnisubmit.Click += new System.EventHandler(this.btnisubmit_Click);
            this.btnisubmit.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnisubmit_KeyDown);
            // 
            // txtirem
            // 
            this.txtirem.Location = new System.Drawing.Point(241, 138);
            this.txtirem.Multiline = true;
            this.txtirem.Name = "txtirem";
            this.txtirem.Size = new System.Drawing.Size(433, 54);
            this.txtirem.TabIndex = 3;
            this.txtirem.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtirem_KeyDown);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(155, 141);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 26);
            this.label9.TabIndex = 10;
            this.label9.Text = "Details";
            // 
            // txtiamt
            // 
            this.txtiamt.Location = new System.Drawing.Point(240, 100);
            this.txtiamt.Name = "txtiamt";
            this.txtiamt.Size = new System.Drawing.Size(433, 32);
            this.txtiamt.TabIndex = 2;
            this.txtiamt.TextChanged += new System.EventHandler(this.txtiamt_TextChanged);
            this.txtiamt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtiamt_KeyDown);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(0, 103);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(234, 26);
            this.label10.TabIndex = 4;
            this.label10.Text = "Approximate cost (Rs.)";
            // 
            // txtiname
            // 
            this.txtiname.Location = new System.Drawing.Point(240, 62);
            this.txtiname.Name = "txtiname";
            this.txtiname.Size = new System.Drawing.Size(433, 32);
            this.txtiname.TabIndex = 1;
            this.txtiname.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtiname_KeyDown);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(163, 68);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 26);
            this.label7.TabIndex = 4;
            this.label7.Text = "Name";
            // 
            // txtiid
            // 
            this.txtiid.Enabled = false;
            this.txtiid.Location = new System.Drawing.Point(240, 24);
            this.txtiid.Name = "txtiid";
            this.txtiid.Size = new System.Drawing.Size(106, 32);
            this.txtiid.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(103, 30);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(131, 26);
            this.label8.TabIndex = 3;
            this.label8.Text = "Account No.";
            // 
            // lblcompanyname
            // 
            this.lblcompanyname.AutoSize = true;
            this.lblcompanyname.Location = new System.Drawing.Point(451, 9);
            this.lblcompanyname.Name = "lblcompanyname";
            this.lblcompanyname.Size = new System.Drawing.Size(24, 26);
            this.lblcompanyname.TabIndex = 3;
            this.lblcompanyname.Text = "..";
            // 
            // btnclose
            // 
            this.btnclose.Location = new System.Drawing.Point(1131, 12);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(51, 38);
            this.btnclose.TabIndex = 4;
            this.btnclose.Text = "X";
            this.btnclose.UseVisualStyleBackColor = true;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click_1);
            // 
            // FrmLedger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 750);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.lblcompanyname);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.lblfinyear);
            this.Controls.Add(this.lblloginid);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FrmLedger";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FrmLedger";
            this.Load += new System.EventHandler(this.FrmLedger_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgridperson)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgriditem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblloginid;
        private System.Windows.Forms.Label lblfinyear;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label lblcompanyname;
        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.DateTimePicker txtledstartdate;
        private System.Windows.Forms.DateTimePicker txtleddate;
        private System.Windows.Forms.TextBox txtledno;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtledname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtledperson;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtledid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtgridperson;
        private System.Windows.Forms.Button btndel;
        private System.Windows.Forms.Button btnsubmit;
        private System.Windows.Forms.TextBox txtledamt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dtgriditem;
        private System.Windows.Forms.Button btnidel;
        private System.Windows.Forms.Button btnisubmit;
        private System.Windows.Forms.TextBox txtirem;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtiamt;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtiname;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtiid;
        private System.Windows.Forms.Label label8;
    }
}