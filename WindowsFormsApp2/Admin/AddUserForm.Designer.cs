namespace WindowsFormsApp2.Admin
{
    partial class AddUserForm
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
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.txtMaTK = new MetroFramework.Controls.MetroTextBox();
            this.txtMatKhau = new MetroFramework.Controls.MetroTextBox();
            this.txtTenDN = new MetroFramework.Controls.MetroTextBox();
            this.cbLoaiTK = new MetroFramework.Controls.MetroComboBox();
            this.btnXacNhan = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(23, 89);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(88, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Mã tài khoản:";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(22, 180);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(66, 19);
            this.metroLabel2.TabIndex = 1;
            this.metroLabel2.Text = "Mật khẩu:";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(22, 133);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(98, 19);
            this.metroLabel3.TabIndex = 2;
            this.metroLabel3.Text = "Tên đăng nhập:";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(22, 236);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(93, 19);
            this.metroLabel5.TabIndex = 4;
            this.metroLabel5.Text = "Loại tài khoản:";
            // 
            // txtMaTK
            // 
            // 
            // 
            // 
            this.txtMaTK.CustomButton.Image = null;
            this.txtMaTK.CustomButton.Location = new System.Drawing.Point(160, 1);
            this.txtMaTK.CustomButton.Name = "";
            this.txtMaTK.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtMaTK.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtMaTK.CustomButton.TabIndex = 1;
            this.txtMaTK.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtMaTK.CustomButton.UseSelectable = true;
            this.txtMaTK.CustomButton.Visible = false;
            this.txtMaTK.Lines = new string[0];
            this.txtMaTK.Location = new System.Drawing.Point(121, 85);
            this.txtMaTK.MaxLength = 32767;
            this.txtMaTK.Name = "txtMaTK";
            this.txtMaTK.PasswordChar = '\0';
            this.txtMaTK.PromptText = "Nhập mã tài khoản...";
            this.txtMaTK.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtMaTK.SelectedText = "";
            this.txtMaTK.SelectionLength = 0;
            this.txtMaTK.SelectionStart = 0;
            this.txtMaTK.ShortcutsEnabled = true;
            this.txtMaTK.Size = new System.Drawing.Size(182, 23);
            this.txtMaTK.TabIndex = 5;
            this.txtMaTK.UseSelectable = true;
            this.txtMaTK.WaterMark = "Nhập mã tài khoản...";
            this.txtMaTK.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtMaTK.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtMatKhau
            // 
            // 
            // 
            // 
            this.txtMatKhau.CustomButton.Image = null;
            this.txtMatKhau.CustomButton.Location = new System.Drawing.Point(160, 1);
            this.txtMatKhau.CustomButton.Name = "";
            this.txtMatKhau.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtMatKhau.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtMatKhau.CustomButton.TabIndex = 1;
            this.txtMatKhau.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtMatKhau.CustomButton.UseSelectable = true;
            this.txtMatKhau.CustomButton.Visible = false;
            this.txtMatKhau.Lines = new string[0];
            this.txtMatKhau.Location = new System.Drawing.Point(121, 176);
            this.txtMatKhau.MaxLength = 32767;
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.PasswordChar = '●';
            this.txtMatKhau.PromptText = "Nhập mật khẩu...";
            this.txtMatKhau.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtMatKhau.SelectedText = "";
            this.txtMatKhau.SelectionLength = 0;
            this.txtMatKhau.SelectionStart = 0;
            this.txtMatKhau.ShortcutsEnabled = true;
            this.txtMatKhau.Size = new System.Drawing.Size(182, 23);
            this.txtMatKhau.TabIndex = 6;
            this.txtMatKhau.UseSelectable = true;
            this.txtMatKhau.UseSystemPasswordChar = true;
            this.txtMatKhau.WaterMark = "Nhập mật khẩu...";
            this.txtMatKhau.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtMatKhau.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtTenDN
            // 
            // 
            // 
            // 
            this.txtTenDN.CustomButton.Image = null;
            this.txtTenDN.CustomButton.Location = new System.Drawing.Point(160, 1);
            this.txtTenDN.CustomButton.Name = "";
            this.txtTenDN.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtTenDN.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtTenDN.CustomButton.TabIndex = 1;
            this.txtTenDN.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtTenDN.CustomButton.UseSelectable = true;
            this.txtTenDN.CustomButton.Visible = false;
            this.txtTenDN.Lines = new string[0];
            this.txtTenDN.Location = new System.Drawing.Point(121, 129);
            this.txtTenDN.MaxLength = 32767;
            this.txtTenDN.Name = "txtTenDN";
            this.txtTenDN.PasswordChar = '\0';
            this.txtTenDN.PromptText = "Nhập tên đăng nhập...";
            this.txtTenDN.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtTenDN.SelectedText = "";
            this.txtTenDN.SelectionLength = 0;
            this.txtTenDN.SelectionStart = 0;
            this.txtTenDN.ShortcutsEnabled = true;
            this.txtTenDN.Size = new System.Drawing.Size(182, 23);
            this.txtTenDN.TabIndex = 7;
            this.txtTenDN.UseSelectable = true;
            this.txtTenDN.WaterMark = "Nhập tên đăng nhập...";
            this.txtTenDN.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtTenDN.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // cbLoaiTK
            // 
            this.cbLoaiTK.FormattingEnabled = true;
            this.cbLoaiTK.ItemHeight = 23;
            this.cbLoaiTK.Items.AddRange(new object[] {
            "Học sinh",
            "Giáo viên",
            "Admin"});
            this.cbLoaiTK.Location = new System.Drawing.Point(121, 226);
            this.cbLoaiTK.Name = "cbLoaiTK";
            this.cbLoaiTK.Size = new System.Drawing.Size(182, 29);
            this.cbLoaiTK.TabIndex = 9;
            this.cbLoaiTK.UseSelectable = true;
            // 
            // btnXacNhan
            // 
            this.btnXacNhan.Location = new System.Drawing.Point(117, 281);
            this.btnXacNhan.Name = "btnXacNhan";
            this.btnXacNhan.Size = new System.Drawing.Size(95, 44);
            this.btnXacNhan.TabIndex = 10;
            this.btnXacNhan.Text = "Xác nhận";
            this.btnXacNhan.UseSelectable = true;
            // 
            // AddUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 353);
            this.Controls.Add(this.btnXacNhan);
            this.Controls.Add(this.cbLoaiTK);
            this.Controls.Add(this.txtTenDN);
            this.Controls.Add(this.txtMatKhau);
            this.Controls.Add(this.txtMaTK);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.MaximizeBox = false;
            this.Name = "AddUserForm";
            this.Resizable = false;
            this.Text = "Thêm Người Dùng Mới";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroTextBox txtMaTK;
        private MetroFramework.Controls.MetroTextBox txtMatKhau;
        private MetroFramework.Controls.MetroTextBox txtTenDN;
        private MetroFramework.Controls.MetroComboBox cbLoaiTK;
        private MetroFramework.Controls.MetroButton btnXacNhan;
    }
}