using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace shopingsite.DAL
{
    public class RegDal
    {

        public SqlConnection con = new SqlConnection();
        SqlCommand cmd = new SqlCommand();

        public RegDal()
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

        public int customerInsertion(BAL.RegBal obj)
        {
            string qry = "insert into login values('" + obj.Password + "','" + obj.User_Name + "','customer',0); select @@IDENTITY";
            SqlCommand cmd = new SqlCommand(qry, GetCon());
            object ob= cmd.ExecuteScalar();


            string ss = "insert into userreg values('" + obj.UserName + "','" + obj.Place + "','" + obj.Pin + "','" + obj.District + "','" + ob + "','" + obj.Email + "','" + obj.Gender + "')";
             cmd = new SqlCommand(ss, GetCon());
            return cmd.ExecuteNonQuery();
        }

        public DataTable viewuser1()
        {



            string s = "select * from userreg tu inner join login tl on tu.loginid=tl.loginid";
            SqlCommand cmd = new SqlCommand(s, GetCon());
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }


        public int userconfirm(BAL.RegBal obj)
        {
            string s = "update login set status='1' where loginid='" + obj.LoginId + "'";
            SqlCommand cmd = new SqlCommand(s, GetCon());
            return cmd.ExecuteNonQuery();
        }

        /*  public int loginInertion(BAL.RegBal obj)
          {
              string qry = "insert into login values('" + obj.Password + "','" + obj.User_Name + "','customer',0)";
              SqlCommand cmd = new SqlCommand(qry, GetCon());
              return cmd.ExecuteNonQuery();
          }
        */
    }

}