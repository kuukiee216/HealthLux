using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthLux.Classes
{
    class clsFunction
    {
        Classes.clsConnection MyConnect = new Classes.clsConnection();

        public Boolean IfAccountExists(string accountinfo)
        {
            string sQry = "SELECT * FROM tbl_account WHERE AccountID = '" + accountinfo + "' OR " +
                "Username = '" + accountinfo + "'";
            DataTable dtAccount = new DataTable();
            dtAccount = MyConnect.SelectQry(sQry);
            if (dtAccount.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public Boolean IfEmployeeExists(string ln, string fn, string mn)
        {
            string sQry = "SELECT lastname,firstname,middlename FROM tbl_employment WHERE " +
                "lastname = '" + ln + "' AND firstname = '" + fn + "' " +
                "AND middlename = '" + MyConnect.FixSQL(mn) + "'";
            DataTable dtName = new DataTable();
            dtName = MyConnect.SelectQry(sQry);
            if (dtName.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public Boolean IfIDExistsInPicture(int id)
        {
            string sQry = "SELECT * FROM tbl_employeepicture WHERE " +
                "EmployeeID = '" + id + "'";
            DataTable dtEmployeePicture = new DataTable();
            dtEmployeePicture = MyConnect.SelectQry(sQry);
            if (dtEmployeePicture.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public Boolean IfServiceExists(string servicename)
        {
            string sQry = "SELECT * FROM tbl_services WHERE ServiceName = '" + servicename + "'";
            DataTable dtServiceName = new DataTable();
            dtServiceName = MyConnect.SelectQry(sQry);
            if (dtServiceName.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public Boolean IfAdminPasswordCorrect(string id, string password)
        {
            string sQry = "SELECT * FROM tbl_account WHERE AccountID = '" + id + "' " +
                "AND Password = '" + password + "'";
            DataTable dtpassword = new DataTable();
            dtpassword = MyConnect.SelectQry(sQry);
            if (dtpassword.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
