using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.IO;

namespace SMKCContractor
{
    public partial class Login : Form
    {
        string drop;
        Class.Common obj = new Class.Common();
        public Login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        protected void bindddl()
        {

            cmbYears.Items.Clear();
            if (DateTime.Today.Month > 3)
            {
                for (int i = DateTime.Today.Year - 10; i < DateTime.Today.Year + 2; i++)
                {
                    int first = i;
                    int section = i + 1;
                    drop = Convert.ToString(first + "-" + section);
                    cmbYears.Items.Add(drop);
                }
                cmbYears.Text = Convert.ToString(DateTime.Today.Year) + "-" + Convert.ToString(DateTime.Today.Year + 1);

            }
            else
            {
                for (int i = DateTime.Today.Year - 11; i < DateTime.Today.Year + 1; i++)
                {
                    int first = i;
                    int section = i + 1;
                    drop = Convert.ToString(first + "-" + section);
                    cmbYears.Items.Add(drop);
                }
                cmbYears.SelectedText = drop;
            }

        }
     
        private void btncancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            try
            {
                //btnlogin
                
                DateTime licensedate = new DateTime(2023, 06, 01);
                DateTime actdate = DateTime.Now;
                TimeSpan diff = (licensedate - actdate);
                int tmp = diff.Days;
                if (diff.Days > 0)
                {
                    if (txtname.Text == "" || txtpass.Text == "")
                    {
                        MessageBox.Show("Please provide UserName and Password", "Login Error");
                    }
                    else
                    {
                        try
                        {
                            String query = "Select [LoginId],[Username],[DeptId],[password] from UserLogin where Username =N'" + txtname.Text.TrimEnd() + "' and password ='" + txtpass.Text.TrimEnd() + "' and resign='0' and transfer='0'";
                            SqlConnection con = new SqlConnection(obj.SqlConn());
                            SqlCommand cmd = new SqlCommand(query, con);
                            SqlDataAdapter adapt = new SqlDataAdapter(cmd);
                            DataSet ds = new DataSet();
                            adapt.Fill(ds);
                            int count = ds.Tables[0].Rows.Count;
                            if (count == 1)
                            {
                                //MessageBox.Show("Login Successful!");
                                this.Hide();                               
                                Master.MasterMDI frm = new Master.MasterMDI();
                                //System.Diagnostics.Process.Start(@"C:\ProgramData\Microsoft\Windows\Start Menu\ISM V6.lnk");
                                frm.lbllogid.Text = ds.Tables[0].Rows[0]["LoginId"].ToString();
                                frm.lbldept.Text = ds.Tables[0].Rows[0]["DeptId"].ToString();
                                frm.lblfinyear.Text = cmbYears.Text;
                                frm.Show();

                            }
                            else
                            {
                                MessageBox.Show("Wrong User Name / Password", "Login Failed!");
                                txtname.Text = "";
                                txtpass.Text = "";
                                txtname.Focus();
                            }
                        }
                        catch (Exception es)
                        {
                            MessageBox.Show(es.Message);

                        }
                    }
                }
                else
                {
                    MessageBox.Show("Insufficient Memory", "License Renewation Error");
                }
            }
            catch (Exception es)
            {
                MessageBox.Show("Something Wrong...!");
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            bindddl();
            txtname.Focus();
            timer1.Start();
            
        }

        private void txtname_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                txtpass.Focus();
            }
        }

        private void txtpass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                cmbYears.Focus();
            }
        }

        private void cmbYears_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                btnlogin.Focus();
            }
        }

        private void btnlogin_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            label3.Text = DateTime.Now.ToString("hh:mm:ss");
            label5.Text = DateTime.Now.ToString("dd/MM/yyyy");
            
        }

        private void txtname_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

       
    }
}
