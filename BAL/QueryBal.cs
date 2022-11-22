using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace shopingsite.BAL
{
    public class QueryBal
    {
        DAL.QueryDal objdal = new DAL.QueryDal();

        private int _querryid;
        private int _customerid;
        private int _pid;
        private string _query;
        private string _login;
        private string _name;
        private string _reply;



        public int QuerryId
        {
            get
            {
                return _querryid;
            }
            set
            {
                _querryid = value;
            }
        }


        public int CustomerId
        {
            get
            {
                return _customerid;
            }
            set
            {
                _customerid = value;
            }
        }
        public string name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }



        public string Login
        {
            get
            {
                return _login;
            }
            set
            {
                _login = value;
            }
        }



        public string query
        {
            get
            {
                return _query;
            }
            set
            {
                _query = value;
            }
        }



        public int pid
        {
            get
            {
                return _pid;
            }
            set
            {
                _pid = value;
            }
        }

        public string Reply
        {
            get
            {
                return _reply;
            }
            set
            {
                _reply = value;
            }
        }

        public DataTable viewreply()
        {
            return objdal.Replyview(this);
        }




        public DataTable getproduct()
        {
            return objdal.getproductdetails();
        }

        public int insertqury()
        {
            return objdal.quryinsert(this);
        }

        public DataTable viewquery()
        {
            return objdal.querytview(this);
        }

        public int updateqry()
        {
            return objdal.QuerryUpdate(this);
        }

    }

    
}