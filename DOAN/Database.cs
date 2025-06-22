using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;
using Oracle.ManagedDataAccess.Types;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace DOAN
{
    internal class Database
    {
        private static OracleConnection conn;
        private static OracleConnection connSys;

        public static string Host;
        public static string Port;
        public static string Sid;
        public static string User;
        public static string Password;

        public static void Set_Database(string host, string port, string sid, string user, string password)
        {
            Database.Host = host;
            Database.Port = port;
            Database.Sid = sid;
            Database.User = user;
            Database.Password = password;
        }

        public static bool Connect()
        {
            string consys = "";
            try
            {
                if (User.ToUpper().Equals("SYS"))
                {
                    consys = ";DBA Privilege = SYSDBA;";
                }

                string connString = "Data Source=(DESCRIPTION =(ADDRESS = ( PROTOCOL = TCP) (HOST = " + Host + ")(PORT = " + Port + "))(CONNECT_DATA = (SERVER = DEDICATED)(SERVICE_NAME = "
                + Sid + "))); User ID = " + User + "; Password = " + Password + consys;

                conn = new OracleConnection();
                conn.ConnectionString = connString;
                conn.Open();

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kiểm tra kết nối!", "Thông báo");
                return false;
            }
        }

        public static OracleConnection Get_connect()
        {
            if (conn == null)
            {
                Connect();
            }    
            return conn;
        }

        public static void Close_connect()
        {
            if (conn.State.ToString().Equals("Open"))
            {
                conn.Close();
            }
        }

        public static bool ConnectSys()
        {
            try
            {
                string connString = "Data Source=(DESCRIPTION =(ADDRESS = ( PROTOCOL = TCP) (HOST = " + Host + ")(PORT = " + Port + "))(CONNECT_DATA = (SERVER = DEDICATED)(SERVICE_NAME = "
                + Sid + "))); User ID = sys; Password = sys;DBA Privilege = SYSDBA;";

                connSys = new OracleConnection();
                connSys.ConnectionString = connString;
                connSys.Open();

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kiểm tra kết nối!", "Thông báo");
                return false;
            }
        }

        public static OracleConnection Get_connectSys()
        {
            if (connSys == null)
            {
                ConnectSys();
            }
            if (connSys.State.ToString().Equals("Closed"))
            {
                connSys.Open();
            }
            return connSys;
        }

        public static void Close_connectSys()
        {
            if (connSys.State.ToString().Equals("Open"))
            {
                connSys.Close();
            }
        }

        public static string Get_Status(string user)
        {
            try
            {
                string Function = "DOAN.F_ACCOUNT_STATUS";

                OracleCommand cmd = new OracleCommand();
                cmd.Connection = Get_connectSys();
                cmd.CommandText = Function;
                cmd.CommandType = CommandType.StoredProcedure;

                OracleParameter resultParam = new OracleParameter();
                resultParam.ParameterName = "@Result";
                resultParam.OracleDbType = OracleDbType.Varchar2;
                resultParam.Size = 100;
                resultParam.Direction = ParameterDirection.ReturnValue;
                cmd.Parameters.Add(resultParam);

                OracleParameter UserName = new OracleParameter();
                UserName.ParameterName = "@User";
                UserName.OracleDbType = OracleDbType.Varchar2;
                UserName.Value = user.ToUpper();
                UserName.Direction = ParameterDirection.Input;
                cmd.Parameters.Add(UserName);

                cmd.ExecuteNonQuery();
                if (resultParam.Value != DBNull.Value)
                {
                    OracleString ret = ((OracleString)resultParam.Value);
                    string s = ret.ToString();
                    return s;
                }
            }
            catch (Exception)
            {
                return "";
            }
            return "";
        }

        public static DataTable Get_NameTableSpace()
        {
            try
            {
                string Procedure = "SYS.SP_NAME_TABLESPACE";

                OracleCommand cmd = new OracleCommand();
                cmd.Connection = Get_connectSys();
                cmd.CommandText = Procedure;
                cmd.CommandType = CommandType.StoredProcedure;

                OracleParameter resultParam = new OracleParameter();
                resultParam.ParameterName = "@Result";
                resultParam.OracleDbType = OracleDbType.RefCursor;
                resultParam.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(resultParam);

                cmd.ExecuteNonQuery();

                if (resultParam.Value != DBNull.Value)
                {
                    OracleDataReader ret = ((OracleRefCursor)resultParam.Value).GetDataReader();
                    DataTable dt = new DataTable();
                    dt.Load(ret);
                    return dt;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi không tải được danh sách", "Lỗi");
            }

            return null;
        }

        public static DataTable Get_NameProfile()
        {
            try
            {
                string Procedure = "SYS.SP_NAME_PROFILE";

                OracleCommand cmd = new OracleCommand();
                cmd.Connection = Get_connectSys();
                cmd.CommandText = Procedure;
                cmd.CommandType = CommandType.StoredProcedure;

                OracleParameter resultParam = new OracleParameter();
                resultParam.ParameterName = "@Result";
                resultParam.OracleDbType = OracleDbType.RefCursor;
                resultParam.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(resultParam);

                cmd.ExecuteNonQuery();

                if (resultParam.Value != DBNull.Value)
                {
                    OracleDataReader ret = ((OracleRefCursor)resultParam.Value).GetDataReader();
                    DataTable dt = new DataTable();
                    dt.Load(ret);
                    return dt;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi không tải được danh sách", "Lỗi");
            }

            return null;
        }
    }
}
