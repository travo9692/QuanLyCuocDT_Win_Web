using QuanLyDT.Model.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyDT.Model.DTO;
using System.Data;

namespace QuanLyDT.Repository.ADO
{
    public class ThanhToanRepository : IThanhToanRepository
    {
        /// <summary>
        /// lấy danh sách HoaDonThanhToan trong database
        /// </summary>
        /// <returns></returns>
        public List<HoaDonThanhToanGUI> DanhSachHDTT()
        {
            List<HoaDonThanhToanGUI> list = new List<HoaDonThanhToanGUI>();

            DataTable table = DataProvider.Instane.ExecuteReader("EXECUTE dbo.SP_DanhSachHDTT");

            foreach (DataRow row in table.Rows)
            {
                list.Add(new HoaDonThanhToanGUI(row));
            }
            return list;
        }

        public List<HoaDonThanhToanGUI> DanhSachHDTTHH()
        {
            List<HoaDonThanhToanGUI> list = new List<HoaDonThanhToanGUI>();

            DataTable table = DataProvider.Instane.ExecuteReader("EXECUTE dbo.SP_DanhSachHDTTHH");

            foreach (DataRow row in table.Rows)
            {
                list.Add(new HoaDonThanhToanGUI(row));
            }
            return list;
        }

        public List<HoaDonThanhToan> DanhSachHDTC()
        {
            List<HoaDonThanhToan> list = new List<HoaDonThanhToan>();

            DataTable table = DataProvider.Instane.ExecuteReader("EXECUTE dbo.SP_DanhSachHDTC");

            foreach (DataRow row in table.Rows)
            {
                list.Add(new HoaDonThanhToan(row));
            }
            return list;
        }
        /// <summary>
        /// thêm HoaDonThanhToan vào database
        /// </summary>
        /// <param name="khachhang"></param>
        /// <returns></returns>
        public bool ThemHDTT(HoaDonThanhToan thanhToan)
        {
            int row = DataProvider.Instane.ExecuteNonQuery("EXEC dbo.SP_TaoHDThanhToan @MaSim , @PhiHangThang , @ThanhTien , @tgThanhToan , @ThanhToan , @Status ",
                                        new object[] {  thanhToan.IDSIM, thanhToan.PhiHangThang, thanhToan.TongTien, thanhToan.NgayTao, thanhToan.ThanhToan, thanhToan.TrangThai});
            return row > 0;
        }

        /// <summary>
        /// tìm kiếm hoa don thanh toan, sử dụng SP_TimKiemHDTT
        /// </summary>
        /// <param name="col">cột trong database</param>
        /// <param name="info">thông tin cần tìm</param>
        /// <returns></returns>
        public List<HoaDonThanhToan> TimKiemHDTT(string col, string info)
        {
            List<HoaDonThanhToan> list = new List<HoaDonThanhToan>();
            DataTable table = DataProvider.Instane.ExecuteReader(" EXEC  dbo.SP_TimKiemHDTT  @TruongDuLieu , @ThongTin ", new object[] { col, info });

            foreach (DataRow row in table.Rows)
            {
                list.Add(new HoaDonThanhToan(row));
            }
            return list;
        }

        /// <summary>
        /// Cập nhật thông tin cho hoa đơn thanh toán
        /// </summary>
        /// <param name="HoaDonThanhToan"></param>
        /// <returns></returns>
        public bool UpdateHDTT(HoaDonThanhToan thanhToan)
        {
            int row = DataProvider.Instane.ExecuteNonQuery("EXEC dbo.SP_UpdateDHTT @MaKH , @MaSim ," +
                                        " @CuocThueBao , @TG_TaoHoaDon , @ThanhToan , @ThanhTien , @Status ",
                                        new object[] { thanhToan.MaHDTC,thanhToan.IDSIM, thanhToan.PhiHangThang, thanhToan.TongTien, thanhToan.NgayTao, thanhToan.ThanhToan, thanhToan.TrangThai });
            return row > 0;
        }

        /// <summary>
        /// tìm kiếm hoa don thanh toan theo tên
        /// </summary>
        /// <param name="col">cột trong database</param>
        /// <param name="info">thông tin cần tìm</param>
        /// <returns></returns>
        public List<HoaDonThanhToan> TimKiemByMaKHHDTT(string info)
        {
            List<HoaDonThanhToan> list = new List<HoaDonThanhToan>();
            DataTable table = DataProvider.Instane.ExecuteReader(" EXEC  dbo.SP_GetHDTT @ThongTin ", new object[] { info });

            foreach (DataRow row in table.Rows)
            {
                list.Add(new HoaDonThanhToan(row));
            }
            return list;
        }
    }
}
