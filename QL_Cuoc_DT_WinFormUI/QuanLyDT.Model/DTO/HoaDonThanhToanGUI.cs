using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDT.Model.DTO
{
    public class HoaDonThanhToanGUI
    {
        public HoaDonThanhToanGUI(int maHDtc, string tenKH, string soSim, decimal cuocTB, DateTime tgTaoHD, bool thanhToan, decimal thanhTien, bool stt)
        {
            MaHDTC = maHDtc;
            TenKH = tenKH;
            SoDienThoai = soSim;
            PhiHangThang = cuocTB;
            NgayTao = tgTaoHD;
            ThanhToan = ThanhToan;
            TongTien = thanhTien;
            TrangThai = stt;

        }

        public HoaDonThanhToanGUI(DataRow row)
        {
            MaHDTC = (int)row["MaHDTC"];
            TenKH = (string)row["TenKH"];
            SoDienThoai = (string)row["SoDienThoai"];
            PhiHangThang = (decimal)row["PhiHangThang"];
            NgayTao = (DateTime)row["NgayTao"];
            ThanhToan = (bool)row["ThanhToan"];
            TongTien = (decimal)row["TongTien"];
            TrangThai = (bool)row["TrangThai"];
        }

        public HoaDonThanhToanGUI() { }



        public int MaHDTC { get; set; }
        public string TenKH { get; set; }
        public string SoDienThoai { get; set; }
        public decimal PhiHangThang { get; set; }
        public DateTime NgayTao { get; set; }
        public bool ThanhToan { get; set; }
        public decimal TongTien { get; set; }
        public bool TrangThai { get; set; }
    }
}
