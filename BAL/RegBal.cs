using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace shopingsite.BAL
{
    public class RegBal
    {
        
            //create object of dataAccess Layer
            DAL.RegDal objuser1 = new DAL.RegDal();

            //create two variable based on table
            private string _userid;
            private string _username;
            private string _place;
            private string _pin;
            private string _district;
            private string _loginid;
            private string _email;
            private string _gender;
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

        public string UserName
        {
            get
            {
                return _username;
            }
            set
            {
                _username = value;
            }
        }

        public string Place
        {
            get
            {
                return _place;
            }
            set
            {
                _place = value;
            }
        }

        public string Pin
        {
            get
            {
                return _pin;
            }
            set
            {
                _pin = value;
            }
        }

        public string District
        {
            get
            {
                return _district;
            }
            set
            {
                _district = value;
            }
        }

        public string LoginId
        {
            get
            {
                return _loginid;
            }
            set
            {
                _loginid = value;
            }
        }

        public string Email
        {
            get
            {
                return _email;
            }
            set
            {
                _email = value;
            }
        }

        public string Gender
        {
            get
            {
                return _gender;
            }
            set
            {
                _gender = value;
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

       



        public int customerInsertion()
        {
            return objuser1.customerInsertion(this);
        }

        public DataTable userview1()
        {
            return objuser1.viewuser1();
        }


        public int confirmuser()
        {
            return objuser1.userconfirm(this);
        }


        /* public int loginInertion()
         {
             return objuser1.loginInertion(this);
         }
        */
    }

}