using QuanLyDT.Infrastructure;
using QuanLyDT.Model;
using QuanLyDT.Model.DTO;
using QuanLyDT.Services;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace QuanLyDT.Winform
{
    public partial class MainFormCuocDT : Form
    {
        private TaiKhoan nhanVien;
        private LibraryService libraryService;
        private static List<Model.DTO.KhachHang> listKH;
        private static List<HoaDonThanhToan> listHDTT;
        private static List<HoaDonThanhToanGUI> listHDTTGUI;
        private static List<Sim> listSim;
        private static List<LoaiCuoc> listLoaiCuoc;
        public static Model.DTO.KhachHang khachHangStatic;

        /// <summary>
        /// constructor
        /// </summary>
        public MainFormCuocDT()
        {
            InitializeComponent();
            libraryService = ServiceFactory.GetLibraryService(LibraryParameter.persistancestrategy);
        }

        public MainFormCuocDT(TaiKhoan nhanVien)
        {
            InitializeComponent();
            libraryService = ServiceFactory.GetLibraryService(LibraryParameter.persistancestrategy);
            this.nhanVien = nhanVien;
        }

        /// <summary>
        /// hàm load khi chạy form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainFormCuocDT_Load(object sender, EventArgs e)
        {

            LoadDanhSachKH();
            LoadDanhSachHDTT();
            LoadDanhSachSim();
            LoadDanhSachLoaiCuoc();

            //set thuộc tính đầu tiên cho combobox tim kiem
            cbxTimKiem.SelectedIndex = 0;
            cbbTimKiemThanhToan.SelectedIndex = 0;
            cbbTimKiemSim.SelectedIndex = 0;
        }

       

        #region Method

        /// <summary>
        /// load danh sách khach hang cho datagridview khach hang
        /// </summary>
        private void LoadDanhSachKH()
        {
            listKH = libraryService.DanhSachKH();
            dgvDanhSachKH.Rows.Clear();
            dgvDanhSachKH.Refresh();
            foreach (Model.DTO.KhachHang item in listKH)
            {
                dgvDanhSachKH.Rows.Add(item.MaKH, item.TenKH, item.CMND,item.NgheNghiep, item.ChucVu,  item.DiaChi, item.TinhTrang);
            }
        }

        private void LoadDanhSachHDTT()
        {
            listHDTTGUI = libraryService.DanhSachHDTT();
            dgvDanhSachHoaDonThanhToan.Rows.Clear();
            dgvDanhSachHoaDonThanhToan.Refresh();
            foreach (HoaDonThanhToanGUI item in listHDTTGUI)
            {
                dgvDanhSachHoaDonThanhToan.Rows.Add(item.MaHDTC, item.TenKH, item.SoDienThoai, item.PhiHangThang, item.NgayTao, item.TongTien, item.ThanhToan, item.TrangThai);
            }
        }

        private void LoadDanhSachHDTTHH()
        {
            listHDTTGUI = libraryService.DanhSachHDTTHH();
            dgvDanhSachHoaDonThanhToan.Rows.Clear();
            dgvDanhSachHoaDonThanhToan.Refresh();
            foreach (HoaDonThanhToanGUI item in listHDTTGUI)
            {
                dgvDanhSachHoaDonThanhToan.Rows.Add(item.MaHDTC, item.TenKH, item.SoDienThoai, item.PhiHangThang, item.NgayTao, item.TongTien, item.ThanhToan, item.TrangThai);
            }
        }

        private void LoadDanhSachSim()
        {
            listSim = libraryService.DanhSachSim();
            dgvDSSim.Rows.Clear();
            dgvDSSim.Refresh();
            foreach (Sim item in listSim)
            {
                dgvDSSim.Rows.Add(item.IDSIM, item.SoDienThoai, item.MaKH, item.NgayDK, item.TinhTrang);
            }
        }

        private void LoadDanhSachLoaiCuoc()
        {
            listLoaiCuoc = libraryService.DanhSachLoaiCuoc();
            dgvLoaiCuoc.Rows.Clear();
            dgvLoaiCuoc.Refresh();
            foreach (LoaiCuoc item in listLoaiCuoc)
            {
                dgvLoaiCuoc.Rows.Add(item.MaGiaCuoc, item.TGBD, item.TGKT, item.Giacuoc1);
            }
        }


        //////////////////////// File log
        ///
        

        #endregion Method

        #region MenuStrip Events

        /// <summary>
        /// Thêm khach hang
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnThemKH_Click(object sender, EventArgs e)
        {
            MainDKKhachHang f = new MainDKKhachHang("Thêm khách hàng", "Thêm");
            f.ShowDialog();
            if (f.DialogResult != DialogResult.Cancel)
            {
                LoadDanhSachKH();
                khachHangStatic = listKH[listKH.Count - 1];
            }
        }

        private void btnCapNhatKH_Click(object sender, EventArgs e)
        {
            if (dgvDanhSachKH.SelectedRows.Count > 0)
            {
                DataGridViewRow row = this.dgvDanhSachKH.SelectedRows[0];
                KhachHang khachHang = listKH.Single(p => p.MaKH == (string)row.Cells[0].Value);

                MainDKKhachHang f = new MainDKKhachHang("Cập nhật thông tin khách hàng", "Cập nhật", khachHang);
                f.ShowDialog();

                if (f.DialogResult != DialogResult.Cancel)
                {
                    LoadDanhSachKH();
                }
            }
        }

        private void btnThongTinThanhToan_Click(object sender, EventArgs e)
        {
            if (dgvDanhSachKH.SelectedRows.Count > 0)
            {
                DataGridViewRow row = this.dgvDanhSachKH.SelectedRows[0];
                string maKH = row.Cells[0].Value.ToString();

                MainThongTinThanhToan f = new MainThongTinThanhToan("Xem thông tin thanh toán", maKH);
                f.ShowDialog();

                if (f.DialogResult != DialogResult.Cancel)
                {
                    LoadDanhSachKH();
                }
            }
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            if (dgvDanhSachKH.SelectedRows.Count > 0)
            {
                DataGridViewRow row = this.dgvDanhSachKH.SelectedRows[0];
                string maKH = row.Cells[0].Value.ToString();
                KhachHang khachHang = listKH.Single(p => p.MaKH == (string)row.Cells[0].Value);
                MainThanhToan f = new MainThanhToan("Tiến hành thanh toán", maKH);
                f.ShowDialog();
                khachHang.TinhTrang = true;
                if (f.DialogResult != DialogResult.Cancel)
                {
                    libraryService.UpdateKHStatus(khachHang);
                    LoadDanhSachKH();
                    LoadDanhSachHDTT();
                    LoadDanhSachSim();
                }
            }
        }

        private void bttThemSim_Click(object sender, EventArgs e)
        {
            MainLuuSim f = new MainLuuSim("Thêm sim", "Thêm");
            f.ShowDialog();
            if (f.DialogResult != DialogResult.Cancel)
            {
                LoadDanhSachKH();
                LoadDanhSachHDTT();
                LoadDanhSachSim();
                khachHangStatic = listKH[listKH.Count - 1];
            }
        }

        private void bttEditSim_Click(object sender, EventArgs e)
        {
            if (dgvDSSim.SelectedRows.Count > 0)
            {
                DataGridViewRow row = this.dgvDSSim.SelectedRows[0];
                string maSim = row.Cells[0].Value.ToString();
                string status = row.Cells[4].Value.ToString();
                if (status == "False")
                {
                    MainChinhSuaSim f = new MainChinhSuaSim("Tiến hành chỉnh sửa", maSim);
                    f.ShowDialog();
                    if (f.DialogResult != DialogResult.Cancel)
                    {
                        LoadDanhSachSim();
                    }
                }
                else
                {
                    MessageBox.Show("Sim đã có người đăng ký, không thể chỉnh sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnAddCuoc_Click(object sender, EventArgs e)
        {
            MainChinhSuaCuoc f = new MainChinhSuaCuoc("Thêm loại cước", "Thêm");
            f.ShowDialog();
            if (f.DialogResult != DialogResult.Cancel)
            {
                LoadDanhSachLoaiCuoc();
            }
        }

        private void btnEditCuoc_Click(object sender, EventArgs e)
        {
            if (dgvLoaiCuoc.SelectedRows.Count > 0)
            {
                DataGridViewRow row = this.dgvLoaiCuoc.SelectedRows[0];
                LoaiCuoc loaiCuoc = listLoaiCuoc.Single(p => p.MaGiaCuoc == (string)row.Cells[0].Value);

                MainChinhSuaCuoc f = new MainChinhSuaCuoc("Cập nhật loại cước", "Cập nhật", loaiCuoc);
                f.ShowDialog();

                if (f.DialogResult != DialogResult.Cancel)
                {
                    LoadDanhSachKH();
                }
            }
        }

        #endregion MenuStrip Events

        /// <summary>
        /// tìm kiếm khách hàng
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void btnTimKiemKhachHang_Click_1(object sender, EventArgs e)
        {
            string cot = "";
            switch (cbxTimKiem.SelectedIndex)
            {
                case 0:
                    cot = "*";
                    break;

                case 1:
                    cot = "MaKH";
                    break;

                case 2:
                    cot = "TenKH";
                    break;
            }

            if (txtTimKiem.Text == "" && cbxTimKiem.SelectedIndex != 0)
            {
                MessageBox.Show("Vui lòng nhập thông tin cần tìm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (libraryService.TimKiemKH(cot, txtTimKiem.Text).Count == 0)
                {
                    MessageBox.Show("Không tìm thấy dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    dgvDanhSachKH.Rows.Clear();
                    dgvDanhSachKH.Refresh();
                    foreach (Model.DTO.KhachHang item in libraryService.TimKiemKH(cot, txtTimKiem.Text.ToString()))
                    {
                        dgvDanhSachKH.Rows.Add(item.MaKH, item.TenKH, item.CMND,item.NgheNghiep, item.ChucVu, item.DiaChi, item.TinhTrang);
                    }
                }
            }
        }

        /// <summary>
        /// tìm kiếm thanh toán
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnTimKiemThanhToan_Click(object sender, EventArgs e)
        {
            string cot = "";
            switch (cbbTimKiemThanhToan.SelectedIndex)
            {
                case 0:
                    cot = "*";
                    break;
                case 1:
                    cot = "TrangThai";
                    break;
            }
            if (cbbTimKiemThanhToan.SelectedIndex == 0)
            {
                LoadDanhSachHDTT();
            }
            else
            {
                LoadDanhSachHDTTHH();
            }
        }

        /// <summary>
        /// tìm kiếm sim
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bttTimKiemSim_Click(object sender, EventArgs e)
        {
            string cot = "";
            switch (cbbTimKiemSim.SelectedIndex)
            {
                case 0:
                    cot = "*";
                    break;
                case 1:
                    cot = "MaSim";
                    break;
                case 2:
                    cot = "SoSim";
                    break;
            }
            if (txtTimKiemSim.Text == "" && cbbTimKiemSim.SelectedIndex != 0)
            {
                MessageBox.Show("Vui lòng nhập thông tin cần tìm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (libraryService.TimKiemSim(cot, txtTimKiemSim.Text).Count == 0)
                {
                    MessageBox.Show("Không tìm thấy dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    dgvDSSim.Rows.Clear();
                    dgvDSSim.Refresh();
                    foreach (Sim item in libraryService.TimKiemSim(cot, txtTimKiemSim.Text))
                    {
                        dgvDSSim.Rows.Add(item.IDSIM, item.SoDienThoai, item.MaKH, item.NgayDK, item.TinhTrang);
                    }
                }
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void btnCapNhatPhieuKham_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1("Gửi mail", "Gửi");
            f.ShowDialog();
            if (f.DialogResult != DialogResult.Cancel)
            {
                LoadDanhSachKH();
                khachHangStatic = listKH[listKH.Count - 1];
            }
        }
    }
}