using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Windows.Forms;
namespace WindowsFormsApp2
{
    public class DataUlti
    {
        public static IList<QueQuan> DSQueQuan()
        {
            IList<QueQuan> rt;
            using (var ds = new QuanLyThiTracNghiemDataContext())
            {
                rt = ds.QueQuans.ToList();
            }
            return rt;
        }

        public static IList<GiaoVien> DSGiaoVien()
        {
            IList<GiaoVien> rt;
            using (var ds = new QuanLyThiTracNghiemDataContext())
            {
                rt = ds.GiaoViens.ToList();
            }
            return rt;
        }

        public static IList<HocSinh> DSHocSinh()
        {
            IList<HocSinh> rt;
            using (var ds = new QuanLyThiTracNghiemDataContext())
            {
                rt = ds.HocSinhs.ToList();
            }
            return rt;
        }

        public static IList<TaiKhoan> DSTaiKhoan()
        {
            IList<TaiKhoan> rt;
            using (var ds = new QuanLyThiTracNghiemDataContext())
            {
                rt = ds.TaiKhoans.ToList();
            }
            return rt;
        }

        public static IList<CauHoi> DSCauHoi()
        {
            IList<CauHoi> rt;
            using (var ds = new QuanLyThiTracNghiemDataContext())
            {
                rt = ds.CauHois.ToList();
            }
            return rt;
        }

        public static IList<CauHoi> DSCauHoi(string MDT)
        {
            IList<CauHoi> rt;
            using (var ds = new QuanLyThiTracNghiemDataContext())
            {
                rt = (from c in ds.CauHois
                      join d in ds.ChiTietDeThis
                      on c.MaCauHoi equals d.MaCauHoi
                      where d.MaDeThi == MDT
                      select c).ToList();
            }
            return rt;
        }

        public static IList<DapAn> DSDapAn(string MDT)
        {
            IList<DapAn> rt;
            using (var ds = new QuanLyThiTracNghiemDataContext())
            {
                rt = (from d in ds.DapAns
                      join c in ds.ChiTietDeThis
                      on d.MaCauHoi equals c.MaCauHoi
                      where c.MaDeThi == MDT
                      select d).ToList();
            }
            return rt;
        }

        public static IList<DSDUTHI> DSThi(string mkt)
        {
            IList<DSDUTHI> rt;
            using (var ds = new QuanLyThiTracNghiemDataContext())
            {
                rt = ds.DSDUTHIs.Where(s => s.MaKyThi == mkt).ToList();
            }
            return rt;
        }

        public static IList<ChiTietKyThi> DSDeThi(string MHS)
        {
            IList<ChiTietKyThi> rt;
            using (var ds = new QuanLyThiTracNghiemDataContext())
            {
                rt = (from c in ds.ChiTietKyThis
                      join d in ds.DSDUTHIs
                      on c.MaKyThi equals d.MaKyThi
                      where d.MaHocSinh == MHS
                      select c).ToList();
            }
            return rt;
        }

        public static IList<DeThi> DSDeThiLuyenTap(string MMH)
        {
            IList<DeThi> rt;
            using (var ds = new QuanLyThiTracNghiemDataContext())
            {
                rt = ds.DeThis.Where(d => d.MonThi == MMH).ToList();
            }
            return rt;
        }

        public static IList<KyThi> LayLichThi(string id)
        {
            IList<KyThi> rt;
            using (var ds = new QuanLyThiTracNghiemDataContext())
            {
                rt = (from c in ds.KyThis
                      join d in ds.DSDUTHIs
                      on c.MaKyThi equals d.MaKyThi
                      where d.MaHocSinh == id
                      select c).ToList();
            }
            return rt;
        }


        public static IList<MonHoc> DSMon()
        {
            IList<MonHoc> rt;
            using (var ds = new QuanLyThiTracNghiemDataContext())
            {
                rt = ds.MonHocs.ToList();
            }
            return rt;
        }

        public static bool ThemCauHoi(CauHoi ch)
        {
            bool flag = true;
            using (var qlch = new QuanLyThiTracNghiemDataContext())
            {
                var query = qlch.CauHois.Where(c => c.MaCauHoi == ch.MaCauHoi).SingleOrDefault();

                if (query != null)
                {
                    flag = false;
                }
                else
                {
                    qlch.CauHois.InsertOnSubmit(ch);

                    try
                    {
                        qlch.SubmitChanges();
                    }
                    catch (Exception)
                    {
                        flag = false;
                    }
                }
            }
            return flag;
        }

        public static bool ThemTaiKhoan(TaiKhoan tk)
        {
            bool flag = true;
            using (var qltk = new QuanLyThiTracNghiemDataContext())
            {
                var query = qltk.TaiKhoans.Where(t => t.ChuTaiKhoan == tk.ChuTaiKhoan).SingleOrDefault();

                // query != null => User có MaTK đã có tài khoản, ko thể tạo
                if (query != null)
                {
                    MessageBox.Show("Đã có tài khoản cho mã tài khoản này");
                    flag = false;
                }
                else
                {
                    qltk.TaiKhoans.InsertOnSubmit(tk);

                    try
                    {
                        qltk.SubmitChanges();
                    }
                    catch (Exception)
                    {
                        flag = false;
                    }
                }
            }
            return flag;
        }

        public static bool ThemChuTaiKhoan(ChuTaiKhoan ctk)
        {
            bool flag = true;
            using (var datacontext = new QuanLyThiTracNghiemDataContext())
            {
                datacontext.ChuTaiKhoans.InsertOnSubmit(ctk);

                try
                {
                    datacontext.SubmitChanges();
                }
                catch (Exception)
                {
                    flag = false;
                }
            }
            return flag;
        }

        public static bool ThemHocSinh(HocSinh hs)
        {
            bool flag = true;
            using (var datacontext = new QuanLyThiTracNghiemDataContext())
            {
                datacontext.HocSinhs.InsertOnSubmit(hs);

                try
                {
                    datacontext.SubmitChanges();
                }
                catch (Exception)
                {
                    flag = false;
                }
            }
            return flag;
        }

        public static bool ThemGiaoVien(GiaoVien gv)
        {
            bool flag = true;
            using (var datacontext = new QuanLyThiTracNghiemDataContext())
            {
                datacontext.GiaoViens.InsertOnSubmit(gv);
                try
                {
                    datacontext.SubmitChanges();
                }
                catch (Exception)
                {
                    flag = false;
                }
            }
            return flag;
        }

        public static bool KiemTraHopLe(TaiKhoan tk)
        {
            using (var ds = new QuanLyThiTracNghiemDataContext())
            {
                TaiKhoan temp = ds.TaiKhoans
                    .Where(t => t.TenDangNhap == tk.TenDangNhap && t.MatKhau == tk.MatKhau)
                    .SingleOrDefault();
                if (temp != null)
                {
                    tk.ChuTaiKhoan = temp.ChuTaiKhoan;
                    tk.PhanHe = temp.PhanHe;
                    return true;
                }
            }
            return false;
        }

        public static HocSinh TimHocSinh(string MHS)
        {
            using (var ds = new QuanLyThiTracNghiemDataContext())
            {
                HocSinh temp = ds.HocSinhs.Where(sv => sv.MaHocSinh == MHS).SingleOrDefault();
                return temp;
            }
        }

        public static bool SuaThongTinTaiKhoan(TaiKhoan tk)
        {
            using (var qltk = new QuanLyThiTracNghiemDataContext())
            {
                var tmp = qltk.TaiKhoans.Where(t => t.ChuTaiKhoan == tk.ChuTaiKhoan).SingleOrDefault();

                if (tmp != null)
                {
                    //tmp.TenDangNhap = tk.TenDangNhap;
                    tmp.MatKhau = tk.MatKhau;
                    tmp.PhanHe = tk.PhanHe;
                    try
                    {
                        qltk.SubmitChanges();
                    }
                    catch (Exception)
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        public static bool SuaThongTinHocSinh(HocSinh sv)
        {
            using (var qlsv = new QuanLyThiTracNghiemDataContext())
            {
                var svO = qlsv.HocSinhs.Where(s => s.MaHocSinh == sv.MaHocSinh).SingleOrDefault();

                if (svO != null)
                {
                    svO.TenHocSinh = sv.TenHocSinh;
                    svO.NgaySinh = sv.NgaySinh;
                    svO.GioiTinh = sv.GioiTinh;
                    svO.QueQuan = sv.QueQuan;
                    try
                    {
                        qlsv.SubmitChanges();
                    }
                    catch
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        public static bool LuuDapAn(IList<LuuTru> lt)
        {
            using (var ds = new QuanLyThiTracNghiemDataContext())
            {
                foreach (var i in lt)
                {
                    //MessageBox.Show(i.MaKyThi + " | " + i.MaDeThi + " | " + i.MaHocSinh + " | " + i.MaCauHoi + " | " + i.MaDapAn);

                    var temp = ds.LuuTrus.Where(s => s.MaHocSinh == i.MaHocSinh && s.MaCauHoi == i.MaCauHoi
                                                     && s.MaDeThi == i.MaDeThi && s.MaKyThi == i.MaKyThi)
                                         .SingleOrDefault();
                    if (temp == null)
                    {
                        // Thêm
                        ds.LuuTrus.InsertOnSubmit(i);
                    }
                    else
                    {
                        // Cập nhật
                        temp.MaDapAn = i.MaDapAn;
                    }
                    try
                    {
                        ds.SubmitChanges();
                    }
                    catch
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        public static IList<LuuTru> XemLichSuBaiLam(string MSSV, string MaDeThi, string MaKyThi)
        {
            IList<LuuTru> rt;
            using (var ds = new QuanLyThiTracNghiemDataContext())
            {
                rt = ds.LuuTrus.Where(s => s.MaDeThi == MaDeThi && s.MaHocSinh == MSSV
                                    && s.MaKyThi == MaKyThi).ToList();
            }
            return rt;
        }

        public static TimeSpan LayThoiGianBD(string id, string MKT)
        {
            TimeSpan rt = new TimeSpan();
            using (var ds = new QuanLyThiTracNghiemDataContext())
            {
                try
                {
                    var q = ds.DSDUTHIs.Where(d => d.MaHocSinh == id && d.MaKyThi == MKT).SingleOrDefault();
                    if (q != null)
                    {
                        if (q.ThoiGianBD.HasValue)
                            rt = q.ThoiGianBD.Value;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            return rt;
        }

        public static bool TiepTucThi(string id, string MKT)
        {
            bool rt = true;
            using (var ds = new QuanLyThiTracNghiemDataContext())
            {
                var q = ds.DSDUTHIs.Where(d => d.MaHocSinh == id && d.MaKyThi == MKT).SingleOrDefault();
                if (q != null)
                {
                    rt = q.ThoiGianBD.HasValue;
                }
            }
            return rt;
        }

        public static IList<ChiTietKyThi> LayDeThi(string MKT)
        {
            IList<ChiTietKyThi> rt;
            using (var ds = new QuanLyThiTracNghiemDataContext())
            {
                rt = (from c in ds.ChiTietKyThis
                      where c.MaKyThi == MKT
                      select c).ToList();
            }
            return rt;
        }

        public static bool BatDauThi(string id, string MKT, string MDT)
        {
            bool rt = true;
            using (var ds = new QuanLyThiTracNghiemDataContext())
            {
                var q = ds.DSDUTHIs.Where(d => d.MaHocSinh == id && d.MaKyThi == MKT).SingleOrDefault();
                if (q != null)
                {
                    q.ThoiGianBD = DateTime.Now.TimeOfDay;
                    q.MaDeThi = MDT;
                    try
                    {
                        ds.SubmitChanges();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        rt = false;
                    }
                }
            }
            return rt;
        }

        public static bool KetThucBaiThi(string id, string MKT)
        {
            using (var ds = new QuanLyThiTracNghiemDataContext())
            {
                try
                {
                    var q = ds.DSDUTHIs
                        .Where(d => d.MaHocSinh == id && d.MaKyThi == MKT)
                        .SingleOrDefault();
                    if (q != null)
                    {
                        q.DaThi = true;
                        q.KetQua = (from l in ds.LuuTrus
                                    join d in ds.DapAns
                                    on new { l.MaCauHoi, l.MaDapAn }
                                    equals new { d.MaCauHoi, d.MaDapAn }
                                    where d.Dung == true && l.MaKyThi == MKT && l.MaHocSinh == id
                                    select l).Count() * 0.1666;
                        ds.SubmitChanges();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return false;
                }
            }
            return true;
        }


        /*
         *  Excel Section
         * 
         */
        public static bool WriteExcelFile(string filePath, DataTable dt, int mode)
        {
            try
            {
                string connStr = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + filePath + ";Extended Properties=\"Excel 12.0;HDR=YES\"";

                string createTable = BuildCreateTableCommand(mode);

                using (OleDbConnection conn = new OleDbConnection(connStr))
                {
                    conn.Open();

                    OleDbCommand command = new OleDbCommand(createTable, conn);
                    command.ExecuteNonQuery();

                    for (int rowIndex = 0; rowIndex < dt.Rows.Count; rowIndex++)
                    {
                        command = new OleDbCommand(BuildInsertCommand(dt, rowIndex), conn);
                        command.ExecuteNonQuery();
                    }

                    conn.Close();
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public static string BuildCreateTableCommand(int mode)
        {
            string query = String.Empty;
            if (mode == 0) // Bảng HocSinh
            {
                query = "Create Table [Sheet1] (" +
                            "[MaHocSinh] char(255), " +
                            "[TenHocSinh] nvarchar(255), " +
                            "[Khoi] int, " +
                            "[Lop] char(255), " +
                            "[NgaySinh] date, " +
                            "[QueQuan] int, " +
                            "[GioiTinh] int )";
            }
            if (mode == 1) // Bảng GiaoVien
            {
                query = "Create Table [Sheet1] (" +
                            "[MaGiaoVien] char(255), " +
                            "[TenGiaoVien] nvarchar(255), " +
                            "[NgaySinh] date, " +
                            "[QueQuan] int, " +
                            "[GioiTinh] int, " +
                            "[DayMon] char(255) )";
            }
            if (mode == 2) // Bảng CauHoi
            {
                query = "CREATE TABLE [Sheet1] (" +
                            "[MaCauHoi] char(10), " +
                            "[Mon] char(4), " +
                            "[DoKho] int, " +
                            "[Khoi] int, " +
                            "[NoiDung] nvarchar(255), " +
                            "[GoiY] nvarchar(50) )";
            }

            return query;
        }

        public static string BuildInsertCommand(DataTable dt, int rowIndex)
        {
            try
            {
                StringBuilder sb = new StringBuilder();

                sb.Append("Insert into [Sheet1] (");

                foreach (DataColumn col in dt.Columns)
                {
                    sb.AppendFormat("[{0}],", col.Caption);
                }
                sb = sb.Replace(',', ')', sb.ToString().LastIndexOf(','), 1);

                sb.Append("Values (");
                foreach (DataColumn col in dt.Columns)
                {
                    string type = col.DataType.ToString();
                    string insertStr = String.Empty;
                    insertStr = dt.Rows[rowIndex][col].ToString().Replace("'", "''");
                    sb.AppendFormat("'{0}',", insertStr);
                }

                sb = sb.Replace(',', ')', sb.ToString().LastIndexOf(','), 1);
                return sb.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        /*
         * support.microsoft.com/en-us/help/316934/how-to-use-ado-net-to-retrieve-and-modify-records-in-an-excel-workbook
         */
        public static DataTable ReadExcelFile(string filePath)
        {
            try
            {
                DataTable dtexcel = new DataTable();

                string strConn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + filePath + ";Extended Properties=\"Excel 12.0;HDR=No;IMEX=0\"";
                //if (filePath.Substring(filePath.LastIndexOf('.')).ToLower() == ".xlsx")
                //    strConn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + filePath + ";Extended Properties=\"Excel 12.0;HDR=No;IMEX=0\"";
                //else
                //    strConn = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + filePath + ";Extended Properties=\"Excel 8.0;HDR=No;IMEX=0\"";

                OleDbConnection conn = new OleDbConnection(strConn);
                conn.Open();
                DataTable schemaTable = conn.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, new object[] { null, null, null, "TABLE" });
                //Looping Total Sheet of Xl File
                /*foreach (DataRow schemaRow in schemaTable.Rows)
                {
                }*/
                //Looping a first Sheet of Xl File
                DataRow schemaRow = schemaTable.Rows[0];
                string sheet = schemaRow["TABLE_NAME"].ToString();
                if (!sheet.EndsWith("_"))
                {
                    string query = "SELECT  * FROM [" + sheet + "]";
                    OleDbDataAdapter daexcel = new OleDbDataAdapter(query, conn);
                    dtexcel.Locale = CultureInfo.CurrentCulture;
                    daexcel.Fill(dtexcel);
                }

                conn.Close();
                return dtexcel;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }
    }
}
