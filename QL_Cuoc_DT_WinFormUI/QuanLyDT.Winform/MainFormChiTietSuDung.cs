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
    public partial class MainFormChiTietSuDung : Form
    {
        private static List<ChiTietSuDung> ctsd;
        private LibraryService libraryService;
        public MainFormChiTietSuDung()
        {
            InitializeComponent();
        }

        private void LoadDSChiTietSuDung()
        {
            ctsd = libraryService.DSChiTietSuDung();
            dgvdsctsd.Rows.Clear();
            dgvdsctsd.Refresh();
            foreach (ChiTietSuDung item in ctsd)
            {
                dgvdsctsd.Rows.Add(item.ID, item.IDSIM, item.TGBD,item.TGKT, item.SoPhut7h23h, item.SoPhut23h7h);
            }
        }
    }
}
