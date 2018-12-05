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
    public partial class MainChinhSuaCuoc : Form
    {
        private bool isNew = true;
        private LibraryService libraryService;
        private LoaiCuoc loaiCuoc;
        public MainChinhSuaCuoc()
        {
            InitializeComponent();
            libraryService = ServiceFactory.GetLibraryService(LibraryParameter.persistancestrategy);
            loaiCuoc = new LoaiCuoc();
        }

        public MainChinhSuaCuoc(string title, string btnText, LoaiCuoc loaiCuoc)
        {
            InitializeComponent();
            this.Text = title;
            btnAddEdit.Text = btnText;
            this.loaiCuoc = loaiCuoc;
            isNew = false;

            #region Code đổ dữ liệu vào các textbox
            txtmaloaicuoc.Text = loaiCuoc.MaGiaCuoc.ToString();
            txttgbatdau.Text = loaiCuoc.TGBD.ToString();
            txttgketthuc.Text = loaiCuoc.TGKT.ToString();
            txtgiacuoc.Text = loaiCuoc.Giacuoc1.ToString();
            #endregion
        }

        public MainChinhSuaCuoc(string title, string btnText)
        {
            InitializeComponent();
            this.Text = title;
            btnAddEdit.Text = btnText;
            loaiCuoc = new LoaiCuoc();
        }

        private void MainChinhSuaCuoc_Load(object sender, EventArgs e)
        {
            libraryService = ServiceFactory.GetLibraryService(LibraryParameter.persistancestrategy);
            txtgiacuoc.Focus();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddEdit_Click(object sender, EventArgs e)
        {
            loaiCuoc.MaGiaCuoc = txtmaloaicuoc.Text;
            loaiCuoc.TGBD = TimeSpan.Parse(txttgbatdau.Text);
            loaiCuoc.TGKT = TimeSpan.Parse(txttgketthuc.Text);
            loaiCuoc.Giacuoc1 = Decimal.Parse(txtgiacuoc.Text);

            //code cho phần thêm mới khách hàng
            if (isNew)
            {
                bool result = libraryService.ThemLoaiCuoc(loaiCuoc);

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
            else
            {
                if (libraryService.UpdateLoaiCuoc(loaiCuoc))
                {
                    if (DialogResult.OK == MessageBox.Show("Cập nhật thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information))
                    {
                        DialogResult = DialogResult.OK;
                    }

                }


            }
        }
    }
}
