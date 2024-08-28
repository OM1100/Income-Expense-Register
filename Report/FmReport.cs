using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using CrystalDecisions.Shared;
using CrystalDecisions.CrystalReports.Engine;

namespace SMKCContractor.Report
{
    public partial class FmReport : Form
    {
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt;
        SqlConnection con;
        string query;
        Class.Common obj = new Class.Common();
        public FmReport(string logid, string logfinyear, string mode)
        {
            InitializeComponent();
            lblloginid.Text = logid;
            lblfinyear.Text = logfinyear;
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FmReport_Load(object sender, EventArgs e)
        {
            lblcompanyname.Text = obj.CmpName("Name");
            bindledger();
        }
        public void bindledger()
        {
            try
            {
                query = "Select Id, LedName from TblLedgerMst union select '0' as Id, 'Select' as LedName";
                SqlConnection con = new SqlConnection(obj.SqlConn());
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataAdapter adapt = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapt.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    cmbledge.Items.Clear();
                    cmbledge.DataSource = dt;
                    cmbledge.DisplayMember = "LedName";
                    cmbledge.ValueMember = "Id";
                    cmbledge.DataBindings.ToString();
                }
            }
            catch (Exception es)
            {
                MessageBox.Show("Something Wrong...!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                query = "alter view ViewSummary as  select distinct t1.LedName, (select SUM(isnull(r1.NetAmt,0))  as PayAmt from TblDailyHeader r1 where r1.TMode = 'Payment' and r1.LedName=t1.LedName) as [Payment], (select SUM(isnull(r1.NetAmt,0))  as PayAmt from TblDailyHeader r1 where r1.TMode = 'Receipt' and r1.LedName=t1.LedName) as [Receipt], (((select SUM(isnull(r1.NetAmt,0))  as PayAmt from TblDailyHeader r1 where r1.TMode = 'Receipt' and r1.LedName=t1.LedName)) - ((select SUM(isnull(r1.NetAmt,0))  as PayAmt from TblDailyHeader r1 where r1.TMode = 'Payment' and r1.LedName=t1.LedName))) as profit  from TblDailyHeader t1";
                SqlConnection con = new SqlConnection(obj.SqlConn());
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataAdapter adapt = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapt.Fill(dt);
                //if (dt.Rows.Count > 0)
                //{
                SqlDataAdapter da1 = new SqlDataAdapter("SELECT * FROM ViewSummary order by LedName asc", con);
                DataSet ds1 = new DataSet();
                da1.Fill(ds1);
                if (ds1.Tables.Count > 0)
                {
                    ReportDocument rd = new ReportDocument();
                    rd.Load(Application.StartupPath + "\\ReportSummary.rpt");
                    rd.SetDataSource(ds1.Tables[0]);
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
                SqlDataAdapter da = new SqlDataAdapter("select * from TblDailyDetail  where ledid = " + obj.LedIdBYName(cmbledge.Text.Trim()) + " order by TransDate asc", con);
                DataSet ds = new DataSet();
                da.Fill(ds);
                if (ds.Tables.Count > 0)
                {
                    ReportDocument rd = new ReportDocument();
                    rd.Load(Application.StartupPath + "\\ReportDetail.rpt");
                    rd.SetDataSource(ds.Tables[0]);
                    rd.SetParameterValue("LedName", cmbledge.Text.Trim());
                    crystalReportViewer1.ReportSource = rd;
                }
                else
                {
                    MessageBox.Show("Information does not exist");
                }
            }
            catch (Exception es)
            {
                MessageBox.Show("Something Wrong...!");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(obj.SqlConn());
                SqlDataAdapter da = new SqlDataAdapter("select * from TblDailyHeader  where ledid = " + obj.LedIdBYName(cmbledge.Text.Trim()) + " and TMode='Receipt' order by Date asc", con);
                DataSet ds = new DataSet();
                da.Fill(ds);
                if (ds.Tables.Count > 0)
                {
                    ReportDocument rd = new ReportDocument();
                    rd.Load(Application.StartupPath + "\\ReportDetailJama.rpt");
                    rd.SetDataSource(ds.Tables[0]);
                    rd.SetParameterValue("LedName", cmbledge.Text.Trim());
                    crystalReportViewer1.ReportSource = rd;
                }
                else
                {
                    MessageBox.Show("Hittite does not exist");
                }
            }
            catch (Exception es)
            {
                MessageBox.Show("Something Wrong...!");
            }
        }
    }
}
