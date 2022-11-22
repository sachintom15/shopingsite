using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace shopingsite.guest
{
    public partial class login : System.Web.UI.Page
    {
        BAL.LoginBal objbal1 = new BAL.LoginBal();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnreg_Click(object sender, EventArgs e)
        {
            objbal1.User_Name = txtusername.Text;
            objbal1.Password = txtpassword.Text;
            DataTable datatbl = objbal1.Logincheck();

            if(datatbl.Rows.Count == 1)
            {
                Session["lid"] = datatbl.Rows[0]["loginid"];
                Session["uname"] = datatbl.Rows[0]["username"].ToString();
                string ro = datatbl.Rows[0]["role"].ToString();
                if (ro=="Admin")
                {
                    Response.Redirect("../admin/AdminHome.aspx");
                }

                else
                {
                    if (datatbl.Rows[0]["status"].ToString() == "1")
                    {
                        Response.Write("<script>alert('successfully logged in')</script");
                        Response.Redirect("../user/UserHome.aspx");
                    }

                    else
                    {
                        Response.Write("<script>alert('Failed to loggin')</script");
                        Response.Redirect("../guest/login.aspx");

                    }
                }

            }


        }

        protected void txtusername_TextChanged(object sender, EventArgs e)
        {

        }
    }
}