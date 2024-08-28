using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SMKCContractor.Master
{
    public partial class MasterMDI : Form
    {
        private int childFormNumber = 0;
        Class.Common cmn = new Class.Common();
        public MasterMDI()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //toolStrip.Visible = toolBarToolStripMenuItem.Checked;
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
           // statusStrip.Visible = statusBarToolStripMenuItem.Checked;
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ledgerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MasterForm.FrmLedger cf = new MasterForm.FrmLedger(this.lbllogid.Text, this.lblfinyear.Text);
            cf.MdiParent = this;
            cf.ClientSize = new System.Drawing.Size(1150, 750);
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            //cf.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            cf.Dock = DockStyle.Fill;
            cf.Show();

        }

        private void MasterMDI_Load(object sender, EventArgs e)
        {
            //MasterMDI obj = new MasterMDI();
            //obj.Text = cmn.CmpName("Name");
        }

        private void daillyEntryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Transaction.FrmDailyEntry cf = new Transaction.FrmDailyEntry(this.lbllogid.Text, this.lblfinyear.Text,"Payment");
            cf.MdiParent = this;
            cf.ClientSize = new System.Drawing.Size(1150, 750);
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            cf.Dock = DockStyle.Fill;
            cf.Show();
        }

        private void incomesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Transaction.FrmDailyEntry cf = new Transaction.FrmDailyEntry(this.lbllogid.Text, this.lblfinyear.Text, "Receipt");
            cf.MdiParent = this;
            cf.ClientSize = new System.Drawing.Size(1150, 750);
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            cf.Dock = DockStyle.Fill;
            cf.Show();
        }

        private void combinedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Report.FmReport cf = new Report.FmReport(this.lbllogid.Text, this.lblfinyear.Text, "Payment");
            cf.MdiParent = this;
            cf.ClientSize = new System.Drawing.Size(1150, 750);
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            cf.Dock = DockStyle.Fill;
            cf.Show();
        }

        private void ledgerToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Report.FrmDaily cf = new Report.FrmDaily(this.lbllogid.Text, this.lblfinyear.Text);
            cf.MdiParent = this;
            cf.ClientSize = new System.Drawing.Size(1150, 750);
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            cf.Dock = DockStyle.Fill;
            cf.Show();
        }

        private void fileMenu_Click(object sender, EventArgs e)
        {

        }

        private void helpMenu_Click(object sender, EventArgs e)
        {

        }

        private void reportToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
