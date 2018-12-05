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
    public partial class MainTimKiemSIM : Form
    {
        private static List<Sim> listSim;
        private LibraryService libraryService;
        public string masim;
        public MainTimKiemSIM()
        {
            InitializeComponent();
            libraryService = ServiceFactory.GetLibraryService(LibraryParameter.persistancestrategy);
        }
        private void button3_Click(object sender, EventArgs e)
        {
            MainLuuSim f = new MainLuuSim("Thêm sim", "Thêm");
            f.ShowDialog();
            List<Sim> sims = libraryService.TimKiemSim("SoSim", f.getSoSim());
            masim = sims[0].IDSIM.ToString();
            if (f.DialogResult != DialogResult.Cancel)
            {

            }
            this.Close();
        }
        public string getMaSim()
        {
            return masim;
        }

        private void MainTimKiemSIM_Load(object sender, EventArgs e)
        {
            LoadDanhSachSim();
        }

        private void LoadDanhSachSim()
        {
            listSim = libraryService.DanhSachSim();
            listSim.RemoveAll(r => r.TinhTrang == true);
            dgvSim.Rows.Clear();
            dgvSim.Refresh();
            foreach (Sim item in listSim)
            {
                dgvSim.Rows.Add(item.IDSIM, item.SoDienThoai, item.MaKH, item.NgayDK, item.TinhTrang);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {           
            masim = (string)dgvSim.SelectedRows[0].Cells[0].Value;
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btntimkiem_Click(object sender, EventArgs e)
        {
            string cot = "SoSim";
            if (txttimkiem.Text == "")
            {
                MessageBox.Show("Vui lòng nhập thông tin cần tìm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (libraryService.TimKiemSim(cot, txttimkiem.Text).Count == 0)
                {
                    MessageBox.Show("Không tìm thấy dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    dgvSim.Rows.Clear();
                    dgvSim.Refresh();
                    foreach (Sim item in libraryService.TimKiemSim(cot, txttimkiem.Text))
                    {
                        dgvSim.Rows.Add(item.IDSIM, item.SoDienThoai, item.MaKH, item.NgayDK, item.TinhTrang);
                    }
                }
            }
        }
    }
}
