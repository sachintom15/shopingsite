using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace shopingsite.admin
{
    public partial class queryview : System.Web.UI.Page
    {
        BAL.QueryBal objbal = new BAL.QueryBal();
        protected void Page_Load(object sender, EventArgs e)
        {
            GridView1.DataSource = objbal.viewquery();
            GridView1.DataBind();

        }
    }
}