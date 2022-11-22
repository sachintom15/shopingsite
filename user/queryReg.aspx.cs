using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace shopingsite.user
{
    public partial class queryReg : System.Web.UI.Page
    {
        BAL.QueryBal objbal = new BAL.QueryBal();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                DropDownList1.DataSource = objbal.getproduct();
                DropDownList1.DataTextField = "productname";
                DropDownList1.DataValueField = "productid";
                DropDownList1.DataBind();
            }

        }

        protected void Unnamed1_Click(object sender, EventArgs e)
        {

            objbal.pid = int.Parse(DropDownList1.SelectedItem.Value);
            objbal.query = complaint.Text;
            
            objbal.Login = Convert.ToString(Session["lid"]);
            objbal.name = Convert.ToString(Session["uname"]);


            int i = objbal.insertqury();

            if (i != 0)
            {
                Response.Write("Complaint registered");
            }
            else
            {
                Response.Write("Failed to register complaint");
            }
        }
    }
}