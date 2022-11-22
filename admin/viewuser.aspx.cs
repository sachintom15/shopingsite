using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace shopingsite.admin
{

    
    public partial class viewuser : System.Web.UI.Page
    {

        BAL.RegBal objbal = new BAL.RegBal();
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
               
                GridView1.DataSource = objbal.userview1();
                GridView1.DataBind();
            }

        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int id = Convert.ToInt32(GridView1.DataKeys[e.RowIndex].Value.ToString());
            objbal.LoginId = id.ToString();
            int i = objbal.confirmuser();
            GridView1.DataSource = objbal.userview1();
            GridView1.DataBind();
        }
    }
}