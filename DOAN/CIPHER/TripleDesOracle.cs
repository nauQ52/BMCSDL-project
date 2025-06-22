using System;
using System.Data;
using Oracle.ManagedDataAccess.Client;
using Oracle.ManagedDataAccess.Types;
using System.Windows.Forms;

namespace DOAN.CIPHER
{
    public class TripleDesOracle
    {
        private OracleConnection conn;

        public TripleDesOracle(OracleConnection connection)
        {
            this.conn = connection;
        }

        public byte[] EncryptTripleDES(string plainText, string priKey)
        {
            try
            {
                // Package name and function
                string function = "TripDES.encrypt";

                OracleCommand cmd = new OracleCommand();
                cmd.Connection = conn;
                cmd.CommandText = function;
                cmd.CommandType = CommandType.StoredProcedure;

                // Return value parameter
                OracleParameter resultPara = new OracleParameter
                {
                    ParameterName = "RETURN_VALUE",
                    OracleDbType = OracleDbType.Raw,
                    Direction = ParameterDirection.ReturnValue,
                    Size = 32767
                };
                cmd.Parameters.Add(resultPara);

                // Input parameter: plaintext
                OracleParameter plainTextPara = new OracleParameter
                {
                    ParameterName = "p_plaintext",
                    OracleDbType = OracleDbType.Varchar2,
                    Value = plainText,
                    Direction = ParameterDirection.Input
                };
                cmd.Parameters.Add(plainTextPara);

                // Input parameter: key
                OracleParameter keyPara = new OracleParameter
                {
                    ParameterName = "priKey",
                    OracleDbType = OracleDbType.Varchar2,
                    Value = priKey,
                    Direction = ParameterDirection.Input
                };
                cmd.Parameters.Add(keyPara);

                // Execute
                cmd.ExecuteNonQuery();

                if (resultPara.Value != DBNull.Value)
                {
                    OracleBinary ret = (OracleBinary)resultPara.Value;
                    return ret.Value;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Encryption Error: " + ex.Message);
            }

            return null;
        }

        public string DecryptTripleDES(byte[] encryptedText, string priKey)
        {
            try
            {
                // Package name and function
                string function = "TripDES.decrypt";

                OracleCommand cmd = new OracleCommand();
                cmd.Connection = conn;
                cmd.CommandText = function;
                cmd.CommandType = CommandType.StoredProcedure;

                // Return value parameter
                OracleParameter resultPara = new OracleParameter
                {
                    ParameterName = "RETURN_VALUE",
                    OracleDbType = OracleDbType.Varchar2,
                    Size = 32767,
                    Direction = ParameterDirection.ReturnValue
                };
                cmd.Parameters.Add(resultPara);

                // Input parameter: encrypted text
                OracleParameter encryptedTextPara = new OracleParameter
                {
                    ParameterName = "p_encryptedText",
                    OracleDbType = OracleDbType.Raw,
                    Value = encryptedText,
                    Direction = ParameterDirection.Input
                };
                cmd.Parameters.Add(encryptedTextPara);

                // Input parameter: key
                OracleParameter keyPara = new OracleParameter
                {
                    ParameterName = "priKey",
                    OracleDbType = OracleDbType.Varchar2,
                    Value = priKey,
                    Direction = ParameterDirection.Input
                };
                cmd.Parameters.Add(keyPara);

                // Execute
                cmd.ExecuteNonQuery();

                if (resultPara.Value != DBNull.Value)
                {
                    OracleString ret = (OracleString)resultPara.Value;
                    return ret.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Decryption Error: " + ex.Message);
            }

            return null;
        }
    }
}
