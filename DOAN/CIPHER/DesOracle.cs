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
    public class DesOracle
    {
        OracleConnection conn;
        public DesOracle(OracleConnection conn)
        {
            this.conn = conn;
        }
        public byte[] EncryptDES(string Plaintext, string priKey)
        {
            try
            {
                string Function = "DOAN.DES.encrypt";

                OracleCommand cmd = new OracleCommand();
                cmd.Connection = conn;
                cmd.CommandText = Function;
                cmd.CommandType = CommandType.StoredProcedure;

                OracleParameter resultPara = new OracleParameter();
                resultPara.ParameterName = "@Result";
                resultPara.OracleDbType = OracleDbType.Raw;
                resultPara.Size = 32767;
                resultPara.Direction = ParameterDirection.ReturnValue;
                cmd.Parameters.Add(resultPara);

                OracleParameter str = new OracleParameter();
                str.ParameterName = "@p_plainText";
                str.OracleDbType = OracleDbType.Varchar2;
                str.Value = Plaintext;
                str.Direction = ParameterDirection.Input;
                cmd.Parameters.Add(str);

                OracleParameter k = new OracleParameter();
                k.ParameterName = "@priKey";
                k.OracleDbType = OracleDbType.Varchar2;
                k.Value = priKey;
                k.Direction = ParameterDirection.Input;
                cmd.Parameters.Add(k);

                cmd.ExecuteNonQuery();

                if (resultPara.Value != DBNull.Value)
                {
                    OracleBinary ret = (OracleBinary)resultPara.Value;
                    return ret.Value;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.GetBaseException().ToString());
            }

            return null;
        }

        public string DecryptDES(byte[] EncryptedText, string priKey)
        {
            try
            {
                string Function = "DOAN.DES.decrypt";

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
                str.ParameterName = "@p_encryptedText";
                str.OracleDbType = OracleDbType.Raw;
                str.Value = EncryptedText;
                str.Direction = ParameterDirection.Input;
                cmd.Parameters.Add(str);

                OracleParameter k = new OracleParameter();
                k.ParameterName = "@priKey";
                k.OracleDbType = OracleDbType.Varchar2;
                k.Value = priKey;
                k.Direction = ParameterDirection.Input;
                cmd.Parameters.Add(k);

                cmd.ExecuteNonQuery();

                if (resultPara.Value != DBNull.Value)
                {
                    OracleString ret = (OracleString)resultPara.Value;
                    return ret.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.GetBaseException().ToString());
            }

            return null;
        }
    }
}
