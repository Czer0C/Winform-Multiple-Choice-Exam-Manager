using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace WindowsFormsApp2
{
    public partial class FormSignup : MetroForm
    {
        public FormSignup()
        {
            InitializeComponent();
            this.Load += FormSignup_Load;
            btnKiemTra.Click += BtnKiemTra_Click;
            btnXacNhan.Click += BtnXacNhan_Click;
        }

        private void BtnXacNhan_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaTK.Text) && string.IsNullOrEmpty(txtTenTK.Text) && string.IsNullOrEmpty(txtMatKhau.Text))
            {
                MessageBox.Show("Xin nhập đầy đủ thông tin");
                return;
            }
            else
            {
                int flag = 1;
                using (var tk = new QuanLyThiTracNghiemDataContext())
                {
                    var isHocSinh = tk.HocSinhs.Where(u => u.MaHocSinh == txtMaTK.Text).SingleOrDefault();

                    if (isHocSinh != null)
                    {
                        // tạo đối tượng tài khoản
                        TaiKhoan t = new TaiKhoan()
                        {
                            ChuTaiKhoan = txtMaTK.Text,
                            TenDangNhap = txtTenTK.Text,
                            MatKhau = txtMatKhau.Text,
                            PhanHe = 1
                        };

                        //ChuTaiKhoan ctk = new ChuTaiKhoan()
                        //{
                        //    ID = txtMaTK.Text                           
                        //};

                        tk.TaiKhoans.InsertOnSubmit(t);
                        //tk.ChuTaiKhoans.InsertOnSubmit(ctk);
                        try
                        {
                            tk.SubmitChanges();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                            return;
                        }
                    }
                    else
                    {
                        var isGiaoVien = tk.GiaoViens.Where(u => u.MaGiaoVien == txtMaTK.Text).SingleOrDefault();

                        if (isGiaoVien != null)
                        {
                            TaiKhoan t = new TaiKhoan()
                            {
                                ChuTaiKhoan = txtMaTK.Text,
                                TenDangNhap = txtTenTK.Text,
                                MatKhau = txtMatKhau.Text,
                                PhanHe = 2
                            };

                            //ChuTaiKhoan ctk = new ChuTaiKhoan()
                            //{
                            //    ID = txtMaTK.Text
                            //};

                            tk.TaiKhoans.InsertOnSubmit(t);
                            //tk.ChuTaiKhoans.InsertOnSubmit(ctk);
                            try
                            {
                                tk.SubmitChanges();
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message);
                                return;
                            }
                        }
                        else
                        {
                            flag = 0;
                        }
                    }
                }

                if (flag == 1)
                {
                    MessageBox.Show("Đăng ký thành công");
                    return;
                }
                else
                {
                    MessageBox.Show("Mã tài khoản không tồn tại");
                }
            }
        }

        private void BtnKiemTra_Click(object sender, EventArgs e)
        {
            using (var kt = new QuanLyThiTracNghiemDataContext())
            {
                //var query = kt.ChuTaiKhoans.Where(u => u.ID == txtMaTK.Text).SingleOrDefault();
                var query = kt.TaiKhoans.Where(u => u.ChuTaiKhoan == txtMaTK.Text).SingleOrDefault();

                if (query != null)
                {
                    MessageBox.Show("Người dùng đã có tài khoản");
                }
                else
                {
                    txtTenTK.Enabled = true;
                    txtMatKhau.Enabled = true;
                    btnXacNhan.Enabled = true;
                }
            }
        }

        private void FormSignup_Load(object sender, EventArgs e)
        {
            txtTenTK.Enabled = false;
            txtMatKhau.Enabled = false;
            btnXacNhan.Enabled = false;
        }
    }
}
