using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic.ApplicationServices;
using Oracle.ManagedDataAccess.Client;


namespace DOAN.F_MAIN
{
    public partial class fGrantGUI : Form
    {
        OracleConnection conn;
        PhanQuyen p;
        public fGrantGUI()
        {
            InitializeComponent();
            CenterToParent();
            conn = Database.Get_connectSys();
            p = new PhanQuyen(conn);
            Load_User();
            Load_Roles();
        }
        void set_Color_Checkbox_user()
        {
            if (cbSelectUs.Checked)
                cbSelectUs.ForeColor = Color.Green;
            else
                cbSelectUs.ForeColor = Color.Red;

            if (cbInsertUs.Checked)
                cbInsertUs.ForeColor = Color.Green;
            else
                cbInsertUs.ForeColor = Color.Red;

            if (cbUpdateUs.Checked)
                cbUpdateUs.ForeColor = Color.Green;
            else
                cbUpdateUs.ForeColor = Color.Red;

            if (cbDeleteUs.Checked)
                cbDeleteUs.ForeColor = Color.Green;
            else
                cbDeleteUs.ForeColor = Color.Red;
        }

        void set_Color_Checkbox_roles()
        {
            if (cbSelectRo.Checked)
                cbSelectRo.ForeColor = Color.Green;
            else
                cbSelectRo.ForeColor = Color.Red;

            if (cbInsertRo.Checked)
                cbInsertRo.ForeColor = Color.Green;
            else
                cbInsertRo.ForeColor = Color.Red;

            if (cbUpdateRo.Checked)
                cbUpdateRo.ForeColor = Color.Green;
            else
                cbUpdateRo.ForeColor = Color.Red;

            if (cbDeleteRo.Checked)
                cbDeleteRo.ForeColor = Color.Green;
            else
                cbDeleteRo.ForeColor = Color.Red;
        }

        void set_Color_Grant_User()
        {
            if (cbUserPro.Checked)
                cbUserPro.ForeColor = Color.Green;
            else
                cbUserPro.ForeColor = Color.Red;

            if (cbUserFun.Checked)
                cbUserFun.ForeColor = Color.Green;
            else
                cbUserFun.ForeColor = Color.Red;

            if (cbUserPk.Checked)
                cbUserPk.ForeColor = Color.Green;
            else
                cbUserPk.ForeColor = Color.Red;
        }

        void set_Color_Grant_Roles()
        {
            if (cbRolesPro.Checked)
                cbRolesPro.ForeColor = Color.Green;
            else
                cbRolesPro.ForeColor = Color.Red;

            if (cbRolesFun.Checked)
                cbRolesFun.ForeColor = Color.Green;
            else
                cbRolesFun.ForeColor = Color.Red;

            if (cbRolesPk.Checked)
                cbRolesPk.ForeColor = Color.Green;
            else
                cbRolesPk.ForeColor = Color.Red;
        }

        void Set_Lable_Table()
        {
            string t = "Table: ";
            if (cmbTable.SelectedItem != null)
            {
                t += cmbTable.SelectedItem.ToString();
            }

            lbTableRoles.Text = t;
            lbTableUser.Text = t;
        }

        void Set_Text_Button(string user, string role)
        {
            int kq = p.Get_Roles_User_Check(user, role);
            if (kq == 1)
            {
                btnGrantRevokeRole.Text = "Revoke";
            }
            else if (kq == 0)
            {
                btnGrantRevokeRole.Text = "Grant";
            }
        }

        void Load_User()
        {
            OracleDataReader read = p.Get_User();
            while (read.Read())
            {
                cmbUser.Items.Add(read[0].ToString());
                cmbUsername.Items.Add(read[0].ToString());
            }
            read.Close();
            cmbUser.SelectedIndex = 0;
            cmbUsername.SelectedIndex = 0;
        }

        void Load_Roles()
        {
            OracleDataReader read = p.Get_Roles();
            while (read.Read())
            {
                cmbRoles.Items.Add(read[0].ToString());
            }
            read.Close();

            cmbRoles.SelectedIndex = 0;
        }

        void Clear_Combobox()
        {
            cmbProcedure.Items.Clear();
            cmbFunction.Items.Clear();
            cmbPackage.Items.Clear();
            cmbTable.Items.Clear();
        }

        void Select_Combobox()
        {
            if (cmbProcedure.Items.Count == 0)
                cmbProcedure.Items.Add("");
            if (cmbFunction.Items.Count == 0)
                cmbFunction.Items.Add("");
            if (cmbPackage.Items.Count == 0)
                cmbPackage.Items.Add("");
            if (cmbTable.Items.Count == 0)
                cmbTable.Items.Add("");

            cmbProcedure.SelectedIndex = 0;
            cmbFunction.SelectedIndex = 0;
            cmbPackage.SelectedIndex = 0;
            cmbTable.SelectedIndex = 0;
        }

        void Load_pro_user(string userowner)
        {
            Clear_Combobox();

            OracleDataReader read_pro = p.Get_Procedure_User(userowner, "PROCEDURE");
            while (read_pro.Read())
            {
                cmbProcedure.Items.Add(read_pro[0].ToString());
            }
            read_pro.Close();

            OracleDataReader read_fun = p.Get_Procedure_User(userowner, "FUNCTION");
            while (read_fun.Read())
            {
                cmbFunction.Items.Add(read_fun[0].ToString());
            }
            read_fun.Close();

            OracleDataReader read_pack = p.Get_Procedure_User(userowner, "PACKAGE");
            while (read_pack.Read())
            {
                cmbPackage.Items.Add(read_pack[0].ToString());
            }
            read_pack.Close();

            OracleDataReader read_tab = p.Get_Table_User(userowner);
            while (read_tab.Read())
            {
                cmbTable.Items.Add(read_tab[0].ToString());
            }
            read_tab.Close();

            Select_Combobox();
        }
        void Load_Roles_User(string user)
        {
            dtgRoles.DataSource = p.Get_Roles_User(user);
        }

        void Load_Grant_User(string user)
        {
            dtgGrant.DataSource = p.Get_Grant_User(user);
        }

        void Load_Grant_Roles(string roles)
        {
            dtgGrantRoles.DataSource = p.Get_Grant_User(roles);
        }

        void Load_Grant_Table_User(string user, string userschema, string table)
        {
            OracleDataReader read = p.Get_Grant(user, userschema, table);
            bool select, insert, update, delete;
            select = insert = update = delete = false;
            while (read.Read())
            {
                string r = read[0].ToString();

                if (r.Equals("SELECT"))
                    select = true;

                if (r.Equals("INSERT"))
                    insert = true;

                if (r.Equals("UPDATE"))
                    update = true;

                if (r.Equals("DELETE"))
                    delete = true;

            }
            cbSelectUs.Checked = select;
            cbInsertUs.Checked = insert;
            cbUpdateUs.Checked = update;
            cbDeleteUs.Checked = delete;
        }

        void Load_Grant_Table_Roles(string roles, string userschema, string table)
        {
            OracleDataReader read = p.Get_Grant(roles, userschema, table);
            bool select, insert, update, delete;
            select = insert = update = delete = false;
            while (read.Read())
            {
                string r = read[0].ToString();

                if (r.Equals("SELECT"))
                    select = true;

                if (r.Equals("INSERT"))
                    insert = true;

                if (r.Equals("UPDATE"))
                    update = true;

                if (r.Equals("DELETE"))
                    delete = true;

            }
            cbSelectRo.Checked = select;
            cbInsertRo.Checked = insert;
            cbUpdateRo.Checked = update;
            cbDeleteRo.Checked = delete;
        }

        bool Load_Execute(string user_roles, string userschema, string pro)
        {
            OracleDataReader read = p.Get_Grant(user_roles, userschema, pro);
            bool execute = false;
            while (read.Read())
            {
                if (read[0].ToString().Equals("EXECUTE"))
                    execute = true;
            }
            return execute;
        }

        private void cmbUser_SelectedIndexChanged(object sender, EventArgs e)
        {
            string userowner = cmbUser.SelectedItem.ToString();
            Load_pro_user(userowner);
        }

        private void cmbUsername_SelectedIndexChanged(object sender, EventArgs e)
        {
            string user = cmbUsername.SelectedItem.ToString();
            string userschema = cmbUser.SelectedItem.ToString();
            Load_Roles_User(user);
            Load_Grant_User(user);
            lbUser.Text = "User: " + user;

            if (cmbTable.SelectedItem != null)
            {
                string table = cmbTable.SelectedItem.ToString();

                Load_Grant_Table_User(user, userschema, table);
                set_Color_Checkbox_user();
            }

            if (cmbProcedure.SelectedItem != null)
            {
                string procedure = cmbProcedure.SelectedItem.ToString();
                cbUserPro.Checked = Load_Execute(user, userschema, procedure);
            }

            if (cmbFunction.SelectedItem != null)
            {
                string function = cmbFunction.SelectedItem.ToString();
                cbUserFun.Checked = Load_Execute(user, userschema, function);
            }

            if (cmbPackage.SelectedItem != null)
            {
                string package = cmbPackage.SelectedItem.ToString();
                cbUserPk.Checked = Load_Execute(user, userschema, package);
            }

            if (cmbRoles.SelectedItem != null)
            {
                string role = cmbRoles.SelectedItem.ToString();
                Set_Text_Button(user, role);
            }
            set_Color_Grant_User();

        }

        private void cmbRoles_SelectedIndexChanged(object sender, EventArgs e)
        {
            string userschema = cmbUser.SelectedItem.ToString();
            string role = cmbRoles.SelectedItem.ToString();
            Load_Grant_Roles(role);

            if (cmbTable.SelectedItem != null)
            {
                string table = cmbTable.SelectedItem.ToString();

                Load_Grant_Table_Roles(role, userschema, table);
                set_Color_Checkbox_roles();
            }

            if (cmbProcedure.SelectedItem != null)
            {
                string procedure = cmbProcedure.SelectedItem.ToString();
                cbRolesPro.Checked = Load_Execute(role, userschema, procedure);
            }

            if (cmbFunction.SelectedItem != null)
            {
                string function = cmbFunction.SelectedItem.ToString();
                cbRolesFun.Checked = Load_Execute(role, userschema, function);
            }

            if (cmbPackage.SelectedItem != null)
            {
                string package = cmbPackage.SelectedItem.ToString();
                cbRolesPk.Checked = Load_Execute(role, userschema, package);
            }

            if (cmbUsername.SelectedItem != null)
            {
                string user = cmbUsername.SelectedItem.ToString();
                Set_Text_Button(user, role);
            }
            set_Color_Grant_Roles();

        }

        private void cmbProcedure_SelectedIndexChanged(object sender, EventArgs e)
        {
            string procedure = cmbProcedure.SelectedItem.ToString();
            string userschema = cmbUser.SelectedItem.ToString();

            if (cmbUsername.SelectedItem != null)
            {
                string user = cmbUsername.SelectedItem.ToString();
                cbUserPro.Checked = Load_Execute(user, userschema, procedure);
            }

            if (cmbRoles.SelectedItem != null)
            {
                string role = cmbRoles.SelectedItem.ToString();
                cbRolesPro.Checked = Load_Execute(role, userschema, procedure);
            }

            set_Color_Grant_Roles();
            set_Color_Grant_User();

        }

        private void cmbFunction_SelectedIndexChanged(object sender, EventArgs e)
        {
            string function = cmbFunction.SelectedItem.ToString();
            string userschema = cmbUser.SelectedItem.ToString();

            if (cmbUsername.SelectedItem != null)
            {
                string user = cmbUsername.SelectedItem.ToString();
                cbUserFun.Checked = Load_Execute(user, userschema, function);
            }

            if (cmbRoles.SelectedItem != null)
            {
                string role = cmbRoles.SelectedItem.ToString();
                cbRolesFun.Checked = Load_Execute(role, userschema, function);
            }

            set_Color_Grant_Roles();
            set_Color_Grant_User();

        }

        private void cmbPackage_SelectedIndexChanged(object sender, EventArgs e)
        {
            string package = cmbPackage.SelectedItem.ToString();
            string userschema = cmbUser.SelectedItem.ToString();

            if (cmbUsername.SelectedItem != null)
            {
                string user = cmbUsername.SelectedItem.ToString();
                cbUserPk.Checked = Load_Execute(user, userschema, package);
            }

            if (cmbRoles.SelectedItem != null)
            {
                string role = cmbRoles.SelectedItem.ToString();
                cbRolesPk.Checked = Load_Execute(role, userschema, package);
            }

            set_Color_Grant_Roles();
            set_Color_Grant_User();
        }

        bool Grant_Revoke_pro(string user_roles, string schema, string pro_tab, string type_user, string type_pro_tab, string type, bool grant_revoke)
        {
            if (pro_tab.Equals(""))
            {
                MessageBox.Show("Mục " + type_pro_tab + " trống!");
                return false;
            }
            if (user_roles.Equals(""))
            {
                MessageBox.Show("Mục " + type_user + " trống!");
                return false;
            }

            int dk;
            DialogResult res;
            if (grant_revoke)
            {
                dk = 1;
                res = MessageBox.Show("Bạn muốn gán quyền " + type + " " + type_pro_tab + ": "
                                + pro_tab + " cho " + type_user + ": " + user_roles + " không?", "Thông báo", MessageBoxButtons.YesNo);
            }
            else
            {
                dk = 0;
                res = MessageBox.Show("Bạn muốn hủy quyền " + type + " " + type_pro_tab + ": "
                                + pro_tab + " cho " + type_user + ": " + user_roles + " không?", "Thông báo", MessageBoxButtons.YesNo);
            }

            if (res == DialogResult.Yes)
            {
                if (p.Grant_Revoke_Pro(user_roles, schema, pro_tab, type, dk))
                {
                    if (grant_revoke)
                        MessageBox.Show("Gán quyền thành công");
                    else
                        MessageBox.Show("Thu hồi quyền thành công");
                }
                else
                    return false;

                return true;
            }
            else
                return false;
        }

        bool Grant_Revoke_Role(string user, string role, int dk)
        {
            if (user.Equals(""))
            {
                MessageBox.Show("Mục User trống!");
                return false;
            }

            if (role.Equals(""))
            {
                MessageBox.Show("Mục Role trống!");
                return false;
            }

            DialogResult res;
            if (dk == 1)
            {
                res = MessageBox.Show("Bạn muốn gán Role: " + role + " vào User: " + user + " không?", "Thông báo", MessageBoxButtons.YesNo);
            }
            else
            {
                res = MessageBox.Show("Bạn muốn thu hồi Role: " + role + " khỏi User: " + user + " không?", "Thông báo", MessageBoxButtons.YesNo);
            }

            if (res == DialogResult.Yes)
            {
                if (p.Grant_Revoke_Role(user, role, dk))
                {
                    if (dk == 1)
                        MessageBox.Show("Gán nhóm quyền thành công");
                    else
                        MessageBox.Show("Thu hồi nhóm quyền thành công");
                }
                else
                    return false;

                return true;
            }
            else
                return false;
        }

        void Grant_Revoke_Pro_User(ComboBox cmb, CheckBox c, string pro)
        {
            bool check = c.Checked;
            string procedure = cmb.SelectedItem.ToString();
            string user = cmbUsername.SelectedItem.ToString();
            string schema = cmbUser.SelectedItem.ToString();
            if (Grant_Revoke_pro(user, schema, procedure, "User", pro, "Execute", check))
            {
                set_Color_Grant_User();
                Load_Grant_User(user);
            }
            else
                c.Checked = !check;
        }

        void Grant_Revoke_Pro_Role(ComboBox cmb, CheckBox c, string pro)
        {
            bool check = c.Checked;
            string procedure = cmb.SelectedItem.ToString();
            string role = cmbRoles.SelectedItem.ToString();
            string schema = cmbUser.SelectedItem.ToString();
            if (Grant_Revoke_pro(role, schema, procedure, "Role", pro, "Execute", check))
            {
                set_Color_Grant_Roles();
                Load_Grant_Roles(role);
            }
            else
                c.Checked = !check;
        }

        void Grant_Revoke_Table_User(CheckBox c, string type)
        {
            bool check = c.Checked;
            string table = cmbTable.SelectedItem.ToString();
            string user = cmbUsername.SelectedItem.ToString();
            string schema = cmbUser.SelectedItem.ToString();
            if (Grant_Revoke_pro(user, schema, table, "User", "Table", type, check))
                set_Color_Checkbox_user();
            else
                c.Checked = !check;
        }

        void Grant_Revoke_Table_Role(CheckBox c, string type)
        {
            bool check = c.Checked;
            string table = cmbTable.SelectedItem.ToString();
            string role = cmbRoles.SelectedItem.ToString();
            string schema = cmbUser.SelectedItem.ToString();
            if (Grant_Revoke_pro(role, schema, table, "Role", "Table", type, check))
                set_Color_Checkbox_roles();
            else
                c.Checked = !check;
        }

        private void cbUserPro_CheckedChanged(object sender, EventArgs e)
        {
            Grant_Revoke_Pro_User(cmbProcedure, cbUserPro, "Procedure");
        }

        private void cbRolesPro_CheckedChanged(object sender, EventArgs e)
        {
            Grant_Revoke_Pro_Role(cmbProcedure, cbRolesPro, "Procedure");

        }

        private void cbUserFun_CheckedChanged(object sender, EventArgs e)
        {
            Grant_Revoke_Pro_User(cmbFunction, cbUserFun, "Function");

        }

        private void cbRolesFun_CheckedChanged(object sender, EventArgs e)
        {
            Grant_Revoke_Pro_Role(cmbFunction, cbRolesFun, "Function");

        }

        private void cbUserPk_CheckedChanged(object sender, EventArgs e)
        {
            Grant_Revoke_Pro_User(cmbPackage, cbUserPk, "Package");

        }

        private void cbRolesPk_CheckedChanged(object sender, EventArgs e)
        {
            Grant_Revoke_Pro_Role(cmbPackage, cbRolesPk, "Package");

        }

        private void cbSelectUs_CheckedChanged(object sender, EventArgs e)
        {
            Grant_Revoke_Table_User(cbSelectUs, "Select");
        }

        private void cbInsertUs_CheckedChanged(object sender, EventArgs e)
        {
            Grant_Revoke_Table_User(cbInsertUs, "Insert");

        }

        private void cbUpdateUs_CheckedChanged(object sender, EventArgs e)
        {
            Grant_Revoke_Table_User(cbUpdateUs, "Update");
        }

        private void cbDeleteUs_CheckedChanged(object sender, EventArgs e)
        {
            Grant_Revoke_Table_User(cbDeleteUs, "Delete");
        }

        private void cbSelectRo_CheckedChanged(object sender, EventArgs e)
        {
            Grant_Revoke_Table_Role(cbSelectRo, "Select");
        }

        private void cbInsertRo_CheckedChanged(object sender, EventArgs e)
        {
            Grant_Revoke_Table_Role(cbInsertRo, "Insert");
        }

        private void cbUpdateRo_CheckedChanged(object sender, EventArgs e)
        {
            Grant_Revoke_Table_Role(cbUpdateRo, "Update");
        }

        private void cbDeleteRo_CheckedChanged(object sender, EventArgs e)
        {
            Grant_Revoke_Table_Role(cbDeleteRo, "Delete");
        }

        private void btnGrantRevokeRole_Click(object sender, EventArgs e)
        {
            string user = cmbUsername.SelectedItem.ToString();
            string role = cmbRoles.SelectedItem.ToString();
            int dk;
            if (btnGrantRevokeRole.Text.Equals("Grant"))
            {
                dk = 1;
            }
            else
            {
                dk = 0;
            }

            if (Grant_Revoke_Role(user, role, dk))
            {
                Set_Text_Button(user, role);
                Load_Roles_User(user);
            }

        }
    }
}
