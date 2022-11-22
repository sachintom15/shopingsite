using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace shopingsite.admin
{
    public partial class Reply : System.Web.UI.Page
    {

        BAL.QueryBal objbal = new BAL.QueryBal();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Unnamed1_Click(object sender, EventArgs e)
        {
            int queid = Convert.ToInt32(Request.QueryString["qid"]);
            objbal.Reply = reply.Text;
            objbal.QuerryId = queid;
            int i = objbal.updateqry();
            if (i == 1)
            {
                Response.Write("<script>alert('Reply Registered Successfully');</script>");

            }

        }
    }
}