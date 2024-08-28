namespace SMKCContractor.Report
{
    partial class FmReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FmReport));
            this.btnclose = new System.Windows.Forms.Button();
            this.lblcompanyname = new System.Windows.Forms.Label();
            this.lblfinyear = new System.Windows.Forms.Label();
            this.lblloginid = new System.Windows.Forms.Label();
            this.cmbledge = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnclose
            // 
            this.btnclose.Location = new System.Drawing.Point(1847, 15);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(51, 38);
            this.btnclose.TabIndex = 12;
            this.btnclose.Text = "X";
            this.btnclose.UseVisualStyleBackColor = true;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // lblcompanyname
            // 
            this.lblcompanyname.AutoSize = true;
            this.lblcompanyname.Location = new System.Drawing.Point(708, 30);
            this.lblcompanyname.Name = "lblcompanyname";
            this.lblcompanyname.Size = new System.Drawing.Size(24, 26);
            this.lblcompanyname.TabIndex = 11;
            this.lblcompanyname.Text = "..";
            // 
            // lblfinyear
            // 
            this.lblfinyear.AutoSize = true;
            this.lblfinyear.Location = new System.Drawing.Point(1110, 15);
            this.lblfinyear.Name = "lblfinyear";
            this.lblfinyear.Size = new System.Drawing.Size(24, 26);
            this.lblfinyear.TabIndex = 10;
            this.lblfinyear.Text = "..";
            // 
            // lblloginid
            // 
            this.lblloginid.AutoSize = true;
            this.lblloginid.Location = new System.Drawing.Point(18, 18);
            this.lblloginid.Name = "lblloginid";
            this.lblloginid.Size = new System.Drawing.Size(24, 26);
            this.lblloginid.TabIndex = 9;
            this.lblloginid.Text = "..";
            this.lblloginid.Visible = false;
            // 
            // cmbledge
            // 
            this.cmbledge.FormattingEnabled = true;
            this.cmbledge.Location = new System.Drawing.Point(126, 85);
            this.cmbledge.Name = "cmbledge";
            this.cmbledge.Size = new System.Drawing.Size(670, 34);
            this.cmbledge.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(0, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 26);
            this.label3.TabIndex = 18;
            this.label3.Text = "Laser head";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(802, 81);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(73, 38);
            this.button1.TabIndex = 22;
            this.button1.Text = "All";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Location = new System.Drawing.Point(29, 137);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.Size = new System.Drawing.Size(1290, 906);
            this.crystalReportViewer1.TabIndex = 23;
            this.crystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(881, 81);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(239, 38);
            this.button2.TabIndex = 24;
            this.button2.Text = "Independent expenses";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1126, 81);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(249, 38);
            this.button3.TabIndex = 25;
            this.button3.Text = "Independent generation";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // FmReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.crystalReportViewer1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cmbledge);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.lblcompanyname);
            this.Controls.Add(this.lblfinyear);
            this.Controls.Add(this.lblloginid);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FmReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FmReport";
            this.Load += new System.EventHandler(this.FmReport_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.Label lblcompanyname;
        private System.Windows.Forms.Label lblfinyear;
        private System.Windows.Forms.Label lblloginid;
        private System.Windows.Forms.ComboBox cmbledge;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}