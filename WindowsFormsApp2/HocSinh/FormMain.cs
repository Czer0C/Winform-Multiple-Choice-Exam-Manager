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
    public partial class FormMain : MetroFramework.Forms.MetroForm
    {
        string MHS = null;
        string MMH = null;
        int? khoi = 0;
        int ThoiGianLamBai = 0;

        public FormMain()
        {
            InitializeComponent();
        }

        public FormMain(string id)
        {
            InitializeComponent();
            MHS = id;
            this.Load += FormMain_Load;
        }



        private void FormMain_Load(object sender, EventArgs e)
        {
            LoadSchedule();
            metroComboBoxSubject.DataSource = DataUlti.DSMon();
            metroComboBoxSubject.DisplayMember = "TenMonHoc";
            metroComboBoxSubject.ValueMember = "MaMonHoc";
            metroComboBoxSubject.SelectedIndex = 0;
            metroComboBoxGrade.SelectedIndex = 0;

            dgvPractice.CellClick += DgvPractice_CellClick;
            dgvSchedule.CellClick += DgvSchedule_CellClick;


            metroComboBoxSubject.SelectedIndexChanged += MetroComboBoxSubject_SelectedIndexChanged;
            metroComboBoxGrade.SelectedIndexChanged += MetroComboBoxGrade_SelectedIndexChanged;
            LoadPractice();
            LoadResult();
        }

        private void LoadResult()
        {
            dgvRes.DataSource = null;
            dgvRes.Columns.Clear();
            dgvRes.AutoGenerateColumns = false;
            using (var ds = new QuanLyThiTracNghiemDataContext())
            {
                try
                {
                    dgvRes.DataSource = from d in ds.DSDUTHIs
                                        join k in ds.KyThis
                                        on d.MaKyThi equals k.MaKyThi
                                        where d.MaHocSinh == MHS
                                        select new
                                        {
                                            TenKyThi = k.TenKyThi,
                                            NgayThi = k.NgayThi,
                                            MaDeThi = d.MaDeThi,
                                            ThoiGianBD = d.ThoiGianBD,
                                            KetQua = d.KetQua
                                        };

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            dgvRes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvRes.RowHeadersVisible = false;
            dgvRes.AutoGenerateColumns = false;
            DataGridViewTextBoxColumn dgvCol = new DataGridViewTextBoxColumn();

            dgvCol.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvCol.HeaderText = "Tên kỳ thi";
            dgvCol.DataPropertyName = "TenKyThi";
            dgvRes.Columns.Add(dgvCol);

            dgvCol = new DataGridViewTextBoxColumn();
            dgvCol.HeaderText = "Ngày thi";
            dgvCol.DataPropertyName = "NgayThi";
            dgvCol.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgvRes.Columns.Add(dgvCol);

            dgvCol = new DataGridViewTextBoxColumn();
            dgvCol.HeaderText = "Mã đề thi";
            dgvCol.DataPropertyName = "MaDeThi";
            dgvCol.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgvRes.Columns.Add(dgvCol);

            dgvCol = new DataGridViewTextBoxColumn();
            dgvCol.HeaderText = "Thời gian Bắt đầu";
            dgvCol.DataPropertyName = "ThoiGianBD";
            dgvCol.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvRes.Columns.Add(dgvCol);

            dgvCol = new DataGridViewTextBoxColumn();
            dgvCol.HeaderText = "Kết quả";
            dgvCol.DataPropertyName = "KetQua";
            dgvCol.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgvRes.Columns.Add(dgvCol);
        }

        private void DgvSchedule_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex != dgvSchedule.Columns["war"].Index)
            {
                return;
            }

            DateTime NgayThi = DateTime.Parse(dgvSchedule.SelectedRows[0].Cells[2].Value.ToString());
            string MKT = dgvSchedule.SelectedRows[0].Cells[0].Value.ToString();

            // Lấy tgian quy định.
            ThoiGianLamBai = (int)dgvSchedule.SelectedRows[0].Cells[4].Value;

            //MessageBox.Show(t.CompareTo(DateTime.Now).ToString());

            if (dgvSchedule.SelectedRows[0].Cells[6].Value.ToString() == "Đóng" ||
                (NgayThi.Date.CompareTo(DateTime.Now.Date) != 0))
            {
                MessageBox.Show("Đã hết hạn làm bài thi");
                return;
            }
            else
            {

                TimeSpan BD = DataUlti.LayThoiGianBD(MHS, MKT);
                TimeSpan now = DateTime.Now.TimeOfDay;
                if (BD != null && BD.Subtract(now).TotalMinutes > ThoiGianLamBai)
                {
                    MessageBox.Show("Đã hết hạn làm bài thi");
                    return;
                }
            }



            using (var ds = new QuanLyThiTracNghiemDataContext())
            {
                try
                {
                    var q = ds.DSDUTHIs.Where(d => d.MaHocSinh == MHS && d.MaKyThi == MKT).SingleOrDefault();
                    if (q != null)
                    {
                        if (q.DaThi == true)
                        {
                            MessageBox.Show("Bài thi đã được hoàn thành");
                            return;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }
            }



            //MessageBox.Show(MDT);
            if (MessageBox.Show("Sẵn sàng làm bài thi?",
                   "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                return;
            }
            string MDT = null;

            // Kiểm tra xem có đang làm bài dang dở.
            if (DataUlti.TiepTucThi(MHS, MKT) == false)
            {
                // Bốc đề ngẫu nhiên trong kỳ thi.
                var q = DataUlti.LayDeThi(MKT);
                Random roulette = new Random();
                MDT = q[roulette.Next(0, q.Count)].MaDeThi;

                // Bắt đầu làm bài:
                DataUlti.BatDauThi(MHS, MKT, MDT);
            }
            else
            {
                // Kiểm tra tgian làm bài:
                TimeSpan now = DateTime.Now.TimeOfDay;
                TimeSpan lastLog = DataUlti.LayThoiGianBD(MHS, MKT);
                if (now.Subtract(lastLog).TotalMinutes > ThoiGianLamBai)
                {
                    MessageBox.Show("Đã hết hạn làm bài");
                    return;
                }

                // Tiếp tục.
                MDT = DataUlti.DSThi(MKT)
                    .Where(d => d.MaHocSinh == MHS && d.MaKyThi == MKT)
                    .Select(d => d.MaDeThi).SingleOrDefault().ToString();
            }
            FormTest FT = new FormTest(MHS, MDT, MKT, true, ThoiGianLamBai);
            FT.ShowDialog();

            LoadResult();
        }

        // Button làm bài ôn tập ở gridview.
        private void DgvPractice_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex != dgvPractice.Columns["war"].Index || e.RowIndex < 0)
            {
                return;
            }
            if (MessageBox.Show("Sẵn sàng làm bài thi?",
                   "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                return;
            }
            string MDT = dgvPractice.SelectedRows[0].Cells[0].Value.ToString();
            //MessageBox.Show(MDT);
            FormTest FT = new FormTest(MDT);
            FT.ShowDialog();
        }

        private void LoadPractice()
        {
            MMH = metroComboBoxSubject.SelectedValue.ToString();
            try
            {
                khoi = int.Parse(metroComboBoxGrade.SelectedItem.ToString());
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

            dgvPractice.Columns.Clear();
            dgvPractice.DataSource = null;
            dgvPractice.AutoGenerateColumns = false;
            using (var ds = new QuanLyThiTracNghiemDataContext())
            {
                try
                {
                    dgvPractice.DataSource = (from dt in ds.DeThis
                                              from ct in ds.ChiTietKyThis
                                              from kt in ds.KyThis
                                              where dt.MaDeThi == ct.MaDeThi && ct.MaKyThi == kt.MaKyThi
                                                       && dt.DaDung == true && dt.MonThi == MMH && dt.Khoi == khoi
                                              select new
                                              {
                                                  MaDeThi = dt.MaDeThi,
                                                  SuDungTrong = kt.TenKyThi,
                                                  ThoiGianLamBai = kt.ThoiGianLamBai,
                                                  NgayThi = kt.NgayThi,
                                                  ThiThu = kt.ThiThu == true ? "Thi thử" : "Chính thức",
                                                  war = "Chiến"
                                              }).ToList();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }

            dgvPractice.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPractice.RowHeadersVisible = false;
            DataGridViewTextBoxColumn dgvCol = new DataGridViewTextBoxColumn();

            dgvCol.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;

            dgvCol.HeaderText = "Mã đề thi";
            dgvCol.DataPropertyName = "MaDeThi";
            dgvPractice.Columns.Add(dgvCol);

            dgvCol = new DataGridViewTextBoxColumn();
            dgvCol.HeaderText = "Sử dụng trong";
            dgvCol.DataPropertyName = "SuDungTrong";
            dgvPractice.Columns.Add(dgvCol);

            dgvCol = new DataGridViewTextBoxColumn();
            dgvCol.HeaderText = "Thời gian";
            dgvCol.DataPropertyName = "ThoiGianLamBai";
            dgvCol.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            dgvPractice.Columns.Add(dgvCol);

            dgvCol = new DataGridViewTextBoxColumn();
            dgvCol.HeaderText = "Ngày thi";
            dgvCol.DataPropertyName = "NgayThi";
            dgvCol.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvPractice.Columns.Add(dgvCol);

            dgvCol = new DataGridViewTextBoxColumn();
            dgvCol.HeaderText = "Hình thức";
            dgvCol.DataPropertyName = "ThiThu";
            dgvCol.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvPractice.Columns.Add(dgvCol);

            DataGridViewButtonColumn dgvBut = new DataGridViewButtonColumn();
            dgvBut.HeaderText = "Luyện tập";
            dgvBut.Name = "war";
            dgvBut.DataPropertyName = "war";
            dgvBut.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvPractice.Columns.Add(dgvBut);

        }


        private void MetroComboBoxSubject_SelectedIndexChanged(object sender, EventArgs e)
        {

            LoadPractice();
        }

        private void MetroComboBoxGrade_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadPractice();
        }

        private void LoadSchedule()
        {
            dgvSchedule.AutoGenerateColumns = false;

            IList<KyThi> t = DataUlti.LayLichThi(MHS);
            dgvSchedule.DataSource = (from k in t
                                      from m in DataUlti.DSMon()
                                      where m.MaMonHoc == k.MonThi
                                      select new
                                      {
                                          k.MaKyThi,
                                          k.TenKyThi,
                                          k.NgayThi,
                                          k.ThoiGianLamBai,
                                          ThiThu = k.ThiThu == true ? "Thi thử" : "Chính thức",
                                          m.TenMonHoc,
                                          KetThuc = k.KetThuc == true ? "Đóng" : "Mở",
                                          war = "Thi"
                                      }).ToList();

            dgvSchedule.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSchedule.RowHeadersVisible = false;
            dgvSchedule.AutoGenerateColumns = false;
            DataGridViewTextBoxColumn dgvCol = new DataGridViewTextBoxColumn();

            dgvCol.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgvCol.HeaderText = "Mã kỳ thi     ";
            dgvCol.DataPropertyName = "MaKyThi";
            dgvSchedule.Columns.Add(dgvCol);

            dgvCol = new DataGridViewTextBoxColumn();
            dgvCol.HeaderText = "Tên kỳ thi";
            dgvCol.DataPropertyName = "TenKyThi";
            dgvCol.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvSchedule.Columns.Add(dgvCol);

            dgvCol = new DataGridViewTextBoxColumn();
            dgvCol.HeaderText = "Ngày thi";
            dgvCol.DataPropertyName = "NgayThi";
            dgvCol.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            dgvSchedule.Columns.Add(dgvCol);

            dgvCol = new DataGridViewTextBoxColumn();
            dgvCol.HeaderText = "Môn Thi";
            dgvCol.DataPropertyName = "TenMonHoc";
            dgvCol.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            dgvSchedule.Columns.Add(dgvCol);

            dgvCol = new DataGridViewTextBoxColumn();
            dgvCol.HeaderText = "Thời gian";
            dgvCol.DataPropertyName = "ThoiGianLamBai";
            dgvCol.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            dgvSchedule.Columns.Add(dgvCol);

            dgvCol = new DataGridViewTextBoxColumn();
            dgvCol.HeaderText = "Hình thức";
            dgvCol.DataPropertyName = "ThiThu";
            dgvCol.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            dgvSchedule.Columns.Add(dgvCol);

            dgvCol = new DataGridViewTextBoxColumn();
            dgvCol.HeaderText = "Trạng thái";
            dgvCol.DataPropertyName = "KetThuc";
            dgvCol.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            dgvSchedule.Columns.Add(dgvCol);

            DataGridViewButtonColumn dgvBut = new DataGridViewButtonColumn();
            dgvBut.HeaderText = "Thi          ";
            dgvBut.Name = "war";
            dgvBut.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            dgvBut.DataPropertyName = "war";

            dgvSchedule.Columns.Add(dgvBut);
        }

        private void thôngTinCáNhânToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormProfile FP = new FormProfile(MHS);
            FP.ShowDialog();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xác nhận đăng xuất?",
                    "Xác nhận xóa", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                return;
            }
            this.Close();
        }
    }
}
