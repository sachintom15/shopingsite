using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace shopingsite.guest
{
    public partial class UserReg : System.Web.UI.Page
    {
        //create object of business access layer
        BAL.RegBal objuser1 = new BAL.RegBal();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnreg_Click(object sender, EventArgs e)
        {
            objuser1.UserName = txtname.Text;
            objuser1.Password = TextBox2.Text;

            objuser1.User_Name = TextBox1.Text;
            objuser1.Place = txtplace.Text;
            objuser1.Pin = txtpin.Text;
            objuser1.District = txtdistrict.Text;
            objuser1.Email = txtmail.Text;
            objuser1.Gender = RadioButtonList1.SelectedValue;

            int i = objuser1.customerInsertion();
            if (i == 1)
            {
                Response.Write("inserted success");

            }
            else
            {
                Response.Write("Faild");
            }

        }
    }
}