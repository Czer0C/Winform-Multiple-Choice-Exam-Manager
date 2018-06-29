using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MetroFramework.Forms;
using System.Timers;
namespace WindowsFormsApp2
{
    public partial class FormTest : MetroFramework.Forms.MetroForm
    {

        string MHS = null;
        string MaDeThi = null;
        string MaKyThi = null;
        DataGridView dgvRes = null;
        int answerCount = 0;
        double c = 0;

        bool offi;
        int ThoiGianLamBai = 0;
        bool showHint = true;
        bool? showSpoil = null;

        IList<CauHoi> listQuestion = new List<CauHoi>();
        IList<DapAn> listAnswer = new List<DapAn>();
        IList<LuuTru> listChoices = new List<LuuTru>();
        private int test = 0;

        public int Test
        {
            get { return test; }
            set
            {

                test = value;
                status.Text = test.ToString();
                metroComboBoxQuestion.SelectedIndex = test;
                metroButtonSpoil.Text = "Xem đáp án";
                showSpoil = true;
                Reload(test);

            }
        }

        private void Reload(int test)
        {


            metroLabelQuestion.Text = string.Format("{0}. {1}", test + 1, listQuestion[test].NoiDung);
            metroRadioButtonA.Text = string.Format("A. {0}", listAnswer[test * 4].NoiDung);
            metroRadioButtonB.Text = string.Format("B. {0}", listAnswer[test * 4 + 1].NoiDung);
            metroRadioButtonC.Text = string.Format("C. {0}", listAnswer[test * 4 + 2].NoiDung);
            metroRadioButtonD.Text = string.Format("D. {0}", listAnswer[test * 4 + 3].NoiDung);
            metroLabelHint2.Text = listQuestion[test].GoiY;



            var temp = listChoices.Where(s => s.MaCauHoi == listQuestion[Test].MaCauHoi).SingleOrDefault();
            if (temp == null)
            {
                metroRadioButtonA.Checked = false;
                metroRadioButtonB.Checked = false;
                metroRadioButtonC.Checked = false;
                metroRadioButtonD.Checked = false;

            }
            else
            {
                if (temp.MaDapAn == "A")
                {
                    metroRadioButtonA.Checked = true;
                }
                else if (temp.MaDapAn == "B")
                {
                    metroRadioButtonB.Checked = true;
                }
                else if (temp.MaDapAn == "C")
                {
                    metroRadioButtonC.Checked = true;
                }
                else if (temp.MaDapAn == "D")
                {
                    metroRadioButtonD.Checked = true;
                }

            }

        }

        public FormTest()
        {
            InitializeComponent();
            MHS = "1612030009";
            MaDeThi = "MH01120001";
            MaKyThi = "CK201801MH01";

            metroLabelStat.Visible = false;
            metroButtonExit.Visible = false;
            metroLabelStat.Visible = false;

            listQuestion = DataUlti.DSCauHoi(MaDeThi);
            listAnswer = DataUlti.DSDapAn(MaDeThi);

            answerCount = listAnswer.Count / 4;
            for (int i = 0; i < answerCount; i++)
                metroComboBoxQuestion.Items.Add((i + 1).ToString());

            metroLabelProgress.Text = string.Format("Đã hoàn thành: {0}/{1}", 0, answerCount);
            metroComboBoxQuestion.SelectedIndex = 0;
            Reload(test);
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            SaveProgress();
            c = c - 0.5;
            Int64 temp = (long)c * 10000000;
            TimeSpan ts = new TimeSpan(temp);
            metroLabelTimer.Text = string.Format("{0:D2}h:{1:D2}m:{2:D2}s",
                ts.Hours, ts.Minutes, ts.Seconds);
            // Khi hết giờ thì tự động ngắt tất cả.
            if (c == 0)
            {
                MessageBox.Show("Đã hết giờ làm bài!");
                DataUlti.KetThucBaiThi(MHS, MaKyThi);
                ShowResult();
            }

        }

        public FormTest(string id, string MDT, string MKT, bool Official, int TG)
        {
            InitializeComponent();
            MHS = id;
            MaDeThi = MDT;
            MaKyThi = MKT;
            offi = true;
            ThoiGianLamBai = TG;

            // Thời gian bắt đầu.
            TimeSpan TGBD = DataUlti.LayThoiGianBD(MHS, MKT);
            TimeSpan ts = DateTime.Now.TimeOfDay;
            double n1 = TGBD.Subtract(ts).TotalSeconds;
            double n2 = TG * 60;
            // Thời gian còn lại.
            c = n1 + n2;

            metroButtonHint.Visible = false;
            metroButtonSpoil.Visible = false;
            this.Load += FormTest_Load;

        }

        public FormTest(string MDT)
        {
            InitializeComponent();
            MaDeThi = MDT;
            MaKyThi = "";
            MHS = "";
            offi = false;
            this.Load += FormTest_Load;
            metroButtonRestore.Visible = false;
            metroLabel3.Visible = false;
            metroLabelTimer.Visible = false;
        }
        private void LoadInfo()
        {
            using (var ds = new QuanLyThiTracNghiemDataContext())
            {
                try
                {
                    if (offi)
                    {
                        var q = ds.KyThis.Where(k => k.MaKyThi == MaKyThi).SingleOrDefault();
                        lblExamName.Text = q.TenKyThi;
                        lblTestId.Text = string.Format("Mã đề: {0}", MaDeThi);
                        lblDate.Text = string.Format("Ngày thi: {0}", q.NgayThi.Value.ToShortDateString());
                        lblTime.Text = string.Format("Thời gian làm bài: {0} phút", q.ThoiGianLamBai);
                    }
                    else
                    {
                        lblExamName.Text = "Luyện tập";
                        lblTestId.Text = string.Format("Mã đề: {0}", MaDeThi);
                        lblDate.Visible = false;
                        lblTime.Visible = false;
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void FormTest_Load(object sender, EventArgs e)
        {
            status.Text = "bình thường";
            metroLabelStat.Visible = false;
            metroButtonExit.Visible = false;
            metroLabelStat.Visible = false;
            LoadInfo();
            listQuestion = DataUlti.DSCauHoi(MaDeThi);
            listAnswer = DataUlti.DSDapAn(MaDeThi);

            timer1.Tick += Timer1_Tick;
            timer1.Start();

            answerCount = listAnswer.Count / 4;
            for (int i = 0; i < answerCount; i++)
                metroComboBoxQuestion.Items.Add((i + 1).ToString());

            metroLabelProgress.Text = string.Format("Đã hoàn thành: {0}/{1}", 0, answerCount);
            metroComboBoxQuestion.SelectedIndex = 0;

            metroLabelHint.Visible = false;
            metroLabelHint2.Visible = false;

            Reload(test);
            showSpoil = true;
        }

        private string getAnswerID()
        {
            if (metroRadioButtonA.Checked)
            {
                return "A";
            }
            else if (metroRadioButtonB.Checked)
            {
                return "B";
            }
            else if (metroRadioButtonC.Checked)
            {
                return "C";
            }
            else if (metroRadioButtonD.Checked)
            {
                return "D";
            }
            else
            {
                return "";
            }
        }

        private int SaveProgress()
        {
            if (getAnswerID() == "")
                return -1; // Chưa chọn gì hết thì không lưu.

            LuuTru temp = listChoices.Where(s => s.MaCauHoi == listQuestion[Test].MaCauHoi).SingleOrDefault();
            if (temp == null)
            {
                listChoices.Add(new LuuTru(MaKyThi, MaDeThi, MHS, listQuestion[Test].MaCauHoi, getAnswerID()));
            }
            else
            {
                temp.MaDapAn = getAnswerID();
            }
            IEnumerable<LuuTru> t = listChoices.OrderBy(f => f.MaCauHoi);
            listChoices = t.ToList();
            metroLabelProgress.Text = string.Format("Đã hoàn thành {0}/{1}", t.Count(), answerCount);

            if (offi)
            {
                if (DataUlti.LuuDapAn(listChoices))
                {
                    status.Text = "Lưu tự động thành công";
                    return 1;
                }
                else
                {
                    status.Text = "Lưu tự động thất bại";
                    return 0;
                }
            }
            else
                return -1;
        }

        private void metroButtonNext_Click(object sender, EventArgs e)
        {
            //SaveProgress();
            if (Test < answerCount - 1)
                Test++;
        }

        private void metroButtonPrevious_Click(object sender, EventArgs e)
        {
            //SaveProgress();
            if (Test > 0)
                Test--;
        }

        private void metroComboBoxQuestion_SelectedIndexChanged(object sender, EventArgs e)
        {

            Test = metroComboBoxQuestion.SelectedIndex;

        }

        private void metroButtonFinish_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn hoàn thành bài thi?\r\n" +
                "Lưu ý: không thể hoàn tác sau khi xác nhận?",
                    "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                return;
            }
            timer1.Stop();
            metroLabel2.Visible = false;
            metroLabel3.Visible = false;
            status.Visible = false;
            groupBoxInterface.Visible = false;
            groupBoxInfo.Visible = false;
            metroButtonExit.Visible = true;
            metroLabelStat.Top = 120;
            metroLabelStat.Visible = true;

            if (offi == true)
            {
                DataUlti.KetThucBaiThi(MHS, MaKyThi);
                ShowResult();
            }
            else
            {
                ShowPracticeResult();
            }
        }

        private void ShowPracticeResult()
        {
            dgvRes = new DataGridView();
            dgvRes.CellClick += DgvRes_CellClick;
            dgvRes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvRes.ClientSize = new Size(750, 300);
            dgvRes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvRes.MultiSelect = false;

            dgvRes.RowPostPaint += DgvRes_RowPostPaint;
            dgvRes.AutoGenerateColumns = false;
            dgvRes.Left = (this.ClientSize.Width - dgvRes.Width) / 2;
            dgvRes.Top = (this.ClientSize.Height - dgvRes.Height) / 2;

            dgvRes.DataSource = (from lc in listChoices
                                 join la in listAnswer
                                 on new
                                 {
                                     lc.MaCauHoi,
                                     lc.MaDapAn
                                 }
                                 equals new
                                 {
                                     la.MaCauHoi,
                                     la.MaDapAn
                                 }
                                 select new
                                 {
                                     MaCauHoi = la.MaCauHoi,
                                     LuaChon = la.MaDapAn,
                                     DungSai = la.Dung == true ? "Đúng" : "Sai",
                                     Xem = "Xem lại"
                                 }).ToList();


            DataGridViewTextBoxColumn dgvCol = new DataGridViewTextBoxColumn();
            dgvCol.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgvCol.HeaderText = "Lựa chọn";
            dgvCol.DataPropertyName = "LuaChon";
            dgvRes.Columns.Add(dgvCol);

            dgvCol = new DataGridViewTextBoxColumn();
            dgvCol.HeaderText = "Đúng sai";
            dgvCol.DataPropertyName = "DungSai";
            dgvRes.Columns.Add(dgvCol);

            dgvCol = new DataGridViewTextBoxColumn();
            dgvCol.HeaderText = "Mã câu hỏi";
            dgvCol.DataPropertyName = "MaCauHoi";
            dgvCol.Visible = false;
            dgvRes.Columns.Add(dgvCol);

            DataGridViewButtonColumn dgvBut = new DataGridViewButtonColumn();
            dgvBut.HeaderText = "Xem";
            dgvBut.DataPropertyName = "Xem";
            dgvBut.Name = "Xem";
            dgvBut.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgvRes.Columns.Add(dgvBut);

            this.Controls.Add(dgvRes);
            dgvRes.Show();
        }

        // Thi thử.
        private void DgvRes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex != dgvRes.Columns["Xem"].Index)
            {
                return;
            }
            string t1 = dgvRes.Rows[e.RowIndex].Cells[2].Value.ToString();
            string t2 = dgvRes.Rows[e.RowIndex].Cells[0].Value.ToString();
            CheckAnswer CA = new CheckAnswer(t1, t2);
            CA.ShowDialog();
        }

        // Thi thật.
        private void dgvRes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex != dgvRes.Columns["Xem"].Index)
            {
                return;
            }
            string t1 = dgvRes.Rows[e.RowIndex].Cells[1].Value.ToString();
            string t2 = dgvRes.Rows[e.RowIndex].Cells[0].Value.ToString();
            CheckAnswer CA = new CheckAnswer(t1, t2);
            CA.ShowDialog();
        }

        private void ShowResult()
        {
            dgvRes = new DataGridView();
            dgvRes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvRes.ClientSize = new Size(750, 300);
            dgvRes.CellClick += new DataGridViewCellEventHandler(dgvRes_CellClick);
            dgvRes.RowPostPaint += DgvRes_RowPostPaint;
            dgvRes.AutoGenerateColumns = false;
            dgvRes.Left = (this.ClientSize.Width - dgvRes.Width) / 2;
            dgvRes.Top = (this.ClientSize.Height - dgvRes.Height) / 2;

            using (var ds = new QuanLyThiTracNghiemDataContext())
            {
                try
                {

                    dgvRes.DataSource = (from lt in ds.LuuTrus
                                         from da in ds.DapAns
                                         where lt.MaKyThi == MaKyThi && lt.MaHocSinh == MHS
                                         && lt.MaDapAn == da.MaDapAn && lt.MaCauHoi == da.MaCauHoi
                                         select new
                                         {
                                             MaCauHoi = lt.MaCauHoi,
                                             MaDapAn = lt.MaDapAn,
                                             Dung = da.Dung == true ? "Đúng" : "Sai",
                                             Xem = "Xem"
                                         }).ToList();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            DataGridViewTextBoxColumn dgvCol = new DataGridViewTextBoxColumn();
            dgvCol.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgvCol.HeaderText = "Lựa chọn";
            dgvCol.DataPropertyName = "MaDapAn";
            dgvRes.Columns.Add(dgvCol);

            dgvCol = new DataGridViewTextBoxColumn();
            dgvCol.HeaderText = "Mã câu hỏi";
            dgvCol.DataPropertyName = "MaCauHoi";
            dgvCol.Visible = false;
            dgvRes.Columns.Add(dgvCol);

            dgvCol = new DataGridViewTextBoxColumn();
            dgvCol.HeaderText = "Đúng sai";
            dgvCol.DataPropertyName = "Dung";
            dgvRes.Columns.Add(dgvCol);

            DataGridViewButtonColumn dgvBut = new DataGridViewButtonColumn();
            dgvBut.HeaderText = "Xem";
            dgvBut.Name = "Xem";
            dgvBut.DataPropertyName = "Xem";
            dgvRes.Columns.Add(dgvBut);

            this.Controls.Add(dgvRes);
            dgvRes.Show();
        }

        // Đánh số thứ tự cho từng dòng.
        private void DgvRes_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            var grid = sender as DataGridView;
            var rowIdx = (e.RowIndex + 1).ToString();

            var centerFormat = new StringFormat()
            {
                // right alignment might actually make more sense for numbers
                Alignment = StringAlignment.Center,
                LineAlignment = StringAlignment.Center
            };

            var headerBounds = new Rectangle(e.RowBounds.Left, e.RowBounds.Top,
                grid.RowHeadersWidth, e.RowBounds.Height);
            e.Graphics.DrawString(rowIdx, this.Font, SystemBrushes.ControlText, headerBounds, centerFormat);
        }

        private void metroButtonExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Kết thúc?",
                    "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                return;
            }
            this.Close();
        }

        private void metroButtonHint_Click(object sender, EventArgs e)
        {
            if (showHint)
            {
                metroLabelHint.Visible = true;
                metroLabelHint2.Visible = true;
                showHint = false;
                metroButtonHint.Text = "Ẩn gợi ý";
            }
            else
            {
                metroLabelHint.Visible = false;
                metroLabelHint2.Visible = false;
                showHint = true;
                metroButtonHint.Text = "Xem gợi ý";
            }
        }

        private void metroButtonSpoil_Click(object sender, EventArgs e)
        {
            if (showSpoil == true)
            {
                if (listAnswer[test * 4].Dung == true)
                {
                    metroRadioButtonA.Text += " \u2713";
                }
                else if (listAnswer[test * 4 + 1].Dung == true)
                {
                    metroRadioButtonB.Text += " \u2713";
                }
                else if (listAnswer[test * 4 + 2].Dung == true)
                {
                    metroRadioButtonC.Text += " \u2713";
                }
                else if (listAnswer[test * 4 + 3].Dung == true)
                {
                    metroRadioButtonD.Text += " \u2713";
                }

                metroButtonSpoil.Text = "Ẩn đáp án";
                showSpoil = false;
                return;
            }
            else if (showSpoil == false)
            {
                metroRadioButtonA.Text = string.Format("A. {0}", listAnswer[test * 4].NoiDung);
                metroRadioButtonB.Text = string.Format("B. {0}", listAnswer[test * 4 + 1].NoiDung);
                metroRadioButtonC.Text = string.Format("C. {0}", listAnswer[test * 4 + 2].NoiDung);
                metroRadioButtonD.Text = string.Format("D. {0}", listAnswer[test * 4 + 3].NoiDung);
                metroButtonSpoil.Text = "Xem đáp án";
                showSpoil = true;
            }

        }

        private void metroButtonRestore_Click(object sender, EventArgs e)
        {
            try
            {
                listChoices = DataUlti.XemLichSuBaiLam(MHS, MaDeThi, MaKyThi);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            metroLabelProgress.Text = string.Format("Đã hoàn thành {0}/{1}", listChoices.Count, answerCount);
            MessageBox.Show("Khôi phục thành công");
        }

    }
}
