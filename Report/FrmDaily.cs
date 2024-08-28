using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using CrystalDecisions.CrystalReports.Engine;


namespace SMKCContractor.Report
{
    public partial class FrmDaily : Form
    {
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt;
        SqlConnection con;
        string query;
        Class.Common obj = new Class.Common();
        public FrmDaily(string logid, string logfinyear)
        {
            InitializeComponent();
            lblloginid.Text = logid;
            lblfinyear.Text = logfinyear;
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmDaily_Load(object sender, EventArgs e)
        {
            lblcompanyname.Text = obj.CmpName("Name");
            //txtdate.Focus();
            //bindledger();
            //binditem();
            //clearpayment();
            //txtledid.Text = lblledid1.Text = (obj.maxidTrans("TblDailyHeader", "Id") + 1).ToString();
            //BindGrid_Expense();
            //txtnetamt.Text = calsumedit();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(obj.SqlConn());
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM TblDailyHeader where Date='" + txtdate.Text + "' and TMode='Payment' order by LedName asc", con);
                DataSet ds = new DataSet();
                da.Fill(ds);
                if (ds.Tables.Count > 0)
                {
                    ReportDocument rd = new ReportDocument();
                    rd.Load(Application.StartupPath + "\\DailyReport.rpt");
                    rd.SetDataSource(ds.Tables[0]);
                    rd.SetParameterValue("date", txtdate.Text.Trim());
                    crystalReportViewer1.ReportSource = rd;
                }
                else
                {
                    MessageBox.Show("Information not available");
                }
            }
            catch (Exception es)
            {
                MessageBox.Show("Something Wrong...!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(obj.SqlConn());
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM TblDailyHeader where Date='" + txtdate.Text + "' and TMode='Receipt' order by LedName asc", con);
                DataSet ds = new DataSet();
                da.Fill(ds);
                if (ds.Tables.Count > 0)
                {
                    ReportDocument rd = new ReportDocument();
                    rd.Load(Application.StartupPath + "\\DailyINcomeReport.rpt");
                    rd.SetDataSource(ds.Tables[0]);
                    rd.SetParameterValue("date", txtdate.Text.Trim());
                    crystalReportViewer2.ReportSource = rd;
                }
                else
                {
                    MessageBox.Show("Information not available");
                }
            }
            catch (Exception es)
            {
                MessageBox.Show("Something Wrong...!");
            }
        }
    }
}
