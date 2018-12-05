using QuanLyDT.Infrastructure;
using QuanLyDT.Model.DTO;
using QuanLyDT.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyDT.Winform
{
    public partial class MainThanhToan : Form
    {
        private HoaDonThanhToan thanhToan;
        private HoaDonThanhToanGUI thanhToanGUI;
        private KhachHang khachHang;
        private Sim sim;
        private static string makh;
        private LibraryService libraryService;

        public MainThanhToan()
        {
            InitializeComponent();
            thanhToan = new HoaDonThanhToan();
            thanhToanGUI = new HoaDonThanhToanGUI();
            khachHang = new KhachHang();
            sim = new Sim();
        }
        /// <summary>
        /// constructor cho việc update khách hàng
        /// </summary>
        /// <param name="title"></param>
        /// <param name="btnText"></param>
        /// <param name="benhNhan"></param>

        public MainThanhToan(string title, string maKH)
        {
            InitializeComponent();
            libraryService = ServiceFactory.GetLibraryService(LibraryParameter.persistancestrategy);
            //load data cho các textbox
            LoadData(title, maKH);
            thanhToan = new HoaDonThanhToan();
            thanhToanGUI = new HoaDonThanhToanGUI();
            khachHang = new KhachHang();
            sim = new Sim();
        }

        private void LoadSim()
        {
            
        }

        private void LoadData(string title, string maKH)
        {
            //set title cho form
            Text = title;
            makh = maKH;
            thanhToan = new HoaDonThanhToan();
            khachHang = new KhachHang();
            // load data cho các textbox
            if (libraryService.TimKiemByMaKHHDTT(maKH).Count == 0)
            {
                DateTime date = DateTime.Now;
                txtThanhToan.Text = "false";
                txtNgayTao.Text = date.ToString();
                txtCuocThueBao.Text = "50000";

            }
            else
            {
                foreach (HoaDonThanhToan item in libraryService.TimKiemByMaKHHDTT(maKH))
                {
                    txtMaSim.Text = item.IDSIM.ToString();
                    txtThanhToan.Text = item.ThanhToan.ToString();
                    txtNgayTao.Text = item.NgayTao.ToString();
                    txtCuocThueBao.Text = item.PhiHangThang.ToString();
                    txtThanhTien.Text = item.TongTien.ToString();
                }
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddEdit_Click(object sender, EventArgs e)
        {
            DateTime date = DateTime.Now;
            thanhToan.IDSIM = int.Parse(txtMaSim.Text.ToString());
            thanhToan.NgayTao = date;
            thanhToan.TongTien = int.Parse(txtThanhTien.Text.ToString());
            thanhToan.ThanhToan = true;
            thanhToan.TrangThai = true;
            thanhToan.PhiHangThang = int.Parse(txtCuocThueBao.Text.ToString());

            if (libraryService.TimKiemByMaKHHDTT(makh).Count != 0)
            {
                if (libraryService.UpdateHDTT(thanhToan))
                {
                    if (DialogResult.OK == MessageBox.Show("Thanh toán thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information))
                    {
                        DialogResult = DialogResult.OK;
                    }

                }
            }
            else
            {
                bool result = libraryService.ThemHDTT(thanhToan);

                if (result)
                {
                    if (DialogResult.OK == MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information))
                    {
                        DialogResult = DialogResult.OK;
                    }
                    
                }
                else
                {
                    MessageBox.Show("Lỗi không thêm được");
                }
            }
        }

        public string getMaKH()
        {
            return makh;
        }

        private void btnThemSim_Click(object sender, EventArgs e)
        {

            string luu = txtMaSim.Text;
            MainLuuSim f = new MainLuuSim();
            f.ShowDialog();
            string simso = f.getSoSim();
            string col = "SoSim";
            if (simso == null)
            {
                txtMaSim.Text = luu;
            }
            else
            {
                foreach (Sim item in libraryService.TimKiemSim(col, simso))
                {
                    txtMaSim.Text = item.IDSIM.ToString();
                }
            }        
            if (f.DialogResult != DialogResult.Cancel)
            {
                
            }
        }
    }
}
