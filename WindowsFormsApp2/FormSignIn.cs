using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
	public partial class FormSignIn : MetroFramework.Forms.MetroForm
	{
		public FormSignIn()
		{
			InitializeComponent();

            metroLinkSignUp.Click += MetroLinkSignUp_Click;
		}

        private void MetroLinkSignUp_Click(object sender, EventArgs e)
        {
            FormSignup frm = new FormSignup();
            frm.ShowDialog();
        }

        private void metroButtonSignIn_Click(object sender, EventArgs e)
		{
			TaiKhoan tk = new TaiKhoan()
			{
				ChuTaiKhoan = null,
				TenDangNhap = metroTextBoxUsername.Text,
				MatKhau = metroTextBoxPassword.Text
			};
			if (DataUlti.KiemTraHopLe(tk))
			{
				if (tk.PhanHe == 1) // Học sinh
				{
					MessageBox.Show(string.Format("Đăng nhập thành công, chào mừng {0}", tk.ChuTaiKhoan));

                    FormMain FM = new FormMain(tk.ChuTaiKhoan);
                    FM.FormClosed += FM_FormClosed;
                    this.Hide();
                    FM.ShowDialog();
				}
				else if (tk.PhanHe == 2) // Giáo viên
				{
                    MessageBox.Show(string.Format("Đăng nhập thành công , chào mừng {0}", tk.ChuTaiKhoan));

                    Form1 GV = new Form1();
                    GV.FormClosed += GV_FormClosed;
                    this.Hide();
                    GV.ShowDialog();
                    
				}
				else // Admin
				{
                    MessageBox.Show(string.Format("Đăng nhập thành công, chào mừng {0}", tk.ChuTaiKhoan));
                    
                    FormAdmin admin = new FormAdmin();
                    admin.FormClosed += Admin_FormClosed;
                    this.Hide();
                    admin.ShowDialog();
				}
			}
			else
			{
				MessageBox.Show("Đăng nhập thất bại, mật khẩu hoặc tên tài khoản không đúng", "Lỗi",
					MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

        private void FM_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }

        private void GV_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }

        private void Admin_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }
    }
}
