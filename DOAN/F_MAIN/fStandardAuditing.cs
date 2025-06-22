using Oracle.ManagedDataAccess.Client;
using Oracle.ManagedDataAccess.Types;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DOAN.F_MAIN
{
    public partial class fStandardAuditing : Form
    {
        private OracleConnection conn;
        private FlowLayoutPanel flowLayoutPanel1;
        PhanQuyen p;
        public fStandardAuditing()
        {
            InitializeComponent();
            CenterToParent();
            conn = Database.Get_connectSys();
            p = new PhanQuyen(conn);
            load_Cbo_User();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel1.Location = new System.Drawing.Point(100, 100); // Đặt vị trí cách top 100px và left 10px
            this.flowLayoutPanel1.Size = new System.Drawing.Size(this.ClientSize.Width - 20, this.ClientSize.Height - 110);
            this.flowLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom;
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            this.flowLayoutPanel1.WrapContents = false;
        }

        private void load_Cbo_User()
        {
            OracleDataReader read = p.Get_User();
            while (read.Read())
            {
                cmbUser.Items.Add(read[0].ToString());
            }
            read.Close();
            cmbUser.SelectedIndex = 0;
        }

        //cmbUser.Items.Add(reader[0].ToString());


        public void LoadAuditUser(string user, DataGridView dataGridView, OracleConnection conn)
        {
            try
            {
                using (OracleCommand cmd = new OracleCommand("SYS.SP_SELECT_AUDIT_TRAIL_USER", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("p_user", OracleDbType.Varchar2).Value = user;
                    cmd.Parameters.Add("p_cursor", OracleDbType.RefCursor).Direction = ParameterDirection.Output;

                    using (OracleDataAdapter adapter = new OracleDataAdapter(cmd))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        dataGridView.DataSource = dataTable;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi không xem bảng audit user được: " + ex.Message);
            }
        }



        private void load_checkListBox_audit_opts(string user, OracleConnection conn)
        {
            try
            {
                checkedListBox1.Items.Clear();
                using (OracleCommand cmd = new OracleCommand("SYS.SP_SELECT_STMT_AUDIT_OPTS", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("p_user", OracleDbType.Varchar2).Value = user;
                    cmd.Parameters.Add("p_cursor", OracleDbType.RefCursor).Direction = ParameterDirection.Output;

                    using (OracleDataAdapter adapter = new OracleDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        HashSet<string> uniqueOptions = new HashSet<string>();

                        foreach (DataRow row in dt.Rows)
                        {
                            string auditOption = row["AUDIT_OPTION"].ToString().ToUpper();
                            uniqueOptions.Add(auditOption);
                        }

                        foreach (string option in uniqueOptions)
                        {
                            int index = checkedListBox1.Items.Add(option);
                            checkedListBox1.SetItemChecked(index, true);
                        }
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Lỗi không xem bảng audit được");
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            string user = cmbUser.SelectedItem.ToString();
            LoadAuditUser(user, dgvAudit, conn);
            load_checkListBox_audit_opts(user, conn);
        }

        private void drgAudit_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvAudit.Rows[e.RowIndex];
                string valueFromSecondColumn = row.Cells[8].Value.ToString();

                txtSql.Text = valueFromSecondColumn;
            }
        }

        private void cmbUser_SelectedIndexChanged(object sender, EventArgs e)
        {
            string user = cmbUser.SelectedItem.ToString();
            LoadAuditUser(user, dgvAudit, conn);
            load_checkListBox_audit_opts(user, conn);
        }
    }
}
