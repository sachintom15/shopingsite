using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace shopingsite.DAL
{
    public class ProdregDal
    {
        public SqlConnection con = new SqlConnection();
        SqlCommand cmd = new SqlCommand();

        public ProdregDal()


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

        public int Insert(BAL.ProdregBal obj)
        {
            string p = "insert into product values ('" + obj.ProdName + "')";
            SqlCommand cmd = new SqlCommand(p, GetCon());
            return cmd.ExecuteNonQuery();
        }

        public DataTable userview()
        {
            string s = "select * from product";
            SqlCommand cmd = new SqlCommand(s, GetCon());
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public int productdelete(BAL.ProdregBal obj)
        {
            string s = "Delete from product where productid='" + obj.ProdId + "'";
            SqlCommand cmd = new SqlCommand(s, GetCon());
            return cmd.ExecuteNonQuery();
        }

        public int productupdate(BAL.ProdregBal obj)
        {
            string s = "update product set productname='" + obj.ProdName + "' where productid='" + obj.ProdId + "'";
            SqlCommand cmd = new SqlCommand(s, GetCon());
            return cmd.ExecuteNonQuery();
        }



    }
}