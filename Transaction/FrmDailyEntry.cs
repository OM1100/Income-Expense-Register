using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;


namespace SMKCContractor.Transaction
{
    public partial class FrmDailyEntry : Form
    {
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt;
        SqlConnection con;
        string query;
        Class.Common obj = new Class.Common();
        public FrmDailyEntry(string logid, string logfinyear, string mode)
        {
            InitializeComponent();
            lblloginid.Text = logid;
            lblfinyear.Text = logfinyear;
            if (mode == "Payment")
            {
                lbltransmode.Text = mode;
                tabControl1.TabPages.Remove(tabPage2);
            }
            if (mode == "Receipt")
            {
                lbltransmode.Text = mode;
                tabControl1.TabPages.Remove(tabPage1);
            }
        }

        public void bindledger()
        {
                SqlConnection con = new SqlConnection(obj.SqlConn());
                DataTable dt = new DataTable();
                try
                {

                    con.Open();
                    SqlCommand cmd = new SqlCommand("Select Id, LedName from TblLedgerMst where isactive = 0 ", con);
                    SqlDataAdapter ada = new SqlDataAdapter(cmd);
                    dt = new DataTable();
                    ada.Fill(dt);
                }
                catch (Exception es)
                {
                    MessageBox.Show("Binding Error at Ledger Master");
                }
                if (dt == null)
                {
                    MessageBox.Show("Error in Quering");
                    return;
                }
                IList<string> lstFirst = new List<string>();
                IList<string> lstLast = new List<string>();
                foreach (DataRow row in dt.Rows)
                {
                    lstLast.Add(row.Field<string>("ledName"));
                }

                this.cmbledge.Items.AddRange(lstFirst.ToArray<string>());
                this.cmbledge.AutoCompleteMode = AutoCompleteMode.Suggest;
                this.cmbledge.AutoCompleteSource = AutoCompleteSource.ListItems;

                this.cmbledge.Items.AddRange(lstLast.ToArray<string>());
                this.cmbledge.AutoCompleteMode = AutoCompleteMode.Suggest;
                this.cmbledge.AutoCompleteSource = AutoCompleteSource.ListItems;

                this.cmbledge1.Items.AddRange(lstFirst.ToArray<string>());
                this.cmbledge1.AutoCompleteMode = AutoCompleteMode.Suggest;
                this.cmbledge1.AutoCompleteSource = AutoCompleteSource.ListItems;

                this.cmbledge1.Items.AddRange(lstLast.ToArray<string>());
                this.cmbledge1.AutoCompleteMode = AutoCompleteMode.Suggest;
                this.cmbledge1.AutoCompleteSource = AutoCompleteSource.ListItems;


                //query = "Select Id, LedName from TblLedgerMst union select '0' as Id, 'Select' as LedName";
                //SqlConnection con = new SqlConnection(obj.SqlConn());
                //SqlCommand cmd = new SqlCommand(query, con);
                //SqlDataAdapter adapt = new SqlDataAdapter(cmd);
                //DataTable dt = new DataTable();
                //adapt.Fill(dt);
                //if (dt.Rows.Count > 0)
                //{
                //    cmbledge.Items.Clear();
                //    cmbledge.DataSource = dt;
                //    cmbledge.DisplayMember = "LedName";
                //    cmbledge.ValueMember = "Id";
                //    cmbledge.DataBindings.ToString();

                //    cmbledge1.Items.Clear();
                //    cmbledge1.DataSource = dt;
                //    cmbledge1.DisplayMember = "LedName";
                //    cmbledge1.ValueMember = "Id";
                //    cmbledge1.DataBindings.ToString();
                //}
            
        }
        public void binditem()
        {
            SqlConnection con = new SqlConnection(obj.SqlConn());
            DataTable dt = new DataTable();
            try
            {

                con.Open();
                SqlCommand cmd = new SqlCommand("Select Id, IName from TblItemMst where isactive = 0 ", con);
                SqlDataAdapter ada = new SqlDataAdapter(cmd);
                dt = new DataTable();
                ada.Fill(dt);
            }
            catch (Exception es)
            {
                MessageBox.Show("Binding Error at Ledger Master");
            }
            if (dt == null)
            {
                MessageBox.Show("Error in Quering");
                return;
            }
            IList<string> lstFirst = new List<string>();
            IList<string> lstLast = new List<string>();
            foreach (DataRow row in dt.Rows)
            {
                lstLast.Add(row.Field<string>("IName"));
            }

            this.cmbitem.Items.AddRange(lstFirst.ToArray<string>());
            this.cmbitem.AutoCompleteMode = AutoCompleteMode.Suggest;
            this.cmbitem.AutoCompleteSource = AutoCompleteSource.ListItems;

            this.cmbitem.Items.AddRange(lstLast.ToArray<string>());
            this.cmbitem.AutoCompleteMode = AutoCompleteMode.Suggest;
            this.cmbitem.AutoCompleteSource = AutoCompleteSource.ListItems;

            //try
            //{
            //    query = "Select Id, IName from TblItemMst union select '0' as Id, 'Select' as IName";
            //    SqlConnection con = new SqlConnection(obj.SqlConn());
            //    SqlCommand cmd = new SqlCommand(query, con);
            //    SqlDataAdapter adapt = new SqlDataAdapter(cmd);
            //    DataTable dt = new DataTable();
            //    adapt.Fill(dt);
            //    if (dt.Rows.Count > 0)
            //    {
            //        cmbitem.Items.Clear();
            //        cmbitem.DataSource = dt;
            //        cmbitem.DisplayMember = "IName";
            //        cmbitem.ValueMember = "Id";
            //        cmbitem.DataBindings.ToString();
            //    }
            //}
            //catch (Exception es)
            //{
            //    MessageBox.Show("Something Wrong...!");
            //}
        }
        public void clearpayment()
        {
            //cmbledge.SelectedIndex = 0;
            //cmbitem.SelectedIndex = 0;
            txtamt.Text = "";
            cmbmode.Text = "";
            //txtnetamt.Text = "0";
            //txtremark.Text = "";
        }
        public void BindGrid_Expense()
        {
            try
            {
                query = " SELECT [Id],[TrandId],[IId],[IName],[Amt],[Mode] from TblDailyDetail where IsActive = '0' and TrandId='" + txtledid.Text + "' and MktYear='" + lblfinyear.Text + "' order by Id asc";
                SqlConnection con = new SqlConnection(obj.SqlConn());
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    BindingSource BS = new BindingSource();
                    dtexpense.Refresh();
                    dtexpense.DataSource = dt;
                }
                else
                {
                    BindingSource BS = new BindingSource();
                    dtexpense.Refresh();
                    dtexpense.DataSource = dt;
                }
            }
            catch (Exception es)
            {

            }
        }
        public void BindGrid_Income()
        {
            try
            {
                query = " SELECT [Id],[LedId],[LedName],[Date],[NetAmt],[Remark],RecMode from TblDailyHeader where IsActive = '0' and LedName=N'" + cmbledge1.Text + "' and MktYear='" + lblfinyear.Text + "' and TMode='Receipt' order by Id asc";
                SqlConnection con = new SqlConnection(obj.SqlConn());
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    BindingSource BS = new BindingSource();
                    dtincome.Refresh();
                    dtincome.DataSource = dt;
                }
                else
                {
                    BindingSource BS = new BindingSource();
                    dtincome.Refresh();
                    dtincome.DataSource = dt;
                }
            }
            catch (Exception es)
            {

            }
        }
        private void FrmDailyEntry_Load(object sender, EventArgs e)
        {
            lblcompanyname.Text = obj.CmpName("Name");
            txtdate.Focus();
            bindledger();
            binditem();
            clearpayment();
            txtledid.Text = lblledid1.Text = (obj.maxidTrans("TblDailyHeader", "Id") + 1).ToString();
            BindGrid_Expense();
            txtnetamt.Text = calsumedit();
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtdate_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                cmbledge.Focus();
            }
        }

        private void cmbledge_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                cmbitem.Focus();
            }
        }

        private void cmbitem_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                if (cmbitem.Text == "Select" || cmbitem.Text == "")
                {
                    txtremark.Focus();
                }
                else
                {
                    txtamt.Focus();
                }
            }
        }

        private void txtamt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                cmbmode.Focus();
            }
        }

        private void cmbmode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                btnadd.Focus();
            }
        }

        private void txtremark_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                btnsubmit.Focus();
            }
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbitem.Text == "Select")
                {
                    MessageBox.Show("Select Expenditure Head.");
                }
                else
                {
                    if (btnadd.Text == "Fill out")
                    {
                        query = "insert into TblDailyDetail ([TrandId],TransDate,LedId,[IId],[IName],[Amt],[Mode],[IsActive],[PrepBy],[PrepDate],MktYear) Values ('" +
                              txtledid.Text + "','" + txtdate.Value.ToString("yyyy-MM-dd") + "' ,'" + obj.LedIdBYName(cmbledge.Text) + "' ,'" + obj.ItemIdBYName(cmbitem.Text.Trim()) + "',N'" + cmbitem.Text.Trim() + "','" + double.Parse(txtamt.Text.Trim()) + "',N'" + cmbmode.Text + "','0','" + lblloginid.Text + "','" + DateTime.Now.ToString("yyyy-MM-dd") + "','" + lblfinyear.Text + "')";
                        SqlConnection con = new SqlConnection(obj.SqlConn());
                        SqlCommand cmd = new SqlCommand(query, con);
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                        BindGrid_Expense();
                        clearpayment();
                        MessageBox.Show("Information saved successfully.");
                        cmbitem.Focus();
                        txtnetamt.Text = calsumedit();
                    }
                    else if (btnadd.Text == "Change")
                    {
                        query = "update TblDailyDetail set TransDate='" + txtdate.Value.ToString("yyyy-MM-dd") + "',IId='" + obj.ItemIdBYName(cmbitem.Text.Trim()) + "',IName=N'" + cmbitem.Text.Trim() + "',Amt='" + double.Parse(txtamt.Text.Trim()) + "',Mode=N'" + cmbmode.Text + "', LedId='" + obj.LedIdBYName(cmbledge.Text) + "',UpdateBy='" + lblloginid.Text + "',UpdateDate='" + DateTime.Now.ToString("yyyy-MM-dd") + "' where Id='" + lblentryid.Text + "'";
                        SqlConnection con = new SqlConnection(obj.SqlConn());
                        SqlCommand cmd = new SqlCommand(query, con);
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                        BindGrid_Expense();
                        clearpayment();
                        btnadd.Text = "Fill out";
                        MessageBox.Show("Information changed successfully.");
                        cmbitem.Focus();
                        txtnetamt.Text = calsumedit();
                    }
                    else
                    {
                        //do nothing
                    }
                }
            }
            catch (Exception es)
            {
                MessageBox.Show("Something Wrong...!");
            }
        }

        public string calsumedit()
        {
            try
            {
                query = "select round(sum(amt),0) as amt from TblDailyDetail where  TrandId='" + txtledid.Text.Trim() + "' and Mktyear='" + lblfinyear.Text.Trim() + "'";
                SqlConnection con = new SqlConnection(obj.SqlConn());
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                DataTable ds = new DataTable();
                da.Fill(ds);
                if (ds.Rows.Count > 0)
                {
                    return ds.Rows[0]["amt"].ToString();
                }
                else
                {
                    return "0";
                }
            }
            catch (Exception es)
            {
                return "0";
            }
        }

       

        private void btnsubmit_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbledge.Text == "Select")
                {
                    MessageBox.Show("Select the laser head.");
                }
                else
                {
                    if (btnsubmit.Text == "Saved")
                    {
                        txtnetamt.Text = calsumedit();
                        query = "insert into TblDailyHeader ([LedId],[LedName],[Date],[NetAmt],[Remark],TMode,[IsActive],[MktYear],[PrepBy],[PrepDate]) Values ('" +
                              obj.LedIdBYName(cmbledge.Text) + "',N'" + cmbledge.Text.Trim() + "','" + txtdate.Value.ToString("yyyy-MM-dd") + "','" + double.Parse(txtnetamt.Text.Trim()) + "',N'" + txtremark.Text + "','" + lbltransmode.Text + "','0','" + lblfinyear.Text + "','" + lblloginid.Text + "','" + DateTime.Now.ToString("yyyy-MM-dd") + "')";
                        SqlConnection con = new SqlConnection(obj.SqlConn());
                        SqlCommand cmd = new SqlCommand(query, con);
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                        clearpayment();
                        MessageBox.Show("Information saved successfully.");
                        cmbledge.Focus();
                        txtledid.Text = (obj.maxidTrans("TblDailyHeader", "Id") + 1).ToString();
                        cmbledge.SelectedIndex = 0;
                        txtnetamt.Text = "0";
                        txtremark.Text = "";
                    }
                    else if (btnsubmit.Text == "Change")
                    {
                        txtnetamt.Text = calsumedit();
                        query = "update TblDailyHeader set LedId='" + cmbledge.SelectedValue + "',LedName=N'" + cmbledge.Text.Trim() + "',Date='" + txtdate.Value.ToString("yyyy-MM-dd") + "',NetAmt='" + double.Parse(txtnetamt.Text.Trim()) + "',Remark=N'" + txtremark.Text + "',UpdateBy='" + lblloginid.Text + "',UpdateDate='" + DateTime.Now.ToString("yyyy-MM-dd") + "' where Id='" + lblentryid.Text + "'";
                        SqlConnection con = new SqlConnection(obj.SqlConn());
                        SqlCommand cmd = new SqlCommand(query, con);
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                        btnsubmit.Text = "Saved";
                        MessageBox.Show("Information changed successfully.");
                        cmbledge.Focus();
                        txtledid.Text = (obj.maxidTrans("TblDailyHeader", "Id") + 1).ToString();
                        cmbledge.SelectedIndex = 0;
                        txtnetamt.Text = "0";
                        txtremark.Text = "";
                    }
                    else
                    {
                        //do nothing
                    }
                }
            }
            catch (Exception es)
            {
                MessageBox.Show("Something Wrong...!");
            }
        }

        private void dtexpense_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                DataGridViewRow row = this.dtexpense.Rows[e.RowIndex];
                lblentryid.Text = row.Cells["Id"].Value.ToString();
                cmbitem.Text = row.Cells["IName"].Value.ToString();
                txtamt.Text = row.Cells["Amt"].Value.ToString();
                cmbmode.Text = row.Cells["Mode"].Value.ToString();
                btnadd.Text = "Change";
            }
            catch
            {
                MessageBox.Show("Something Wrong...");
            }
        }

        private void txtdate1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                cmbledge1.Focus();
            }
        }

        public string CalIncome()
        {
            try
            {
                query = "select round(sum(Netamt),0) as amt from TblDailyHeader where  LedName=N'" + cmbledge1.Text.Trim() + "' and Mktyear='" + lblfinyear.Text.Trim() + "' and TMode='Receipt'";
                SqlConnection con = new SqlConnection(obj.SqlConn());
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                DataTable ds = new DataTable();
                da.Fill(ds);
                if (ds.Rows.Count > 0)
                {
                    return ds.Rows[0]["amt"].ToString();
                }
                else
                {
                    return "0";
                }
            }
            catch (Exception es)
            {
                return "0";
            }
        }

        private void cmbledge1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                txtnetamt1.Focus();
                BindGrid_Income();
                lbltotrecamt.Text = CalIncome();
            }
        }

        private void txtnetamt1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                cmbmode1.Focus();
            }
        }

        private void cmbmode1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                txtremark1.Focus();
            }
        }

        private void txtremark1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                btnsubmit1.Focus();
            }
        }

        private void btnsubmit1_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbledge1.Text == "Select")
                {
                    MessageBox.Show("Select the laser head.");
                }
                else
                {
                    if (btnsubmit1.Text == "Saved")
                    {
                        //txtnetamt.Text = calsumedit();
                        query = "insert into TblDailyHeader ([LedId],[LedName],[Date],[NetAmt],[Remark],TMode,RecMode,[IsActive],[MktYear],[PrepBy],[PrepDate]) Values ('" +
                              obj.LedIdBYName(cmbledge1.Text) + "',N'" + cmbledge1.Text.Trim() + "','" + txtdate1.Value.ToString("yyyy-MM-dd") + "','" + double.Parse(txtnetamt1.Text.Trim()) + "',N'" + txtremark1.Text + "','" + lbltransmode.Text + "',N'" + cmbmode1.Text + "','0','" + lblfinyear.Text + "','" + lblloginid.Text + "','" + DateTime.Now.ToString("yyyy-MM-dd") + "')";
                        SqlConnection con = new SqlConnection(obj.SqlConn());
                        SqlCommand cmd = new SqlCommand(query, con);
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                        cmbledge1.Text = "Select";
                        txtnetamt1.Text = "";
                        cmbmode1.Text = "Select";
                        txtremark1.Text = "";
                        MessageBox.Show("Information saved successfully.");
                        cmbledge1.Focus();
                        lblledid1.Text = (obj.maxidTrans("TblDailyHeader", "Id") + 1).ToString();
                        cmbledge1.SelectedIndex = 0;
                        txtnetamt1.Text = "0";
                        txtremark1.Text = "";
                        BindGrid_Income();
                    }
                    else if (btnsubmit1.Text == "Change")
                    {
                        //txtnetamt.Text = calsumedit();
                        query = "update TblDailyHeader set LedId='" + obj.LedIdBYName(cmbledge1.Text) + "',LedName=N'" + cmbledge1.Text.Trim() + "',Date='" + txtdate1.Value.ToString("yyyy-MM-dd") + "',NetAmt='" + double.Parse(txtnetamt1.Text.Trim()) + "',Remark=N'" + txtremark1.Text + "',RecMode=N'" + cmbmode1.Text + "',UpdateBy='" + lblloginid.Text + "',UpdateDate='" + DateTime.Now.ToString("yyyy-MM-dd") + "' where Id='" + lblledid1.Text + "'";
                        SqlConnection con = new SqlConnection(obj.SqlConn());
                        SqlCommand cmd = new SqlCommand(query, con);
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                        btnsubmit1.Text = "Saved";
                        //cmbledge1.Text = "Select";
                        txtnetamt1.Text = "";
                        cmbmode1.Text = "Select";
                        txtremark1.Text = "";
                        MessageBox.Show("Information changed successfully.");
                        cmbledge1.Focus();
                        lblledid1.Text = (obj.maxidTrans("TblDailyHeader", "Id") + 1).ToString();
                        //cmbledge1.SelectedIndex = 0;
                        txtnetamt1.Text = "0";
                        txtremark1.Text = "";
                        BindGrid_Income();
                    }
                    else
                    {
                        //do nothing
                    }
                }
            }
            catch (Exception es)
            {
                MessageBox.Show("Something Wrong...!");
            }
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void dtincome_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = this.dtincome.Rows[e.RowIndex];
                lblledid1.Text = row.Cells["Id"].Value.ToString();
                cmbledge1.Text = row.Cells["LedName"].Value.ToString();
                txtdate1.Text = row.Cells["Date"].Value.ToString();
                txtnetamt1.Text = row.Cells["NetAmt"].Value.ToString();
                txtremark1.Text = row.Cells["Remark"].Value.ToString();
                cmbmode1.Text = row.Cells["RecMode"].Value.ToString();
                btnsubmit1.Text = "Change";
            }
            catch
            {
                MessageBox.Show("Something Wrong...");
            }
        }

        private void txtledid_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                if (txtledid.Text == "")
                {
                    MessageBox.Show("Number required");
                }
                else
                {
                    selectheader();
                    lblentryid.Text = txtledid.Text;
                    txtnetamt.Text = calsumedit();
                }
            }
        }

        public void selectheader()
        {
            try
            {
                query = "SELECT [Id],[LedId],[LedName],CONVERT(VARCHAR(10), [Date], 103) as [Date],[NetAmt],[Remark],[TMode],[RecMode],[IsActive],[MktYear] FROM [TblDailyHeader] where IsActive = 0  and Id='" + txtledid.Text + "' and Mktyear='" + lblfinyear.Text.Trim() + "' and TMode='Payment'";
                SqlConnection con = new SqlConnection(obj.SqlConn());
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                DataTable ds = new DataTable();
                da.Fill(ds);
                if (ds.Rows.Count > 0)
                {
                    txtdate.Text = ds.Rows[0]["Date"].ToString();
                    cmbledge.Text = ds.Rows[0]["LedName"].ToString();
                    txtnetamt.Text = ds.Rows[0]["NetAmt"].ToString();
                    txtremark.Text = ds.Rows[0]["Remark"].ToString();
                    txtnetamt.Text = ds.Rows[0]["NetAmt"].ToString();
                    btnsubmit.Text = "Change";
                    BindGrid_Expense();
                }
            }
            catch (Exception es)
            {
                MessageBox.Show(es.ToString());
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

    }
}
