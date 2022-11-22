using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace shopingsite.DAL
{
    public class LoginDal
    {
        public SqlConnection con = new SqlConnection();
        SqlCommand cmd = new SqlCommand();

        public LoginDal()
       
            
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

        public DataTable logincheck(BAL.LoginBal obj)
        {
            string qry = "SELECT * from login where username='" + obj.User_Name + "' AND password='" + obj.Password + "' ";
           SqlCommand cmd = new SqlCommand(qry, GetCon());
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            return dt;

        }

        

       

    }
}
