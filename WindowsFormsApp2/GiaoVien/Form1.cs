using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using MetroFramework.Forms;
using System.IO;
using System.Collections.Generic;

namespace WindowsFormsApp2
{
    public partial class Form1 : MetroForm
    {
        public Form1()
        {
            InitializeComponent();

            btnXoa.Click += BtnXoa_Click;
            btnViewAll.Click += btnViewAll_Click;

            // Tab Câu Hỏi            
            btnXuatFileCauHoi.Click += BtnXuatFileCauHoi_Click;
            btnNhapFileCauHoi.Click += BtnNhapFileCauHoi_Click;
        }

        private void BtnNhapFileCauHoi_Click(object sender, EventArgs e)
        {
            try
            {
                fileDialogImportExcel.Filter = "Excel files (*.xlsx)|*.xlsx|Excel files (*.xls)|*.xls";
                DialogResult dialog = fileDialogImportExcel.ShowDialog();

                if (dialog == DialogResult.OK)
                {
                    var notExistList = new List<DataRow>();
                    var existList = new List<DataRow>();

                    // Lấy dữ liệu từ file excel
                    //DataGridView tmpDGV = new DataGridView();
                    //tmpDGV.Columns.Clear();
                    var dt = DataUlti.ReadExcelFile(fileDialogImportExcel.FileName);
                    //tmpDGV.DataSource = dt;

                    // Lấy danh sách câu hỏi
                    var chList = DataUlti.DSCauHoi();

                    //Lấy ra danh sách các câu hỏi chưa có trong database
                    IEnumerable<string> list = chList.Select(ch => ch.MaCauHoi);
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        var MaCH = dt.Rows[i]["MaCauHoi"].ToString();
                        if (!list.Contains(MaCH))
                        {
                            notExistList.Add(dt.Rows[i]);
                        }
                        else
                        {
                            existList.Add(dt.Rows[i]);
                        }
                    }

                    // add vào database
                    // tạo đối tương CauHoi
                    if (notExistList.Count > 0)
                    {
                        int flag = 0;
                        foreach (var item in notExistList)
                        {
                            var ch = new CauHoi()
                            {
                                MaCauHoi = item["MaCauHoi"].ToString(),
                                Mon = item["Mon"].ToString(),
                                DoKho = int.Parse(item["DoKho"].ToString()),
                                Khoi = int.Parse(item["Khoi"].ToString()),
                                NoiDung = item["NoiDung"].ToString(),
                                GoiY = item["GoiY"].ToString()
                            };

                            if (!DataUlti.ThemCauHoi(ch))
                            {
                                flag = 1;
                                break;
                            }
                        }

                        if (flag == 0)
                        {
                            dt.Columns.Clear();
                            dt.Rows.Clear();
                            MessageBox.Show("Đã thêm vào CSDL");                            
                            LoadCauHoi();
                        }
                        else
                        {
                            MessageBox.Show("Có lỗi xãy ra");
                        }
                    }
                    else
                    {
                        if (existList.Count > 0)
                        {
                            string str = "";
                            if (existList.Count < 5)
                            {
                                foreach (var item in existList)
                                {
                                    str += item["MaCauHoi"].ToString() + "\n";
                                }
                                MessageBox.Show(string.Format("Các câu hỏi bị trùng:\n{0}", str));
                            }
                            else
                            {
                                MessageBox.Show(string.Format("Số lượng câu hỏi đã tồn tại quá nhiều: {0}", existList.Count));
                            }
                        }
                    }
                    notExistList.Clear();
                    existList.Clear();
                    dt.Dispose();
                }                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }           
        }

        private void BtnXuatFileCauHoi_Click(object sender, EventArgs e)
        {
            try
            {
                saveFileDialog.Filter = "Excel files (*.xls)|*.xls";
                DialogResult result = saveFileDialog.ShowDialog();

                if (result == DialogResult.OK)
                {
                    if (File.Exists(saveFileDialog.FileName))
                    {
                        File.Delete(saveFileDialog.FileName);
                    }

                    var DSCauHoi = DataUlti.DSCauHoi();

                    using (DataTable dt = new DataTable())
                    {
                        dt.Columns.Add("MaCauHoi", typeof(string));
                        dt.Columns.Add("Mon", typeof(string));
                        dt.Columns.Add("DoKho", typeof(int));
                        dt.Columns.Add("Khoi", typeof(int));
                        dt.Columns.Add("NoiDung", typeof(string));
                        dt.Columns.Add("GoiY", typeof(string));

                        foreach (var ch in DSCauHoi)
                        {
                            dt.Rows.Add(ch.MaCauHoi, ch.Mon, ch.DoKho, ch.Khoi, ch.NoiDung, ch.GoiY);
                        }

                        if (!DataUlti.WriteExcelFile(saveFileDialog.FileName, dt, 2))
                        {
                            MessageBox.Show("Không thể xuất ra file excel");
                            return;
                        }
                        else
                        {
                            MessageBox.Show("Xuất file thành công");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }

        QuanLyThiTracNghiemDataContext dt = new QuanLyThiTracNghiemDataContext();

        void LoadKyThi()
        {
            dtg1.CellClick += Dtg1_CellClick;

            var L = dt.KyThis.ToList();
            
            dtg1.DataSource = L;
            dtg1.Columns.Clear();

            DataGridViewTextBoxColumn dgvCol = new DataGridViewTextBoxColumn();            
            dgvCol.HeaderText = "Mã Kỳ Thi";
            //dgvCol.Name = "MaKyThi";
            dgvCol.DataPropertyName = "MaKyThi";
            dgvCol.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dtg1.Columns.Add(dgvCol);

            dgvCol = new DataGridViewTextBoxColumn();
            dgvCol.HeaderText = "Tên Kỳ Thi";
            dgvCol.DataPropertyName = "TenKyThi";
            dgvCol.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dtg1.Columns.Add(dgvCol);

            dgvCol = new DataGridViewTextBoxColumn();
            dgvCol.HeaderText = "Khối";
            dgvCol.DataPropertyName = "Khoi";
            dgvCol.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            dtg1.Columns.Add(dgvCol);

            dgvCol = new DataGridViewTextBoxColumn();
            dgvCol.HeaderText = "Ngày Thi";
            dgvCol.DataPropertyName = "NgayThi";
            dgvCol.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            dtg1.Columns.Add(dgvCol);

            dgvCol = new DataGridViewTextBoxColumn();
            dgvCol.HeaderText = "Ngày Tạo";
            dgvCol.DataPropertyName = "NgayTao";
            dgvCol.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            dtg1.Columns.Add(dgvCol);

            dgvCol = new DataGridViewTextBoxColumn();
            dgvCol.HeaderText = "Người Tạo";
            dgvCol.DataPropertyName = "NguoiTao";
            dgvCol.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            dtg1.Columns.Add(dgvCol);

            dgvCol = new DataGridViewTextBoxColumn();
            dgvCol.HeaderText = "Môn Thi";
            dgvCol.DataPropertyName = "MonThi";
            dgvCol.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            dtg1.Columns.Add(dgvCol);

            dgvCol = new DataGridViewTextBoxColumn();
            dgvCol.HeaderText = "Thi Thử";
            dgvCol.DataPropertyName = "ThiThu";
            dgvCol.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            dtg1.Columns.Add(dgvCol);

            dgvCol = new DataGridViewTextBoxColumn();
            dgvCol.HeaderText = "Kết Thúc";
            dgvCol.DataPropertyName = "KetThuc";
            dgvCol.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            dtg1.Columns.Add(dgvCol);

            dgvCol = new DataGridViewTextBoxColumn();
            dgvCol.HeaderText = "Kết Thúc";
            dgvCol.DataPropertyName = "MonHoc";
            dgvCol.Visible = false;
            dgvCol.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            dtg1.Columns.Add(dgvCol);

            dgvCol = new DataGridViewTextBoxColumn();
            dgvCol.HeaderText = "Kết Thúc";
            dgvCol.DataPropertyName = "GiaoVien";
            dgvCol.Visible = false;
            dgvCol.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            dtg1.Columns.Add(dgvCol);

            dgvCol = new DataGridViewTextBoxColumn();
            dgvCol.HeaderText = "Thời Gian Làm Bài";
            dgvCol.DataPropertyName = "ThoiGianLamBai";
            dgvCol.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            dtg1.Columns.Add(dgvCol);

        }

        private void Dtg1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = new DataGridViewRow();
                row = dtg1.Rows[e.RowIndex];
                txtMaKyThi.Text = row.Cells[0].Value.ToString();
                dateTimePicker1.Value = DateTime.Parse(row.Cells[3].Value.ToString());
                cbKhoi.SelectedIndex = int.Parse(row.Cells[2].Value.ToString()) - 10;
                txtTenKyThi.Text = row.Cells[1].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }

        // Xóa kỳ thi.
        private void BtnXoa_Click(object sender, EventArgs e)
        {
            if (dtg1.SelectedRows.Count != 1)
            {
                return;
            }
            using (var ds = new QuanLyThiTracNghiemDataContext())
            {
                var temp = ds.KyThis.Where(k => k.MaKyThi == txtMaKyThi.Text).SingleOrDefault();
                if (temp != null)
                {
                    var DSDT = ds.DSDUTHIs.Where(d => d.MaKyThi == temp.MaKyThi);
                    ds.DSDUTHIs.DeleteAllOnSubmit(DSDT);

                    var LT = ds.LuuTrus.Where(d => d.MaKyThi == temp.MaKyThi);
                    ds.LuuTrus.DeleteAllOnSubmit(LT);

                    var CTKT = ds.ChiTietKyThis.Where(d => d.MaKyThi == temp.MaKyThi);
                    ds.ChiTietKyThis.DeleteAllOnSubmit(CTKT);

                    ds.KyThis.DeleteOnSubmit(temp);

                    try
                    {
                        ds.SubmitChanges();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        return;
                    }

                }
            }

            MessageBox.Show("Xóa thành công");

            LoadKyThi();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadKyThi();
            LoadDeThi();
            LoadCauHoi();
            LoadHocSinh();
        }

        private void dtg1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = new DataGridViewRow();
                row = dtg1.Rows[e.RowIndex];
                txtMaKyThi.Text = row.Cells[0].Value.ToString();
                dateTimePicker1.Value = DateTime.Parse(row.Cells[3].Value.ToString());
                cbKhoi.SelectedIndex = int.Parse(row.Cells[2].Value.ToString()) - 10;
                txtTenKyThi.Text = row.Cells[1].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }

        //private void btnThem_Click(object sender, EventArgs e)
        //{
        //    var Them = (from DeThi in dt.DeThis
        //             where DeThi.MaDeThi == txtMaDeThi.Text
        //             select DeThi).SingleOrDefault();
        //    var KiemTraMonHoc = (from ktmh in dt.MonHocs
        //                where ktmh.MaMonHoc == txtMaMon.Text
        //                select ktmh).SingleOrDefault();

        //    if (Them==null)
        //    {
        //        if(KiemTraMonHoc!=null)
        //        {
        //            DeThi d = new DeThi();
        //            d.MaDeThi = txtMaDeThi.Text;
        //            d.MonHoc.MaMonHoc = txtMaMon.Text;
        //            d.NgayThi = dateTimePicker1.Value;
        //            int Khoi1 = int.Parse(txtKhoi.Text.ToString());
        //            d.Khoi = Khoi1;
        //            int NienKhoa1 = int.Parse(txtNienKhoa.Text.ToString());
        //            d.NienKhoa = NienKhoa1;
        //            int HocKy1 = int.Parse(txtHocKy.Text.ToString());
        //            d.HocKy = HocKy1;

        //            dt.DeThis.InsertOnSubmit(d);

        //            dt.SubmitChanges();

        //            LoadKyThi();
        //            MessageBox.Show("Thêm thành công !");
        //        }
        //       else
        //        {
        //            MessageBox.Show("Mã môn học chưa tồn tại, xin kiem tra lại !");
        //        }
        //    }
        //    else
        //    {
        //        MessageBox.Show("Đề thi đã tồn tại !");
        //    }
        //}

        //private void BtnXoa_Click(object sender, EventArgs e)
        //{
        //    WindowsFormsApp2.KyThi kt = dt.KyThis.Where(k => k.MaKyThi == txtMaKyThi.Text).SingleOrDefault();

        //    if (kt != null)
        //    {
        //        dt.KyThis.DeleteOnSubmit(kt);

        //        try
        //        {
        //            dt.SubmitChanges();    
        //        }
        //        catch (Exception ex)
        //        {
        //            MessageBox.Show(ex.Message);
        //        }
        //    }
        //    else
        //    {
        //        MessageBox.Show("Không tồn tại kỳ thi");
        //    }
        //}

        


        void LoadDeThi()
        {
            dtg2.CellClick += Dtg2_CellClick;
            var L1 = dt.DeThis.ToList();
            dtg2.DataSource = L1;
            dtg2.Columns.Clear();

            DataGridViewTextBoxColumn dgvCol = new DataGridViewTextBoxColumn();
            dgvCol.HeaderText = "Mã Đề Thi";
            dgvCol.DataPropertyName = "MaDeThi";
            dgvCol.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dtg2.Columns.Add(dgvCol);

            dgvCol = new DataGridViewTextBoxColumn();
            dgvCol.HeaderText = "Môn Thi";
            dgvCol.DataPropertyName = "MonThi";
            dgvCol.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dtg2.Columns.Add(dgvCol);

            dgvCol = new DataGridViewTextBoxColumn();
            dgvCol.HeaderText = "Khối";
            dgvCol.DataPropertyName = "Khoi";
            dgvCol.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dtg2.Columns.Add(dgvCol);

            dgvCol = new DataGridViewTextBoxColumn();
            dgvCol.HeaderText = "Người Tạo";
            dgvCol.DataPropertyName = "NguoiTao";
            dgvCol.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dtg2.Columns.Add(dgvCol);

            dgvCol = new DataGridViewTextBoxColumn();
            dgvCol.HeaderText = "Ngày Tạo";
            dgvCol.DataPropertyName = "NgayTao";
            dgvCol.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dtg2.Columns.Add(dgvCol);

            dgvCol = new DataGridViewTextBoxColumn();
            dgvCol.HeaderText = "Đã Dùng";
            dgvCol.DataPropertyName = "DaDung";
            dgvCol.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dtg2.Columns.Add(dgvCol);

            dgvCol = new DataGridViewTextBoxColumn();
            dgvCol.HeaderText = "Môn";
            dgvCol.DataPropertyName = "MonHoc";
            dgvCol.Visible = false;
            dtg2.Columns.Add(dgvCol);

            dgvCol = new DataGridViewTextBoxColumn();
            dgvCol.HeaderText = "GiaoVien";
            dgvCol.DataPropertyName = "GiaoVien";
            dgvCol.Visible = false;
            dtg2.Columns.Add(dgvCol);
        }

       
        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void Dtg2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtg2.SelectedRows.Count != 1)
            {
                return;
            }
            txtMaDeThi1.Text = dtg2.SelectedRows[0].Cells[0].Value.ToString();
            txtMaMon1.Text = dtg2.SelectedRows[0].Cells[1].Value.ToString();
            txtKhoi1.Text = dtg2.SelectedRows[0].Cells[2].Value.ToString();
        }
        // Xóa đề thi
        private void btnXoa1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaDeThi1.Text))
            {
                return;
            }
            using (var ds = new QuanLyThiTracNghiemDataContext())
            {
                DeThi temp;
                try
                {
                    temp = ds.DeThis.Where(d => d.MaDeThi == txtMaDeThi1.Text).SingleOrDefault();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }


                if (temp != null)
                {
                    var CTDT = ds.ChiTietDeThis.Where(d => d.MaDeThi == temp.MaDeThi);
                    ds.ChiTietDeThis.DeleteAllOnSubmit(CTDT);

                    var CTKT = ds.ChiTietKyThis.Where(k => k.MaDeThi == temp.MaDeThi);
                    ds.ChiTietKyThis.DeleteAllOnSubmit(CTKT);

                    var LT = ds.LuuTrus.Where(l => l.MaDeThi == temp.MaDeThi);
                    ds.LuuTrus.DeleteAllOnSubmit(LT);

                    var DSDT = ds.DSDUTHIs.Where(d => d.MaDeThi == temp.MaDeThi);
                    ds.DSDUTHIs.DeleteAllOnSubmit(DSDT);

                    ds.DeThis.DeleteOnSubmit(temp);

                    try
                    {
                        ds.SubmitChanges();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        return;
                    }

                }
            }
            MessageBox.Show("Xóa thành công");
            LoadDeThi();
        }

        //private void dtg2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    try
        //    {
        //        DataGridViewRow row = new DataGridViewRow();
        //        row = dtg2.Rows[e.RowIndex];
        //        txtMaDeThi1.Text = row.Cells[0].Value.ToString();

        //        txtMaMon1.Text=row.Cells[1].Value.ToString();
        //        txtKhoi1.Text = row.Cells[2].Value.ToString();


        //    }
        //    catch (Exception)
        //    {


        //    }
        //}

        private void btnSua_Click(object sender, EventArgs e)
        {
            WindowsFormsApp2.KyThi kt = dt.KyThis.Where(k => k.MaKyThi == txtMaKyThi.Text).SingleOrDefault();

            if (kt != null)
            {
                kt.NgayThi = dateTimePicker1.Value;
                kt.Khoi = int.Parse(cbKhoi.SelectedItem.ToString());
                kt.TenKyThi = txtTenKyThi.Text;

                try
                {
                    dt.SubmitChanges();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }
            }
        }

        //private void btnXoa1_Click(object sender, EventArgs e)
        //{
        //    WindowsFormsApp2.DeThi dtt = dt.DeThis.Where(k => k.MaDeThi == txtMaDeThi1.Text).SingleOrDefault();
        //    if (dtt != null)
        //    {
        //        dt.DeThis.DeleteOnSubmit(dtt);

        //        try
        //        {
        //            dt.SubmitChanges();
        //        }
        //        catch (Exception ex)
        //        {
        //            MessageBox.Show(ex.Message);
        //        }
        //    }
        //    else
        //    {
        //        MessageBox.Show("Không tồn tại kỳ thi");
        //    }
        //}

        private void btnSua1_Click(object sender, EventArgs e)
        {
            WindowsFormsApp2.DeThi dtt = dt.DeThis.Where(k => k.MaDeThi == txtMaDeThi1.Text).SingleOrDefault();

            if (dtt != null)
            {
                dtt.MaDeThi = txtMaDeThi1.Text;
               
                try
                {
                    dt.DeThis.InsertOnSubmit(dtt);
                    dt.SubmitChanges();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }
            }
        }


        void LoadCauHoi()
        {
            var cauhoi = dt.CauHois.ToList();

            dgvCauHoi.DataSource = cauhoi;
            dgvCauHoi.Columns.Clear();



            DataGridViewTextBoxColumn dgvCol = new DataGridViewTextBoxColumn();
            dgvCol.HeaderText = "Mã Câu Hỏi";
            dgvCol.DataPropertyName = "MaCauHoi";
            dgvCol.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvCauHoi.Columns.Add(dgvCol);

            dgvCol = new DataGridViewTextBoxColumn();
            dgvCol.HeaderText = "Môn";
            dgvCol.DataPropertyName = "Mon";
            dgvCol.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvCauHoi.Columns.Add(dgvCol);

            dgvCol = new DataGridViewTextBoxColumn();
            dgvCol.HeaderText = "Môn";
            dgvCol.DataPropertyName = "MonHoc";
            dgvCol.Visible = false;
            dgvCauHoi.Columns.Add(dgvCol);

            dgvCol = new DataGridViewTextBoxColumn();
            dgvCol.HeaderText = "Độ Khó";
            dgvCol.DataPropertyName = "DoKho";
            dgvCol.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvCauHoi.Columns.Add(dgvCol);

            dgvCol = new DataGridViewTextBoxColumn();
            dgvCol.HeaderText = "Khối";
            dgvCol.DataPropertyName = "Khoi";
            dgvCol.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvCauHoi.Columns.Add(dgvCol);

            dgvCol = new DataGridViewTextBoxColumn();
            dgvCol.HeaderText = "NoiDung";
            dgvCol.DataPropertyName = "NoiDung";
            dgvCol.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvCauHoi.Columns.Add(dgvCol);

            dgvCol = new DataGridViewTextBoxColumn();
            dgvCol.HeaderText = "Gợi Ý";
            dgvCol.DataPropertyName = "GoiY";
            dgvCol.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvCauHoi.Columns.Add(dgvCol);

        }


        void LoadHocSinh()
        {
            LoadCbBoxKT();
            dgvHocSinh.Columns.Clear();
            cbExam.SelectedIndexChanged += cbExam_SelectedIndexChanged;

            dgvHocSinh.AutoGenerateColumns = false;
            dgvHocSinh.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void LoadCbBoxKT()
        {
            using (var ds = new QuanLyThiTracNghiemDataContext())
            {
                cbExam.DataSource = ds.KyThis.ToList();
                cbExam.DisplayMember = "TenKyThi";
                cbExam.ValueMember = "MaKyThi";
            }
        }

        private void LoadGridViewHS()
        {
            dgvHocSinh.Columns.Clear();
            dgvHocSinh.RowHeadersVisible = false;
            using (var ds = new QuanLyThiTracNghiemDataContext())
            {
                dgvHocSinh.DataSource = (from hs in ds.HocSinhs
                                         join dt in ds.DSDUTHIs on hs.MaHocSinh equals dt.MaHocSinh
                                         join kt in ds.KyThis on dt.MaKyThi equals kt.MaKyThi
                                         select new
                                         {
                                             MaHocSinh = hs.MaHocSinh,
                                             TenHocSinh = hs.TenHocSinh,
                                             Khoi = hs.Khoi,
                                             Lop = hs.Lop,
                                             GioiTinh = hs.GioiTinh == true ? "Nam" : "Nữ",
                                             TenKyThi = kt.TenKyThi,
                                             MaDeThi = dt.MaDeThi,
                                             KetQua = dt.KetQua
                                         }).ToList();
            }

            DataGridViewTextBoxColumn dgvCol = new DataGridViewTextBoxColumn();
            dgvCol.HeaderText = "Mã học sinh";
            dgvCol.DataPropertyName = "MaHocSinh";
            dgvCol.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvHocSinh.Columns.Add(dgvCol);

            dgvCol = new DataGridViewTextBoxColumn();
            dgvCol.HeaderText = "Tên học sinh";
            dgvCol.DataPropertyName = "TenHocSinh";
            dgvCol.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvHocSinh.Columns.Add(dgvCol);

            dgvCol = new DataGridViewTextBoxColumn();
            dgvCol.HeaderText = "Khối";
            dgvCol.DataPropertyName = "Khoi";
            dgvCol.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvHocSinh.Columns.Add(dgvCol);

            dgvCol = new DataGridViewTextBoxColumn();
            dgvCol.HeaderText = "Lớp";
            dgvCol.DataPropertyName = "Lop";
            dgvCol.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvHocSinh.Columns.Add(dgvCol);

            dgvCol = new DataGridViewTextBoxColumn();
            dgvCol.HeaderText = "Giới tính";
            dgvCol.DataPropertyName = "GioiTinh";
            dgvCol.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvHocSinh.Columns.Add(dgvCol);

            dgvCol = new DataGridViewTextBoxColumn();
            dgvCol.HeaderText = "Kỳ thi";
            dgvCol.DataPropertyName = "TenKyThi";
            dgvCol.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvHocSinh.Columns.Add(dgvCol);

            dgvCol = new DataGridViewTextBoxColumn();
            dgvCol.HeaderText = "Đề thi";
            dgvCol.DataPropertyName = "MaDeThi";
            dgvCol.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvHocSinh.Columns.Add(dgvCol);

            dgvCol = new DataGridViewTextBoxColumn();
            dgvCol.HeaderText = "Kết quả";
            dgvCol.DataPropertyName = "KetQua";
            dgvCol.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvHocSinh.Columns.Add(dgvCol);
            dgvHocSinh.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void cbExam_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                ReloadDgvHS(cbExam.SelectedValue.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }

        private void ReloadDgvHS(string MKT)
        {
            dgvHocSinh.Columns.Clear();
            dgvHocSinh.DataSource = null;
            using (var ds = new QuanLyThiTracNghiemDataContext())
            {
                dgvHocSinh.DataSource = (from hs in ds.HocSinhs
                                         join dt in ds.DSDUTHIs on hs.MaHocSinh equals dt.MaHocSinh
                                         join kt in ds.KyThis on dt.MaKyThi equals kt.MaKyThi
                                         where kt.MaKyThi == MKT
                                         select new
                                         {
                                             MaHocSinh = hs.MaHocSinh,
                                             TenHocSinh = hs.TenHocSinh,
                                             Khoi = hs.Khoi,
                                             Lop = hs.Lop,
                                             GioiTinh = hs.GioiTinh == true ? "Nam" : "Nữ",
                                             TenKyThi = kt.TenKyThi,
                                             MaDeThi = dt.MaDeThi,
                                             KetQua = dt.KetQua
                                         }).ToList();
            }

            DataGridViewTextBoxColumn dgvCol = new DataGridViewTextBoxColumn();
            dgvCol.HeaderText = "Mã học sinh";
            dgvCol.DataPropertyName = "MaHocSinh";
            dgvCol.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgvHocSinh.Columns.Add(dgvCol);

            dgvCol = new DataGridViewTextBoxColumn();
            dgvCol.HeaderText = "Tên học sinh";
            dgvCol.DataPropertyName = "TenHocSinh";
            dgvCol.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvHocSinh.Columns.Add(dgvCol);

            dgvCol = new DataGridViewTextBoxColumn();
            dgvCol.HeaderText = "Khối";
            dgvCol.DataPropertyName = "Khoi";
            dgvCol.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgvHocSinh.Columns.Add(dgvCol);

            dgvCol = new DataGridViewTextBoxColumn();
            dgvCol.HeaderText = "Lớp";
            dgvCol.DataPropertyName = "Lop";
            dgvCol.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgvHocSinh.Columns.Add(dgvCol);

            dgvCol = new DataGridViewTextBoxColumn();
            dgvCol.HeaderText = "Giới tính";
            dgvCol.DataPropertyName = "GioiTinh";
            dgvCol.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgvHocSinh.Columns.Add(dgvCol);

            dgvCol = new DataGridViewTextBoxColumn();
            dgvCol.HeaderText = "Kỳ thi";
            dgvCol.DataPropertyName = "TenKyThi";
            dgvCol.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvHocSinh.Columns.Add(dgvCol);

            dgvCol = new DataGridViewTextBoxColumn();
            dgvCol.HeaderText = "Đề thi";
            dgvCol.DataPropertyName = "MaDeThi";
            dgvCol.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvHocSinh.Columns.Add(dgvCol);

            dgvCol = new DataGridViewTextBoxColumn();
            dgvCol.HeaderText = "Kết quả";
            dgvCol.DataPropertyName = "KetQua";
            dgvCol.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgvHocSinh.Columns.Add(dgvCol);
            dgvHocSinh.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnViewAll_Click(object sender, EventArgs e)
        {
            LoadGridViewHS();
        }


        //private void btnThem1_Click(object sender, EventArgs e)
        //{

        //    var KiemTraMaDeThi = (from ktmdt in dt.DeThis
        //                         where ktmdt.MaDeThi == txtMaDeThi1.Text
        //                         select ktmdt).SingleOrDefault();
        //    var KiemTraCauHoi = (from KhoCauHoi in dt.KhoCauHois
        //                         where KhoCauHoi.MaCauHoi == txtMaCauHoi.Text
        //                         select KhoCauHoi).SingleOrDefault();
        //    var KiemTraTrung = (from KhoCauHoi in dt.ChiTietDeThis
        //                        where KhoCauHoi.MaDeThi==txtMaDeThi1.Text
        //                        where KhoCauHoi.MaCauHoi == txtMaCauHoi.Text
        //                        select KhoCauHoi).SingleOrDefault();

        //    if (KiemTraMaDeThi != null)
        //    {
        //            if(KiemTraCauHoi!=null)
        //            {
        //                    if(KiemTraTrung==null)
        //                    {
        //                        ChiTietDeThi d = new ChiTietDeThi();
        //                        d.MaDeThi = txtMaDeThi1.Text;
        //                        d.MaCauHoi = txtMaCauHoi.Text;


        //                        dt.ChiTietDeThis.InsertOnSubmit(d);

        //                        dt.SubmitChanges();

        //                        LoadDeThi();
        //                        MessageBox.Show("Thêm thành công !");
        //                    }
        //                    else
        //                    {
        //                        MessageBox.Show("Câu hỏi đã được sử dụng trong đề thi !");
        //                    }
        //            }

        //            else
        //            {
        //                MessageBox.Show("Mã câu hỏi chưa tồn tại, xin kiem tra lại !");
        //            }
        //    }

        //    else
        //    {
        //         MessageBox.Show("Mã đề thi chưa tồn tại, xin kiem tra lại !");
        //    }


        //}

    }
}
