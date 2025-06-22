using Oracle.ManagedDataAccess.Client;
using Oracle.ManagedDataAccess.Types;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOAN
{
    public class PhanQuyen
    {
        OracleConnection conn;
        public PhanQuyen(OracleConnection conn)
        {
            this.conn = conn;
        }
        public OracleDataReader Get_User()
        {
            try
            {
                string Procedure = "sys.PHANQUYEN.SP_SELECT_USER";

                OracleCommand cmd = new OracleCommand();
                cmd.Connection = conn;
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

                    return ret;
                }
            }
            catch
            {
                MessageBox.Show("Lỗi gọi chạy thủ tục: SP_SELECT_USER");
                return null;
            }
            return null;
        }

        public OracleDataReader Get_Roles()
        {
            try
            {
                string Procedure = "sys.PHANQUYEN.SP_SELECT_ROLES";

                OracleCommand cmd = new OracleCommand();
                cmd.Connection = conn;
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

                    return ret;
                }
            }
            catch
            {
                MessageBox.Show("Lỗi gọi chạy thủ tục: SP_SELECT_ROLES");
                return null;
            }
            return null;
        }

        public OracleDataReader Get_Procedure_User(string userowner, string type)
        {
            try
            {
                string Procedure = "sys.PHANQUYEN.SP_SELECT_PROCEDURE_USER";

                OracleCommand cmd = new OracleCommand();
                cmd.Connection = conn;
                cmd.CommandText = Procedure;
                cmd.CommandType = CommandType.StoredProcedure;

                OracleParameter UserOwner = new OracleParameter();
                UserOwner.ParameterName = "@userowner";
                UserOwner.OracleDbType = OracleDbType.Varchar2;
                UserOwner.Value = userowner.ToUpper();
                UserOwner.Direction = ParameterDirection.Input;
                cmd.Parameters.Add(UserOwner);

                OracleParameter pro_type = new OracleParameter();
                pro_type.ParameterName = "@pro_type";
                pro_type.OracleDbType = OracleDbType.Varchar2;
                pro_type.Value = type.ToUpper();
                pro_type.Direction = ParameterDirection.Input;
                cmd.Parameters.Add(pro_type);

                OracleParameter resultParam = new OracleParameter();
                resultParam.ParameterName = "@Result";
                resultParam.OracleDbType = OracleDbType.RefCursor;
                resultParam.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(resultParam);

                cmd.ExecuteNonQuery();

                if (resultParam.Value != DBNull.Value)
                {
                    OracleDataReader ret = ((OracleRefCursor)resultParam.Value).GetDataReader();

                    return ret;
                }
            }
            catch
            {
                MessageBox.Show("Lỗi gọi chạy thủ tục: SP_SELECT_PROCEDURE_USER");
                return null;
            }
            return null;
        }

        public OracleDataReader Get_Table_User(string userowner)
        {
            try
            {
                string Procedure = "sys.PHANQUYEN.SP_SELECT_TABLE";

                OracleCommand cmd = new OracleCommand();
                cmd.Connection = conn;
                cmd.CommandText = Procedure;
                cmd.CommandType = CommandType.StoredProcedure;

                OracleParameter UserOwner = new OracleParameter();
                UserOwner.ParameterName = "@userowner";
                UserOwner.OracleDbType = OracleDbType.Varchar2;
                UserOwner.Value = userowner.ToUpper();
                UserOwner.Direction = ParameterDirection.Input;
                cmd.Parameters.Add(UserOwner);

                OracleParameter resultParam = new OracleParameter();
                resultParam.ParameterName = "@Result";
                resultParam.OracleDbType = OracleDbType.RefCursor;
                resultParam.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(resultParam);

                cmd.ExecuteNonQuery();

                if (resultParam.Value != DBNull.Value)
                {
                    OracleDataReader ret = ((OracleRefCursor)resultParam.Value).GetDataReader();

                    return ret;
                }
            }
            catch
            {
                MessageBox.Show("Lỗi gọi chạy thủ tục: SP_SELECT_TABLE");
                return null;
            }
            return null;
        }

        public OracleDataReader Get_Roles_User(string username)
        {
            try
            {
                string Procedure = "sys.PHANQUYEN.SP_USER_ROLES";

                OracleCommand cmd = new OracleCommand();
                cmd.Connection = conn;
                cmd.CommandText = Procedure;
                cmd.CommandType = CommandType.StoredProcedure;

                OracleParameter UserName = new OracleParameter();
                UserName.ParameterName = "@username";
                UserName.OracleDbType = OracleDbType.Varchar2;
                UserName.Value = username.ToUpper();
                UserName.Direction = ParameterDirection.Input;
                cmd.Parameters.Add(UserName);

                OracleParameter resultParam = new OracleParameter();
                resultParam.ParameterName = "@Result";
                resultParam.OracleDbType = OracleDbType.RefCursor;
                resultParam.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(resultParam);

                cmd.ExecuteNonQuery();

                if (resultParam.Value != DBNull.Value)
                {
                    // Trả về OracleDataReader trực tiếp từ RefCursor
                    OracleDataReader ret = ((OracleRefCursor)resultParam.Value).GetDataReader();
                    return ret;  // Trả về OracleDataReader
                }
            }
            catch
            {
                MessageBox.Show("Lỗi gọi chạy thủ tục: SP_USER_ROLES");
                return null;
            }
            return null;
        }


        public int Get_Roles_User_Check(string username, string roles)
        {
            try
            {
                string Procedure = "sys.PHANQUYEN.SP_USER_ROLES_CHECK";

                OracleCommand cmd = new OracleCommand();
                cmd.Connection = conn;
                cmd.CommandText = Procedure;
                cmd.CommandType = CommandType.StoredProcedure;

                OracleParameter UserName = new OracleParameter();
                UserName.ParameterName = "@username";
                UserName.OracleDbType = OracleDbType.Varchar2;
                UserName.Value = username.ToUpper();
                UserName.Direction = ParameterDirection.Input;
                cmd.Parameters.Add(UserName);

                OracleParameter Roles = new OracleParameter();
                Roles.ParameterName = "@roles";
                Roles.OracleDbType = OracleDbType.Varchar2;
                Roles.Value = roles.ToUpper();
                Roles.Direction = ParameterDirection.Input;
                cmd.Parameters.Add(Roles);

                OracleParameter resultParam = new OracleParameter();
                resultParam.ParameterName = "@Result";
                resultParam.OracleDbType = OracleDbType.Int16;
                resultParam.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(resultParam);

                cmd.ExecuteNonQuery();

                if (resultParam.Value != DBNull.Value)
                {
                    return int.Parse(resultParam.Value.ToString());
                }
            }
            catch
            {
                MessageBox.Show("Lỗi gọi chạy thủ tục: SP_USER_ROLES_CHECK");
                return -1;
            }
            return -1;
        }


        public DataTable Get_Grant_User(string username)
        {
            try
            {
                string Procedure = "sys.PHANQUYEN.SP_SELECT_GRANT_USER";

                OracleCommand cmd = new OracleCommand();
                cmd.Connection = conn;
                cmd.CommandText = Procedure;
                cmd.CommandType = CommandType.StoredProcedure;

                OracleParameter UserName = new OracleParameter();
                UserName.ParameterName = "@username";
                UserName.OracleDbType = OracleDbType.Varchar2;
                UserName.Value = username.ToUpper();
                UserName.Direction = ParameterDirection.Input;
                cmd.Parameters.Add(UserName);

                OracleParameter resultParam = new OracleParameter();
                resultParam.ParameterName = "@Result";
                resultParam.OracleDbType = OracleDbType.RefCursor;
                resultParam.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(resultParam);

                cmd.ExecuteNonQuery();

                if (resultParam.Value != DBNull.Value)
                {
                    OracleDataReader ret = ((OracleRefCursor)resultParam.Value).GetDataReader();
                    DataTable data = new DataTable();
                    data.Load(ret);
                    return data;
                }
            }
            catch
            {
                MessageBox.Show("Lỗi gọi chạy thủ tục: SP_SELECT_GRANT_USER");
                return null;
            }
            return null;
        }

        public OracleDataReader Get_Grant(string username, string userschema, string tab)
        {
            try
            {
                string Procedure = "sys.PHANQUYEN.SP_SELECT_GRANT";

                OracleCommand cmd = new OracleCommand();
                cmd.Connection = conn;
                cmd.CommandText = Procedure;
                cmd.CommandType = CommandType.StoredProcedure;

                OracleParameter UserName = new OracleParameter();
                UserName.ParameterName = "@username";
                UserName.OracleDbType = OracleDbType.Varchar2;
                UserName.Value = username.ToUpper();
                UserName.Direction = ParameterDirection.Input;
                cmd.Parameters.Add(UserName);

                OracleParameter UserSchema = new OracleParameter();
                UserSchema.ParameterName = "@userschema";
                UserSchema.OracleDbType = OracleDbType.Varchar2;
                UserSchema.Value = userschema.ToUpper();
                UserSchema.Direction = ParameterDirection.Input;
                cmd.Parameters.Add(UserSchema);

                OracleParameter TableName = new OracleParameter();
                TableName.ParameterName = "@tablename";
                TableName.OracleDbType = OracleDbType.Varchar2;
                TableName.Value = tab.ToUpper();
                TableName.Direction = ParameterDirection.Input;
                cmd.Parameters.Add(TableName);

                OracleParameter resultParam = new OracleParameter();
                resultParam.ParameterName = "@Result";
                resultParam.OracleDbType = OracleDbType.RefCursor;
                resultParam.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(resultParam);

                cmd.ExecuteNonQuery();

                if (resultParam.Value != DBNull.Value)
                {
                    OracleDataReader ret = ((OracleRefCursor)resultParam.Value).GetDataReader();
                    return ret;  // Trả về OracleDataReader
                }
            }
            catch
            {
                MessageBox.Show("Lỗi gọi chạy thủ tục: SP_SELECT_GRANT");
                return null;
            }
            return null;
        }


        public bool Grant_Revoke_Pro(string username, string userschema, string tab, string type, int dk)
        {
            try
            {
                string Procedure = "sys.PHANQUYEN.SP_GRANT_REVOKE";

                OracleCommand cmd = new OracleCommand();
                cmd.Connection = conn;
                cmd.CommandText = Procedure;
                cmd.CommandType = CommandType.StoredProcedure;

                OracleParameter UserName = new OracleParameter();
                UserName.ParameterName = "@username";
                UserName.OracleDbType = OracleDbType.Varchar2;
                UserName.Value = username.ToUpper();
                UserName.Direction = ParameterDirection.Input;
                cmd.Parameters.Add(UserName);

                OracleParameter UserSchema = new OracleParameter();
                UserSchema.ParameterName = "@userschema";
                UserSchema.OracleDbType = OracleDbType.Varchar2;
                UserSchema.Value = userschema.ToUpper();
                UserSchema.Direction = ParameterDirection.Input;
                cmd.Parameters.Add(UserSchema);

                OracleParameter TableName = new OracleParameter();
                TableName.ParameterName = "@tablename";
                TableName.OracleDbType = OracleDbType.Varchar2;
                TableName.Value = tab.ToUpper();
                TableName.Direction = ParameterDirection.Input;
                cmd.Parameters.Add(TableName);

                OracleParameter pro_type = new OracleParameter();
                pro_type.ParameterName = "@pro_type";
                pro_type.OracleDbType = OracleDbType.Varchar2;
                pro_type.Value = type.ToUpper();
                pro_type.Direction = ParameterDirection.Input;
                cmd.Parameters.Add(pro_type);

                OracleParameter DK = new OracleParameter();
                DK.ParameterName = "@dk";
                DK.OracleDbType = OracleDbType.Int16;
                DK.Value = dk;
                DK.Direction = ParameterDirection.Input;
                cmd.Parameters.Add(DK);

                cmd.ExecuteNonQuery();

                return true;
            }
            catch
            {
                MessageBox.Show("Lỗi gọi chạy thủ tục: SP_GRANT_REVOKE");
                return false;
            }
        }

        public bool Grant_Revoke_Role(string username, string role, int dk)
        {
            try
            {
                string Procedure = "sys.PHANQUYEN.SP_GRANT_REVOKE_ROLES";

                OracleCommand cmd = new OracleCommand();
                cmd.Connection = conn;
                cmd.CommandText = Procedure;
                cmd.CommandType = CommandType.StoredProcedure;

                OracleParameter UserName = new OracleParameter();
                UserName.ParameterName = "@username";
                UserName.OracleDbType = OracleDbType.Varchar2;
                UserName.Value = username.ToUpper();
                UserName.Direction = ParameterDirection.Input;
                cmd.Parameters.Add(UserName);

                OracleParameter Role = new OracleParameter();
                Role.ParameterName = "@roles";
                Role.OracleDbType = OracleDbType.Varchar2;
                Role.Value = role.ToUpper();
                Role.Direction = ParameterDirection.Input;
                cmd.Parameters.Add(Role);

                OracleParameter DK = new OracleParameter();
                DK.ParameterName = "@dk";
                DK.OracleDbType = OracleDbType.Int16;
                DK.Value = dk;
                DK.Direction = ParameterDirection.Input;
                cmd.Parameters.Add(DK);

                cmd.ExecuteNonQuery();

                return true;
            }
            catch
            {
                MessageBox.Show("Lỗi gọi chạy thủ tục: SP_GRANT_REVOKE_ROLES");
                return false;
            }
        }

    }
}
