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
    public partial class CheckAnswer : MetroFramework.Forms.MetroForm
    {
        public CheckAnswer()
        {
            InitializeComponent();
        }

        public CheckAnswer(string MCH, string choice)
        {
            InitializeComponent();
            using (var ds = new QuanLyThiTracNghiemDataContext())
            {
                try
                {
                    var q = (from ch in ds.CauHois
                             join da in ds.DapAns on
                             ch.MaCauHoi equals da.MaCauHoi
                             where ch.MaCauHoi == MCH
                             select new
                             {
                                 NoiDung = ch.NoiDung,
                                 MaDaAp = da.MaDapAn,
                                 NoiDungDa = da.NoiDung,
                                 Dung = da.Dung,
                                 DoKho = ch.DoKho,
                                 GoiY = ch.GoiY
                             }).ToList();
                    metroLabel1.Text = q[0].NoiDung;
                    A.Text = q[0].NoiDungDa;
                    B.Text = q[1].NoiDungDa;
                    C.Text = q[2].NoiDungDa;
                    D.Text = q[3].NoiDungDa;

                    picked.Text = string.Format("Bạn chọn câu: {0}", choice);
                    Hint.Text = string.Format("Gợi ý: {0}", q[0].GoiY);

                    if (q[0].Dung == true)
                    {
                        Answer.Text = string.Format("Đáp án là câu A: {0}", q[0].NoiDungDa);
                    }
                    else if (q[1].Dung == true)
                    {
                        Answer.Text = string.Format("Đáp án là câu B: {0}", q[1].NoiDungDa);
                    }
                    else if (q[2].Dung == true)
                    {
                        Answer.Text = string.Format("Đáp án là câu C: {0}", q[2].NoiDungDa);
                    }
                    else
                    {
                        Answer.Text = string.Format("Đáp án là câu D: {0}", q[3].NoiDungDa);
                    }
                    string diff;
                    if (q[0].DoKho == 1)
                        diff = "Max dễ";
                    else if (q[0].DoKho == 1)
                        diff = "Dễ";
                    else if (q[0].DoKho == 1)
                        diff = "Bình thường";
                    else
                    {
                        diff = "Khó";
                    }

                    Difficulty.Text = string.Format("Độ khó: {0}", diff);

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void metroButtonReturn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Quay lại?",
                    "Xác nhận xóa", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                return;
            }
            this.Close();
        }
    }
}
