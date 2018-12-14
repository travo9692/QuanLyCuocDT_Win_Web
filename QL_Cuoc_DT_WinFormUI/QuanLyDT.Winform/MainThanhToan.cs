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
        private HoaDonDK thanhToan;
        private KhachHang khachHang;
        private Sim sim;
        private static string makh;
        private static int simso;
        private LibraryService libraryService;

        public MainThanhToan()
        {
            InitializeComponent();
            thanhToan = new HoaDonDK();
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
            thanhToan = new HoaDonDK();
            khachHang = new KhachHang();
            sim = new Sim();
        }

        private void LoadData(string title, string maKH)
        {
            //set title cho form
            Text = title;

            makh = maKH;
            thanhToan = new HoaDonDK();
            khachHang = new KhachHang();
            // load data cho các textbox
            if (libraryService.TimKiemHoaDonDK("0", maKH).Count == 0)
            {
                txtCuocThueBao.Text = "50000";
            }
            else
            {
                foreach (HoaDonDK item in libraryService.TimKiemHoaDonDK("0",maKH))
                {
                    txtMaHD.Text = item.MaHDDK.ToString();
                    txtMaSim.Text = item.IDSIM.ToString();
                    txtCuocThueBao.Text = item.ChiPhiDK.ToString();
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
            simso = int.Parse(txtMaSim.Text.ToString());
            thanhToan.MaHDDK = txtMaHD.Text.ToString();
            thanhToan.ChiPhiDK = decimal.Parse(txtCuocThueBao.Text.ToString());

            if (libraryService.TimKiemHoaDonDK("0",makh).Count != 0)
            {
                if (libraryService.UpdateHoaDonDK(thanhToan))
                {
                    if (DialogResult.OK == MessageBox.Show("Thanh toán thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information))
                    {
                            sim.MaKH = makh;
                            sim.IDSIM = int.Parse(txtMaSim.Text.ToString());
                        sim.TinhTrang = true;
                            bool resu = libraryService.UpdateKHSim(sim);
                            if (resu)
                            {
                                
                            }
                            else MessageBox.Show("Lỗi không thêm được s");
                        DialogResult = DialogResult.OK;
                    }

                }
            }
            else
            {

                bool result = libraryService.ThemHoaDonDK(thanhToan);
                
                if (result)
                {
                    sim.MaKH = makh;
                    sim.IDSIM = int.Parse(txtMaSim.Text.ToString());
                    sim.TinhTrang = true;
                    bool resu = libraryService.UpdateKHSim(sim);
                    if(resu)
                    {
                        if (DialogResult.OK == MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information))
                        {
                            DialogResult = DialogResult.OK;
                        }
                    }
                    else MessageBox.Show("Lỗi không thêm được s");
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
