using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using System.Data.OleDb;
using System.Globalization;
using System.Data.Sql;
using System.Configuration;
using System.Collections.Specialized;
using System.Data.SqlClient;
using System.Data.Linq;
using System.IO;

namespace WindowsFormsApp2
{
    public partial class FormAdmin : MetroForm
    {
        public FormAdmin()
        {
            InitializeComponent();
            this.FocusMe();

            //
            InitTabUserManagement();

            // Import / Export Tab
            btnImportFile.Click += BtnFileOpen_Click;
            btnXuatDSHS.Click += BtnXuatDSHS_Click;
            btnXuatDSGV.Click += BtnXuatDSGV_Click;
            btnUpdateFromImport.Click += BtnUpdateFromImport_Click;

            // User Management Tab
            btnUpdateUser.Click += BtnUpdateUser_Click;
            btnAddUser.Click += BtnAddUser_Click;


            // System Management Tab
            btnBrowse.Click += BtnBrowse_Click;
            btnConnect.Click += BtnConnect_Click;
            btnRefresh.Click += BtnRefresh_Click;
            btnBackup.Click += BtnBackup_Click;
            btnRestore.Click += BtnRestore_Click;
        }

        /*
         * www.codeproject.com/Tips/873677/SQL-Server-Database-Backup-and-Restore-in-Csharp
         *
         */
        private void BtnRestore_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(cbDatabaseName.Text))
                {
                    MessageBox.Show("Tên database không được để trống");
                    return;
                }
                else
                {
                    openFileDialog.Filter = "Text files (*.bak)|*.bak|All files (*.*)|*.*";
                    DialogResult result = openFileDialog.ShowDialog();

                    if (result == DialogResult.OK)
                    {
                        DataContext db = new DataContext("Data Source=" + cbServerName.Text + ";Database=Master;Integrated Security=True");
                        if (db.DatabaseExists())
                        {
                            // Single user mode
                            var Alter1 = db.ExecuteCommand(@"ALTER DATABASE
                   [" + cbDatabaseName.Text + "] SET Single_User WITH Rollback Immediate");

                            // Restore database
                            var query = db.ExecuteCommand(@"RESTORE DATABASE
                   [" + cbDatabaseName.Text + "] FROM DISK = N'" +
                       openFileDialog.FileName + @"' WITH  FILE = 1,  NOUNLOAD,  STATS = 10");

                            // Multi user mode
                            var Alter2 = db.ExecuteCommand(@"ALTER DATABASE
                   [" + cbDatabaseName.Text + "] SET Multi_User");

                            if (query != 0)
                            {
                                MessageBox.Show("Phục hồi thành công");
                            }
                            else
                            {
                                MessageBox.Show("Không thể phục hồi");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void BtnBackup_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(cbDatabaseName.Text))
                {
                    MessageBox.Show("Tên database không được để trống");
                    return;
                }
                else
                {
                    saveFileDialog.FileName = cbDatabaseName.Text;
                    saveFileDialog.Filter = "Text files (*.bak)|*.bak|All files (*.*)|*.*";
                    DialogResult result = saveFileDialog.ShowDialog();

                    if (result == DialogResult.OK)
                    {
                        string s = saveFileDialog.FileName;

                        DataContext db = new DataContext("Data Source=" + cbServerName.Text + ";Database=Master;Integrated Security=True");
                        if (db.DatabaseExists())
                        {
                            var query = db.ExecuteCommand("Backup database " + cbDatabaseName.Text + " to disk='" + s + "'");
                            if (query != 0)
                            {
                                MessageBox.Show("Sao lưu thành công");
                            }
                            else
                            {
                                MessageBox.Show("Không thể sao lưu");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        /*
         * 
         */
        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sẽ phải mất một lúc để load danh sách Server");

            DataContext db = new DataContext("Data Source=.;Database=Master;Integrated Security=True");
            if (db.DatabaseExists())
            {
                var query = db.ExecuteQuery<string>("select srvname from sysservers where srvproduct='SQL Server'");
                cbServerName.DataSource = query.ToList();
            }
            else
            {
                MessageBox.Show("Không thể lấy danh sách server");
            }

            db = new DataContext("Data Source=" + cbServerName.Text + ";Database=Master;Integrated Security=True");
            if (db.DatabaseExists())
            {
                var query = db.ExecuteQuery<string>("Select name from sysdatabases");
                cbDatabaseName.DataSource = query.ToList();
            }

        }

        private void BtnConnect_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtPathToDB.Text))
            {
                MessageBox.Show("Xin hãy chọn file mdf");
            }
            else
            {
                Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

                config.ConnectionStrings.LockItem = false;

                string serverName = cbServerName.Items[cbServerName.SelectedIndex].ToString();

                var setting = config.ConnectionStrings.ConnectionStrings["QLThiTracNghiem.Properties.Settings.QLThiTracNghiemConnectionString"];

                if (serverName != String.Empty)
                {
                    if (setting != null)
                    {
                        setting.ConnectionString = string.Format("Data Source={0};AttachDbFilename={1};Integrated Security=True", serverName, txtPathToDB.Text);

                        config.Save(ConfigurationSaveMode.Modified);

                        ConfigurationManager.RefreshSection("connectionStrings");

                        MessageBox.Show("Đã cập nhật Database, chương trình sẽ được khởi động lại");
                        Application.Restart();
                        Environment.Exit(0);
                    }
                    else
                    {
                        MessageBox.Show("Không thể kết nối, kiểm tra lại Connection String");
                    }
                }
                else
                {
                    MessageBox.Show("Xin hãy chọn Server");
                    return;
                }
            }
        }

        private void BtnBrowse_Click(object sender, EventArgs e)
        {
            DialogResult result = fileDialogImportDB.ShowDialog();

            if (result == DialogResult.OK)
            {
                txtPathToDB.Text += fileDialogImportDB.FileName;
            }
        }

        private void BtnUpdateUser_Click(object sender, EventArgs e)
        {
            if (dgvUpdateUser.SelectedRows.Count > 0)
            {
                // get selected row
                var tk = dgvUpdateUser.SelectedRows[0].Tag as TaiKhoan;

                // get new data
                //tk.ChuTaiKhoan = lblAccount.Text;
                //tk.TenDangNhap = txtUserName.Text;
                tk.MatKhau = txtMatKhau.Text;
                tk.PhanHe = cbUserType.SelectedIndex + 1;

                if (DataUlti.SuaThongTinTaiKhoan(tk))
                {
                    MessageBox.Show("Đã cập nhật thành công");
                    LoadDgvUpdateUser();
                }
                else
                {
                    MessageBox.Show("Không thể cập nhật");
                }
            }
        }

        private void BtnAddUser_Click(object sender, EventArgs e)
        {
            Admin.AddUserForm addUserForm = new Admin.AddUserForm();
            addUserForm.FormClosed += (s, args) => this.LoadDgvUpdateUser();
            addUserForm.ShowDialog();
        }

        private void InitTabUserManagement()
        {
            // Load data from database
            LoadDgvUpdateUser();


            // 
            dgvUpdateUser.SelectionChanged += DgvUpdateUser_SelectionChanged;
        }

        public void LoadDgvUpdateUser()
        {
            dgvUpdateUser.Rows.Clear();
            dgvUpdateUser.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DataGridViewRow row = null;
            DataGridViewCell cell = null;


            // get user list
            var list = DataUlti.DSTaiKhoan();
            foreach (var user in list)
            {
                row = new DataGridViewRow();

                row.Tag = user;

                // User ID
                cell = new DataGridViewTextBoxCell();
                cell.Value = user.ChuTaiKhoan;
                row.Cells.Add(cell);

                // User Account
                cell = new DataGridViewTextBoxCell();
                cell.Value = user.TenDangNhap;
                row.Cells.Add(cell);

                // Password
                cell = new DataGridViewTextBoxCell();
                cell.Value = user.MatKhau;
                row.Cells.Add(cell);


                // User Type
                cell = new DataGridViewTextBoxCell();
                cell.Value = user.PhanHe == 1 ? "Học sinh" : user.PhanHe == 2 ? "Giáo viên" : "Admin";
                row.Cells.Add(cell);

                // Add to Data Grid View
                dgvUpdateUser.Rows.Add(row);
            }
        }

        private void DgvUpdateUser_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvUpdateUser.SelectedRows.Count > 0)
            {
                var tk = dgvUpdateUser.SelectedRows[0].Tag as TaiKhoan;
                lblAccount.Text = tk.ChuTaiKhoan;
                lblTenDN.Text = tk.TenDangNhap;
                txtMatKhau.Text = tk.MatKhau;
                cbUserType.SelectedIndex = ((int)tk.PhanHe - 1);
            }
        }

        private void BtnUpdateFromImport_Click(object sender, EventArgs e)
        {
            var notExistList = new List<DataGridViewCellCollection>();
            var existList = new List<DataGridViewCellCollection>();

            if (dgvImportUserList.RowCount > 0)
            {
                var firstCellValue = dgvImportUserList.Rows[0].Cells[0].Value.ToString();
                if (firstCellValue.Contains("GV"))
                {
                    // Get list of giaovien
                    var gvList = DataUlti.DSGiaoVien();

                    try
                    {
                        //Lấy ra danh sách các giáo viên chưa có trong database
                        IEnumerable<string> list = gvList.Select(gv => gv.MaGiaoVien);
                        for (int i = 0; i < dgvImportUserList.RowCount; i++)
                        {
                            var MaGV = dgvImportUserList.Rows[i].Cells["MaGiaoVien"].Value;
                            if (!list.Contains(MaGV))
                            {
                                notExistList.Add(dgvImportUserList.Rows[i].Cells);
                            }
                            else
                            {
                                existList.Add(dgvImportUserList.Rows[i].Cells);
                            }
                        }

                        // add vào database
                        // tạo đối tương GiaoVien
                        if (notExistList.Count > 0)
                        {
                            int flag = 0;
                            foreach (var item in notExistList)
                            {
                                var gv = new GiaoVien()
                                {
                                    MaGiaoVien = item["MaGiaoVien"].Value.ToString(),
                                    TenGiaoVien = item["TenGiaoVien"].Value.ToString(),
                                    NgaySinh = DateTime.Parse(item["NgaySinh"].Value.ToString()),
                                    QueQuan = int.Parse(item["QueQuan"].Value.ToString()),
                                    //GioiTinh = bool.Parse(item["GioiTinh"].Value.ToString()),
                                    GioiTinh = (item["GioiTinh"].Value.ToString() == "0") ? false : true,
                                    DayMon = item["DayMon"].Value.ToString()
                                };

                                var ctk = new ChuTaiKhoan()
                                {
                                    ID = item["MaGiaoVien"].Value.ToString()
                                };

                                if (!DataUlti.ThemChuTaiKhoan(ctk) && !DataUlti.ThemGiaoVien(gv))
                                {
                                    flag = 1;
                                    break;
                                }
                            }

                            if (flag == 0)
                            {
                                dgvImportUserList.Columns.Clear();
                                MessageBox.Show("Đã thêm vào CSDL");
                                btnUpdateFromImport.Visible = false;
                                LoadDgvUpdateUser();
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
                                        str += item["MaGiaoVien"].Value.ToString() + "\n";
                                    }
                                    MessageBox.Show(string.Format("Các giáo viên bị trùng:\n{0}", str));
                                }
                                else
                                {
                                    MessageBox.Show(string.Format("Số lượng giáo viên đã tồn tại quá nhiều: {0}", existList.Count));
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        existList.Clear();
                        notExistList.Clear();
                        return;
                    }
                }
                else
                {
                    var hsList = DataUlti.DSHocSinh();

                    try
                    {
                        //Lấy ra danh sách các học sinh chưa có trong database
                        IEnumerable<string> list = hsList.Select(hs => hs.MaHocSinh);
                        for (int i = 0; i < dgvImportUserList.RowCount; i++)
                        {
                            var MaHS = dgvImportUserList.Rows[i].Cells["MaHocSinh"].Value;
                            if (!list.Contains(MaHS))
                            {
                                notExistList.Add(dgvImportUserList.Rows[i].Cells);
                            }
                            else
                            {
                                existList.Add(dgvImportUserList.Rows[i].Cells);
                            }
                        }

                        // add vào database
                        // tạo đối tương HocSinh
                        if (notExistList.Count > 0)
                        {
                            int flag = 0;
                            foreach (var item in notExistList)
                            {
                                var hs = new HocSinh()
                                {
                                    MaHocSinh = item["MaHocSinh"].Value.ToString(),
                                    TenHocSinh = item["TenHocSinh"].Value.ToString(),
                                    Khoi = int.Parse(item["Khoi"].Value.ToString()),
                                    Lop = item["Lop"].Value.ToString(),
                                    NgaySinh = DateTime.Parse(item["NgaySinh"].Value.ToString()),
                                    QueQuan = int.Parse(item["QueQuan"].Value.ToString()),
                                    //GioiTinh = bool.Parse(item["GioiTinh"].Value.ToString())
                                    GioiTinh = (item["GioiTinh"].Value.ToString() == "0") ? false : true
                                };

                                var ctk = new ChuTaiKhoan()
                                {
                                    ID = item["MaHocSinh"].Value.ToString()
                                };

                                if (!DataUlti.ThemChuTaiKhoan(ctk) && !DataUlti.ThemHocSinh(hs))
                                {
                                    flag = 1;
                                    break;
                                }
                            }

                            if (flag == 0)
                            {
                                dgvImportUserList.Columns.Clear();
                                MessageBox.Show("Đã thêm vào CSDL");
                                btnUpdateFromImport.Visible = false;
                                LoadDgvUpdateUser();
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
                                        str += item["MaHocSinh"].Value.ToString() + "\n";
                                    }
                                    MessageBox.Show(string.Format("Các học sinh bị trùng:\n{0}", str));
                                }
                                else
                                {
                                    MessageBox.Show(string.Format("Số lượng học sinh đã tồn tại quá nhiều: {0}", existList.Count));
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        existList.Clear();
                        notExistList.Clear();
                        return;
                    }
                }
            }
            existList.Clear();
            notExistList.Clear();
        }

        private void BtnFileOpen_Click(object sender, EventArgs e)
        {
            try
            {
                // Choose what file with the specific ext to open
                fileDialogImportExcel.Filter = "Excel files (*.xlsx)|*.xlsx|Excel files (*.xls)|*.xls";
                DialogResult dialog = fileDialogImportExcel.ShowDialog();

                if (dialog == DialogResult.OK)
                {
                    // load to gridview
                    dgvImportUserList.Columns.Clear();
                    var dt = DataUlti.ReadExcelFile(fileDialogImportExcel.FileName);
                    dgvImportUserList.DataSource = dt;
                    dgvImportUserList.AllowUserToAddRows = false;

                    // enable update button
                    btnUpdateFromImport.Visible = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }

        private void BtnXuatDSHS_Click(object sender, EventArgs e)
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

                    var DSHocSinh = DataUlti.DSHocSinh();

                    using (DataTable dt = new DataTable())
                    {
                        dt.Columns.Add("MaHocSinh", typeof(string));
                        dt.Columns.Add("TenHocSinh", typeof(string));
                        dt.Columns.Add("Khoi", typeof(int));
                        dt.Columns.Add("Lop", typeof(string));
                        dt.Columns.Add("NgaySinh", typeof(string));
                        dt.Columns.Add("QueQuan", typeof(int));
                        dt.Columns.Add("GioiTinh", typeof(int));
                        foreach (var hs in DSHocSinh)
                        {
                            dt.Rows.Add(hs.MaHocSinh, hs.TenHocSinh, hs.Khoi, hs.Lop, hs.NgaySinh, hs.QueQuan, hs.GioiTinh);
                        }

                        if (!DataUlti.WriteExcelFile(saveFileDialog.FileName, dt, 0))
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

        private void BtnXuatDSGV_Click(object sender, EventArgs e)
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

                    var DSGiaoVien = DataUlti.DSGiaoVien();

                    using (DataTable dt = new DataTable())
                    {
                        dt.Columns.Add("MaGiaoVien", typeof(string));
                        dt.Columns.Add("TenGiaoVien", typeof(string));
                        dt.Columns.Add("NgaySinh", typeof(string));
                        dt.Columns.Add("QueQuan", typeof(int));
                        dt.Columns.Add("GioiTinh", typeof(int));
                        dt.Columns.Add("DayMon", typeof(string));
                        foreach (var gv in DSGiaoVien)
                        {
                            dt.Rows.Add(gv.MaGiaoVien, gv.TenGiaoVien, gv.NgaySinh, gv.QueQuan, gv.GioiTinh, gv.DayMon);
                        }

                        if (!DataUlti.WriteExcelFile(saveFileDialog.FileName, dt, 1))
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

        
    }
}
