using shopingsite.BAL;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace shopingsite.DAL
{
    public class QueryDal
    {
        public SqlConnection con = new SqlConnection();
        SqlCommand cmd = new SqlCommand();

        public QueryDal()
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

        public DataTable getproductdetails()
        {
            string s = "select * from product";
            SqlCommand cmd = new SqlCommand(s, GetCon());
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public int quryinsert(BAL.QueryBal obj)
        {
            //var dat = DateTime.Now.ToString("yyyy-MM-dd");
            string s = "insert into querry values('" + obj.query + "','" + obj.pid + "','" + obj.Login + "','notreplyed',GETDATE())";
            SqlCommand cmd = new SqlCommand(s, GetCon());
            return cmd.ExecuteNonQuery();
        }


        public DataTable querytview(BAL.QueryBal obj)
        {
            string s = "select * from userreg ur inner join querry q on ur.userid = q.userid inner join product p on p.productid = q.productid";
            SqlCommand cmd = new SqlCommand(s, GetCon());
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public int QuerryUpdate(BAL.QueryBal obj)
        {

            string qry = "update querry set reply='" + obj.Reply + "' where querryid='" + obj.QuerryId + "'";
            SqlCommand cmd = new SqlCommand(qry, GetCon());
            return cmd.ExecuteNonQuery();
        }

        public DataTable Replyview(BAL.QueryBal obj)
        {
            string s = "select * from product pt inner join querry qt on pt.productid=qt.productid where qt.userid='" + obj.CustomerId + "'";
            SqlCommand cmd = new SqlCommand(s, GetCon());
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }


        // internal DataTable getproductdetails(QueryBal queryBal)
        // {
        //    throw new NotImplementedException();
        // }
    }
}