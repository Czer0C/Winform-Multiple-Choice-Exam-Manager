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
    public partial class FormProfile : MetroFramework.Forms.MetroForm
    {
        public FormProfile()
        {
            InitializeComponent();
        }
        public FormProfile(string id)
        {
            InitializeComponent();
            metroComboBoxHometown.DataSource = DataUlti.DSQueQuan();
            metroComboBoxHometown.DisplayMember = "TenDiaPhuong";
            metroComboBoxHometown.ValueMember = "MaVung";

            HocSinh sv = DataUlti.TimHocSinh(id);
            dateTimePickerBirthday.Format = DateTimePickerFormat.Custom;
            dateTimePickerBirthday.CustomFormat = "dd-MM-yyyy";

            metroTextBoxID.Text = sv.MaHocSinh;
            metroTextBoxName.Text = sv.TenHocSinh;
            try
            {

                metroComboBoxHometown.SelectedValue = sv.QueQuan;
                dateTimePickerBirthday.Value = sv.NgaySinh.Value;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            metroTextBoxClass.Text = sv.Lop;
            metroTextBoxGrade.Text = sv.Khoi.ToString();

            metroRadioButtonMale.Checked = sv.GioiTinh == true ? true : false;
            metroRadioButtonFemale.Checked = sv.GioiTinh == false ? true : false;
        }

        private void metroButtonEdit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xác nhận chỉnh sửa thông tin?",
                    "Xác nhận xóa", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                return;
            }

            HocSinh sv = new HocSinh();
            sv.MaHocSinh = metroTextBoxID.Text;
            sv.TenHocSinh = metroTextBoxName.Text;
            sv.QueQuan = (int)metroComboBoxHometown.SelectedValue;
            sv.GioiTinh = metroRadioButtonMale.Checked;
            sv.NgaySinh = dateTimePickerBirthday.Value;

            if (DataUlti.SuaThongTinHocSinh(sv))
            {
                MessageBox.Show("Thành công");
                ReloadForm();
            }
            else
            {
                MessageBox.Show("Thất bại");
            }
        }

        private void ReloadForm()
        {
            metroComboBoxHometown.DataSource = null;
            metroComboBoxHometown.DataSource = DataUlti.DSQueQuan();
            metroComboBoxHometown.DisplayMember = "TenDiaPhuong";
            metroComboBoxHometown.ValueMember = "MaVung";
            HocSinh sv = DataUlti.TimHocSinh(metroTextBoxID.Text);

            metroTextBoxName.Text = sv.TenHocSinh;
            dateTimePickerBirthday.Value = sv.NgaySinh.Value;
            metroComboBoxHometown.SelectedValue = sv.QueQuan;
            metroRadioButtonMale.Checked = sv.GioiTinh == true ? true : false;
            metroRadioButtonFemale.Checked = sv.GioiTinh == false ? true : false;
        }
    }
}
