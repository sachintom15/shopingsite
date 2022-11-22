using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace shopingsite.BAL
{
    public class ProdregBal
    {

        //create object of dataAccess Layer
        DAL.ProdregDal objprod1 = new DAL.ProdregDal();

        //create two variable based on table
        private string _prodid;
        private string _prodname;
        private string _amount;


        public string ProdId
        {
            get
            {
                return _prodid;
            }
            set
            {
                _prodid = value;
            }
        }

        public string ProdName
        {
            get
            {
                return _prodname;
            }
            set
            {
                _prodname = value;
            }
        }

        public string Amount
        {
            get
            {
                return _amount;
            }
            set
            {
                _amount = value;
            }
        }

        public int Insert()
        {
            return objprod1.Insert(this);
        }

        public DataTable viewuser()
        {
            return objprod1.userview();

        }

        public int deleteProd()
        {
            return objprod1.productdelete(this);
        }

        public int updateProd()
        {
            return objprod1.productupdate(this);
        }

    }
}