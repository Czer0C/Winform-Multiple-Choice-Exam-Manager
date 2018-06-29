namespace WindowsFormsApp2
{
    partial class Form1
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
            this.tabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.tabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txtTenKyThi = new MetroFramework.Controls.MetroTextBox();
            this.cbKhoi = new MetroFramework.Controls.MetroComboBox();
            this.btnSua = new MetroFramework.Controls.MetroButton();
            this.btnXoa = new MetroFramework.Controls.MetroButton();
            this.btnThem = new MetroFramework.Controls.MetroButton();
            this.dtg1 = new System.Windows.Forms.DataGridView();
            this.dateTimePicker1 = new MetroFramework.Controls.MetroDateTime();
            this.label8 = new MetroFramework.Controls.MetroLabel();
            this.label3 = new MetroFramework.Controls.MetroLabel();
            this.label1 = new MetroFramework.Controls.MetroLabel();
            this.txtMaKyThi = new MetroFramework.Controls.MetroTextBox();
            this.tabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.btnSua1 = new MetroFramework.Controls.MetroButton();
            this.btnXoa1 = new MetroFramework.Controls.MetroButton();
            this.btnThem1 = new MetroFramework.Controls.MetroButton();
            this.txtKhoi1 = new MetroFramework.Controls.MetroTextBox();
            this.label9 = new MetroFramework.Controls.MetroLabel();
            this.txtMaMon1 = new MetroFramework.Controls.MetroTextBox();
            this.label10 = new MetroFramework.Controls.MetroLabel();
            this.dtg2 = new System.Windows.Forms.DataGridView();
            this.txtMaDeThi1 = new MetroFramework.Controls.MetroTextBox();
            this.label4 = new MetroFramework.Controls.MetroLabel();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.dgvCauHoi = new System.Windows.Forms.DataGridView();
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.dgvHocSinh = new System.Windows.Forms.DataGridView();
            this.btnViewAll = new MetroFramework.Controls.MetroButton();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.cbExam = new MetroFramework.Controls.MetroComboBox();
            this.btnXuatFileCauHoi = new MetroFramework.Controls.MetroButton();
            this.btnNhapFileCauHoi = new MetroFramework.Controls.MetroButton();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.fileDialogImportExcel = new System.Windows.Forms.OpenFileDialog();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg2)).BeginInit();
            this.metroTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCauHoi)).BeginInit();
            this.metroTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHocSinh)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.metroTabPage1);
            this.tabControl1.Controls.Add(this.metroTabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(20, 60);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 2;
            this.tabControl1.Size = new System.Drawing.Size(958, 433);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.UseSelectable = true;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Transparent;
            this.tabPage1.Controls.Add(this.metroLabel1);
            this.tabPage1.Controls.Add(this.txtTenKyThi);
            this.tabPage1.Controls.Add(this.cbKhoi);
            this.tabPage1.Controls.Add(this.btnSua);
            this.tabPage1.Controls.Add(this.btnXoa);
            this.tabPage1.Controls.Add(this.btnThem);
            this.tabPage1.Controls.Add(this.dtg1);
            this.tabPage1.Controls.Add(this.dateTimePicker1);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.txtMaKyThi);
            this.tabPage1.HorizontalScrollbarBarColor = true;
            this.tabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.tabPage1.HorizontalScrollbarSize = 10;
            this.tabPage1.Location = new System.Drawing.Point(4, 38);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(950, 391);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Quản Lý Kỳ Thi";
            this.tabPage1.VerticalScrollbarBarColor = true;
            this.tabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.tabPage1.VerticalScrollbarSize = 10;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(25, 88);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(65, 19);
            this.metroLabel1.TabIndex = 27;
            this.metroLabel1.Text = "Tên Kỳ Thi";
            // 
            // txtTenKyThi
            // 
            // 
            // 
            // 
            this.txtTenKyThi.CustomButton.Image = null;
            this.txtTenKyThi.CustomButton.Location = new System.Drawing.Point(358, 2);
            this.txtTenKyThi.CustomButton.Name = "";
            this.txtTenKyThi.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtTenKyThi.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtTenKyThi.CustomButton.TabIndex = 1;
            this.txtTenKyThi.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtTenKyThi.CustomButton.UseSelectable = true;
            this.txtTenKyThi.CustomButton.Visible = false;
            this.txtTenKyThi.Lines = new string[0];
            this.txtTenKyThi.Location = new System.Drawing.Point(96, 79);
            this.txtTenKyThi.MaxLength = 32767;
            this.txtTenKyThi.Name = "txtTenKyThi";
            this.txtTenKyThi.PasswordChar = '\0';
            this.txtTenKyThi.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtTenKyThi.SelectedText = "";
            this.txtTenKyThi.SelectionLength = 0;
            this.txtTenKyThi.SelectionStart = 0;
            this.txtTenKyThi.ShortcutsEnabled = true;
            this.txtTenKyThi.Size = new System.Drawing.Size(384, 28);
            this.txtTenKyThi.TabIndex = 26;
            this.txtTenKyThi.UseSelectable = true;
            this.txtTenKyThi.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtTenKyThi.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // cbKhoi
            // 
            this.cbKhoi.FormattingEnabled = true;
            this.cbKhoi.ItemHeight = 23;
            this.cbKhoi.Items.AddRange(new object[] {
            "10",
            "11",
            "12"});
            this.cbKhoi.Location = new System.Drawing.Point(253, 31);
            this.cbKhoi.Name = "cbKhoi";
            this.cbKhoi.Size = new System.Drawing.Size(121, 29);
            this.cbKhoi.TabIndex = 25;
            this.cbKhoi.UseSelectable = true;
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(635, 84);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 24;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseSelectable = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(635, 54);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 23;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseSelectable = true;
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.Transparent;
            this.btnThem.Location = new System.Drawing.Point(635, 22);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 22;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseSelectable = true;
            // 
            // dtg1
            // 
            this.dtg1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg1.Location = new System.Drawing.Point(-4, 175);
            this.dtg1.MultiSelect = false;
            this.dtg1.Name = "dtg1";
            this.dtg1.ReadOnly = true;
            this.dtg1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtg1.Size = new System.Drawing.Size(949, 210);
            this.dtg1.TabIndex = 21;
            this.dtg1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg1_CellContentClick);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd/MM/yyyy";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(96, 31);
            this.dateTimePicker1.MinimumSize = new System.Drawing.Size(0, 29);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(100, 29);
            this.dateTimePicker1.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(404, 41);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 19);
            this.label8.TabIndex = 19;
            this.label8.Text = "Mã Kỳ Thi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(213, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 19);
            this.label3.TabIndex = 14;
            this.label3.Text = "Khối";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 19);
            this.label1.TabIndex = 12;
            this.label1.Text = "Ngày Thi";
            // 
            // txtMaKyThi
            // 
            // 
            // 
            // 
            this.txtMaKyThi.CustomButton.Image = null;
            this.txtMaKyThi.CustomButton.Location = new System.Drawing.Point(74, 2);
            this.txtMaKyThi.CustomButton.Name = "";
            this.txtMaKyThi.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtMaKyThi.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtMaKyThi.CustomButton.TabIndex = 1;
            this.txtMaKyThi.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtMaKyThi.CustomButton.UseSelectable = true;
            this.txtMaKyThi.CustomButton.Visible = false;
            this.txtMaKyThi.Lines = new string[0];
            this.txtMaKyThi.Location = new System.Drawing.Point(475, 32);
            this.txtMaKyThi.MaxLength = 32767;
            this.txtMaKyThi.Name = "txtMaKyThi";
            this.txtMaKyThi.PasswordChar = '\0';
            this.txtMaKyThi.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtMaKyThi.SelectedText = "";
            this.txtMaKyThi.SelectionLength = 0;
            this.txtMaKyThi.SelectionStart = 0;
            this.txtMaKyThi.ShortcutsEnabled = true;
            this.txtMaKyThi.Size = new System.Drawing.Size(100, 28);
            this.txtMaKyThi.TabIndex = 10;
            this.txtMaKyThi.UseSelectable = true;
            this.txtMaKyThi.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtMaKyThi.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnSua1);
            this.tabPage2.Controls.Add(this.btnXoa1);
            this.tabPage2.Controls.Add(this.btnThem1);
            this.tabPage2.Controls.Add(this.txtKhoi1);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.txtMaMon1);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.dtg2);
            this.tabPage2.Controls.Add(this.txtMaDeThi1);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.HorizontalScrollbarBarColor = true;
            this.tabPage2.HorizontalScrollbarHighlightOnWheel = false;
            this.tabPage2.HorizontalScrollbarSize = 10;
            this.tabPage2.Location = new System.Drawing.Point(4, 38);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(950, 391);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Quản Lý Đề Thi";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.VerticalScrollbarBarColor = true;
            this.tabPage2.VerticalScrollbarHighlightOnWheel = false;
            this.tabPage2.VerticalScrollbarSize = 10;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // btnSua1
            // 
            this.btnSua1.Location = new System.Drawing.Point(654, 101);
            this.btnSua1.Name = "btnSua1";
            this.btnSua1.Size = new System.Drawing.Size(75, 23);
            this.btnSua1.TabIndex = 13;
            this.btnSua1.Text = "Sửa";
            this.btnSua1.UseSelectable = true;
            this.btnSua1.Click += new System.EventHandler(this.btnSua1_Click);
            // 
            // btnXoa1
            // 
            this.btnXoa1.Location = new System.Drawing.Point(654, 63);
            this.btnXoa1.Name = "btnXoa1";
            this.btnXoa1.Size = new System.Drawing.Size(75, 23);
            this.btnXoa1.TabIndex = 12;
            this.btnXoa1.Text = "Xóa";
            this.btnXoa1.UseSelectable = true;
            this.btnXoa1.Click += new System.EventHandler(this.btnXoa1_Click);
            // 
            // btnThem1
            // 
            this.btnThem1.Location = new System.Drawing.Point(654, 16);
            this.btnThem1.Name = "btnThem1";
            this.btnThem1.Size = new System.Drawing.Size(75, 23);
            this.btnThem1.TabIndex = 11;
            this.btnThem1.Text = "Thêm";
            this.btnThem1.UseSelectable = true;
            // 
            // txtKhoi1
            // 
            // 
            // 
            // 
            this.txtKhoi1.CustomButton.Image = null;
            this.txtKhoi1.CustomButton.Location = new System.Drawing.Point(82, 2);
            this.txtKhoi1.CustomButton.Name = "";
            this.txtKhoi1.CustomButton.Size = new System.Drawing.Size(15, 15);
            this.txtKhoi1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtKhoi1.CustomButton.TabIndex = 1;
            this.txtKhoi1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtKhoi1.CustomButton.UseSelectable = true;
            this.txtKhoi1.CustomButton.Visible = false;
            this.txtKhoi1.Enabled = false;
            this.txtKhoi1.Lines = new string[0];
            this.txtKhoi1.Location = new System.Drawing.Point(377, 19);
            this.txtKhoi1.MaxLength = 32767;
            this.txtKhoi1.Name = "txtKhoi1";
            this.txtKhoi1.PasswordChar = '\0';
            this.txtKhoi1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtKhoi1.SelectedText = "";
            this.txtKhoi1.SelectionLength = 0;
            this.txtKhoi1.SelectionStart = 0;
            this.txtKhoi1.ShortcutsEnabled = true;
            this.txtKhoi1.Size = new System.Drawing.Size(100, 20);
            this.txtKhoi1.TabIndex = 10;
            this.txtKhoi1.UseSelectable = true;
            this.txtKhoi1.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtKhoi1.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(291, 26);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(34, 19);
            this.label9.TabIndex = 9;
            this.label9.Text = "Khối";
            // 
            // txtMaMon1
            // 
            // 
            // 
            // 
            this.txtMaMon1.CustomButton.Image = null;
            this.txtMaMon1.CustomButton.Location = new System.Drawing.Point(82, 2);
            this.txtMaMon1.CustomButton.Name = "";
            this.txtMaMon1.CustomButton.Size = new System.Drawing.Size(15, 15);
            this.txtMaMon1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtMaMon1.CustomButton.TabIndex = 1;
            this.txtMaMon1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtMaMon1.CustomButton.UseSelectable = true;
            this.txtMaMon1.CustomButton.Visible = false;
            this.txtMaMon1.Enabled = false;
            this.txtMaMon1.Lines = new string[0];
            this.txtMaMon1.Location = new System.Drawing.Point(136, 101);
            this.txtMaMon1.MaxLength = 32767;
            this.txtMaMon1.Name = "txtMaMon1";
            this.txtMaMon1.PasswordChar = '\0';
            this.txtMaMon1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtMaMon1.SelectedText = "";
            this.txtMaMon1.SelectionLength = 0;
            this.txtMaMon1.SelectionStart = 0;
            this.txtMaMon1.ShortcutsEnabled = true;
            this.txtMaMon1.Size = new System.Drawing.Size(100, 20);
            this.txtMaMon1.TabIndex = 8;
            this.txtMaMon1.UseSelectable = true;
            this.txtMaMon1.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtMaMon1.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(45, 108);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 19);
            this.label10.TabIndex = 7;
            this.label10.Text = "Mã Môn";
            // 
            // dtg2
            // 
            this.dtg2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg2.Location = new System.Drawing.Point(7, 184);
            this.dtg2.MultiSelect = false;
            this.dtg2.Name = "dtg2";
            this.dtg2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtg2.Size = new System.Drawing.Size(954, 307);
            this.dtg2.TabIndex = 2;
            //this.dtg2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg2_CellContentClick);
            // 
            // txtMaDeThi1
            // 
            // 
            // 
            // 
            this.txtMaDeThi1.CustomButton.Image = null;
            this.txtMaDeThi1.CustomButton.Location = new System.Drawing.Point(82, 2);
            this.txtMaDeThi1.CustomButton.Name = "";
            this.txtMaDeThi1.CustomButton.Size = new System.Drawing.Size(15, 15);
            this.txtMaDeThi1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtMaDeThi1.CustomButton.TabIndex = 1;
            this.txtMaDeThi1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtMaDeThi1.CustomButton.UseSelectable = true;
            this.txtMaDeThi1.CustomButton.Visible = false;
            this.txtMaDeThi1.Lines = new string[0];
            this.txtMaDeThi1.Location = new System.Drawing.Point(136, 19);
            this.txtMaDeThi1.MaxLength = 32767;
            this.txtMaDeThi1.Name = "txtMaDeThi1";
            this.txtMaDeThi1.PasswordChar = '\0';
            this.txtMaDeThi1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtMaDeThi1.SelectedText = "";
            this.txtMaDeThi1.SelectionLength = 0;
            this.txtMaDeThi1.SelectionStart = 0;
            this.txtMaDeThi1.ShortcutsEnabled = true;
            this.txtMaDeThi1.Size = new System.Drawing.Size(100, 20);
            this.txtMaDeThi1.TabIndex = 1;
            this.txtMaDeThi1.UseSelectable = true;
            this.txtMaDeThi1.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtMaDeThi1.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 19);
            this.label4.TabIndex = 0;
            this.label4.Text = "Mã Đề Thi";
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.Controls.Add(this.btnNhapFileCauHoi);
            this.metroTabPage1.Controls.Add(this.btnXuatFileCauHoi);
            this.metroTabPage1.Controls.Add(this.dgvCauHoi);
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.HorizontalScrollbarSize = 10;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(950, 391);
            this.metroTabPage1.TabIndex = 2;
            this.metroTabPage1.Text = "Câu Hỏi";
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.VerticalScrollbarSize = 10;
            // 
            // dgvCauHoi
            // 
            this.dgvCauHoi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCauHoi.Location = new System.Drawing.Point(-1, 127);
            this.dgvCauHoi.MultiSelect = false;
            this.dgvCauHoi.Name = "dgvCauHoi";
            this.dgvCauHoi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCauHoi.Size = new System.Drawing.Size(925, 268);
            this.dgvCauHoi.TabIndex = 2;
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.Controls.Add(this.cbExam);
            this.metroTabPage2.Controls.Add(this.metroLabel2);
            this.metroTabPage2.Controls.Add(this.btnViewAll);
            this.metroTabPage2.Controls.Add(this.dgvHocSinh);
            this.metroTabPage2.HorizontalScrollbarBarColor = true;
            this.metroTabPage2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.HorizontalScrollbarSize = 10;
            this.metroTabPage2.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Size = new System.Drawing.Size(950, 391);
            this.metroTabPage2.TabIndex = 3;
            this.metroTabPage2.Text = "Học Sinh";
            this.metroTabPage2.VerticalScrollbarBarColor = true;
            this.metroTabPage2.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.VerticalScrollbarSize = 10;
            // 
            // dgvHocSinh
            // 
            this.dgvHocSinh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHocSinh.Location = new System.Drawing.Point(-4, 149);
            this.dgvHocSinh.Name = "dgvHocSinh";
            this.dgvHocSinh.Size = new System.Drawing.Size(928, 242);
            this.dgvHocSinh.TabIndex = 2;
            // 
            // btnViewAll
            // 
            this.btnViewAll.Location = new System.Drawing.Point(3, 28);
            this.btnViewAll.Name = "btnViewAll";
            this.btnViewAll.Size = new System.Drawing.Size(166, 47);
            this.btnViewAll.TabIndex = 3;
            this.btnViewAll.Text = "Thống kê toàn bộ";
            this.btnViewAll.UseSelectable = true;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(245, 42);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(77, 19);
            this.metroLabel2.TabIndex = 4;
            this.metroLabel2.Text = "Chọn kỳ thi:";
            // 
            // cbExam
            // 
            this.cbExam.FormattingEnabled = true;
            this.cbExam.ItemHeight = 23;
            this.cbExam.Location = new System.Drawing.Point(345, 38);
            this.cbExam.Name = "cbExam";
            this.cbExam.Size = new System.Drawing.Size(516, 29);
            this.cbExam.TabIndex = 5;
            this.cbExam.UseSelectable = true;
            // 
            // btnXuatFileCauHoi
            // 
            this.btnXuatFileCauHoi.Location = new System.Drawing.Point(3, 16);
            this.btnXuatFileCauHoi.Name = "btnXuatFileCauHoi";
            this.btnXuatFileCauHoi.Size = new System.Drawing.Size(118, 35);
            this.btnXuatFileCauHoi.TabIndex = 3;
            this.btnXuatFileCauHoi.Text = "Xuất File Câu Hỏi";
            this.btnXuatFileCauHoi.UseSelectable = true;
            // 
            // btnNhapFileCauHoi
            // 
            this.btnNhapFileCauHoi.Location = new System.Drawing.Point(127, 16);
            this.btnNhapFileCauHoi.Name = "btnNhapFileCauHoi";
            this.btnNhapFileCauHoi.Size = new System.Drawing.Size(118, 35);
            this.btnNhapFileCauHoi.TabIndex = 4;
            this.btnNhapFileCauHoi.Text = "Nhập File Câu Hỏi";
            this.btnNhapFileCauHoi.UseSelectable = true;
            // 
            // fileDialogImportExcel
            // 
            this.fileDialogImportExcel.DefaultExt = "xlsx";
            this.fileDialogImportExcel.Title = "Chọn file để import";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(998, 513);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg2)).EndInit();
            this.metroTabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCauHoi)).EndInit();
            this.metroTabPage2.ResumeLayout(false);
            this.metroTabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHocSinh)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dtg1;
        private System.Windows.Forms.DataGridView dtg2;
        private MetroFramework.Controls.MetroTabControl tabControl1;
        private MetroFramework.Controls.MetroTabPage tabPage1;

        private MetroFramework.Controls.MetroTabPage tabPage2;
        private MetroFramework.Controls.MetroLabel label8;
        private MetroFramework.Controls.MetroLabel label3;
        private MetroFramework.Controls.MetroLabel label1;
        private MetroFramework.Controls.MetroTextBox txtMaKyThi;


        private MetroFramework.Controls.MetroDateTime dateTimePicker1;

        private MetroFramework.Controls.MetroTextBox txtMaDeThi1;
        private MetroFramework.Controls.MetroLabel label4;

        private MetroFramework.Controls.MetroTextBox txtKhoi1;
        private MetroFramework.Controls.MetroLabel label9;
        private MetroFramework.Controls.MetroTextBox txtMaMon1;
        private MetroFramework.Controls.MetroLabel label10;
        private MetroFramework.Controls.MetroButton btnSua;
        private MetroFramework.Controls.MetroButton btnXoa;
        private MetroFramework.Controls.MetroButton btnThem;
        private MetroFramework.Controls.MetroButton btnSua1;
        private MetroFramework.Controls.MetroButton btnXoa1;
        private MetroFramework.Controls.MetroButton btnThem1;
        private MetroFramework.Controls.MetroComboBox cbKhoi;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox txtTenKyThi;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private System.Windows.Forms.DataGridView dgvCauHoi;
        private MetroFramework.Controls.MetroTabPage metroTabPage2;
        private System.Windows.Forms.DataGridView dgvHocSinh;
        private MetroFramework.Controls.MetroComboBox cbExam;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroButton btnViewAll;
        private MetroFramework.Controls.MetroButton btnNhapFileCauHoi;
        private MetroFramework.Controls.MetroButton btnXuatFileCauHoi;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.OpenFileDialog fileDialogImportExcel;
    }
}

