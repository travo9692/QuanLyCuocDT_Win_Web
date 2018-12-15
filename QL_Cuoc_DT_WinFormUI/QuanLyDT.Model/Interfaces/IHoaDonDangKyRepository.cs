using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyDT.Model.DTO;

namespace QuanLyDT.Model.Interfaces
{
    public interface IHoaDonDangKyRepository
    {
        List<HoaDonDK> DanhSachHoaDonDK();
        List<HoaDonDK> GetHoaDonDK(KhachHang kh);
        List<HoaDonDK> TimKiemHoaDonDK(string col, string info);
        List<HoaDonDK> TimKiemHoaDonDKById(int info);
        bool ThemHoaDonDK(HoaDonDK hoaDonDK);
        bool UpdateHoaDonDK(HoaDonDK hoaDonDK);
    }
}
