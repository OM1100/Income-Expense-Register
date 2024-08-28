using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace SMKCContractor.Class
{
    class Common
    {
        SqlCommand cmd1 = new SqlCommand();
        SqlCommand cmd = new SqlCommand();
        DataTable dt = new DataTable();
        SqlDataAdapter da = new SqlDataAdapter();
        string tmp;
        public string SqlConn()
        {
             return "server=DESKTOP-MU6CP5L;database=DB_sargar;UID=sa;password=manali";
        }   
        public string CmpName(string value)
        {
            try
            {
                SqlConnection con = new SqlConnection(SqlConn());
                cmd = new SqlCommand("SELECT [Name],[Address],[Website],[GST],[PAN],[Mob],[Mob1],[Landline],[IsActive] FROM Tbl_CompMst where IsActive = 0", con);
                da = new SqlDataAdapter(cmd);
                dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    if (value == "Name")
                        return dt.Rows[0]["Name"].ToString();
                    else if (value == "Address")
                        return dt.Rows[0]["Address"].ToString();
                    else if (value == "Website")
                        return dt.Rows[0]["Website"].ToString();
                    else if (value == "GST")
                        return dt.Rows[0]["GST"].ToString();
                    else if (value == "PAN")
                        return dt.Rows[0]["PAN"].ToString();
                    else if (value == "Mob")
                        return dt.Rows[0]["Mob"].ToString();
                    else if (value == "Landline")
                        return dt.Rows[0]["Landline"].ToString();
                    else
                        return "";
                }
                else
                {
                    return "";
                }
            }
            catch (Exception es)
            {
                return "";
            }
        }
        public int maxidTrans(string tabname, string colname)
        {
            try
            {
                SqlConnection con = new SqlConnection(SqlConn());
                cmd = new SqlCommand("select top 1 " + colname + " as colname from " + tabname + " order by " + colname + " desc", con);
                da = new SqlDataAdapter(cmd);
                dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                    tmp = dt.Rows[0]["colname"].ToString();
                if (tmp != "")
                    return Int32.Parse(dt.Rows[0]["colname"].ToString());
                else
                    return 0;
            }
            catch (Exception es)
            {
                return 0;
            }
        }
        public int LedIdBYName(string name)
        {
            try
            {
                SqlConnection con = new SqlConnection(SqlConn());
                cmd = new SqlCommand("SELECT [Id],[LedName] FROM [TblLedgerMst] where LedName = N'" + name + "' and IsActive = 0", con);
                da = new SqlDataAdapter(cmd);
                dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    return Int32.Parse(dt.Rows[0]["Id"].ToString());
                }
                else
                {
                    return 0;
                }
            }
            catch (Exception es)
            {
                return 0;
            }
        }
        public int ItemIdBYName(string name)
        {
            try
            {
                SqlConnection con = new SqlConnection(SqlConn());
                cmd = new SqlCommand("SELECT [Id],[IName] FROM [TblItemMst] where IName = N'" + name + "' and IsActive = 0", con);
                da = new SqlDataAdapter(cmd);
                dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    return Int32.Parse(dt.Rows[0]["Id"].ToString());
                }
                else
                {
                    return 0;
                }
            }
            catch (Exception es)
            {
                return 0;
            }
        }
    }
}
