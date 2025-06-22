namespace DOAN.F_MAIN
{
    partial class fGrantGUI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            label1 = new Label();
            panel2 = new Panel();
            label4 = new Label();
            label3 = new Label();
            label5 = new Label();
            label6 = new Label();
            label2 = new Label();
            cbRolesFun = new CheckBox();
            cbRolesPk = new CheckBox();
            cbUserPk = new CheckBox();
            cbUserFun = new CheckBox();
            cbRolesPro = new CheckBox();
            cbUserPro = new CheckBox();
            cmbProcedure = new ComboBox();
            cmbPackage = new ComboBox();
            cmbFunction = new ComboBox();
            cmbTable = new ComboBox();
            cmbUser = new ComboBox();
            panel3 = new Panel();
            dtgGrantRoles = new DataGridView();
            btnGrantRevokeRole = new Button();
            label7 = new Label();
            lbTableRoles = new Label();
            lbUser = new Label();
            label10 = new Label();
            cbDeleteRo = new CheckBox();
            cbUpdateRo = new CheckBox();
            cbInsertRo = new CheckBox();
            cbSelectRo = new CheckBox();
            cmbRoles = new ComboBox();
            panel4 = new Panel();
            dtgRoles = new DataGridView();
            dtgGrant = new DataGridView();
            label9 = new Label();
            lbTableUser = new Label();
            label8 = new Label();
            label11 = new Label();
            cbDeleteUs = new CheckBox();
            cmbUsername = new ComboBox();
            cbUpdateUs = new CheckBox();
            cbSelectUs = new CheckBox();
            cbInsertUs = new CheckBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgGrantRoles).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgRoles).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dtgGrant).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Location = new Point(230, 14);
            panel1.Margin = new Padding(4, 5, 4, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(852, 74);
            panel1.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Courier New", 27.75F, FontStyle.Bold);
            label1.ImeMode = ImeMode.NoControl;
            label1.Location = new Point(127, 10);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(611, 53);
            label1.TabIndex = 0;
            label1.Text = "Phân quyền người dùng";
            // 
            // panel2
            // 
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(cbRolesFun);
            panel2.Controls.Add(cbRolesPk);
            panel2.Controls.Add(cbUserPk);
            panel2.Controls.Add(cbUserFun);
            panel2.Controls.Add(cbRolesPro);
            panel2.Controls.Add(cbUserPro);
            panel2.Controls.Add(cmbProcedure);
            panel2.Controls.Add(cmbPackage);
            panel2.Controls.Add(cmbFunction);
            panel2.Controls.Add(cmbTable);
            panel2.Controls.Add(cmbUser);
            panel2.Location = new Point(13, 98);
            panel2.Margin = new Padding(4, 5, 4, 5);
            panel2.Name = "panel2";
            panel2.Size = new Size(865, 273);
            panel2.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Courier New", 12F, FontStyle.Bold);
            label4.Location = new Point(582, 62);
            label4.Name = "label4";
            label4.Size = new Size(94, 23);
            label4.TabIndex = 20;
            label4.Text = "Package";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Courier New", 12F, FontStyle.Bold);
            label3.Location = new Point(296, 62);
            label3.Name = "label3";
            label3.Size = new Size(106, 23);
            label3.TabIndex = 21;
            label3.Text = "Function";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Courier New", 12F, FontStyle.Bold);
            label5.Location = new Point(3, 62);
            label5.Name = "label5";
            label5.Size = new Size(118, 23);
            label5.TabIndex = 22;
            label5.Text = "Procedure";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Courier New", 12F, FontStyle.Bold);
            label6.Location = new Point(286, 185);
            label6.Name = "label6";
            label6.Size = new Size(70, 23);
            label6.TabIndex = 23;
            label6.Text = "Table";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Courier New", 12F, FontStyle.Bold);
            label2.Location = new Point(3, 15);
            label2.Name = "label2";
            label2.Size = new Size(58, 23);
            label2.TabIndex = 23;
            label2.Text = "User";
            // 
            // cbRolesFun
            // 
            cbRolesFun.AutoSize = true;
            cbRolesFun.Font = new Font("Courier New", 10F);
            cbRolesFun.Location = new Point(433, 136);
            cbRolesFun.Name = "cbRolesFun";
            cbRolesFun.Size = new Size(141, 24);
            cbRolesFun.TabIndex = 16;
            cbRolesFun.Text = "Grant Roles";
            cbRolesFun.UseVisualStyleBackColor = true;
            cbRolesFun.CheckedChanged += cbRolesFun_CheckedChanged;
            // 
            // cbRolesPk
            // 
            cbRolesPk.AutoSize = true;
            cbRolesPk.Font = new Font("Courier New", 10F);
            cbRolesPk.Location = new Point(719, 136);
            cbRolesPk.Name = "cbRolesPk";
            cbRolesPk.Size = new Size(141, 24);
            cbRolesPk.TabIndex = 17;
            cbRolesPk.Text = "Grant Roles";
            cbRolesPk.UseVisualStyleBackColor = true;
            cbRolesPk.CheckedChanged += cbRolesPk_CheckedChanged;
            // 
            // cbUserPk
            // 
            cbUserPk.AutoSize = true;
            cbUserPk.Font = new Font("Courier New", 10F);
            cbUserPk.Location = new Point(582, 136);
            cbUserPk.Name = "cbUserPk";
            cbUserPk.Size = new Size(131, 24);
            cbUserPk.TabIndex = 17;
            cbUserPk.Text = "Grant User";
            cbUserPk.UseVisualStyleBackColor = true;
            cbUserPk.CheckedChanged += cbUserPk_CheckedChanged;
            // 
            // cbUserFun
            // 
            cbUserFun.AutoSize = true;
            cbUserFun.Font = new Font("Courier New", 10F);
            cbUserFun.Location = new Point(296, 136);
            cbUserFun.Name = "cbUserFun";
            cbUserFun.Size = new Size(131, 24);
            cbUserFun.TabIndex = 17;
            cbUserFun.Text = "Grant User";
            cbUserFun.UseVisualStyleBackColor = true;
            cbUserFun.CheckedChanged += cbUserFun_CheckedChanged;
            // 
            // cbRolesPro
            // 
            cbRolesPro.AutoSize = true;
            cbRolesPro.Font = new Font("Courier New", 10F);
            cbRolesPro.Location = new Point(140, 136);
            cbRolesPro.Name = "cbRolesPro";
            cbRolesPro.Size = new Size(141, 24);
            cbRolesPro.TabIndex = 15;
            cbRolesPro.Text = "Grant Roles";
            cbRolesPro.UseVisualStyleBackColor = true;
            cbRolesPro.CheckedChanged += cbRolesPro_CheckedChanged;
            // 
            // cbUserPro
            // 
            cbUserPro.AutoSize = true;
            cbUserPro.Font = new Font("Courier New", 10F);
            cbUserPro.Location = new Point(3, 136);
            cbUserPro.Name = "cbUserPro";
            cbUserPro.Size = new Size(131, 24);
            cbUserPro.TabIndex = 14;
            cbUserPro.Text = "Grant User";
            cbUserPro.UseVisualStyleBackColor = true;
            cbUserPro.CheckedChanged += cbUserPro_CheckedChanged;
            // 
            // cmbProcedure
            // 
            cmbProcedure.Font = new Font("Courier New", 12F);
            cmbProcedure.FormattingEnabled = true;
            cmbProcedure.Location = new Point(3, 88);
            cmbProcedure.Name = "cmbProcedure";
            cmbProcedure.Size = new Size(278, 30);
            cmbProcedure.TabIndex = 13;
            cmbProcedure.SelectedIndexChanged += cmbProcedure_SelectedIndexChanged;
            // 
            // cmbPackage
            // 
            cmbPackage.Font = new Font("Courier New", 12F);
            cmbPackage.FormattingEnabled = true;
            cmbPackage.Location = new Point(582, 88);
            cmbPackage.Name = "cmbPackage";
            cmbPackage.Size = new Size(280, 30);
            cmbPackage.TabIndex = 12;
            cmbPackage.SelectedIndexChanged += cmbPackage_SelectedIndexChanged;
            // 
            // cmbFunction
            // 
            cmbFunction.Font = new Font("Courier New", 12F);
            cmbFunction.FormattingEnabled = true;
            cmbFunction.Location = new Point(296, 88);
            cmbFunction.Name = "cmbFunction";
            cmbFunction.Size = new Size(278, 30);
            cmbFunction.TabIndex = 11;
            cmbFunction.SelectedIndexChanged += cmbFunction_SelectedIndexChanged;
            // 
            // cmbTable
            // 
            cmbTable.Font = new Font("Courier New", 12F);
            cmbTable.FormattingEnabled = true;
            cmbTable.Location = new Point(286, 211);
            cmbTable.Name = "cmbTable";
            cmbTable.Size = new Size(288, 30);
            cmbTable.TabIndex = 10;
            // 
            // cmbUser
            // 
            cmbUser.Font = new Font("Courier New", 12F);
            cmbUser.FormattingEnabled = true;
            cmbUser.Location = new Point(67, 12);
            cmbUser.Name = "cmbUser";
            cmbUser.Size = new Size(196, 30);
            cmbUser.TabIndex = 10;
            cmbUser.SelectedIndexChanged += cmbUser_SelectedIndexChanged;
            // 
            // panel3
            // 
            panel3.Controls.Add(dtgGrantRoles);
            panel3.Controls.Add(btnGrantRevokeRole);
            panel3.Controls.Add(label7);
            panel3.Controls.Add(lbTableRoles);
            panel3.Controls.Add(lbUser);
            panel3.Controls.Add(label10);
            panel3.Controls.Add(cbDeleteRo);
            panel3.Controls.Add(cbUpdateRo);
            panel3.Controls.Add(cbInsertRo);
            panel3.Controls.Add(cbSelectRo);
            panel3.Controls.Add(cmbRoles);
            panel3.Location = new Point(880, 98);
            panel3.Margin = new Padding(4, 5, 4, 5);
            panel3.Name = "panel3";
            panel3.Size = new Size(525, 712);
            panel3.TabIndex = 10;
            // 
            // dtgGrantRoles
            // 
            dtgGrantRoles.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgGrantRoles.Location = new Point(3, 283);
            dtgGrantRoles.Name = "dtgGrantRoles";
            dtgGrantRoles.RowHeadersWidth = 51;
            dtgGrantRoles.Size = new Size(514, 426);
            dtgGrantRoles.TabIndex = 35;
            // 
            // btnGrantRevokeRole
            // 
            btnGrantRevokeRole.Font = new Font("Courier New", 12F);
            btnGrantRevokeRole.Location = new Point(8, 198);
            btnGrantRevokeRole.Name = "btnGrantRevokeRole";
            btnGrantRevokeRole.Size = new Size(160, 55);
            btnGrantRevokeRole.TabIndex = 19;
            btnGrantRevokeRole.Text = "Cấp quyền";
            btnGrantRevokeRole.UseVisualStyleBackColor = true;
            btnGrantRevokeRole.Click += btnGrantRevokeRole_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Courier New", 12F, FontStyle.Bold);
            label7.Location = new Point(207, 250);
            label7.Name = "label7";
            label7.Size = new Size(70, 23);
            label7.TabIndex = 31;
            label7.Text = "Grant";
            // 
            // lbTableRoles
            // 
            lbTableRoles.AutoSize = true;
            lbTableRoles.Font = new Font("Courier New", 12F, FontStyle.Bold);
            lbTableRoles.Location = new Point(8, 82);
            lbTableRoles.Name = "lbTableRoles";
            lbTableRoles.Size = new Size(70, 23);
            lbTableRoles.TabIndex = 32;
            lbTableRoles.Text = "Table";
            // 
            // lbUser
            // 
            lbUser.AutoSize = true;
            lbUser.Font = new Font("Courier New", 12F, FontStyle.Bold);
            lbUser.Location = new Point(8, 169);
            lbUser.Name = "lbUser";
            lbUser.Size = new Size(58, 23);
            lbUser.TabIndex = 33;
            lbUser.Text = "User";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Courier New", 12F, FontStyle.Bold);
            label10.Location = new Point(8, 35);
            label10.Name = "label10";
            label10.Size = new Size(70, 23);
            label10.TabIndex = 34;
            label10.Text = "Roles";
            // 
            // cbDeleteRo
            // 
            cbDeleteRo.AutoSize = true;
            cbDeleteRo.Font = new Font("Courier New", 10F);
            cbDeleteRo.Location = new Point(390, 126);
            cbDeleteRo.Name = "cbDeleteRo";
            cbDeleteRo.Size = new Size(91, 24);
            cbDeleteRo.TabIndex = 29;
            cbDeleteRo.Text = "Delete";
            cbDeleteRo.UseVisualStyleBackColor = true;
            cbDeleteRo.CheckedChanged += cbDeleteRo_CheckedChanged;
            // 
            // cbUpdateRo
            // 
            cbUpdateRo.AutoSize = true;
            cbUpdateRo.Font = new Font("Courier New", 10F);
            cbUpdateRo.Location = new Point(270, 126);
            cbUpdateRo.Name = "cbUpdateRo";
            cbUpdateRo.Size = new Size(91, 24);
            cbUpdateRo.TabIndex = 30;
            cbUpdateRo.Text = "Update";
            cbUpdateRo.UseVisualStyleBackColor = true;
            cbUpdateRo.CheckedChanged += cbUpdateRo_CheckedChanged;
            // 
            // cbInsertRo
            // 
            cbInsertRo.AutoSize = true;
            cbInsertRo.Font = new Font("Courier New", 10F);
            cbInsertRo.Location = new Point(141, 126);
            cbInsertRo.Name = "cbInsertRo";
            cbInsertRo.Size = new Size(91, 24);
            cbInsertRo.TabIndex = 28;
            cbInsertRo.Text = "Insert";
            cbInsertRo.UseVisualStyleBackColor = true;
            cbInsertRo.CheckedChanged += cbInsertRo_CheckedChanged;
            // 
            // cbSelectRo
            // 
            cbSelectRo.AutoSize = true;
            cbSelectRo.Font = new Font("Courier New", 10F);
            cbSelectRo.Location = new Point(8, 126);
            cbSelectRo.Name = "cbSelectRo";
            cbSelectRo.Size = new Size(91, 24);
            cbSelectRo.TabIndex = 27;
            cbSelectRo.Text = "Select";
            cbSelectRo.UseVisualStyleBackColor = true;
            cbSelectRo.CheckedChanged += cbSelectRo_CheckedChanged;
            // 
            // cmbRoles
            // 
            cmbRoles.Font = new Font("Courier New", 12F);
            cmbRoles.FormattingEnabled = true;
            cmbRoles.Location = new Point(90, 32);
            cmbRoles.Name = "cmbRoles";
            cmbRoles.Size = new Size(278, 30);
            cmbRoles.TabIndex = 24;
            cmbRoles.SelectedIndexChanged += cmbRoles_SelectedIndexChanged;
            // 
            // panel4
            // 
            panel4.Controls.Add(dtgRoles);
            panel4.Controls.Add(dtgGrant);
            panel4.Controls.Add(label9);
            panel4.Controls.Add(lbTableUser);
            panel4.Controls.Add(label8);
            panel4.Controls.Add(label11);
            panel4.Controls.Add(cbDeleteUs);
            panel4.Controls.Add(cmbUsername);
            panel4.Controls.Add(cbUpdateUs);
            panel4.Controls.Add(cbSelectUs);
            panel4.Controls.Add(cbInsertUs);
            panel4.Location = new Point(13, 381);
            panel4.Margin = new Padding(4, 5, 4, 5);
            panel4.Name = "panel4";
            panel4.Size = new Size(865, 429);
            panel4.TabIndex = 10;
            // 
            // dtgRoles
            // 
            dtgRoles.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgRoles.Location = new Point(125, 129);
            dtgRoles.Name = "dtgRoles";
            dtgRoles.RowHeadersWidth = 51;
            dtgRoles.Size = new Size(260, 297);
            dtgRoles.TabIndex = 35;
            // 
            // dtgGrant
            // 
            dtgGrant.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgGrant.Location = new Point(391, 37);
            dtgGrant.Name = "dtgGrant";
            dtgGrant.RowHeadersWidth = 51;
            dtgGrant.Size = new Size(469, 389);
            dtgGrant.TabIndex = 35;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Courier New", 12F, FontStyle.Bold);
            label9.Location = new Point(217, 100);
            label9.Name = "label9";
            label9.Size = new Size(70, 23);
            label9.TabIndex = 31;
            label9.Text = "Roles";
            // 
            // lbTableUser
            // 
            lbTableUser.AutoSize = true;
            lbTableUser.Font = new Font("Courier New", 12F, FontStyle.Bold);
            lbTableUser.Location = new Point(3, 72);
            lbTableUser.Name = "lbTableUser";
            lbTableUser.Size = new Size(70, 23);
            lbTableUser.TabIndex = 32;
            lbTableUser.Text = "Table";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Courier New", 12F, FontStyle.Bold);
            label8.Location = new Point(569, 11);
            label8.Name = "label8";
            label8.Size = new Size(70, 23);
            label8.TabIndex = 31;
            label8.Text = "Grant";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Courier New", 12F, FontStyle.Bold);
            label11.Location = new Point(3, 29);
            label11.Name = "label11";
            label11.Size = new Size(58, 23);
            label11.TabIndex = 23;
            label11.Text = "User";
            // 
            // cbDeleteUs
            // 
            cbDeleteUs.AutoSize = true;
            cbDeleteUs.Font = new Font("Courier New", 10F);
            cbDeleteUs.Location = new Point(13, 245);
            cbDeleteUs.Name = "cbDeleteUs";
            cbDeleteUs.Size = new Size(91, 24);
            cbDeleteUs.TabIndex = 29;
            cbDeleteUs.Text = "Delete";
            cbDeleteUs.UseVisualStyleBackColor = true;
            cbDeleteUs.CheckedChanged += cbDeleteUs_CheckedChanged;
            // 
            // cmbUsername
            // 
            cmbUsername.Font = new Font("Courier New", 12F);
            cmbUsername.FormattingEnabled = true;
            cmbUsername.Location = new Point(67, 26);
            cmbUsername.Name = "cmbUsername";
            cmbUsername.Size = new Size(289, 30);
            cmbUsername.TabIndex = 10;
            cmbUsername.SelectedIndexChanged += cmbUsername_SelectedIndexChanged;
            // 
            // cbUpdateUs
            // 
            cbUpdateUs.AutoSize = true;
            cbUpdateUs.Font = new Font("Courier New", 10F);
            cbUpdateUs.Location = new Point(13, 205);
            cbUpdateUs.Name = "cbUpdateUs";
            cbUpdateUs.Size = new Size(91, 24);
            cbUpdateUs.TabIndex = 30;
            cbUpdateUs.Text = "Update";
            cbUpdateUs.UseVisualStyleBackColor = true;
            cbUpdateUs.CheckedChanged += cbUpdateUs_CheckedChanged;
            // 
            // cbSelectUs
            // 
            cbSelectUs.AutoSize = true;
            cbSelectUs.Font = new Font("Courier New", 10F);
            cbSelectUs.Location = new Point(13, 121);
            cbSelectUs.Name = "cbSelectUs";
            cbSelectUs.Size = new Size(91, 24);
            cbSelectUs.TabIndex = 27;
            cbSelectUs.Text = "Select";
            cbSelectUs.UseVisualStyleBackColor = true;
            cbSelectUs.CheckedChanged += cbSelectUs_CheckedChanged;
            // 
            // cbInsertUs
            // 
            cbInsertUs.AutoSize = true;
            cbInsertUs.Font = new Font("Courier New", 10F);
            cbInsertUs.Location = new Point(13, 164);
            cbInsertUs.Name = "cbInsertUs";
            cbInsertUs.Size = new Size(91, 24);
            cbInsertUs.TabIndex = 28;
            cbInsertUs.Text = "Insert";
            cbInsertUs.UseVisualStyleBackColor = true;
            cbInsertUs.CheckedChanged += cbInsertUs_CheckedChanged;
            // 
            // fGrantGUI
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1418, 852);
            Controls.Add(panel3);
            Controls.Add(panel4);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "fGrantGUI";
            Text = "fGraintGUI";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtgGrantRoles).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtgRoles).EndInit();
            ((System.ComponentModel.ISupportInitialize)dtgGrant).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Label label4;
        private Label label3;
        private Label label5;
        private Label label2;
        private CheckBox cbRolesFun;
        private CheckBox cbUserFun;
        private CheckBox cbRolesPro;
        private CheckBox cbUserPro;
        private ComboBox cmbProcedure;
        private ComboBox cmbPackage;
        private ComboBox cmbFunction;
        private ComboBox cmbUser;
        private Label label6;
        private CheckBox cbRolesPk;
        private CheckBox cbUserPk;
        private ComboBox cmbTable;
        private Label label7;
        private Label lbTableRoles;
        private Label lbUser;
        private Label label10;
        private CheckBox cbDeleteRo;
        private CheckBox cbUpdateRo;
        private CheckBox cbInsertRo;
        private CheckBox cbSelectRo;
        private ComboBox cmbRoles;
        private DataGridView dtgGrantRoles;
        private Button btnGrantRevokeRole;
        private DataGridView dtgRoles;
        private DataGridView dtgGrant;
        private Label label9;
        private Label lbTableUser;
        private Label label8;
        private Label label11;
        private ComboBox cmbUsername;
        private CheckBox cbDeleteUs;
        private CheckBox cbUpdateUs;
        private CheckBox cbSelectUs;
        private CheckBox cbInsertUs;
    }
}