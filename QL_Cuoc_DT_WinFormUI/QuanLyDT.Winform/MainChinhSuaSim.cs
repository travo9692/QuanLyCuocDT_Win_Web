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
    public partial class MainChinhSuaSim : Form
    {
        private Sim sim;
        private int masim;
        private LibraryService libraryService;
        public MainChinhSuaSim()
        {
            InitializeComponent();
            libraryService = ServiceFactory.GetLibraryService(LibraryParameter.persistancestrategy);
            sim = new Sim();
        }

        public MainChinhSuaSim(string title, string maSim)
        {
            InitializeComponent();
            libraryService = ServiceFactory.GetLibraryService(LibraryParameter.persistancestrategy);
            //load data cho các textbox
            LoadData(title, maSim);
            sim = new Sim();
        }

        private void LoadData(string title, string maSim)
        {
            //set title cho form
            Text = title;
            sim = new Sim();
            string col = "MaSim";
            masim = int.Parse(maSim);
            // load data cho các textbox
            if (libraryService.TimKiemSim(col , maSim).Count == 0)
            {
                MessageBox.Show("Không tìm thấy dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                foreach (Sim item in libraryService.TimKiemSim(col, maSim))
                {
                    txtSim.Text = item.SoDienThoai.ToString();
                }
            }

        }

        private void bttAddEdit_Click(object sender, EventArgs e)
        {
            sim.SoDienThoai = txtSim.Text.ToString();
            sim.TinhTrang = false;
            sim.IDSIM = masim;
            if (libraryService.UpdateSim(sim))
            {
                if (DialogResult.OK == MessageBox.Show("Cập nhật thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information))
                {
                    DialogResult = DialogResult.OK;
                }

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
