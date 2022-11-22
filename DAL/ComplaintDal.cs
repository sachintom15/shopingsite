using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace shopingsite.DAL
{
    public class ComplaintDal
    {

        public SqlConnection con = new SqlConnection();
        SqlCommand cmd = new SqlCommand();

        public ComplaintDal()
        {
            //call conncetionstring;conncetion string should be set in the web.conf file
            string conn = ConfigurationManager.ConnectionStrings["rose"].ConnectionString;
            con = new SqlConnection(conn);
            cmd.Connection = con;
        }

        public SqlConnection GetCon()
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            return con;
        }

        public DataTable getproductdetails(BAL.ComplaintBal obj)
        {
            string s = "select * from product";
            SqlCommand cmd = new SqlCommand(s, GetCon());
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public int complaintinsert(BAL.ComplaintBal obj)
        {
            //var dat = DateTime.Now.ToString("yyyy-MM-dd");
            string s = "insert into complaint values('" + obj.complaint + "','" + obj.pid + "','notchecked','" + obj.Login + "',GETDATE())";
            SqlCommand cmd = new SqlCommand(s, GetCon());
            return cmd.ExecuteNonQuery();
        }

        public DataTable complaintview(BAL.ComplaintBal obj)
        {
            string s = "select * from userreg ur inner join complaint c on ur.userid = c.userid inner join product p on p.productid = c.productid where c.status = 'notchecked'";
            SqlCommand cmd = new SqlCommand(s, GetCon());
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public int complaintconfirm(BAL.ComplaintBal obj)
        {
            string s = "update complaint set status='on process' where cmpid='" + obj.complaint + "'";
            SqlCommand cmd = new SqlCommand(s, GetCon());
            return cmd.ExecuteNonQuery();
        }

        public int complaintclose(BAL.ComplaintBal obj)
        {
            string s = "update complaint set Status='closed' where cmpid='" + obj.complaint + "'";
            SqlCommand cmd = new SqlCommand(s, GetCon());
            return cmd.ExecuteNonQuery();

        }

        public DataTable Closedcomplaint(BAL.ComplaintBal obj)
        {
            string s = "select * from userreg ur inner join complaint c on ur.userid = c.userid inner join product p on p.productid = c.productid where c.status = 'on process' or c.status = 'closed'";
            SqlCommand cmd = new SqlCommand(s, GetCon());
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }


    }
}