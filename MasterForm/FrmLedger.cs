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

namespace SMKCContractor.MasterForm
{
    public partial class FrmLedger : Form
    {
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt;
        SqlConnection con;
        string query;
        Class.Common obj = new Class.Common();
        public FrmLedger(string logid,string logfinyear)
        {
            InitializeComponent();
            lblloginid.Text = logid;
            lblfinyear.Text = logfinyear;
            //bindbranch();
            
        }

        private void FrmLedger_Load(object sender, EventArgs e)
        {
            lblcompanyname.Text = obj.CmpName("Name");
            txtledname.Focus();
            BindGrid_Ledger();
            BindGrid_Item();
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnclose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtledname_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                txtledno.Focus();
            }
        }

        private void txtledno_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                txtleddate.Focus();
            }
        }

        private void txtleddate_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                txtledstartdate.Focus();
            }
        }

        private void txtledstartdate_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                txtledamt.Focus();
            }
        }

        private void txtledamt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                txtledperson.Focus();
            }
        }

        private void txtledperson_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                btnsubmit.Focus();
            }
        }

        public void BindGrid_Ledger()
        {
            try
            {
                query = " SELECT [Id],[LedName],[SanDate],[SanNo],[StartDate],[SanBy],[TotCost] from TblLedgerMst where IsActive = '0' order by LedName asc";
                SqlConnection con = new SqlConnection(obj.SqlConn());
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    BindingSource BS = new BindingSource();
                    dtgridperson.Refresh();
                    dtgridperson.DataSource = dt;
                }
                else
                {
                    BindingSource BS = new BindingSource();
                    dtgridperson.Refresh();
                    dtgridperson.DataSource = dt;
                }
            }
            catch (Exception es)
            {

            }
        }

        public void LedgerClear()
        {
            txtledname.Text = "";
            txtledno.Text = "";
            txtledamt.Text = "";
            txtledperson.Text = "";
        }

        private void btnsubmit_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtledname.Text == "" && txtledperson.Text == "")
                {
                    MessageBox.Show("Register name and person's name required.");
                }
                else
                {
                    if (btnsubmit.Text == "Saved")
                    {
                        query = "insert into TblLedgerMst ([LedName],[SanDate],[SanNo],[SanBy],[StartDate],[TotCost],[IsActive],[PrepBy],[PrepDate]) Values (N'" +
                              txtledname.Text.Trim() + "',N'" + txtleddate.Text + "',N'" + txtledno.Text + "',N'" + txtledperson.Text.Trim() + "','" + txtledstartdate.Text + "','" + double.Parse(txtledamt.Text.Trim()) + "','0','" + lblloginid.Text + "','" + DateTime.Now.ToString("yyyy-MM-dd") + "')";
                        SqlConnection con = new SqlConnection(obj.SqlConn());
                        SqlCommand cmd = new SqlCommand(query, con);
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                        BindGrid_Ledger();
                        LedgerClear();
                        MessageBox.Show("Information saved successfully.");
                    }
                    else if (btnsubmit.Text == "Change")
                    {
                        query = "update TblLedgerMst set LedName=N'" + txtledname.Text.Trim() + "',SanDate='" + txtleddate.Text + "',SanNo=N'" + txtledno.Text + "',SanBy=N'" + txtledperson.Text.Trim() + "',StartDate='" + txtledstartdate.Text + "',TotCost='" + double.Parse(txtledamt.Text.Trim()) + "',UpdateBy='" + lblloginid.Text + "',UpdateDate='" + DateTime.Now.ToString("yyyy-MM-dd") + "' where Id='" + txtledid.Text + "'";
                        SqlConnection con = new SqlConnection(obj.SqlConn());
                        SqlCommand cmd = new SqlCommand(query, con);
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                        BindGrid_Ledger();
                        LedgerClear();
                        btnsubmit.Text = "Saved";
                        MessageBox.Show("Information changed successfully.");
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

        private void dtgridperson_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = this.dtgridperson.Rows[e.RowIndex];
                //cmbbank.SelectedValue = row.Cells["BankCode"].Value.ToString();
                txtledid.Text = row.Cells["Id"].Value.ToString();
                txtledname.Text = row.Cells["LedName"].Value.ToString();
                txtleddate.Text = row.Cells["SanDate"].Value.ToString();
                txtledno.Text = row.Cells["SanNo"].Value.ToString();
                txtledstartdate.Text = row.Cells["StartDate"].Value.ToString();
                txtledperson.Text = row.Cells["SanBy"].Value.ToString();
                txtledamt.Text = row.Cells["TotCost"].Value.ToString();
                btnsubmit.Text = "Change";
            }
            catch
            {
                MessageBox.Show("Something Wrong...");
            }
        }

        private void btndel_Click(object sender, EventArgs e)
        {
            try
            {
                query = "update TblLedgerMst set IsActive='1' where Id='" + txtledid.Text + "'";
                SqlConnection con = new SqlConnection(obj.SqlConn());
                SqlCommand cmd = new SqlCommand(query, con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                BindGrid_Ledger();
                LedgerClear();
                btnsubmit.Text = "Saved";
                MessageBox.Show("Information successfully removed.");
            }
            catch (Exception es)
            {
                MessageBox.Show("Something Wrong...!");
            }

        }

        public void BindGrid_Item()
        {
            try
            {
                query = " SELECT Id,[IName],[IRate],[Iremark] from TblItemMst where IsActive = '0' order by IName asc";
                SqlConnection con = new SqlConnection(obj.SqlConn());
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    BindingSource BS = new BindingSource();
                    dtgriditem.Refresh();
                    dtgriditem.DataSource = dt;
                }
                else
                {
                    BindingSource BS = new BindingSource();
                    dtgriditem.Refresh();
                    dtgriditem.DataSource = dt;
                }
            }
            catch (Exception es)
            {

            }
        }

        public void ItemClear()
        {
            txtiname.Text = "";
            txtiamt.Text = "";
            txtirem.Text = "";
        }

        private void btnisubmit_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtiname.Text == "")
                {
                    MessageBox.Show("Name required.");
                }
                else
                {
                    if (btnisubmit.Text == "Saved")
                    {
                        query = "insert into TblItemMst ([IName],[IRate],[Iremark],[IsActive],[PrepBy],[PrepDate]) Values (N'" +
                              txtiname.Text.Trim() + "','" + double.Parse(txtiamt.Text.Trim()) + "',N'" + txtirem.Text + "','0','" + lblloginid.Text + "','" + DateTime.Now.ToString("yyyy-MM-dd") + "')";
                        SqlConnection con = new SqlConnection(obj.SqlConn());
                        SqlCommand cmd = new SqlCommand(query, con);
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                        BindGrid_Item();
                        ItemClear();
                        MessageBox.Show("Information saved successfully.");
                    }
                    else if (btnisubmit.Text == "Change")
                    {
                        query = "update TblItemMst set IName=N'" + txtiname.Text.Trim() + "',IRate='" + double.Parse(txtiamt.Text.Trim()) + "',Iremark=N'" + txtirem.Text + "',UpdatedBy='" + lblloginid.Text + "',UpdDate='" + DateTime.Now.ToString("yyyy-MM-dd") + "' where Id='" + txtiid.Text + "'";
                        SqlConnection con = new SqlConnection(obj.SqlConn());
                        SqlCommand cmd = new SqlCommand(query, con);
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                        BindGrid_Item();
                        ItemClear();
                        btnisubmit.Text = "Saved";
                        MessageBox.Show("Information changed successfully.");
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

        private void txtiname_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                txtiamt.Focus();
            }
        }

        private void txtiamt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                txtirem.Focus();
            }
        }

        private void txtirem_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                btnisubmit.Focus();
            }
        }

        private void btnisubmit_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                txtiname.Focus();
            }
        }

        private void btnsubmit_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                txtledname.Focus();
            }
        }

        private void dtgriditem_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = this.dtgriditem.Rows[e.RowIndex];
                txtiid.Text = row.Cells["Id"].Value.ToString();
                txtiname.Text = row.Cells["IName"].Value.ToString();
                txtiamt.Text = row.Cells["IRate"].Value.ToString();
                txtirem.Text = row.Cells["IRemark"].Value.ToString();
                btnisubmit.Text = "Change";
            }
            catch
            {
                MessageBox.Show("Something Wrong...");
            }
        }

        private void btnidel_Click(object sender, EventArgs e)
        {
            query = "update TblItemMst set IsActive='1' where Id='" + txtiid.Text + "'";
            SqlConnection con = new SqlConnection(obj.SqlConn());
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            BindGrid_Item();
            ItemClear();
            btnisubmit.Text = "Saved";
            MessageBox.Show("Information successfully removed.");
        }

        private void txtiamt_TextChanged(object sender, EventArgs e)
        {

        }

       
    }
}
