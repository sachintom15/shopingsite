using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace shopingsite.BAL
{
    public class LoginBal
    {
        //create object of dataAccess Layer
        DAL.LoginDal objlogin1 = new DAL.LoginDal();


        //create two variable based on table
        private string _userid;
       
        private string _user_name;
        private string _password;

        public string UserId
        {
            get
            {
                return _userid;
            }
            set
            {
                _userid = value;
            }
        }

        

        public string User_Name
        {
            get
            {
                return _user_name;
            }
            set
            {
                _user_name = value;
            }
        }

        public string Password
        {
            get
            {
                return _password;
            }
            set
            {
                _password = value;
            }
        }

        public DataTable Logincheck()
        {
            return objlogin1.logincheck(this);
        }


    }

}