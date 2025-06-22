using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Oracle.ManagedDataAccess.Client;
using Oracle.ManagedDataAccess.Types;
using System.Windows.Forms;

namespace DOAN.CIPHER
{
    public class MultiEncryptionOracle
    {
        OracleConnection conn;
        public MultiEncryptionOracle(OracleConnection conn)
        {
            this.conn = conn;
        }
        public string EncryptMulti(string Plaintext, int key)
        {
            try
            {
                string Function = "DOAN.MULTIENCRYPTION.encrypt";

                OracleCommand cmd = new OracleCommand();
                cmd.Connection = conn;
                cmd.CommandText = Function;
                cmd.CommandType = CommandType.StoredProcedure;

                OracleParameter resultPara = new OracleParameter();
                resultPara.ParameterName = "@Result";
                resultPara.OracleDbType = OracleDbType.Varchar2;
                resultPara.Size = 32767;
                resultPara.Direction = ParameterDirection.ReturnValue;
                cmd.Parameters.Add(resultPara);

                OracleParameter str = new OracleParameter();
                str.ParameterName = "@input_str";
                str.OracleDbType = OracleDbType.Varchar2;
                str.Value = Plaintext;
                str.Direction = ParameterDirection.Input;
                cmd.Parameters.Add(str);

                OracleParameter k = new OracleParameter();
                k.ParameterName = "@k";
                k.OracleDbType = OracleDbType.Int32;
                k.Value = key;
                k.Direction = ParameterDirection.Input;
                cmd.Parameters.Add(k);

                cmd.ExecuteNonQuery();

                string s = "null";
                if (resultPara.Value != DBNull.Value)
                {
                    OracleString ret = (OracleString)resultPara.Value;
                    s = ret.ToString();
                }

                return s;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.GetBaseException().ToString());
            }

            return null;
        }

        public string DecryptMulti(string EncryptedText, int key)
        {
            try
            {
                string Function = "DOAN.MULTIENCRYPTION.decrypt";

                OracleCommand cmd = new OracleCommand();
                cmd.Connection = conn;
                cmd.CommandText = Function;
                cmd.CommandType = CommandType.StoredProcedure;

                OracleParameter resultPara = new OracleParameter();
                resultPara.ParameterName = "@Result";
                resultPara.OracleDbType = OracleDbType.Varchar2;
                resultPara.Size = 32767;
                resultPara.Direction = ParameterDirection.ReturnValue;
                cmd.Parameters.Add(resultPara);

                OracleParameter str = new OracleParameter();
                str.ParameterName = "@input_str";
                str.OracleDbType = OracleDbType.Varchar2;
                str.Value = EncryptedText;
                str.Direction = ParameterDirection.Input;
                cmd.Parameters.Add(str);

                OracleParameter k = new OracleParameter();
                k.ParameterName = "@k";
                k.OracleDbType = OracleDbType.Int32;
                k.Value = key;
                k.Direction = ParameterDirection.Input;
                cmd.Parameters.Add(k);

                cmd.ExecuteNonQuery();

                string s = "null";
                if (resultPara.Value != DBNull.Value)
                {
                    OracleString ret = (OracleString)resultPara.Value;
                    s = ret.ToString();
                }

                return s;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.GetBaseException().ToString());
            }

            return null;
        }
    }
}
