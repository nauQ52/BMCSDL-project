using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DOAN
{
    public partial class fGrantPolicy : Form
    {
        private OracleConnection conn;
        public fGrantPolicy()
        {
            InitializeComponent();
            CenterToParent();
            conn = Database.Get_connect();
        }
        private void fGrantPolicyLoad(object sender, EventArgs e)
        {
            LoadPolicyComboBox(conn);
            LoadStatus(conn);
        }

        private void LoadPolicyComboBox(OracleConnection connection)
        {
            try
            {
                using (OracleCommand command = new OracleCommand("packg_disable_enable_policy.pro_select_OLS_POLICIES", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    // Tạo tham số output
                    OracleParameter outParam = new OracleParameter("v_out", OracleDbType.RefCursor);
                    outParam.Direction = ParameterDirection.Output;
                    command.Parameters.Add(outParam);

                    // Thực thi thủ tục và nhận tập kết quả
                    using (OracleDataReader reader = command.ExecuteReader())
                    {
                        cboName.Items.Clear();

                        while (reader.Read())
                        {
                            string policyName = reader.GetString(0);
                            cboName.Items.Add(policyName);
                            cboName.SelectedIndex = 0;
                        }
                    }
                }
            }
            catch (OracleException ex)
            {
                MessageBox.Show("Error selecting policy: " + ex.Message);
            }
        }

        private void LoadStatus(OracleConnection connection)
        {
            try
            {
                string policyName = cboName.SelectedItem.ToString();  // Get the selected policy name

                using (OracleCommand command = new OracleCommand("packg_disable_enable_policy.pro_select_Status_OLS_POLICIES", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    // Thêm tham số đầu vào
                    command.Parameters.Add("policyName", OracleDbType.Varchar2).Value = policyName;

                    // Tạo tham số output
                    OracleParameter outParam = new OracleParameter("v_out", OracleDbType.RefCursor);
                    outParam.Direction = ParameterDirection.Output;
                    command.Parameters.Add(outParam);

                    // Thực thi thủ tục và nhận tập kết quả
                    using (OracleDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string userName = reader.GetString(0);  // Get the value of the first column
                            lb_Status.Text = userName;  // Assuming lbl_Status is a label or similar control
                        }
                    }
                }
            }
            catch (OracleException ex)
            {
                MessageBox.Show("Error selecting status for policy: " + ex.Message);
            }
        }

        private void cboName_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadStatus(conn);
        }

        private void btnCommit_Click(object sender, EventArgs e)
        {
            object selectedItem = cboName.SelectedItem;
            string policyName = cboName.SelectedItem.ToString();

            // Kiểm tra xem đã chọn RadioButton chưa
            if (rdbEnable.Checked || rdbDisable.Checked)
            {
                // Lấy ra giá trị đã chọn
                if (rdbEnable.Checked)
                {
                    using (OracleCommand cmd = new OracleCommand("pro_enable_policy", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        // Thêm tham số vào stored procedure
                        cmd.Parameters.Add("policyName", OracleDbType.Varchar2).Value = policyName;

                        try
                        {
                            // Thực thi stored procedure
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Policy enabled successfully!");
                        }
                        catch (OracleException ex)
                        {
                            MessageBox.Show("Error enabling policy: " + ex.Message);
                        }
                    }
                }
                else
                {
                    using (OracleCommand cmd = new OracleCommand("pro_disable_policy", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        // Thêm tham số vào stored procedure
                        cmd.Parameters.Add("policyName", OracleDbType.Varchar2).Value = policyName;

                        try
                        {
                            // Thực thi stored procedure
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Policy disabled successfully!");
                        }
                        catch (OracleException ex)
                        {
                            MessageBox.Show("Error disabling policy: " + ex.Message);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select Enable or Disable to proceed.");
            }
        }


    }
}
