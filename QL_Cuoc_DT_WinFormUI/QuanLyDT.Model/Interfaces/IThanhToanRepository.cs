using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyDT.Model.DTO;

namespace QuanLyDT.Model.Interfaces
{
    public interface IThanhToanRepository
    {
        List<HoaDonThanhToan> DanhSachHDTT();
        List<HoaDonThanhToan> TimKiemHDTT(string col, string info);
        List<HoaDonThanhToan> TimKiemByMaKHHDTT(string info);
        bool ThemHDTT(HoaDonThanhToan hoaDonThanhToan);
        bool UpdateHDTT(HoaDonThanhToan hoaDonThanhToan);
    }
}
