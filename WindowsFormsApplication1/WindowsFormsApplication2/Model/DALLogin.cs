using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
namespace WindowsFormsApplication2.Model
{
   public class DALLogin
    {
        private SqlConnection _sqlConn = null;
        private SqlCommand _cmd = null;
        public DALLogin() {
            String Conn = ConfigurationManager.ConnectionStrings["dbConnection"].ConnectionString;
            _sqlConn = new SqlConnection(Conn);
            if (_sqlConn.State == System.Data.ConnectionState.Closed)
                _sqlConn.Open();
        }
        //Create
        //Update
        //Delete
        //Read All
        //Select By id
        //CheckUser Status
        //IsValidIser
        public bool LoginUser(Login lg) {
            _cmd = new SqlCommand("SELECT COUNT(*) FROM LOGINTB WHERE USERNAME = @USERNAME AND UPASSWORD = @UPASSWORD AND USTATUS =1", _sqlConn);
            _cmd.Parameters.AddWithValue("@USERNAME", lg.UserName);
            _cmd.Parameters.AddWithValue("@UPASSWORD", lg.UserPass);
            int _flag = int.Parse(_cmd.ExecuteScalar().ToString());

            return _flag>0 ? true : false;
        }
    }
}
