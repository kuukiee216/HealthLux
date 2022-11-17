using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HealthLux.Classes
{
    class clsConnection
    {
        MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["HealthLuxDB"].ConnectionString);

        private bool OpenConnection()
        {
            try
            {
                conn.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                switch (ex.Number)
                {
                    case 0:
                        MessageBox.Show("Cannot connect to server. Please try again.\nIf Error still occured, contact  the administrator.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;

                    case 1045:
                        MessageBox.Show("Invalid username/password, please try again");
                        break;
                    default:
                        MessageBox.Show(ex.ToString());
                        break;
                }

                return false;
            }
        }

        private bool CloseConnection()
        {
            try
            {
                conn.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public DataTable SelectQry(string sQry)
        {
            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(sQry, conn);
                MySqlDataAdapter returnVal = new MySqlDataAdapter(sQry, conn);
                DataTable dt = new DataTable("CharacterInfo");
                returnVal.Fill(dt);
                CloseConnection();
                return dt;
            }
            else
            {
                this.CloseConnection();
                return null;
            }
        }

        public void ActionQry(string sQry)
        {
            //open connection
            if (OpenConnection() == true)
            {
                //create command and assign the query and connection from the constructor
                MySqlCommand cmd = new MySqlCommand(sQry, conn);

                //Execute command
                cmd.ExecuteNonQuery();

                //close connection
                this.CloseConnection();
            }
        }

        public void ImgActionQry(string sQry, string QParameter, byte[] ms)
        {
            //open connection
            if (OpenConnection() == true)
            {
                //create command and assign the query and connection from the constructor
                MySqlCommand cmd = new MySqlCommand(sQry, conn);
                cmd.Parameters.Add("@employee_img", MySqlDbType.Blob).Value = ms;
                //Execute command
                cmd.ExecuteNonQuery();

                //close connection
                this.CloseConnection();
            }
        }

        private string DataConnection()
        { return ConfigurationManager.ConnectionStrings["HealthLuxDB"].ConnectionString; }

        public DataTable ReturnDT(string strCmd)
        {
            MySqlConnection conn = new MySqlConnection(DataConnection());
            MySqlCommand cmd = new MySqlCommand(strCmd, conn);
            MySqlDataReader myReader;
            conn.Open();
            myReader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(myReader);
            return dt;
        }

        public string FixSQL(string str)
        {
            return str.Replace("\\", "/").Replace("'", "''");
        }
    }
}
