using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace shopingsite.BAL
{
    public class ComplaintBal
    {
        DAL.ComplaintDal objdal = new DAL.ComplaintDal();


        private int _pid;
        private string _complaint;
        private string _login;
        private string _name;



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



        public string complaint
        {
            get
            {
                return _complaint;
            }
            set
            {
                _complaint = value;
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

        public DataTable getproduct()
        {
            return objdal.getproductdetails(this);
        }

        public int insertcomplaint()
        {
            return objdal.complaintinsert(this);
        }

        public DataTable viewcomplaint()
        {
            return objdal.complaintview(this);
        }

        public int confircomplaint()
        {
            return objdal.complaintconfirm(this);
        }

        public int closecomplaint()
        {
            return objdal.complaintclose(this);
        }

        public DataTable complaintProcess()
        {
            return objdal.Closedcomplaint(this);
        }
    }
}