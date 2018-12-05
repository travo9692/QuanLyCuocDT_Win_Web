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
    public class HoaDonDangKyRepository : IHoaDonDangKyRepository
    {
        public List<HoaDonDK> DanhSachHoaDonDK()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// lấy danh sách HoaDonDK trong database
        /// </summary>
        /// <returns></returns>
        public List<HoaDonDK> GetHoaDonDK(KhachHang kh)
        {
            List<HoaDonDK> list = new List<HoaDonDK>();

            DataTable table = DataProvider.Instane.ExecuteReader("EXECUTE dbo.SP_GetHDDangKi @MaKH", new object[] { kh.MaKH });

            foreach (DataRow row in table.Rows)
            {
                list.Add(new HoaDonDK(row));
            }
            return list;
        }

        /// <summary>
        /// thêm HoaDonDK vào database
        /// </summary>
        /// <param name="HoaDonDK"></param>
        /// <returns></returns>
        public bool ThemHoaDonDK(HoaDonDK hoaDonDK)
        {
            int row = DataProvider.Instane.ExecuteNonQuery("EXEC dbo.SP_TaoHDDangKi @MaHDDK , @IDSIM , @ChiPhi , @ChiPhiDK ",
                                        new object[] { hoaDonDK.MaHDDK, hoaDonDK.IDSIM, hoaDonDK.ChiPhiDK });
            return row > 0;
        }

        /// <summary>
        /// tìm kiếm HoaDonDK, sử dụng SP_TimKiemHoaDonDK
        /// </summary>
        /// <param name="col">cột trong database</param>
        /// <param name="info">thông tin cần tìm</param>
        /// <returns></returns>
        public List<HoaDonDK> TimKiemHoaDonDK(string col, string info)
        {
            List<HoaDonDK> list = new List<HoaDonDK>();
            DataTable table = DataProvider.Instane.ExecuteReader(" EXEC  dbo.SP_TimKiemHoaDonDK  @TruongDuLieu , @ThongTin ", new object[] { col, info });

            foreach (DataRow row in table.Rows)
            {
                list.Add(new HoaDonDK(row));
            }
            return list;
        }

        /// <summary>
        /// Cập nhật thông tin cho HoaDonDK
        /// </summary>
        /// <param name="HoaDonDK"></param>
        /// <returns></returns>
        public bool UpdateHoaDonDK(HoaDonDK hoaDonDK)
        {
            int row = DataProvider.Instane.ExecuteNonQuery("EXEC dbo.SP_UpdateHoaDonDK @IDSIM , @hoaDonDK.ChiPhiDK ",
                                        new object[] { hoaDonDK.IDSIM , hoaDonDK.ChiPhiDK });
            return row > 0;
        }
    }
}
