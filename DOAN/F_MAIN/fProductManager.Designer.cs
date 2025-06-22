namespace DOAN
{
    partial class fProductManager
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
            tabControl1 = new TabControl();
            tabProduct = new TabPage();
            button1 = new Button();
            btnDesCipher = new Button();
            btnMultiCipher = new Button();
            btnCeasarCipher = new Button();
            btnCallRSA = new Button();
            nmrQuantity = new NumericUpDown();
            nmrPrice = new NumericUpDown();
            txbProductCategory = new TextBox();
            txbProductName = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnEditProduct = new Button();
            btnDeleteProduct = new Button();
            btnAddProduct = new Button();
            dtgvProduct = new DataGridView();
            tabBill = new TabPage();
            txbBillAccountID = new TextBox();
            label7 = new Label();
            nmrBillProductQuantity = new NumericUpDown();
            txbBillProductID = new TextBox();
            txbBillID = new TextBox();
            label5 = new Label();
            label6 = new Label();
            label8 = new Label();
            btnEditBill = new Button();
            btnDeleteBill = new Button();
            btnAddBill = new Button();
            dtgvBill = new DataGridView();
            tabAccount = new TabPage();
            button2 = new Button();
            btnGrPolicy = new Button();
            btnPolicy = new Button();
            btnGrant = new Button();
            txbAccountName = new TextBox();
            label12 = new Label();
            txbAccountID = new TextBox();
            label13 = new Label();
            label11 = new Label();
            txbAccountAddress = new TextBox();
            txbAccountPhone = new TextBox();
            label9 = new Label();
            label10 = new Label();
            btnLogout = new Button();
            btnEditAccount = new Button();
            btnDeleteAccount = new Button();
            dtgvAccount = new DataGridView();
            btnAudit = new Button();
            tabControl1.SuspendLayout();
            tabProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nmrQuantity).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nmrPrice).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dtgvProduct).BeginInit();
            tabBill.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nmrBillProductQuantity).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dtgvBill).BeginInit();
            tabAccount.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvAccount).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabProduct);
            tabControl1.Controls.Add(tabBill);
            tabControl1.Controls.Add(tabAccount);
            tabControl1.Font = new Font("Courier New", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tabControl1.Location = new Point(19, 14);
            tabControl1.Margin = new Padding(4, 5, 4, 5);
            tabControl1.Multiline = true;
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1515, 884);
            tabControl1.TabIndex = 0;
            tabControl1.Tag = "a";
            // 
            // tabProduct
            // 
            tabProduct.Controls.Add(button1);
            tabProduct.Controls.Add(btnDesCipher);
            tabProduct.Controls.Add(btnMultiCipher);
            tabProduct.Controls.Add(btnCeasarCipher);
            tabProduct.Controls.Add(btnCallRSA);
            tabProduct.Controls.Add(nmrQuantity);
            tabProduct.Controls.Add(nmrPrice);
            tabProduct.Controls.Add(txbProductCategory);
            tabProduct.Controls.Add(txbProductName);
            tabProduct.Controls.Add(label4);
            tabProduct.Controls.Add(label3);
            tabProduct.Controls.Add(label2);
            tabProduct.Controls.Add(label1);
            tabProduct.Controls.Add(btnEditProduct);
            tabProduct.Controls.Add(btnDeleteProduct);
            tabProduct.Controls.Add(btnAddProduct);
            tabProduct.Controls.Add(dtgvProduct);
            tabProduct.Location = new Point(4, 31);
            tabProduct.Margin = new Padding(4, 5, 4, 5);
            tabProduct.Name = "tabProduct";
            tabProduct.Padding = new Padding(4, 5, 4, 5);
            tabProduct.Size = new Size(1507, 849);
            tabProduct.TabIndex = 0;
            tabProduct.Text = "Sản phẩm";
            tabProduct.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(505, 730);
            button1.Margin = new Padding(4, 5, 4, 5);
            button1.Name = "button1";
            button1.Size = new Size(163, 47);
            button1.TabIndex = 13;
            button1.Text = "Call TripDES";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btnTripleDesCipher_Click;
            // 
            // btnDesCipher
            // 
            btnDesCipher.Location = new Point(334, 730);
            btnDesCipher.Margin = new Padding(4, 5, 4, 5);
            btnDesCipher.Name = "btnDesCipher";
            btnDesCipher.Size = new Size(163, 47);
            btnDesCipher.TabIndex = 13;
            btnDesCipher.Text = "Call DES";
            btnDesCipher.UseVisualStyleBackColor = true;
            btnDesCipher.Click += btnDesCipher_Click;
            // 
            // btnMultiCipher
            // 
            btnMultiCipher.Location = new Point(676, 730);
            btnMultiCipher.Margin = new Padding(4, 5, 4, 5);
            btnMultiCipher.Name = "btnMultiCipher";
            btnMultiCipher.Size = new Size(168, 47);
            btnMultiCipher.TabIndex = 13;
            btnMultiCipher.Text = "Call Multi";
            btnMultiCipher.UseVisualStyleBackColor = true;
            btnMultiCipher.Click += btnMultiCipher_Click;
            // 
            // btnCeasarCipher
            // 
            btnCeasarCipher.Font = new Font("Courier New", 12F);
            btnCeasarCipher.Location = new Point(160, 730);
            btnCeasarCipher.Margin = new Padding(4, 5, 4, 5);
            btnCeasarCipher.Name = "btnCeasarCipher";
            btnCeasarCipher.Size = new Size(166, 47);
            btnCeasarCipher.TabIndex = 13;
            btnCeasarCipher.Text = "Call Ceasar";
            btnCeasarCipher.UseVisualStyleBackColor = true;
            btnCeasarCipher.Click += btnCeasarCipher_Click;
            // 
            // btnCallRSA
            // 
            btnCallRSA.Font = new Font("Courier New", 12F);
            btnCallRSA.Location = new Point(20, 730);
            btnCallRSA.Margin = new Padding(4, 5, 4, 5);
            btnCallRSA.Name = "btnCallRSA";
            btnCallRSA.Size = new Size(132, 47);
            btnCallRSA.TabIndex = 13;
            btnCallRSA.Text = "Call RSA";
            btnCallRSA.UseVisualStyleBackColor = true;
            btnCallRSA.Click += btnCallRSATable_Click;
            // 
            // nmrQuantity
            // 
            nmrQuantity.Location = new Point(604, 660);
            nmrQuantity.Margin = new Padding(4, 5, 4, 5);
            nmrQuantity.Maximum = new decimal(new int[] { 1410065407, 2, 0, 0 });
            nmrQuantity.Name = "nmrQuantity";
            nmrQuantity.Size = new Size(152, 30);
            nmrQuantity.TabIndex = 11;
            // 
            // nmrPrice
            // 
            nmrPrice.Location = new Point(177, 660);
            nmrPrice.Margin = new Padding(4, 5, 4, 5);
            nmrPrice.Maximum = new decimal(new int[] { 1410065407, 2, 0, 0 });
            nmrPrice.Name = "nmrPrice";
            nmrPrice.Size = new Size(160, 30);
            nmrPrice.TabIndex = 10;
            // 
            // txbProductCategory
            // 
            txbProductCategory.Location = new Point(219, 599);
            txbProductCategory.Margin = new Padding(4, 5, 4, 5);
            txbProductCategory.Name = "txbProductCategory";
            txbProductCategory.Size = new Size(676, 30);
            txbProductCategory.TabIndex = 9;
            // 
            // txbProductName
            // 
            txbProductName.Location = new Point(219, 549);
            txbProductName.Margin = new Padding(4, 5, 4, 5);
            txbProductName.Name = "txbProductName";
            txbProductName.Size = new Size(676, 30);
            txbProductName.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(20, 602);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(178, 22);
            label4.TabIndex = 7;
            label4.Text = "Loại sản phẩm:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(469, 662);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(118, 22);
            label3.TabIndex = 6;
            label3.Text = "Số lượng:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 662);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(106, 22);
            label2.TabIndex = 5;
            label2.Text = "Đơn giá:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 552);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(166, 22);
            label1.TabIndex = 4;
            label1.Text = "Tên sản phẩm:";
            // 
            // btnEditProduct
            // 
            btnEditProduct.Location = new Point(1305, 645);
            btnEditProduct.Margin = new Padding(4, 5, 4, 5);
            btnEditProduct.Name = "btnEditProduct";
            btnEditProduct.Size = new Size(191, 77);
            btnEditProduct.TabIndex = 3;
            btnEditProduct.Text = "Sửa";
            btnEditProduct.UseVisualStyleBackColor = true;
            btnEditProduct.Click += btnEditProduct_Click;
            // 
            // btnDeleteProduct
            // 
            btnDeleteProduct.Location = new Point(1106, 645);
            btnDeleteProduct.Margin = new Padding(4, 5, 4, 5);
            btnDeleteProduct.Name = "btnDeleteProduct";
            btnDeleteProduct.Size = new Size(191, 77);
            btnDeleteProduct.TabIndex = 2;
            btnDeleteProduct.Text = "Xóa";
            btnDeleteProduct.UseVisualStyleBackColor = true;
            btnDeleteProduct.Click += btnDeleteProduct_Click;
            // 
            // btnAddProduct
            // 
            btnAddProduct.Location = new Point(907, 645);
            btnAddProduct.Margin = new Padding(4, 5, 4, 5);
            btnAddProduct.Name = "btnAddProduct";
            btnAddProduct.Size = new Size(191, 77);
            btnAddProduct.TabIndex = 1;
            btnAddProduct.Text = "Thêm";
            btnAddProduct.UseVisualStyleBackColor = true;
            btnAddProduct.Click += btnAddProduct_Click;
            // 
            // dtgvProduct
            // 
            dtgvProduct.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvProduct.Location = new Point(9, 11);
            dtgvProduct.Margin = new Padding(4, 5, 4, 5);
            dtgvProduct.Name = "dtgvProduct";
            dtgvProduct.ReadOnly = true;
            dtgvProduct.RowHeadersWidth = 51;
            dtgvProduct.Size = new Size(1487, 506);
            dtgvProduct.TabIndex = 0;
            dtgvProduct.CellClick += dtgvProduct_CellClick;
            // 
            // tabBill
            // 
            tabBill.Controls.Add(txbBillAccountID);
            tabBill.Controls.Add(label7);
            tabBill.Controls.Add(nmrBillProductQuantity);
            tabBill.Controls.Add(txbBillProductID);
            tabBill.Controls.Add(txbBillID);
            tabBill.Controls.Add(label5);
            tabBill.Controls.Add(label6);
            tabBill.Controls.Add(label8);
            tabBill.Controls.Add(btnEditBill);
            tabBill.Controls.Add(btnDeleteBill);
            tabBill.Controls.Add(btnAddBill);
            tabBill.Controls.Add(dtgvBill);
            tabBill.Location = new Point(4, 31);
            tabBill.Margin = new Padding(4, 5, 4, 5);
            tabBill.Name = "tabBill";
            tabBill.Padding = new Padding(4, 5, 4, 5);
            tabBill.Size = new Size(1507, 849);
            tabBill.TabIndex = 1;
            tabBill.Text = "Hóa đơn";
            tabBill.UseVisualStyleBackColor = true;
            // 
            // txbBillAccountID
            // 
            txbBillAccountID.Location = new Point(152, 573);
            txbBillAccountID.Margin = new Padding(4, 5, 4, 5);
            txbBillAccountID.Name = "txbBillAccountID";
            txbBillAccountID.Size = new Size(1121, 30);
            txbBillAccountID.TabIndex = 21;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(9, 576);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(82, 22);
            label7.TabIndex = 20;
            label7.Text = "Mã TK:";
            // 
            // nmrBillProductQuantity
            // 
            nmrBillProductQuantity.Location = new Point(152, 671);
            nmrBillProductQuantity.Margin = new Padding(4, 5, 4, 5);
            nmrBillProductQuantity.Maximum = new decimal(new int[] { 1410065407, 2, 0, 0 });
            nmrBillProductQuantity.Name = "nmrBillProductQuantity";
            nmrBillProductQuantity.Size = new Size(152, 30);
            nmrBillProductQuantity.TabIndex = 19;
            // 
            // txbBillProductID
            // 
            txbBillProductID.Location = new Point(152, 616);
            txbBillProductID.Margin = new Padding(4, 5, 4, 5);
            txbBillProductID.Name = "txbBillProductID";
            txbBillProductID.Size = new Size(1121, 30);
            txbBillProductID.TabIndex = 17;
            // 
            // txbBillID
            // 
            txbBillID.Location = new Point(152, 535);
            txbBillID.Margin = new Padding(4, 5, 4, 5);
            txbBillID.Name = "txbBillID";
            txbBillID.Size = new Size(1121, 30);
            txbBillID.TabIndex = 16;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(9, 619);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(82, 22);
            label5.TabIndex = 15;
            label5.Text = "Mã SP:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(9, 673);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(118, 22);
            label6.TabIndex = 14;
            label6.Text = "Số lượng:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(9, 543);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(82, 22);
            label8.TabIndex = 12;
            label8.Text = "Mã HD:";
            // 
            // btnEditBill
            // 
            btnEditBill.Location = new Point(1293, 653);
            btnEditBill.Margin = new Padding(4, 5, 4, 5);
            btnEditBill.Name = "btnEditBill";
            btnEditBill.Size = new Size(191, 63);
            btnEditBill.TabIndex = 7;
            btnEditBill.Text = "Sửa";
            btnEditBill.UseVisualStyleBackColor = true;
            btnEditBill.Click += btnEditBill_Click;
            // 
            // btnDeleteBill
            // 
            btnDeleteBill.Location = new Point(1082, 653);
            btnDeleteBill.Margin = new Padding(4, 5, 4, 5);
            btnDeleteBill.Name = "btnDeleteBill";
            btnDeleteBill.Size = new Size(191, 63);
            btnDeleteBill.TabIndex = 6;
            btnDeleteBill.Text = "Xóa";
            btnDeleteBill.UseVisualStyleBackColor = true;
            btnDeleteBill.Click += btnDeleteBill_Click;
            // 
            // btnAddBill
            // 
            btnAddBill.Location = new Point(860, 656);
            btnAddBill.Margin = new Padding(4, 5, 4, 5);
            btnAddBill.Name = "btnAddBill";
            btnAddBill.Size = new Size(191, 63);
            btnAddBill.TabIndex = 5;
            btnAddBill.Text = "Thêm";
            btnAddBill.UseVisualStyleBackColor = true;
            btnAddBill.Click += btnAddBill_Click;
            // 
            // dtgvBill
            // 
            dtgvBill.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvBill.Location = new Point(9, 11);
            dtgvBill.Margin = new Padding(4, 5, 4, 5);
            dtgvBill.Name = "dtgvBill";
            dtgvBill.ReadOnly = true;
            dtgvBill.RowHeadersWidth = 51;
            dtgvBill.Size = new Size(1487, 506);
            dtgvBill.TabIndex = 4;
            dtgvBill.CellClick += dtgvBill_CellClick;
            // 
            // tabAccount
            // 
            tabAccount.Controls.Add(btnAudit);
            tabAccount.Controls.Add(button2);
            tabAccount.Controls.Add(btnGrPolicy);
            tabAccount.Controls.Add(btnPolicy);
            tabAccount.Controls.Add(btnGrant);
            tabAccount.Controls.Add(txbAccountName);
            tabAccount.Controls.Add(label12);
            tabAccount.Controls.Add(txbAccountID);
            tabAccount.Controls.Add(label13);
            tabAccount.Controls.Add(label11);
            tabAccount.Controls.Add(txbAccountAddress);
            tabAccount.Controls.Add(txbAccountPhone);
            tabAccount.Controls.Add(label9);
            tabAccount.Controls.Add(label10);
            tabAccount.Controls.Add(btnLogout);
            tabAccount.Controls.Add(btnEditAccount);
            tabAccount.Controls.Add(btnDeleteAccount);
            tabAccount.Controls.Add(dtgvAccount);
            tabAccount.Location = new Point(4, 31);
            tabAccount.Margin = new Padding(4, 5, 4, 5);
            tabAccount.Name = "tabAccount";
            tabAccount.Padding = new Padding(4, 5, 4, 5);
            tabAccount.Size = new Size(1507, 849);
            tabAccount.TabIndex = 2;
            tabAccount.Text = "Tài khoản";
            tabAccount.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(1125, 562);
            button2.Margin = new Padding(4, 5, 4, 5);
            button2.Name = "button2";
            button2.Size = new Size(177, 92);
            button2.TabIndex = 28;
            button2.Text = "GUI Grant";
            button2.UseVisualStyleBackColor = true;
            button2.Click += btnGrantGUI_Click;
            // 
            // btnGrPolicy
            // 
            btnGrPolicy.Location = new Point(326, 740);
            btnGrPolicy.Margin = new Padding(4, 5, 4, 5);
            btnGrPolicy.Name = "btnGrPolicy";
            btnGrPolicy.Size = new Size(223, 50);
            btnGrPolicy.TabIndex = 28;
            btnGrPolicy.Text = "Grant Policy";
            btnGrPolicy.UseVisualStyleBackColor = true;
            btnGrPolicy.Click += btnGrPolicy_Click;
            // 
            // btnPolicy
            // 
            btnPolicy.Location = new Point(36, 740);
            btnPolicy.Margin = new Padding(4, 5, 4, 5);
            btnPolicy.Name = "btnPolicy";
            btnPolicy.Size = new Size(223, 50);
            btnPolicy.TabIndex = 28;
            btnPolicy.Text = "Tạo Policy";
            btnPolicy.UseVisualStyleBackColor = true;
            btnPolicy.Click += btnPolicy_Click;
            // 
            // btnGrant
            // 
            btnGrant.Location = new Point(906, 562);
            btnGrant.Margin = new Padding(4, 5, 4, 5);
            btnGrant.Name = "btnGrant";
            btnGrant.Size = new Size(202, 92);
            btnGrant.TabIndex = 28;
            btnGrant.Text = "Phân quyền";
            btnGrant.UseVisualStyleBackColor = true;
            btnGrant.Click += btnGrant_Click;
            // 
            // txbAccountName
            // 
            txbAccountName.Location = new Point(141, 578);
            txbAccountName.Margin = new Padding(4, 5, 4, 5);
            txbAccountName.Name = "txbAccountName";
            txbAccountName.Size = new Size(733, 30);
            txbAccountName.TabIndex = 25;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(9, 581);
            label12.Margin = new Padding(4, 0, 4, 0);
            label12.Name = "label12";
            label12.Size = new Size(94, 22);
            label12.TabIndex = 24;
            label12.Text = "Tên TK:";
            // 
            // txbAccountID
            // 
            txbAccountID.Location = new Point(141, 531);
            txbAccountID.Margin = new Padding(4, 5, 4, 5);
            txbAccountID.Name = "txbAccountID";
            txbAccountID.Size = new Size(733, 30);
            txbAccountID.TabIndex = 23;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(906, 534);
            label13.Margin = new Padding(4, 0, 4, 0);
            label13.Name = "label13";
            label13.Size = new Size(178, 22);
            label13.TabIndex = 22;
            label13.Text = "Administrator:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(9, 534);
            label11.Margin = new Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new Size(82, 22);
            label11.TabIndex = 22;
            label11.Text = "Mã TK:";
            // 
            // txbAccountAddress
            // 
            txbAccountAddress.Location = new Point(141, 668);
            txbAccountAddress.Margin = new Padding(4, 5, 4, 5);
            txbAccountAddress.Name = "txbAccountAddress";
            txbAccountAddress.Size = new Size(733, 30);
            txbAccountAddress.TabIndex = 21;
            // 
            // txbAccountPhone
            // 
            txbAccountPhone.Location = new Point(141, 624);
            txbAccountPhone.Margin = new Padding(4, 5, 4, 5);
            txbAccountPhone.Name = "txbAccountPhone";
            txbAccountPhone.Size = new Size(733, 30);
            txbAccountPhone.TabIndex = 20;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(9, 668);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(106, 22);
            label9.TabIndex = 19;
            label9.Text = "Địa chỉ:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(9, 627);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(58, 22);
            label10.TabIndex = 18;
            label10.Text = "SĐT:";
            // 
            // btnLogout
            // 
            btnLogout.Location = new Point(906, 680);
            btnLogout.Margin = new Padding(4, 5, 4, 5);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(191, 63);
            btnLogout.TabIndex = 8;
            btnLogout.Text = "Đăng xuất";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnEditAccount
            // 
            btnEditAccount.Location = new Point(1304, 680);
            btnEditAccount.Margin = new Padding(4, 5, 4, 5);
            btnEditAccount.Name = "btnEditAccount";
            btnEditAccount.Size = new Size(192, 63);
            btnEditAccount.TabIndex = 7;
            btnEditAccount.Text = "Sửa";
            btnEditAccount.UseVisualStyleBackColor = true;
            btnEditAccount.Click += btnEditAccount_Click;
            // 
            // btnDeleteAccount
            // 
            btnDeleteAccount.Location = new Point(1105, 680);
            btnDeleteAccount.Margin = new Padding(4, 5, 4, 5);
            btnDeleteAccount.Name = "btnDeleteAccount";
            btnDeleteAccount.Size = new Size(191, 63);
            btnDeleteAccount.TabIndex = 6;
            btnDeleteAccount.Text = "Xóa";
            btnDeleteAccount.UseVisualStyleBackColor = true;
            btnDeleteAccount.Click += btnDeleteAccount_Click;
            // 
            // dtgvAccount
            // 
            dtgvAccount.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvAccount.Location = new Point(9, 11);
            dtgvAccount.Margin = new Padding(4, 5, 4, 5);
            dtgvAccount.Name = "dtgvAccount";
            dtgvAccount.ReadOnly = true;
            dtgvAccount.RowHeadersWidth = 51;
            dtgvAccount.Size = new Size(1487, 501);
            dtgvAccount.TabIndex = 4;
            dtgvAccount.CellClick += dtgvAccount_CellClick;
            // 
            // btnAudit
            // 
            btnAudit.Location = new Point(1310, 562);
            btnAudit.Margin = new Padding(4, 5, 4, 5);
            btnAudit.Name = "btnAudit";
            btnAudit.Size = new Size(186, 92);
            btnAudit.TabIndex = 28;
            btnAudit.Text = "Audit";
            btnAudit.UseVisualStyleBackColor = true;
            btnAudit.Click += btnAudit_Click;
            // 
            // fProductManager
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1547, 938);
            Controls.Add(tabControl1);
            Margin = new Padding(4, 5, 4, 5);
            Name = "fProductManager";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản lý cửa hàng tiện lợi";
            tabControl1.ResumeLayout(false);
            tabProduct.ResumeLayout(false);
            tabProduct.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nmrQuantity).EndInit();
            ((System.ComponentModel.ISupportInitialize)nmrPrice).EndInit();
            ((System.ComponentModel.ISupportInitialize)dtgvProduct).EndInit();
            tabBill.ResumeLayout(false);
            tabBill.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nmrBillProductQuantity).EndInit();
            ((System.ComponentModel.ISupportInitialize)dtgvBill).EndInit();
            tabAccount.ResumeLayout(false);
            tabAccount.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvAccount).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabProduct;
        private System.Windows.Forms.TabPage tabBill;
        private System.Windows.Forms.Button btnEditProduct;
        private System.Windows.Forms.Button btnDeleteProduct;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.DataGridView dtgvProduct;
        private System.Windows.Forms.Button btnEditBill;
        private System.Windows.Forms.Button btnDeleteBill;
        private System.Windows.Forms.Button btnAddBill;
        private System.Windows.Forms.DataGridView dtgvBill;
        private System.Windows.Forms.TabPage tabAccount;
        private System.Windows.Forms.Button btnEditAccount;
        private System.Windows.Forms.Button btnDeleteAccount;
        private System.Windows.Forms.DataGridView dtgvAccount;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nmrPrice;
        private System.Windows.Forms.TextBox txbProductCategory;
        private System.Windows.Forms.TextBox txbProductName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nmrQuantity;
        private System.Windows.Forms.NumericUpDown nmrBillProductQuantity;
        private System.Windows.Forms.TextBox txbBillProductID;
        private System.Windows.Forms.TextBox txbBillID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txbBillAccountID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txbAccountAddress;
        private System.Windows.Forms.TextBox txbAccountPhone;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txbAccountName;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txbAccountID;
        private System.Windows.Forms.Label label11;
        private Button btnCallRSA;
        private Button btnCeasarCipher;
        private Button btnDesCipher;
        private Button btnGrant;
        private Label label13;
        private Button btnMultiCipher;
        private Button button1;
        private Button btnPolicy;
        private Button btnGrPolicy;
        private Button button2;
        private Button btnAudit;
    }
}