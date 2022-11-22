using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace shopingsite.admin
{
    public partial class productreg : System.Web.UI.Page
    {
        BAL.ProdregBal objbal1 = new BAL.ProdregBal();
        protected void Page_Load(object sender, EventArgs e)
        {
            {
                if (!IsPostBack)
                {
                    GridView1.DataSource = objbal1.viewuser();
                    GridView1.DataBind();
                }



            }

        }

        protected void btnreg_Click(object sender, EventArgs e)
        {
            //objbal1.ProdName = txtproductid.Text;
            objbal1.ProdName = txtproductname.Text;
            

            int i = objbal1.Insert();
            if(i == 1)
            {
                Response.Write("sucessfully inserted");
            }
            else
            {
                Response.Write("Filed to insert");
            }

        }

        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridView1.EditIndex = e.NewEditIndex;
            GridView1.DataSource = objbal1.viewuser();

            GridView1.DataBind();

        }

        protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            int id = Convert.ToInt32(GridView1.DataKeys[e.RowIndex].Value.ToString());
            TextBox txtdeptname = new TextBox();
            txtdeptname = (TextBox)GridView1.Rows[e.RowIndex].Cells[1].Controls[0];
            objbal1.ProdId = id.ToString();
            objbal1.ProdName = txtproductname.Text;
            int i = objbal1.updateProd();
            GridView1.EditIndex = -1;

        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {

            int id = Convert.ToInt32(GridView1.DataKeys[e.RowIndex].Value.ToString());
            objbal1.ProdId = id.ToString();
            int i = objbal1.deleteProd();
            GridView1.EditIndex = -1;
            GridView1.DataSource = objbal1.viewuser();
            GridView1.DataBind();
        }

        protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            GridView1.EditIndex = -1;
            GridView1.DataSource = objbal1.viewuser();
            GridView1.DataBind();
        }
    }
}