using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace DOAN
{
    public partial class fCrPolicy : Form
    {
        private OracleConnection conn;
        public fCrPolicy()
        {
            InitializeComponent();
            CenterToParent();
            conn = Database.Get_connect();
        }
        private void fCrPolicyLoad(object sender, EventArgs e)
        {
            LoadPolicyComboBox(conn);
            load_Cbo_User(conn);
        }

        private void addPolicy(OracleConnection conn, string policyName, string columnName)
        {
            try
            {
                using (OracleCommand cmd = new OracleCommand("pro_create_policy", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("policyName", OracleDbType.Varchar2).Value = policyName;
                    cmd.Parameters.Add("colName", OracleDbType.Varchar2).Value = columnName;

                    try
                    {
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Policy created successfully!");
                        LoadPolicyComboBox(conn);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error creating policy: " + ex.Message);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error creating policy: " + ex.Message);
            }
        }

        private void LoadPolicyComboBox(OracleConnection connection)
        {
            try
            {
                using (OracleCommand command = new OracleCommand("pro_select_OLS_POLICIES", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    OracleParameter outParam = new OracleParameter("v_out", OracleDbType.RefCursor);
                    outParam.Direction = ParameterDirection.Output;
                    command.Parameters.Add(outParam);

                    command.ExecuteNonQuery();

                    using (OracleDataReader reader = command.ExecuteReader())
                    {
                        cboName.Items.Clear();
                        while (reader.Read())
                        {
                            string policyName = reader.GetString(0);
                            cboName.Items.Add(policyName);
                        }

                        if (cboName.Items.Count > 0)
                            cboName.SelectedIndex = 0;
                    }
                }
            }
            catch (OracleException ex)
            {
                MessageBox.Show("Error loading policies: " + ex.Message);
            }
        }

        private void btnGan_Click(object sender, EventArgs e)
        {
            if (cboName.SelectedItem == null || string.IsNullOrEmpty(txtName1.Text))
            {
                MessageBox.Show("Please select a policy and enter a username.");
                return;
            }

            string selectedPolicy = cboName.SelectedItem.ToString();
            string userName = txtName1.Text;

            runPro_grant_policy(conn, selectedPolicy, userName);
        }

        private void runPro_grant_policy(OracleConnection conn, string policyName, string userName)
        {
            try
            {
                using (OracleCommand cmd = new OracleCommand("pro_grant_policy", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("policyName", OracleDbType.Varchar2).Value = policyName;
                    cmd.Parameters.Add("username", OracleDbType.Varchar2).Value = userName;

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Policy granted successfully!");
                }
            }
            catch (OracleException ex)
            {
                MessageBox.Show("Error granting policy: " + ex.Message);
            }
        }


        private void load_Cbo_User(OracleConnection conn)
        {
            try
            {
                using (OracleCommand command = new OracleCommand("pro_select_all_users", conn))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    // Tạo tham số output
                    OracleParameter outParam = new OracleParameter("v_out", OracleDbType.RefCursor);
                    outParam.Direction = ParameterDirection.Output;
                    command.Parameters.Add(outParam);

                    // Thực thi thủ tục
                    command.ExecuteNonQuery();

                    // Lấy dữ liệu từ tham số output
                    using (OracleDataReader reader = command.ExecuteReader())
                    {
                        cboUser.Items.Clear();
                        while (reader.Read())
                        {
                            string userName = reader.GetString(0);
                            cboUser.Items.Add(userName);
                            cboUser.SelectedIndex = 0;
                        }
                    }
                }
            }
            catch (OracleException ex)
            {
                MessageBox.Show("Error selecting users: " + ex.Message);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {

        }
    }
}
