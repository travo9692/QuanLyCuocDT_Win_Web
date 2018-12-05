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
    public partial class MainThongTinThanhToan : Form
    {
        private LibraryService libraryService;

        public MainThongTinThanhToan()
        {
            InitializeComponent();
        }
        /// <summary>
        /// constructor cho việc update khách hàng
        /// </summary>
        /// <param name="title"></param>
        /// <param name="btnText"></param>
        /// <param name=""></param>

        public MainThongTinThanhToan(string title, string maKH)
        {
            InitializeComponent();
            libraryService = ServiceFactory.GetLibraryService(LibraryParameter.persistancestrategy);
            //load data cho các textbox
            LoadData(title, maKH);
        }

        private void LoadData(string title, string maKH)
        {
            //set title cho form
            Text = title;
            string col = "MaKH";
            // load data cho các textbox
            foreach (HoaDonDK item in libraryService.TimKiemHoaDonDK(col, maKH))
            {
                txtMaKH.Text = item.MaHDDK.ToString();
                txtMaSim.Text = item.IDSIM.ToString();
                txtThanhTien.Text = item.ChiPhiDK.ToString();
            }
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
