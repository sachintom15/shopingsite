using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace shopingsite.admin
{
    public partial class ComplaintView : System.Web.UI.Page
    {

        BAL.ComplaintBal objbal = new BAL.ComplaintBal();
        protected void Page_Load(object sender, EventArgs e)
        {
            GridView1.DataSource = objbal.viewcomplaint();
            GridView1.DataBind();

            GridView2.DataSource = objbal.complaintProcess();
            GridView2.DataBind();


        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int id = Convert.ToInt32(GridView1.DataKeys[e.RowIndex].Value.ToString());
            objbal.complaint = id.ToString();
            int i = objbal.confircomplaint();
            GridView1.DataSource = objbal.viewcomplaint();
            GridView1.DataBind();
        }

        protected void GridView2_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {

            int id = Convert.ToInt32(GridView2.DataKeys[e.RowIndex].Value.ToString());
            objbal.complaint = id.ToString();
            int i = objbal.closecomplaint();
            GridView2.DataSource = objbal.complaintProcess();
            GridView2.DataBind();
            GridView1.DataBind();

        }

       
    }
}