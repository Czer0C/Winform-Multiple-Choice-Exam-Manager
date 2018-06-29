namespace WindowsFormsApp2
{
    partial class FormAdmin
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl = new MetroFramework.Controls.MetroTabControl();
            this.tpUpdateUser = new MetroFramework.Controls.MetroTabPage();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.txtMatKhau = new MetroFramework.Controls.MetroTextBox();
            this.dgvUpdateUser = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAddUser = new MetroFramework.Controls.MetroButton();
            this.btnUpdateUser = new MetroFramework.Controls.MetroButton();
            this.cbUserType = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.lblAccount = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.tpImport = new MetroFramework.Controls.MetroTabPage();
            this.btnXuatDSGV = new MetroFramework.Controls.MetroButton();
            this.btnXuatDSHS = new MetroFramework.Controls.MetroButton();
            this.dgvImportUserList = new System.Windows.Forms.DataGridView();
            this.btnUpdateFromImport = new MetroFramework.Controls.MetroButton();
            this.btnImportFile = new MetroFramework.Controls.MetroButton();
            this.tpSystemManagement = new MetroFramework.Controls.MetroTabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.btnBackup = new MetroFramework.Controls.MetroButton();
            this.btnRestore = new MetroFramework.Controls.MetroButton();
            this.cbDatabaseName = new MetroFramework.Controls.MetroComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.txtPathToDB = new MetroFramework.Controls.MetroTextBox();
            this.btnBrowse = new MetroFramework.Controls.MetroButton();
            this.btnConnect = new MetroFramework.Controls.MetroButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbServerName = new MetroFramework.Controls.MetroComboBox();
            this.btnRefresh = new MetroFramework.Controls.MetroButton();
            this.fileDialogImportExcel = new System.Windows.Forms.OpenFileDialog();
            this.fileDialogImportDB = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.lblTenDN = new MetroFramework.Controls.MetroLabel();
            this.tabControl.SuspendLayout();
            this.tpUpdateUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUpdateUser)).BeginInit();
            this.tpImport.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvImportUserList)).BeginInit();
            this.tpSystemManagement.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tpUpdateUser);
            this.tabControl.Controls.Add(this.tpImport);
            this.tabControl.Controls.Add(this.tpSystemManagement);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(20, 60);
            this.tabControl.Multiline = true;
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(718, 566);
            this.tabControl.TabIndex = 0;
            this.tabControl.UseSelectable = true;
            // 
            // tpUpdateUser
            // 
            this.tpUpdateUser.Controls.Add(this.lblTenDN);
            this.tpUpdateUser.Controls.Add(this.metroLabel4);
            this.tpUpdateUser.Controls.Add(this.txtMatKhau);
            this.tpUpdateUser.Controls.Add(this.dgvUpdateUser);
            this.tpUpdateUser.Controls.Add(this.btnAddUser);
            this.tpUpdateUser.Controls.Add(this.btnUpdateUser);
            this.tpUpdateUser.Controls.Add(this.cbUserType);
            this.tpUpdateUser.Controls.Add(this.metroLabel5);
            this.tpUpdateUser.Controls.Add(this.metroLabel3);
            this.tpUpdateUser.Controls.Add(this.lblAccount);
            this.tpUpdateUser.Controls.Add(this.metroLabel1);
            this.tpUpdateUser.HorizontalScrollbarBarColor = true;
            this.tpUpdateUser.HorizontalScrollbarHighlightOnWheel = false;
            this.tpUpdateUser.HorizontalScrollbarSize = 10;
            this.tpUpdateUser.Location = new System.Drawing.Point(4, 38);
            this.tpUpdateUser.Name = "tpUpdateUser";
            this.tpUpdateUser.Size = new System.Drawing.Size(710, 524);
            this.tpUpdateUser.TabIndex = 0;
            this.tpUpdateUser.Text = "Quản lý người dùng";
            this.tpUpdateUser.VerticalScrollbarBarColor = true;
            this.tpUpdateUser.VerticalScrollbarHighlightOnWheel = false;
            this.tpUpdateUser.VerticalScrollbarSize = 10;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(9, 126);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(66, 19);
            this.metroLabel4.TabIndex = 15;
            this.metroLabel4.Text = "Mật khẩu:";
            // 
            // txtMatKhau
            // 
            // 
            // 
            // 
            this.txtMatKhau.CustomButton.Image = null;
            this.txtMatKhau.CustomButton.Location = new System.Drawing.Point(242, 1);
            this.txtMatKhau.CustomButton.Name = "";
            this.txtMatKhau.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtMatKhau.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtMatKhau.CustomButton.TabIndex = 1;
            this.txtMatKhau.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtMatKhau.CustomButton.UseSelectable = true;
            this.txtMatKhau.CustomButton.Visible = false;
            this.txtMatKhau.Lines = new string[0];
            this.txtMatKhau.Location = new System.Drawing.Point(113, 122);
            this.txtMatKhau.MaxLength = 32767;
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.PasswordChar = '\0';
            this.txtMatKhau.PromptText = "Mật khẩu ...";
            this.txtMatKhau.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtMatKhau.SelectedText = "";
            this.txtMatKhau.SelectionLength = 0;
            this.txtMatKhau.SelectionStart = 0;
            this.txtMatKhau.ShortcutsEnabled = true;
            this.txtMatKhau.Size = new System.Drawing.Size(264, 23);
            this.txtMatKhau.TabIndex = 14;
            this.txtMatKhau.UseSelectable = true;
            this.txtMatKhau.WaterMark = "Mật khẩu ...";
            this.txtMatKhau.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtMatKhau.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // dgvUpdateUser
            // 
            this.dgvUpdateUser.AllowUserToAddRows = false;
            this.dgvUpdateUser.AllowUserToDeleteRows = false;
            this.dgvUpdateUser.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvUpdateUser.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvUpdateUser.ColumnHeadersHeight = 30;
            this.dgvUpdateUser.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.userName,
            this.password,
            this.userType});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvUpdateUser.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvUpdateUser.EnableHeadersVisualStyles = false;
            this.dgvUpdateUser.Location = new System.Drawing.Point(3, 238);
            this.dgvUpdateUser.MultiSelect = false;
            this.dgvUpdateUser.Name = "dgvUpdateUser";
            this.dgvUpdateUser.ReadOnly = true;
            this.dgvUpdateUser.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUpdateUser.Size = new System.Drawing.Size(704, 273);
            this.dgvUpdateUser.TabIndex = 13;
            // 
            // id
            // 
            this.id.HeaderText = "Mã tài khoản";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // userName
            // 
            this.userName.HeaderText = "Tài khoản";
            this.userName.Name = "userName";
            this.userName.ReadOnly = true;
            // 
            // password
            // 
            this.password.HeaderText = "Mật khẩu";
            this.password.Name = "password";
            this.password.ReadOnly = true;
            // 
            // userType
            // 
            this.userType.HeaderText = "Loại tài khoản";
            this.userType.Name = "userType";
            this.userType.ReadOnly = true;
            // 
            // btnAddUser
            // 
            this.btnAddUser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAddUser.AutoSize = true;
            this.btnAddUser.Location = new System.Drawing.Point(365, 167);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(122, 50);
            this.btnAddUser.TabIndex = 12;
            this.btnAddUser.Text = "Thêm người dùng";
            this.btnAddUser.UseSelectable = true;
            // 
            // btnUpdateUser
            // 
            this.btnUpdateUser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnUpdateUser.AutoSize = true;
            this.btnUpdateUser.Location = new System.Drawing.Point(223, 167);
            this.btnUpdateUser.Name = "btnUpdateUser";
            this.btnUpdateUser.Size = new System.Drawing.Size(122, 50);
            this.btnUpdateUser.TabIndex = 11;
            this.btnUpdateUser.Text = "Cập nhật thông tin";
            this.btnUpdateUser.UseSelectable = true;
            // 
            // cbUserType
            // 
            this.cbUserType.FormattingEnabled = true;
            this.cbUserType.ItemHeight = 23;
            this.cbUserType.Items.AddRange(new object[] {
            "Học sinh",
            "Giáo viên",
            "Admin"});
            this.cbUserType.Location = new System.Drawing.Point(383, 29);
            this.cbUserType.Name = "cbUserType";
            this.cbUserType.Size = new System.Drawing.Size(121, 29);
            this.cbUserType.TabIndex = 10;
            this.cbUserType.UseSelectable = true;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(284, 39);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(93, 19);
            this.metroLabel5.TabIndex = 8;
            this.metroLabel5.Text = "Loại tài khoản:";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(9, 83);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(98, 19);
            this.metroLabel3.TabIndex = 6;
            this.metroLabel3.Text = "Tên đăng nhập:";
            // 
            // lblAccount
            // 
            this.lblAccount.AutoSize = true;
            this.lblAccount.Location = new System.Drawing.Point(113, 39);
            this.lblAccount.Name = "lblAccount";
            this.lblAccount.Size = new System.Drawing.Size(79, 19);
            this.lblAccount.TabIndex = 5;
            this.lblAccount.Text = "MaTaiKhoan";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(9, 39);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(88, 19);
            this.metroLabel1.TabIndex = 4;
            this.metroLabel1.Text = "Mã tài khoản:";
            // 
            // tpImport
            // 
            this.tpImport.Controls.Add(this.btnXuatDSGV);
            this.tpImport.Controls.Add(this.btnXuatDSHS);
            this.tpImport.Controls.Add(this.dgvImportUserList);
            this.tpImport.Controls.Add(this.btnUpdateFromImport);
            this.tpImport.Controls.Add(this.btnImportFile);
            this.tpImport.HorizontalScrollbarBarColor = true;
            this.tpImport.HorizontalScrollbarHighlightOnWheel = false;
            this.tpImport.HorizontalScrollbarSize = 10;
            this.tpImport.Location = new System.Drawing.Point(4, 38);
            this.tpImport.Name = "tpImport";
            this.tpImport.Size = new System.Drawing.Size(710, 524);
            this.tpImport.TabIndex = 2;
            this.tpImport.Text = "Nhập / Xuất danh sách";
            this.tpImport.VerticalScrollbarBarColor = true;
            this.tpImport.VerticalScrollbarHighlightOnWheel = false;
            this.tpImport.VerticalScrollbarSize = 10;
            // 
            // btnXuatDSGV
            // 
            this.btnXuatDSGV.Location = new System.Drawing.Point(170, 82);
            this.btnXuatDSGV.Name = "btnXuatDSGV";
            this.btnXuatDSGV.Size = new System.Drawing.Size(148, 50);
            this.btnXuatDSGV.TabIndex = 16;
            this.btnXuatDSGV.Text = "Xuất danh sách giáo viên";
            this.btnXuatDSGV.UseSelectable = true;
            // 
            // btnXuatDSHS
            // 
            this.btnXuatDSHS.Location = new System.Drawing.Point(3, 82);
            this.btnXuatDSHS.Name = "btnXuatDSHS";
            this.btnXuatDSHS.Size = new System.Drawing.Size(148, 50);
            this.btnXuatDSHS.TabIndex = 15;
            this.btnXuatDSHS.Text = "Xuất danh sách học sinh";
            this.btnXuatDSHS.UseSelectable = true;
            // 
            // dgvImportUserList
            // 
            this.dgvImportUserList.AllowUserToDeleteRows = false;
            this.dgvImportUserList.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvImportUserList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvImportUserList.ColumnHeadersHeight = 30;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvImportUserList.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvImportUserList.EnableHeadersVisualStyles = false;
            this.dgvImportUserList.Location = new System.Drawing.Point(6, 144);
            this.dgvImportUserList.MultiSelect = false;
            this.dgvImportUserList.Name = "dgvImportUserList";
            this.dgvImportUserList.ReadOnly = true;
            this.dgvImportUserList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvImportUserList.Size = new System.Drawing.Size(698, 319);
            this.dgvImportUserList.TabIndex = 14;
            // 
            // btnUpdateFromImport
            // 
            this.btnUpdateFromImport.Location = new System.Drawing.Point(170, 21);
            this.btnUpdateFromImport.Name = "btnUpdateFromImport";
            this.btnUpdateFromImport.Size = new System.Drawing.Size(148, 50);
            this.btnUpdateFromImport.TabIndex = 4;
            this.btnUpdateFromImport.Text = "Cập nhật CSDL";
            this.btnUpdateFromImport.UseSelectable = true;
            this.btnUpdateFromImport.Visible = false;
            // 
            // btnImportFile
            // 
            this.btnImportFile.Location = new System.Drawing.Point(3, 21);
            this.btnImportFile.Name = "btnImportFile";
            this.btnImportFile.Size = new System.Drawing.Size(148, 50);
            this.btnImportFile.TabIndex = 2;
            this.btnImportFile.Text = "Nhập danh sách ...";
            this.btnImportFile.UseSelectable = true;
            // 
            // tpSystemManagement
            // 
            this.tpSystemManagement.Controls.Add(this.groupBox3);
            this.tpSystemManagement.Controls.Add(this.groupBox2);
            this.tpSystemManagement.Controls.Add(this.groupBox1);
            this.tpSystemManagement.HorizontalScrollbarBarColor = true;
            this.tpSystemManagement.HorizontalScrollbarHighlightOnWheel = false;
            this.tpSystemManagement.HorizontalScrollbarSize = 10;
            this.tpSystemManagement.Location = new System.Drawing.Point(4, 38);
            this.tpSystemManagement.Name = "tpSystemManagement";
            this.tpSystemManagement.Size = new System.Drawing.Size(710, 524);
            this.tpSystemManagement.TabIndex = 3;
            this.tpSystemManagement.Text = "Quản lý hệ thống";
            this.tpSystemManagement.VerticalScrollbarBarColor = true;
            this.tpSystemManagement.VerticalScrollbarHighlightOnWheel = false;
            this.tpSystemManagement.VerticalScrollbarSize = 10;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.White;
            this.groupBox3.Controls.Add(this.metroLabel2);
            this.groupBox3.Controls.Add(this.btnBackup);
            this.groupBox3.Controls.Add(this.btnRestore);
            this.groupBox3.Controls.Add(this.cbDatabaseName);
            this.groupBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(7, 239);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(601, 174);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Sao lưu và phục hồi";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(6, 30);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(86, 19);
            this.metroLabel2.TabIndex = 11;
            this.metroLabel2.Text = "Tên Database";
            // 
            // btnBackup
            // 
            this.btnBackup.Location = new System.Drawing.Point(441, 52);
            this.btnBackup.Name = "btnBackup";
            this.btnBackup.Size = new System.Drawing.Size(74, 29);
            this.btnBackup.TabIndex = 9;
            this.btnBackup.Text = "Sao lưu";
            this.btnBackup.UseSelectable = true;
            // 
            // btnRestore
            // 
            this.btnRestore.Location = new System.Drawing.Point(521, 52);
            this.btnRestore.Name = "btnRestore";
            this.btnRestore.Size = new System.Drawing.Size(74, 29);
            this.btnRestore.TabIndex = 10;
            this.btnRestore.Text = "Phục hồi";
            this.btnRestore.UseSelectable = true;
            // 
            // cbDatabaseName
            // 
            this.cbDatabaseName.FormattingEnabled = true;
            this.cbDatabaseName.ItemHeight = 23;
            this.cbDatabaseName.Location = new System.Drawing.Point(6, 52);
            this.cbDatabaseName.Name = "cbDatabaseName";
            this.cbDatabaseName.Size = new System.Drawing.Size(423, 29);
            this.cbDatabaseName.TabIndex = 8;
            this.cbDatabaseName.UseSelectable = true;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.metroLabel6);
            this.groupBox2.Controls.Add(this.txtPathToDB);
            this.groupBox2.Controls.Add(this.btnBrowse);
            this.groupBox2.Controls.Add(this.btnConnect);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(7, 130);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(601, 103);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thiết lập kết nối database";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(6, 26);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(150, 19);
            this.metroLabel6.TabIndex = 12;
            this.metroLabel6.Text = "Đường dẫn đến file mdf";
            // 
            // txtPathToDB
            // 
            // 
            // 
            // 
            this.txtPathToDB.CustomButton.Image = null;
            this.txtPathToDB.CustomButton.Location = new System.Drawing.Point(395, 1);
            this.txtPathToDB.CustomButton.Name = "";
            this.txtPathToDB.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txtPathToDB.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPathToDB.CustomButton.TabIndex = 1;
            this.txtPathToDB.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPathToDB.CustomButton.UseSelectable = true;
            this.txtPathToDB.CustomButton.Visible = false;
            this.txtPathToDB.Lines = new string[0];
            this.txtPathToDB.Location = new System.Drawing.Point(6, 49);
            this.txtPathToDB.MaxLength = 32767;
            this.txtPathToDB.Name = "txtPathToDB";
            this.txtPathToDB.PasswordChar = '\0';
            this.txtPathToDB.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPathToDB.SelectedText = "";
            this.txtPathToDB.SelectionLength = 0;
            this.txtPathToDB.SelectionStart = 0;
            this.txtPathToDB.ShortcutsEnabled = true;
            this.txtPathToDB.Size = new System.Drawing.Size(423, 29);
            this.txtPathToDB.TabIndex = 2;
            this.txtPathToDB.UseSelectable = true;
            this.txtPathToDB.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPathToDB.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(441, 49);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(74, 29);
            this.btnBrowse.TabIndex = 4;
            this.btnBrowse.Text = "Tìm ...";
            this.btnBrowse.UseSelectable = true;
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(521, 49);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(74, 29);
            this.btnConnect.TabIndex = 5;
            this.btnConnect.Text = "Kết nối";
            this.btnConnect.UseSelectable = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.cbServerName);
            this.groupBox1.Controls.Add(this.btnRefresh);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(7, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(601, 100);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chọn tên Server";
            // 
            // cbServerName
            // 
            this.cbServerName.FormattingEnabled = true;
            this.cbServerName.ItemHeight = 23;
            this.cbServerName.Location = new System.Drawing.Point(6, 40);
            this.cbServerName.Name = "cbServerName";
            this.cbServerName.Size = new System.Drawing.Size(423, 29);
            this.cbServerName.TabIndex = 7;
            this.cbServerName.UseSelectable = true;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(441, 40);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(154, 29);
            this.btnRefresh.TabIndex = 8;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseSelectable = true;
            // 
            // fileDialogImportExcel
            // 
            this.fileDialogImportExcel.DefaultExt = "xlsx";
            this.fileDialogImportExcel.Title = "Chọn file để import";
            // 
            // fileDialogImportDB
            // 
            this.fileDialogImportDB.AddExtension = false;
            this.fileDialogImportDB.DefaultExt = "mdf";
            this.fileDialogImportDB.FileName = "db";
            this.fileDialogImportDB.InitialDirectory = "c:\\";
            this.fileDialogImportDB.RestoreDirectory = true;
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // lblTenDN
            // 
            this.lblTenDN.AutoSize = true;
            this.lblTenDN.Location = new System.Drawing.Point(113, 83);
            this.lblTenDN.Name = "lblTenDN";
            this.lblTenDN.Size = new System.Drawing.Size(91, 19);
            this.lblTenDN.TabIndex = 16;
            this.lblTenDN.Text = "TenDangNhap";
            // 
            // FormAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 646);
            this.Controls.Add(this.tabControl);
            this.Name = "FormAdmin";
            this.Text = "AdminForm";
            this.tabControl.ResumeLayout(false);
            this.tpUpdateUser.ResumeLayout(false);
            this.tpUpdateUser.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUpdateUser)).EndInit();
            this.tpImport.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvImportUserList)).EndInit();
            this.tpSystemManagement.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl tabControl;
        private MetroFramework.Controls.MetroTabPage tpUpdateUser;
        private MetroFramework.Controls.MetroTabPage tpImport;
        private MetroFramework.Controls.MetroButton btnImportFile;
        private System.Windows.Forms.OpenFileDialog fileDialogImportExcel;
        private MetroFramework.Controls.MetroButton btnUpdateFromImport;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel lblAccount;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroComboBox cbUserType;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroButton btnUpdateUser;
        private MetroFramework.Controls.MetroButton btnAddUser;
        private MetroFramework.Controls.MetroTabPage tpSystemManagement;
        private MetroFramework.Controls.MetroButton btnBrowse;
        private MetroFramework.Controls.MetroTextBox txtPathToDB;
        private System.Windows.Forms.OpenFileDialog fileDialogImportDB;
        private MetroFramework.Controls.MetroButton btnConnect;
        private MetroFramework.Controls.MetroComboBox cbServerName;
        private MetroFramework.Controls.MetroButton btnRefresh;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private MetroFramework.Controls.MetroComboBox cbDatabaseName;
        private MetroFramework.Controls.MetroButton btnBackup;
        private MetroFramework.Controls.MetroButton btnRestore;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.DataGridView dgvUpdateUser;
        private System.Windows.Forms.DataGridView dgvImportUserList;
        private MetroFramework.Controls.MetroButton btnXuatDSHS;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn userName;
        private System.Windows.Forms.DataGridViewTextBoxColumn password;
        private System.Windows.Forms.DataGridViewTextBoxColumn userType;
        private MetroFramework.Controls.MetroButton btnXuatDSGV;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox txtMatKhau;
        private MetroFramework.Controls.MetroLabel lblTenDN;
    }
}