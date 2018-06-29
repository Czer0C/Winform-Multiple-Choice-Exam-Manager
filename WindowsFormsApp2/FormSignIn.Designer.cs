namespace WindowsFormsApp2
{
	partial class FormSignIn
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
            this.metroButtonSignIn = new MetroFramework.Controls.MetroButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroTextBoxUsername = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBoxPassword = new MetroFramework.Controls.MetroTextBox();
            this.metroLinkSignUp = new MetroFramework.Controls.MetroLink();
            this.metroLinkRecover = new MetroFramework.Controls.MetroLink();
            this.SuspendLayout();
            // 
            // metroButtonSignIn
            // 
            this.metroButtonSignIn.Location = new System.Drawing.Point(380, 220);
            this.metroButtonSignIn.Name = "metroButtonSignIn";
            this.metroButtonSignIn.Size = new System.Drawing.Size(98, 50);
            this.metroButtonSignIn.TabIndex = 0;
            this.metroButtonSignIn.Text = "Đăng nhập";
            this.metroButtonSignIn.UseSelectable = true;
            this.metroButtonSignIn.Click += new System.EventHandler(this.metroButtonSignIn_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.BackColor = System.Drawing.Color.Black;
            this.metroLabel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.metroLabel1.Location = new System.Drawing.Point(116, 101);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(85, 19);
            this.metroLabel1.TabIndex = 1;
            this.metroLabel1.Text = "Tên tài khoản";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.BackColor = System.Drawing.Color.Black;
            this.metroLabel2.Location = new System.Drawing.Point(138, 150);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(63, 19);
            this.metroLabel2.TabIndex = 2;
            this.metroLabel2.Text = "Mật khẩu";
            // 
            // metroTextBoxUsername
            // 
            // 
            // 
            // 
            this.metroTextBoxUsername.CustomButton.Image = null;
            this.metroTextBoxUsername.CustomButton.Location = new System.Drawing.Point(245, 2);
            this.metroTextBoxUsername.CustomButton.Name = "";
            this.metroTextBoxUsername.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.metroTextBoxUsername.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBoxUsername.CustomButton.TabIndex = 1;
            this.metroTextBoxUsername.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBoxUsername.CustomButton.UseSelectable = true;
            this.metroTextBoxUsername.CustomButton.Visible = false;
            this.metroTextBoxUsername.Lines = new string[] {
        "gv01"};
            this.metroTextBoxUsername.Location = new System.Drawing.Point(207, 101);
            this.metroTextBoxUsername.MaxLength = 32767;
            this.metroTextBoxUsername.Name = "metroTextBoxUsername";
            this.metroTextBoxUsername.PasswordChar = '\0';
            this.metroTextBoxUsername.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxUsername.SelectedText = "";
            this.metroTextBoxUsername.SelectionLength = 0;
            this.metroTextBoxUsername.SelectionStart = 0;
            this.metroTextBoxUsername.ShortcutsEnabled = true;
            this.metroTextBoxUsername.Size = new System.Drawing.Size(271, 28);
            this.metroTextBoxUsername.TabIndex = 3;
            this.metroTextBoxUsername.Text = "gv01";
            this.metroTextBoxUsername.UseSelectable = true;
            this.metroTextBoxUsername.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBoxUsername.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroTextBoxPassword
            // 
            // 
            // 
            // 
            this.metroTextBoxPassword.CustomButton.Image = null;
            this.metroTextBoxPassword.CustomButton.Location = new System.Drawing.Point(245, 2);
            this.metroTextBoxPassword.CustomButton.Name = "";
            this.metroTextBoxPassword.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.metroTextBoxPassword.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBoxPassword.CustomButton.TabIndex = 1;
            this.metroTextBoxPassword.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBoxPassword.CustomButton.UseSelectable = true;
            this.metroTextBoxPassword.CustomButton.Visible = false;
            this.metroTextBoxPassword.Lines = new string[] {
        "123"};
            this.metroTextBoxPassword.Location = new System.Drawing.Point(207, 150);
            this.metroTextBoxPassword.MaxLength = 32767;
            this.metroTextBoxPassword.Name = "metroTextBoxPassword";
            this.metroTextBoxPassword.PasswordChar = '*';
            this.metroTextBoxPassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxPassword.SelectedText = "";
            this.metroTextBoxPassword.SelectionLength = 0;
            this.metroTextBoxPassword.SelectionStart = 0;
            this.metroTextBoxPassword.ShortcutsEnabled = true;
            this.metroTextBoxPassword.Size = new System.Drawing.Size(271, 28);
            this.metroTextBoxPassword.TabIndex = 4;
            this.metroTextBoxPassword.Text = "123";
            this.metroTextBoxPassword.UseSelectable = true;
            this.metroTextBoxPassword.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBoxPassword.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLinkSignUp
            // 
            this.metroLinkSignUp.Location = new System.Drawing.Point(120, 206);
            this.metroLinkSignUp.Name = "metroLinkSignUp";
            this.metroLinkSignUp.Size = new System.Drawing.Size(102, 29);
            this.metroLinkSignUp.TabIndex = 5;
            this.metroLinkSignUp.Text = "Đăng kí";
            this.metroLinkSignUp.UseSelectable = true;
            // 
            // metroLinkRecover
            // 
            this.metroLinkRecover.Location = new System.Drawing.Point(99, 241);
            this.metroLinkRecover.Name = "metroLinkRecover";
            this.metroLinkRecover.Size = new System.Drawing.Size(102, 29);
            this.metroLinkRecover.TabIndex = 6;
            this.metroLinkRecover.Text = "Quên mật khẩu";
            this.metroLinkRecover.UseSelectable = true;
            // 
            // FormSignIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 370);
            this.Controls.Add(this.metroLinkRecover);
            this.Controls.Add(this.metroLinkSignUp);
            this.Controls.Add(this.metroTextBoxPassword);
            this.Controls.Add(this.metroTextBoxUsername);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.metroButtonSignIn);
            this.Name = "FormSignIn";
            this.Text = "Đăng nhập";
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private MetroFramework.Controls.MetroButton metroButtonSignIn;
		private MetroFramework.Controls.MetroLabel metroLabel1;
		private MetroFramework.Controls.MetroLabel metroLabel2;
		private MetroFramework.Controls.MetroTextBox metroTextBoxUsername;
		private MetroFramework.Controls.MetroTextBox metroTextBoxPassword;
		private MetroFramework.Controls.MetroLink metroLinkSignUp;
		private MetroFramework.Controls.MetroLink metroLinkRecover;
	}
}